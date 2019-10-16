﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Security.KeyVault.Keys
{
    /// <summary>
    /// A long-running operation for <see cref="KeyClient.StartRecoverDeletedKey(string, CancellationToken)"/> or <see cref="KeyClient.StartRecoverDeletedKeyAsync(string, CancellationToken)"/>.
    /// </summary>
    public class RecoverDeletedKeyOperation : Operation<KeyVaultKey>
    {
        private readonly KeyVaultPipeline _pipeline;
        private readonly KeyVaultKey _value;
        private Response _response;
        private bool _completed;

        internal RecoverDeletedKeyOperation(KeyVaultPipeline pipeline, Response<KeyVaultKey> response)
        {
            _pipeline = pipeline;
            _value = response.Value ?? throw new InvalidOperationException("The response does not contain a value.");
            _response = response.GetRawResponse();
        }

        /// <inheritdoc/>
        public override string Id => _value.Id.ToString();

        /// <summary>
        /// Gets the <see cref="KeyVaultKey"/> of the key being recovered.
        /// You should await <see cref="WaitForCompletionAsync(CancellationToken)"/> before attempting to use a key in this pending state.
        /// </summary>
        /// <remarks>
        /// Azure Key Vault will return a <see cref="KeyVaultKey"/> immediately but may take time to actually recover the deleted key if soft-delete is enabled.
        /// </remarks>
        public override KeyVaultKey Value => _value;

        /// <inheritdoc/>
        public override bool HasCompleted => _completed;

        /// <inheritdoc/>
        public override bool HasValue => true;

        /// <inheritdoc/>
        public override Response GetRawResponse() => _response;

        /// <inheritdoc/>
        public override Response UpdateStatus(CancellationToken cancellationToken = default)
        {
            if (!_completed)
            {
                using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Secrets.RecoverDeletedKeyOperation.UpdateStatus");
                scope.AddAttribute("secret", _value.Name);
                scope.Start();

                try
                {
                    _response = _pipeline.GetResponse(RequestMethod.Get, cancellationToken, KeyClient.KeysPath, _value.Name, "/", _value.Properties.Version);
                    _completed = CheckCompleted(_response);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            return GetRawResponse();
        }

        /// <inheritdoc/>
        public override async ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default)
        {
            if (!_completed)
            {
                using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Secrets.RecoverDeletedKeyOperation.UpdateStatus");
                scope.AddAttribute("secret", _value.Name);
                scope.Start();

                try
                {
                    _response = await _pipeline.GetResponseAsync(RequestMethod.Get, cancellationToken, KeyClient.KeysPath, _value.Name, "/", _value.Properties.Version).ConfigureAwait(false);
                    _completed = await CheckCompletedAsync(_response).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            return GetRawResponse();
        }

        /// <inheritdoc />
        public override ValueTask<Response<KeyVaultKey>> WaitForCompletionAsync(CancellationToken cancellationToken = default) =>
            this.DefaultWaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<KeyVaultKey>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken) =>
            this.DefaultWaitForCompletionAsync(pollingInterval, cancellationToken);

        private static async Task<bool> CheckCompletedAsync(Response response)
        {
            switch (response.Status)
            {
                case 200:
                case 403: // Access denied but proof the key was recovered.
                    return true;

                case 404:
                    return false;

                default:
                    throw await response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
            }
        }
        private static bool CheckCompleted(Response response)
        {
            switch (response.Status)
            {
                case 200:
                case 403: // Access denied but proof the key was recovered.
                    return true;

                case 404:
                    return false;

                default:
                    throw response.CreateRequestFailedException();
            }
        }
    }
}
