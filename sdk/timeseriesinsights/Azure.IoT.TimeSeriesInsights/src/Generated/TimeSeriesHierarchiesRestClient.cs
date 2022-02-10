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

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class TimeSeriesHierarchiesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _environmentFqdn;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of TimeSeriesHierarchiesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="environmentFqdn"> Per environment FQDN, for example 10000000-0000-0000-0000-100000000109.env.timeseries.azure.com. You can obtain this domain name from the response of the Get Environments API, Azure portal, or Azure Resource Manager. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentFqdn"/> or <paramref name="apiVersion"/> is null. </exception>
        public TimeSeriesHierarchiesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string environmentFqdn, string apiVersion = "2020-07-31")
        {
            _environmentFqdn = environmentFqdn ?? throw new ArgumentNullException(nameof(environmentFqdn));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string continuationToken, string clientSessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_environmentFqdn, false);
            uri.AppendPath("/timeseries/hierarchies", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (continuationToken != null)
            {
                request.Headers.Add("x-ms-continuation", continuationToken);
            }
            if (clientSessionId != null)
            {
                request.Headers.Add("x-ms-client-session-id", clientSessionId);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns time series hierarchies definitions in pages. </summary>
        /// <param name="continuationToken"> Continuation token from previous page of results to retrieve the next page of the results in calls that support pagination. To get the first page results, specify null continuation token as parameter value. Returned continuation token is null if all results have been returned, and there is no next page of results. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GetHierarchiesPage>> ListAsync(string continuationToken = null, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(continuationToken, clientSessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GetHierarchiesPage value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GetHierarchiesPage.DeserializeGetHierarchiesPage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns time series hierarchies definitions in pages. </summary>
        /// <param name="continuationToken"> Continuation token from previous page of results to retrieve the next page of the results in calls that support pagination. To get the first page results, specify null continuation token as parameter value. Returned continuation token is null if all results have been returned, and there is no next page of results. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GetHierarchiesPage> List(string continuationToken = null, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(continuationToken, clientSessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GetHierarchiesPage value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GetHierarchiesPage.DeserializeGetHierarchiesPage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateExecuteBatchRequest(HierarchiesBatchRequest parameters, string clientSessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_environmentFqdn, false);
            uri.AppendPath("/timeseries/hierarchies/$batch", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (clientSessionId != null)
            {
                request.Headers.Add("x-ms-client-session-id", clientSessionId);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Executes a batch get, create, update, delete operation on multiple time series hierarchy definitions. </summary>
        /// <param name="parameters"> Time series hierarchies batch request body. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async Task<Response<HierarchiesBatchResponse>> ExecuteBatchAsync(HierarchiesBatchRequest parameters, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateExecuteBatchRequest(parameters, clientSessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HierarchiesBatchResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HierarchiesBatchResponse.DeserializeHierarchiesBatchResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Executes a batch get, create, update, delete operation on multiple time series hierarchy definitions. </summary>
        /// <param name="parameters"> Time series hierarchies batch request body. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public Response<HierarchiesBatchResponse> ExecuteBatch(HierarchiesBatchRequest parameters, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateExecuteBatchRequest(parameters, clientSessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HierarchiesBatchResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HierarchiesBatchResponse.DeserializeHierarchiesBatchResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
