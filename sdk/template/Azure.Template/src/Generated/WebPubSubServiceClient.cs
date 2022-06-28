// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Template
{
    /// <summary> The WebPubSubService service client. </summary>
    public partial class WebPubSubServiceClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of WebPubSubServiceClient for mocking. </summary>
        protected WebPubSubServiceClient()
        {
        }

        /// <summary> Initializes a new instance of WebPubSubServiceClient. </summary>
        /// <param name="endpoint"> Endpoint - server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public WebPubSubServiceClient(Uri endpoint) : this(endpoint, new WebPubSubServiceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of WebPubSubServiceClient. </summary>
        /// <param name="endpoint"> Endpoint - server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public WebPubSubServiceClient(Uri endpoint, WebPubSubServiceClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new WebPubSubServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Add a connection to the target group. </summary>
        /// <param name="hub"> The String to use. </param>
        /// <param name="group"> The String to use. </param>
        /// <param name="connectionId"> The String to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hub"/>, <paramref name="group"/> or <paramref name="connectionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="hub"/>, <paramref name="group"/> or <paramref name="connectionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> AddConnectionToGroupAsync(string hub, string group, string connectionId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(hub, nameof(hub));
            Argument.AssertNotNullOrEmpty(group, nameof(group));
            Argument.AssertNotNullOrEmpty(connectionId, nameof(connectionId));

            using var scope = ClientDiagnostics.CreateScope("WebPubSubServiceClient.AddConnectionToGroup");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAddConnectionToGroupRequest(hub, group, connectionId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a connection to the target group. </summary>
        /// <param name="hub"> The String to use. </param>
        /// <param name="group"> The String to use. </param>
        /// <param name="connectionId"> The String to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hub"/>, <paramref name="group"/> or <paramref name="connectionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="hub"/>, <paramref name="group"/> or <paramref name="connectionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response AddConnectionToGroup(string hub, string group, string connectionId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(hub, nameof(hub));
            Argument.AssertNotNullOrEmpty(group, nameof(group));
            Argument.AssertNotNullOrEmpty(connectionId, nameof(connectionId));

            using var scope = ClientDiagnostics.CreateScope("WebPubSubServiceClient.AddConnectionToGroup");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAddConnectionToGroupRequest(hub, group, connectionId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateAddConnectionToGroupRequest(string hub, string group, string connectionId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/api/hubs/", false);
            uri.AppendPath(hub, true);
            uri.AppendPath("/groups/", false);
            uri.AppendPath(group, true);
            uri.AppendPath("/connections/", false);
            uri.AppendPath(connectionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
