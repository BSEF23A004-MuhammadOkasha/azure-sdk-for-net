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
    internal partial class VpnSiteLinksRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of VpnSiteLinksRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public VpnSiteLinksRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string vpnSiteName, string vpnSiteLinkName)
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
            uri.AppendPath("/providers/Microsoft.Network/vpnSites/", false);
            uri.AppendPath(vpnSiteName, true);
            uri.AppendPath("/vpnSiteLinks/", false);
            uri.AppendPath(vpnSiteLinkName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Retrieves the details of a VPN site link. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="vpnSiteLinkName"> The name of the VpnSiteLink being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vpnSiteName"/>, or <paramref name="vpnSiteLinkName"/> is null. </exception>
        public async Task<Response<VpnSiteLinkData>> GetAsync(string resourceGroupName, string vpnSiteName, string vpnSiteLinkName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnSiteName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteName));
            }
            if (vpnSiteLinkName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteLinkName));
            }

            using var message = CreateGetRequest(resourceGroupName, vpnSiteName, vpnSiteLinkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnSiteLinkData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VpnSiteLinkData.DeserializeVpnSiteLinkData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VpnSiteLinkData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the details of a VPN site link. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="vpnSiteLinkName"> The name of the VpnSiteLink being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vpnSiteName"/>, or <paramref name="vpnSiteLinkName"/> is null. </exception>
        public Response<VpnSiteLinkData> Get(string resourceGroupName, string vpnSiteName, string vpnSiteLinkName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnSiteName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteName));
            }
            if (vpnSiteLinkName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteLinkName));
            }

            using var message = CreateGetRequest(resourceGroupName, vpnSiteName, vpnSiteLinkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnSiteLinkData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VpnSiteLinkData.DeserializeVpnSiteLinkData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VpnSiteLinkData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllByVpnSiteRequest(string resourceGroupName, string vpnSiteName)
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
            uri.AppendPath("/providers/Microsoft.Network/vpnSites/", false);
            uri.AppendPath(vpnSiteName, true);
            uri.AppendPath("/vpnSiteLinks", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all the vpnSiteLinks in a resource group for a vpn site. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is null. </exception>
        public async Task<Response<ListVpnSiteLinksResult>> GetAllByVpnSiteAsync(string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnSiteName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteName));
            }

            using var message = CreateGetAllByVpnSiteRequest(resourceGroupName, vpnSiteName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinksResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnSiteLinksResult.DeserializeListVpnSiteLinksResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the vpnSiteLinks in a resource group for a vpn site. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is null. </exception>
        public Response<ListVpnSiteLinksResult> GetAllByVpnSite(string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnSiteName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteName));
            }

            using var message = CreateGetAllByVpnSiteRequest(resourceGroupName, vpnSiteName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinksResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnSiteLinksResult.DeserializeListVpnSiteLinksResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllByVpnSiteNextPageRequest(string nextLink, string resourceGroupName, string vpnSiteName)
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

        /// <summary> Lists all the vpnSiteLinks in a resource group for a vpn site. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="vpnSiteName"/> is null. </exception>
        public async Task<Response<ListVpnSiteLinksResult>> GetAllByVpnSiteNextPageAsync(string nextLink, string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnSiteName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteName));
            }

            using var message = CreateGetAllByVpnSiteNextPageRequest(nextLink, resourceGroupName, vpnSiteName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinksResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnSiteLinksResult.DeserializeListVpnSiteLinksResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the vpnSiteLinks in a resource group for a vpn site. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="vpnSiteName"/> is null. </exception>
        public Response<ListVpnSiteLinksResult> GetAllByVpnSiteNextPage(string nextLink, string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnSiteName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteName));
            }

            using var message = CreateGetAllByVpnSiteNextPageRequest(nextLink, resourceGroupName, vpnSiteName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinksResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnSiteLinksResult.DeserializeListVpnSiteLinksResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
