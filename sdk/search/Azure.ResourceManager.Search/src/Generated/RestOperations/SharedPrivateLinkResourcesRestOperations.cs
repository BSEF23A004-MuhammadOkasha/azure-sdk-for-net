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
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    internal partial class SharedPrivateLinkResourcesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SharedPrivateLinkResourcesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SharedPrivateLinkResourcesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SharedSearchServicePrivateLinkResourceData data, SearchManagementRequestOptions searchManagementRequestOptions)
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
            uri.AppendPath("/providers/Microsoft.Search/searchServices/", false);
            uri.AppendPath(searchServiceName, true);
            uri.AppendPath("/sharedPrivateLinkResources/", false);
            uri.AppendPath(sharedPrivateLinkResourceName, true);
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

        /// <summary> Initiates the creation or update of a shared private link resource managed by the search service in the given resource group. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="data"> The definition of the shared private link resource to create or update. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/>, <paramref name="sharedPrivateLinkResourceName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/> or <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SharedSearchServicePrivateLinkResourceData data, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, data, searchManagementRequestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Initiates the creation or update of a shared private link resource managed by the search service in the given resource group. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="data"> The definition of the shared private link resource to create or update. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/>, <paramref name="sharedPrivateLinkResourceName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/> or <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SharedSearchServicePrivateLinkResourceData data, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, data, searchManagementRequestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions)
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
            uri.AppendPath("/providers/Microsoft.Search/searchServices/", false);
            uri.AppendPath(searchServiceName, true);
            uri.AppendPath("/sharedPrivateLinkResources/", false);
            uri.AppendPath(sharedPrivateLinkResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the details of the shared private link resource managed by the search service in the given resource group. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/> or <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/> or <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SharedSearchServicePrivateLinkResourceData>> GetAsync(string subscriptionId, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, searchManagementRequestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedSearchServicePrivateLinkResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SharedSearchServicePrivateLinkResourceData.DeserializeSharedSearchServicePrivateLinkResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SharedSearchServicePrivateLinkResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the details of the shared private link resource managed by the search service in the given resource group. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/> or <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/> or <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SharedSearchServicePrivateLinkResourceData> Get(string subscriptionId, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, searchManagementRequestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedSearchServicePrivateLinkResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SharedSearchServicePrivateLinkResourceData.DeserializeSharedSearchServicePrivateLinkResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SharedSearchServicePrivateLinkResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions)
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
            uri.AppendPath("/providers/Microsoft.Search/searchServices/", false);
            uri.AppendPath(searchServiceName, true);
            uri.AppendPath("/sharedPrivateLinkResources/", false);
            uri.AppendPath(sharedPrivateLinkResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Initiates the deletion of the shared private link resource from the search service. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/> or <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/> or <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, searchManagementRequestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Initiates the deletion of the shared private link resource from the search service. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/> or <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="searchServiceName"/> or <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, searchManagementRequestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByServiceRequest(string subscriptionId, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions)
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
            uri.AppendPath("/providers/Microsoft.Search/searchServices/", false);
            uri.AppendPath(searchServiceName, true);
            uri.AppendPath("/sharedPrivateLinkResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of all shared private link resources managed by the given service. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="searchServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SharedPrivateLinkResourceListResult>> ListByServiceAsync(string subscriptionId, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));

            using var message = CreateListByServiceRequest(subscriptionId, resourceGroupName, searchServiceName, searchManagementRequestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedPrivateLinkResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SharedPrivateLinkResourceListResult.DeserializeSharedPrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of all shared private link resources managed by the given service. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="searchServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SharedPrivateLinkResourceListResult> ListByService(string subscriptionId, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));

            using var message = CreateListByServiceRequest(subscriptionId, resourceGroupName, searchServiceName, searchManagementRequestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedPrivateLinkResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SharedPrivateLinkResourceListResult.DeserializeSharedPrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByServiceNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions)
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

        /// <summary> Gets a list of all shared private link resources managed by the given service. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="searchServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SharedPrivateLinkResourceListResult>> ListByServiceNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));

            using var message = CreateListByServiceNextPageRequest(nextLink, subscriptionId, resourceGroupName, searchServiceName, searchManagementRequestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedPrivateLinkResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SharedPrivateLinkResourceListResult.DeserializeSharedPrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of all shared private link resources managed by the given service. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="searchServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SharedPrivateLinkResourceListResult> ListByServiceNextPage(string nextLink, string subscriptionId, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(searchServiceName, nameof(searchServiceName));

            using var message = CreateListByServiceNextPageRequest(nextLink, subscriptionId, resourceGroupName, searchServiceName, searchManagementRequestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SharedPrivateLinkResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SharedPrivateLinkResourceListResult.DeserializeSharedPrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
