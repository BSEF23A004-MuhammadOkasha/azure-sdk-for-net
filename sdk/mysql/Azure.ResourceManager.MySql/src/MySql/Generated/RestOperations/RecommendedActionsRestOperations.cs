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
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql
{
    internal partial class RecommendedActionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RecommendedActionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RecommendedActionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2018-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string serverName, string advisorName, string recommendedActionName)
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
            uri.AppendPath("/providers/Microsoft.DBforMySQL/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/advisors/", false);
            uri.AppendPath(advisorName, true);
            uri.AppendPath("/recommendedActions/", false);
            uri.AppendPath(recommendedActionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve recommended actions from the advisor. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="advisorName"> The advisor name for recommendation action. </param>
        /// <param name="recommendedActionName"> The recommended action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="advisorName"/> or <paramref name="recommendedActionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="advisorName"/> or <paramref name="recommendedActionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MySqlRecommendationActionData>> GetAsync(string subscriptionId, string resourceGroupName, string serverName, string advisorName, string recommendedActionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));
            Argument.AssertNotNullOrEmpty(recommendedActionName, nameof(recommendedActionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serverName, advisorName, recommendedActionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MySqlRecommendationActionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MySqlRecommendationActionData.DeserializeMySqlRecommendationActionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MySqlRecommendationActionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve recommended actions from the advisor. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="advisorName"> The advisor name for recommendation action. </param>
        /// <param name="recommendedActionName"> The recommended action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="advisorName"/> or <paramref name="recommendedActionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="advisorName"/> or <paramref name="recommendedActionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MySqlRecommendationActionData> Get(string subscriptionId, string resourceGroupName, string serverName, string advisorName, string recommendedActionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));
            Argument.AssertNotNullOrEmpty(recommendedActionName, nameof(recommendedActionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serverName, advisorName, recommendedActionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MySqlRecommendationActionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MySqlRecommendationActionData.DeserializeMySqlRecommendationActionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MySqlRecommendationActionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByServerRequest(string subscriptionId, string resourceGroupName, string serverName, string advisorName, string sessionId)
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
            uri.AppendPath("/providers/Microsoft.DBforMySQL/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/advisors/", false);
            uri.AppendPath(advisorName, true);
            uri.AppendPath("/recommendedActions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (sessionId != null)
            {
                uri.AppendQuery("sessionId", sessionId, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve recommended actions from the advisor. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="advisorName"> The advisor name for recommendation action. </param>
        /// <param name="sessionId"> The recommendation action session identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="advisorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MySqlRecommendationActionListResult>> ListByServerAsync(string subscriptionId, string resourceGroupName, string serverName, string advisorName, string sessionId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var message = CreateListByServerRequest(subscriptionId, resourceGroupName, serverName, advisorName, sessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MySqlRecommendationActionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MySqlRecommendationActionListResult.DeserializeMySqlRecommendationActionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve recommended actions from the advisor. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="advisorName"> The advisor name for recommendation action. </param>
        /// <param name="sessionId"> The recommendation action session identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="advisorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MySqlRecommendationActionListResult> ListByServer(string subscriptionId, string resourceGroupName, string serverName, string advisorName, string sessionId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var message = CreateListByServerRequest(subscriptionId, resourceGroupName, serverName, advisorName, sessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MySqlRecommendationActionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MySqlRecommendationActionListResult.DeserializeMySqlRecommendationActionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByServerNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string advisorName, string sessionId)
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

        /// <summary> Retrieve recommended actions from the advisor. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="advisorName"> The advisor name for recommendation action. </param>
        /// <param name="sessionId"> The recommendation action session identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="advisorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MySqlRecommendationActionListResult>> ListByServerNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string advisorName, string sessionId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var message = CreateListByServerNextPageRequest(nextLink, subscriptionId, resourceGroupName, serverName, advisorName, sessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MySqlRecommendationActionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MySqlRecommendationActionListResult.DeserializeMySqlRecommendationActionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve recommended actions from the advisor. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="advisorName"> The advisor name for recommendation action. </param>
        /// <param name="sessionId"> The recommendation action session identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="advisorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MySqlRecommendationActionListResult> ListByServerNextPage(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string advisorName, string sessionId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(advisorName, nameof(advisorName));

            using var message = CreateListByServerNextPageRequest(nextLink, subscriptionId, resourceGroupName, serverName, advisorName, sessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MySqlRecommendationActionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MySqlRecommendationActionListResult.DeserializeMySqlRecommendationActionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
