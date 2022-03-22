// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing collection of DeletedVault and their operations over its parent. </summary>
    public partial class DeletedVaultCollection : ArmCollection
    {
        private readonly ClientDiagnostics _deletedVaultVaultsClientDiagnostics;
        private readonly VaultsRestOperations _deletedVaultVaultsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeletedVaultCollection"/> class for mocking. </summary>
        protected DeletedVaultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedVaultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeletedVaultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedVaultVaultsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KeyVault", DeletedVaultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeletedVaultResource.ResourceType, out string deletedVaultVaultsApiVersion);
            _deletedVaultVaultsRestClient = new VaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deletedVaultVaultsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the deleted Azure key vault.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// Operation Id: Vaults_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<DeletedVaultResource>> GetAsync(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedVaultVaultsRestClient.GetDeletedAsync(Id.SubscriptionId, location, vaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the deleted Azure key vault.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// Operation Id: Vaults_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public virtual Response<DeletedVaultResource> Get(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedVaultVaultsRestClient.GetDeleted(Id.SubscriptionId, location, vaultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// Operation Id: Vaults_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// Operation Id: Vaults_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public virtual Response<bool> Exists(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, vaultName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// Operation Id: Vaults_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<DeletedVaultResource>> GetIfExistsAsync(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deletedVaultVaultsRestClient.GetDeletedAsync(Id.SubscriptionId, location, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DeletedVaultResource>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/locations/{location}/deletedVaults/{vaultName}
        /// Operation Id: Vaults_GetDeleted
        /// </summary>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="vaultName"/> is null. </exception>
        public virtual Response<DeletedVaultResource> GetIfExists(string location, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var scope = _deletedVaultVaultsClientDiagnostics.CreateScope("DeletedVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deletedVaultVaultsRestClient.GetDeleted(Id.SubscriptionId, location, vaultName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DeletedVaultResource>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
