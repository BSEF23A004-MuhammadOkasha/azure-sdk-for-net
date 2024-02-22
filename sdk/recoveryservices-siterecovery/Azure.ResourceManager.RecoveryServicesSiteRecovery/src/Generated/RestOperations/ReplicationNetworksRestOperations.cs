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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    internal partial class ReplicationNetworksRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ReplicationNetworksRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ReplicationNetworksRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByReplicationFabricsRequest(string subscriptionId, string resourceGroupName, string resourceName, string fabricName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/replicationFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/replicationNetworks", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the networks available for a fabric. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="fabricName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SiteRecoveryNetworkListResult>> ListByReplicationFabricsAsync(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }

            using var message = CreateListByReplicationFabricsRequest(subscriptionId, resourceGroupName, resourceName, fabricName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryNetworkListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SiteRecoveryNetworkListResult.DeserializeSiteRecoveryNetworkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the networks available for a fabric. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="fabricName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SiteRecoveryNetworkListResult> ListByReplicationFabrics(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }

            using var message = CreateListByReplicationFabricsRequest(subscriptionId, resourceGroupName, resourceName, fabricName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryNetworkListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SiteRecoveryNetworkListResult.DeserializeSiteRecoveryNetworkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string networkName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/replicationFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/replicationNetworks/", false);
            uri.AppendPath(networkName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the details of a network. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Server Id. </param>
        /// <param name="networkName"> Primary network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="networkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="networkName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SiteRecoveryNetworkData>> GetAsync(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string networkName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (networkName == null)
            {
                throw new ArgumentNullException(nameof(networkName));
            }
            if (networkName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, fabricName, networkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryNetworkData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SiteRecoveryNetworkData.DeserializeSiteRecoveryNetworkData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SiteRecoveryNetworkData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the details of a network. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Server Id. </param>
        /// <param name="networkName"> Primary network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="networkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="networkName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SiteRecoveryNetworkData> Get(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string networkName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (networkName == null)
            {
                throw new ArgumentNullException(nameof(networkName));
            }
            if (networkName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(networkName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, fabricName, networkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryNetworkData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SiteRecoveryNetworkData.DeserializeSiteRecoveryNetworkData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SiteRecoveryNetworkData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/replicationNetworks", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the networks available in a vault. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SiteRecoveryNetworkListResult>> ListAsync(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryNetworkListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SiteRecoveryNetworkListResult.DeserializeSiteRecoveryNetworkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the networks available in a vault. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SiteRecoveryNetworkListResult> List(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryNetworkListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SiteRecoveryNetworkListResult.DeserializeSiteRecoveryNetworkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByReplicationFabricsNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the networks available for a fabric. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="fabricName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SiteRecoveryNetworkListResult>> ListByReplicationFabricsNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }

            using var message = CreateListByReplicationFabricsNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName, fabricName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryNetworkListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SiteRecoveryNetworkListResult.DeserializeSiteRecoveryNetworkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the networks available for a fabric. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="fabricName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SiteRecoveryNetworkListResult> ListByReplicationFabricsNextPage(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }

            using var message = CreateListByReplicationFabricsNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName, fabricName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryNetworkListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SiteRecoveryNetworkListResult.DeserializeSiteRecoveryNetworkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the networks available in a vault. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SiteRecoveryNetworkListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryNetworkListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SiteRecoveryNetworkListResult.DeserializeSiteRecoveryNetworkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the networks available in a vault. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SiteRecoveryNetworkListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryNetworkListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SiteRecoveryNetworkListResult.DeserializeSiteRecoveryNetworkListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
