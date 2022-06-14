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
using Azure.ResourceManager.NetworkFunction.Models;

namespace Azure.ResourceManager.NetworkFunction
{
    internal partial class CollectorPoliciesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CollectorPoliciesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CollectorPoliciesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName)
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
            uri.AppendPath("/providers/Microsoft.NetworkFunction/azureTrafficCollectors/", false);
            uri.AppendPath(azureTrafficCollectorName, true);
            uri.AppendPath("/collectorPolicies", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Return list of Collector policies in a Azure Traffic Collector. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CollectorPolicyListResult>> ListAsync(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectorPolicyListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CollectorPolicyListResult.DeserializeCollectorPolicyListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Return list of Collector policies in a Azure Traffic Collector. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CollectorPolicyListResult> List(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectorPolicyListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CollectorPolicyListResult.DeserializeCollectorPolicyListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, string collectorPolicyName)
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
            uri.AppendPath("/providers/Microsoft.NetworkFunction/azureTrafficCollectors/", false);
            uri.AppendPath(azureTrafficCollectorName, true);
            uri.AppendPath("/collectorPolicies/", false);
            uri.AppendPath(collectorPolicyName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the collector policy in a specified Traffic Collector. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="collectorPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CollectorPolicyData>> GetAsync(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, string collectorPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName, collectorPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectorPolicyData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CollectorPolicyData.DeserializeCollectorPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CollectorPolicyData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the collector policy in a specified Traffic Collector. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="collectorPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CollectorPolicyData> Get(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, string collectorPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName, collectorPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectorPolicyData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CollectorPolicyData.DeserializeCollectorPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CollectorPolicyData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, string collectorPolicyName, CollectorPolicyData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.NetworkFunction/azureTrafficCollectors/", false);
            uri.AppendPath(azureTrafficCollectorName, true);
            uri.AppendPath("/collectorPolicies/", false);
            uri.AppendPath(collectorPolicyName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a Collector Policy resource. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="data"> The parameters to provide for the created Collector Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/>, <paramref name="collectorPolicyName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, string collectorPolicyName, CollectorPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName, collectorPolicyName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a Collector Policy resource. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="data"> The parameters to provide for the created Collector Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/>, <paramref name="collectorPolicyName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, string collectorPolicyName, CollectorPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName, collectorPolicyName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, string collectorPolicyName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.NetworkFunction/azureTrafficCollectors/", false);
            uri.AppendPath(azureTrafficCollectorName, true);
            uri.AppendPath("/collectorPolicies/", false);
            uri.AppendPath(collectorPolicyName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a specified Collector Policy resource. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="collectorPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, string collectorPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName, collectorPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a specified Collector Policy resource. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="collectorPolicyName"> Collector Policy Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="collectorPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="collectorPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, string collectorPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNullOrEmpty(collectorPolicyName, nameof(collectorPolicyName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName, collectorPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string azureTrafficCollectorName)
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

        /// <summary> Return list of Collector policies in a Azure Traffic Collector. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CollectorPolicyListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, azureTrafficCollectorName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectorPolicyListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CollectorPolicyListResult.DeserializeCollectorPolicyListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Return list of Collector policies in a Azure Traffic Collector. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CollectorPolicyListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, azureTrafficCollectorName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectorPolicyListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CollectorPolicyListResult.DeserializeCollectorPolicyListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
