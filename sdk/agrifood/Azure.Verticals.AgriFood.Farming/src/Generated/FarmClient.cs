// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The Farm service client. </summary>
    public partial class FarmClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly string _apiVersion;

        /// <summary> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </summary>
        public Uri Endpoint { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of FarmClient for mocking. </summary>
        protected FarmClient()
        {
        }

        /// <summary> Initializes a new instance of FarmClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FarmClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new FarmBeatsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of FarmClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FarmClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new FarmBeatsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            Endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Get a farm operation data ingestion job. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>FarmOperationDataIngestionJob</c>:
        /// <code>{
        ///   farmerId: string, # Required. Farmer ID.
        ///   authProviderId: string, # Required. Authentication provider ID.
        ///   operations: [string], # Optional. List of operation types for which data needs to be downloaded. Available values: AllOperations, Application, Planting, Harvest, Tillage.
        ///   startYear: number, # Required. Start Year (Minimum = 2000, Maximum = CurrentYear).
        ///   id: string, # Optional. Unique job id.
        ///   status: string, # Optional. Status of the job.
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        ///   durationInSeconds: number, # Optional. Duration of the job in seconds.
        ///   message: string, # Optional. Status message to capture more details of the job.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   lastActionDateTime: string (ISO 8601 Format), # Optional. Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   startTime: string (ISO 8601 Format), # Optional. Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   endTime: string (ISO 8601 Format), # Optional. Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetDataIngestionJobDetailsAsync(string jobId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("FarmClient.GetDataIngestionJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetDataIngestionJobDetailsRequest(jobId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a farm operation data ingestion job. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>FarmOperationDataIngestionJob</c>:
        /// <code>{
        ///   farmerId: string, # Required. Farmer ID.
        ///   authProviderId: string, # Required. Authentication provider ID.
        ///   operations: [string], # Optional. List of operation types for which data needs to be downloaded. Available values: AllOperations, Application, Planting, Harvest, Tillage.
        ///   startYear: number, # Required. Start Year (Minimum = 2000, Maximum = CurrentYear).
        ///   id: string, # Optional. Unique job id.
        ///   status: string, # Optional. Status of the job.
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        ///   durationInSeconds: number, # Optional. Duration of the job in seconds.
        ///   message: string, # Optional. Status message to capture more details of the job.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   lastActionDateTime: string (ISO 8601 Format), # Optional. Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   startTime: string (ISO 8601 Format), # Optional. Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   endTime: string (ISO 8601 Format), # Optional. Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetDataIngestionJobDetails(string jobId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("FarmClient.GetDataIngestionJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetDataIngestionJobDetailsRequest(jobId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a farm operation data ingestion job. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job ID supplied by user. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>FarmOperationDataIngestionJob</c>:
        /// <code>{
        ///   farmerId: string, # Required. Farmer ID.
        ///   authProviderId: string, # Required. Authentication provider ID.
        ///   operations: [string], # Optional. List of operation types for which data needs to be downloaded. Available values: AllOperations, Application, Planting, Harvest, Tillage.
        ///   startYear: number, # Required. Start Year (Minimum = 2000, Maximum = CurrentYear).
        ///   id: string, # Optional. Unique job id.
        ///   status: string, # Optional. Status of the job.
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        ///   durationInSeconds: number, # Optional. Duration of the job in seconds.
        ///   message: string, # Optional. Status message to capture more details of the job.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   lastActionDateTime: string (ISO 8601 Format), # Optional. Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   startTime: string (ISO 8601 Format), # Optional. Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   endTime: string (ISO 8601 Format), # Optional. Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>FarmOperationDataIngestionJob</c>:
        /// <code>{
        ///   farmerId: string, # Required. Farmer ID.
        ///   authProviderId: string, # Required. Authentication provider ID.
        ///   operations: [string], # Optional. List of operation types for which data needs to be downloaded. Available values: AllOperations, Application, Planting, Harvest, Tillage.
        ///   startYear: number, # Required. Start Year (Minimum = 2000, Maximum = CurrentYear).
        ///   id: string, # Optional. Unique job id.
        ///   status: string, # Optional. Status of the job.
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        ///   durationInSeconds: number, # Optional. Duration of the job in seconds.
        ///   message: string, # Optional. Status message to capture more details of the job.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   lastActionDateTime: string (ISO 8601 Format), # Optional. Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   startTime: string (ISO 8601 Format), # Optional. Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   endTime: string (ISO 8601 Format), # Optional. Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Operation<BinaryData>> CreateDataIngestionJobAsync(WaitUntil waitUntil, string jobId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("FarmClient.CreateDataIngestionJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateDataIngestionJobRequest(jobId, content, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "FarmClient.CreateDataIngestionJob", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a farm operation data ingestion job. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job ID supplied by user. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>FarmOperationDataIngestionJob</c>:
        /// <code>{
        ///   farmerId: string, # Required. Farmer ID.
        ///   authProviderId: string, # Required. Authentication provider ID.
        ///   operations: [string], # Optional. List of operation types for which data needs to be downloaded. Available values: AllOperations, Application, Planting, Harvest, Tillage.
        ///   startYear: number, # Required. Start Year (Minimum = 2000, Maximum = CurrentYear).
        ///   id: string, # Optional. Unique job id.
        ///   status: string, # Optional. Status of the job.
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        ///   durationInSeconds: number, # Optional. Duration of the job in seconds.
        ///   message: string, # Optional. Status message to capture more details of the job.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   lastActionDateTime: string (ISO 8601 Format), # Optional. Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   startTime: string (ISO 8601 Format), # Optional. Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   endTime: string (ISO 8601 Format), # Optional. Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>FarmOperationDataIngestionJob</c>:
        /// <code>{
        ///   farmerId: string, # Required. Farmer ID.
        ///   authProviderId: string, # Required. Authentication provider ID.
        ///   operations: [string], # Optional. List of operation types for which data needs to be downloaded. Available values: AllOperations, Application, Planting, Harvest, Tillage.
        ///   startYear: number, # Required. Start Year (Minimum = 2000, Maximum = CurrentYear).
        ///   id: string, # Optional. Unique job id.
        ///   status: string, # Optional. Status of the job.
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        ///   durationInSeconds: number, # Optional. Duration of the job in seconds.
        ///   message: string, # Optional. Status message to capture more details of the job.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   lastActionDateTime: string (ISO 8601 Format), # Optional. Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   startTime: string (ISO 8601 Format), # Optional. Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   endTime: string (ISO 8601 Format), # Optional. Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Operation<BinaryData> CreateDataIngestionJob(WaitUntil waitUntil, string jobId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("FarmClient.CreateDataIngestionJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateDataIngestionJobRequest(jobId, content, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "FarmClient.CreateDataIngestionJob", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateDataIngestionJobRequest(string jobId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/farm-operations/ingest-data/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetDataIngestionJobDetailsRequest(string jobId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendPath("/farm-operations/ingest-data/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
