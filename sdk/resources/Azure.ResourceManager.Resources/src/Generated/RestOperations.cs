// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    internal partial class RestOperations
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of RestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public RestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("https://management.azure.com");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal Core.HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/providers/Microsoft.Resources/operations", false);
            uri.AppendQuery("api-version", "2019-10-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Lists all of the available Microsoft.Resources REST API operations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<OperationListResult>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OperationListResult.DeserializeOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all of the available Microsoft.Resources REST API operations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<OperationListResult> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OperationListResult.DeserializeOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateListNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Lists all of the available Microsoft.Resources REST API operations. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<OperationListResult>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OperationListResult.DeserializeOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all of the available Microsoft.Resources REST API operations. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<OperationListResult> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OperationListResult.DeserializeOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
