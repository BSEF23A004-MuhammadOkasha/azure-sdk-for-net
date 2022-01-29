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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class ServiceAssociationLinksRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of ServiceAssociationLinksRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public ServiceAssociationLinksRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2021-02-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string virtualNetworkName, string subnetName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworks/", false);
            uri.AppendPath(virtualNetworkName, true);
            uri.AppendPath("/subnets/", false);
            uri.AppendPath(subnetName, true);
            uri.AppendPath("/ServiceAssociationLinks", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Gets a list of service association links for a subnet. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkName"/>, or <paramref name="subnetName"/> is null. </exception>
        public async Task<Response<ServiceAssociationLinksListResult>> ListAsync(string subscriptionId, string resourceGroupName, string virtualNetworkName, string subnetName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, virtualNetworkName, subnetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceAssociationLinksListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceAssociationLinksListResult.DeserializeServiceAssociationLinksListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of service association links for a subnet. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkName"/>, or <paramref name="subnetName"/> is null. </exception>
        public Response<ServiceAssociationLinksListResult> List(string subscriptionId, string resourceGroupName, string virtualNetworkName, string subnetName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, virtualNetworkName, subnetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceAssociationLinksListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceAssociationLinksListResult.DeserializeServiceAssociationLinksListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
