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
using Azure.ResourceManager.BotService.Models;

namespace Azure.ResourceManager.BotService
{
    internal partial class QnAMakerEndpointKeysRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of QnAMakerEndpointKeysRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public QnAMakerEndpointKeysRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-06-15-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, QnAMakerEndpointKeysRequestBody qnAMakerEndpointKeysRequestBody)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.BotService/listQnAMakerEndpointKeys", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(qnAMakerEndpointKeysRequestBody);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the QnA Maker endpoint keys. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="qnAMakerEndpointKeysRequestBody"> The request body parameters to provide for the check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="qnAMakerEndpointKeysRequestBody"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<QnAMakerEndpointKeysResponse>> GetAsync(string subscriptionId, QnAMakerEndpointKeysRequestBody qnAMakerEndpointKeysRequestBody, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(qnAMakerEndpointKeysRequestBody, nameof(qnAMakerEndpointKeysRequestBody));

            using var message = CreateGetRequest(subscriptionId, qnAMakerEndpointKeysRequestBody);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QnAMakerEndpointKeysResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QnAMakerEndpointKeysResponse.DeserializeQnAMakerEndpointKeysResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the QnA Maker endpoint keys. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="qnAMakerEndpointKeysRequestBody"> The request body parameters to provide for the check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="qnAMakerEndpointKeysRequestBody"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<QnAMakerEndpointKeysResponse> Get(string subscriptionId, QnAMakerEndpointKeysRequestBody qnAMakerEndpointKeysRequestBody, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(qnAMakerEndpointKeysRequestBody, nameof(qnAMakerEndpointKeysRequestBody));

            using var message = CreateGetRequest(subscriptionId, qnAMakerEndpointKeysRequestBody);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QnAMakerEndpointKeysResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QnAMakerEndpointKeysResponse.DeserializeQnAMakerEndpointKeysResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
