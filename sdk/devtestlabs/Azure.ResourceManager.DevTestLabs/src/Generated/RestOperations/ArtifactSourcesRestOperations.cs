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
using Azure.ResourceManager.DevTestLabs.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    internal partial class ArtifactSourcesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ArtifactSourcesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ArtifactSourcesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2018-09-15";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string labName, string expand, string filter, int? top, string orderby)
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
            uri.AppendPath("/providers/Microsoft.DevTestLab/labs/", false);
            uri.AppendPath(labName, true);
            uri.AppendPath("/artifactsources", false);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List artifact sources in a given lab. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="labName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ArtifactSourceList>> ListAsync(string subscriptionId, string resourceGroupName, string labName, string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, labName, expand, filter, top, orderby);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArtifactSourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ArtifactSourceList.DeserializeArtifactSourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List artifact sources in a given lab. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="labName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ArtifactSourceList> List(string subscriptionId, string resourceGroupName, string labName, string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, labName, expand, filter, top, orderby);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArtifactSourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ArtifactSourceList.DeserializeArtifactSourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string labName, string name, string expand)
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
            uri.AppendPath("/providers/Microsoft.DevTestLab/labs/", false);
            uri.AppendPath(labName, true);
            uri.AppendPath("/artifactsources/", false);
            uri.AppendPath(name, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get artifact source. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DevTestLabArtifactSourceData>> GetAsync(string subscriptionId, string resourceGroupName, string labName, string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, labName, name, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DevTestLabArtifactSourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DevTestLabArtifactSourceData.DeserializeDevTestLabArtifactSourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DevTestLabArtifactSourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get artifact source. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DevTestLabArtifactSourceData> Get(string subscriptionId, string resourceGroupName, string labName, string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, labName, name, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DevTestLabArtifactSourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DevTestLabArtifactSourceData.DeserializeDevTestLabArtifactSourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DevTestLabArtifactSourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string labName, string name, DevTestLabArtifactSourceData data)
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
            uri.AppendPath("/providers/Microsoft.DevTestLab/labs/", false);
            uri.AppendPath(labName, true);
            uri.AppendPath("/artifactsources/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = data;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or replace an existing artifact source. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="data"> Properties of an artifact source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/>, <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DevTestLabArtifactSourceData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string labName, string name, DevTestLabArtifactSourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, labName, name, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DevTestLabArtifactSourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DevTestLabArtifactSourceData.DeserializeDevTestLabArtifactSourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or replace an existing artifact source. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="data"> Properties of an artifact source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/>, <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DevTestLabArtifactSourceData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string labName, string name, DevTestLabArtifactSourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, labName, name, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DevTestLabArtifactSourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DevTestLabArtifactSourceData.DeserializeDevTestLabArtifactSourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string labName, string name)
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
            uri.AppendPath("/providers/Microsoft.DevTestLab/labs/", false);
            uri.AppendPath(labName, true);
            uri.AppendPath("/artifactsources/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete artifact source. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, labName, name);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete artifact source. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, labName, name);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string labName, string name, DevTestLabArtifactSourcePatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DevTestLab/labs/", false);
            uri.AppendPath(labName, true);
            uri.AppendPath("/artifactsources/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = patch;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Allows modifying tags of artifact sources. All other properties will be ignored. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="patch"> Properties of an artifact source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/>, <paramref name="name"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DevTestLabArtifactSourceData>> UpdateAsync(string subscriptionId, string resourceGroupName, string labName, string name, DevTestLabArtifactSourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, labName, name, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DevTestLabArtifactSourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DevTestLabArtifactSourceData.DeserializeDevTestLabArtifactSourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Allows modifying tags of artifact sources. All other properties will be ignored. </summary>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="name"> The name of the artifact source. </param>
        /// <param name="patch"> Properties of an artifact source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/>, <paramref name="name"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="labName"/> or <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DevTestLabArtifactSourceData> Update(string subscriptionId, string resourceGroupName, string labName, string name, DevTestLabArtifactSourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, labName, name, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DevTestLabArtifactSourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DevTestLabArtifactSourceData.DeserializeDevTestLabArtifactSourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string labName, string expand, string filter, int? top, string orderby)
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

        /// <summary> List artifact sources in a given lab. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="labName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ArtifactSourceList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string labName, string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, labName, expand, filter, top, orderby);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArtifactSourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ArtifactSourceList.DeserializeArtifactSourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List artifact sources in a given lab. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="labName"> The name of the lab. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=displayName)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="labName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ArtifactSourceList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string labName, string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(labName, nameof(labName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, labName, expand, filter, top, orderby);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArtifactSourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ArtifactSourceList.DeserializeArtifactSourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
