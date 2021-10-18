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
    internal partial class ExpressRouteLinksRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of ExpressRouteLinksRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public ExpressRouteLinksRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string expressRoutePortName, string linkName)
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
            uri.AppendPath("/providers/Microsoft.Network/ExpressRoutePorts/", false);
            uri.AppendPath(expressRoutePortName, true);
            uri.AppendPath("/links/", false);
            uri.AppendPath(linkName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Retrieves the specified ExpressRouteLink resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="linkName"> The name of the ExpressRouteLink resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="expressRoutePortName"/>, or <paramref name="linkName"/> is null. </exception>
        public async Task<Response<ExpressRouteLinkData>> GetAsync(string resourceGroupName, string expressRoutePortName, string linkName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRoutePortName == null)
            {
                throw new ArgumentNullException(nameof(expressRoutePortName));
            }
            if (linkName == null)
            {
                throw new ArgumentNullException(nameof(linkName));
            }

            using var message = CreateGetRequest(resourceGroupName, expressRoutePortName, linkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressRouteLinkData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExpressRouteLinkData.DeserializeExpressRouteLinkData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExpressRouteLinkData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the specified ExpressRouteLink resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="linkName"> The name of the ExpressRouteLink resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="expressRoutePortName"/>, or <paramref name="linkName"/> is null. </exception>
        public Response<ExpressRouteLinkData> Get(string resourceGroupName, string expressRoutePortName, string linkName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRoutePortName == null)
            {
                throw new ArgumentNullException(nameof(expressRoutePortName));
            }
            if (linkName == null)
            {
                throw new ArgumentNullException(nameof(linkName));
            }

            using var message = CreateGetRequest(resourceGroupName, expressRoutePortName, linkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressRouteLinkData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExpressRouteLinkData.DeserializeExpressRouteLinkData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExpressRouteLinkData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllRequest(string resourceGroupName, string expressRoutePortName)
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
            uri.AppendPath("/providers/Microsoft.Network/ExpressRoutePorts/", false);
            uri.AppendPath(expressRoutePortName, true);
            uri.AppendPath("/links", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Retrieve the ExpressRouteLink sub-resources of the specified ExpressRoutePort resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="expressRoutePortName"/> is null. </exception>
        public async Task<Response<ExpressRouteLinkListResult>> GetAllAsync(string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRoutePortName == null)
            {
                throw new ArgumentNullException(nameof(expressRoutePortName));
            }

            using var message = CreateGetAllRequest(resourceGroupName, expressRoutePortName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressRouteLinkListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExpressRouteLinkListResult.DeserializeExpressRouteLinkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieve the ExpressRouteLink sub-resources of the specified ExpressRoutePort resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="expressRoutePortName"/> is null. </exception>
        public Response<ExpressRouteLinkListResult> GetAll(string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRoutePortName == null)
            {
                throw new ArgumentNullException(nameof(expressRoutePortName));
            }

            using var message = CreateGetAllRequest(resourceGroupName, expressRoutePortName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressRouteLinkListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExpressRouteLinkListResult.DeserializeExpressRouteLinkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllNextPageRequest(string nextLink, string resourceGroupName, string expressRoutePortName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Retrieve the ExpressRouteLink sub-resources of the specified ExpressRoutePort resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="expressRoutePortName"/> is null. </exception>
        public async Task<Response<ExpressRouteLinkListResult>> GetAllNextPageAsync(string nextLink, string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRoutePortName == null)
            {
                throw new ArgumentNullException(nameof(expressRoutePortName));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, expressRoutePortName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressRouteLinkListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExpressRouteLinkListResult.DeserializeExpressRouteLinkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieve the ExpressRouteLink sub-resources of the specified ExpressRoutePort resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="expressRoutePortName"/> is null. </exception>
        public Response<ExpressRouteLinkListResult> GetAllNextPage(string nextLink, string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRoutePortName == null)
            {
                throw new ArgumentNullException(nameof(expressRoutePortName));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, expressRoutePortName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressRouteLinkListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExpressRouteLinkListResult.DeserializeExpressRouteLinkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
