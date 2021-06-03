// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The Scenes service client. </summary>
    public partial class ScenesClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of ScenesClient for mocking. </summary>
        protected ScenesClient()
        {
        }

        /// <summary> Initializes a new instance of ScenesClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ScenesClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new FarmBeatsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Returns a paginated list of scene resources. </summary>
        /// <param name="provider"> Provider name of scene data. </param>
        /// <param name="farmerId"> FarmerId. </param>
        /// <param name="boundaryId"> BoundaryId. </param>
        /// <param name="source"> Source name of scene data, default value Sentinel_2_L2A (Sentinel 2 L2A). </param>
        /// <param name="startDateTime"> Scene start UTC datetime (inclusive), sample format: yyyy-MM-ddThh:mm:ssZ. </param>
        /// <param name="endDateTime"> Scene end UTC datetime (inclusive), sample format: yyyy-MM-dThh:mm:ssZ. </param>
        /// <param name="maxCloudCoveragePercentage"> Filter scenes with cloud coverage percentage less than max value. Range [0 to 100.0]. </param>
        /// <param name="maxDarkPixelCoveragePercentage"> Filter scenes with dark pixel coverage percentage less than max value. Range [0 to 100.0]. </param>
        /// <param name="imageNames"> List of image names to be filtered. </param>
        /// <param name="imageResolutions"> List of image resolutions in meters to be filtered. </param>
        /// <param name="imageFormats"> List of image formats to be filtered. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// 
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> ListAsync(string provider, string farmerId, string boundaryId, string source = null, DateTimeOffset? startDateTime = null, DateTimeOffset? endDateTime = null, double? maxCloudCoveragePercentage = null, double? maxDarkPixelCoveragePercentage = null, IEnumerable<string> imageNames = null, IEnumerable<double> imageResolutions = null, IEnumerable<string> imageFormats = null, int? maxPageSize = null, string skipToken = null, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateListRequest(provider, farmerId, boundaryId, source, startDateTime, endDateTime, maxCloudCoveragePercentage, maxDarkPixelCoveragePercentage, imageNames, imageResolutions, imageFormats, maxPageSize, skipToken, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ScenesClient.List");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a paginated list of scene resources. </summary>
        /// <param name="provider"> Provider name of scene data. </param>
        /// <param name="farmerId"> FarmerId. </param>
        /// <param name="boundaryId"> BoundaryId. </param>
        /// <param name="source"> Source name of scene data, default value Sentinel_2_L2A (Sentinel 2 L2A). </param>
        /// <param name="startDateTime"> Scene start UTC datetime (inclusive), sample format: yyyy-MM-ddThh:mm:ssZ. </param>
        /// <param name="endDateTime"> Scene end UTC datetime (inclusive), sample format: yyyy-MM-dThh:mm:ssZ. </param>
        /// <param name="maxCloudCoveragePercentage"> Filter scenes with cloud coverage percentage less than max value. Range [0 to 100.0]. </param>
        /// <param name="maxDarkPixelCoveragePercentage"> Filter scenes with dark pixel coverage percentage less than max value. Range [0 to 100.0]. </param>
        /// <param name="imageNames"> List of image names to be filtered. </param>
        /// <param name="imageResolutions"> List of image resolutions in meters to be filtered. </param>
        /// <param name="imageFormats"> List of image formats to be filtered. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// 
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response List(string provider, string farmerId, string boundaryId, string source = null, DateTimeOffset? startDateTime = null, DateTimeOffset? endDateTime = null, double? maxCloudCoveragePercentage = null, double? maxDarkPixelCoveragePercentage = null, IEnumerable<string> imageNames = null, IEnumerable<double> imageResolutions = null, IEnumerable<string> imageFormats = null, int? maxPageSize = null, string skipToken = null, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateListRequest(provider, farmerId, boundaryId, source, startDateTime, endDateTime, maxCloudCoveragePercentage, maxDarkPixelCoveragePercentage, imageNames, imageResolutions, imageFormats, maxPageSize, skipToken, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ScenesClient.List");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="List"/> and <see cref="ListAsync"/> operations. </summary>
        /// <param name="provider"> Provider name of scene data. </param>
        /// <param name="farmerId"> FarmerId. </param>
        /// <param name="boundaryId"> BoundaryId. </param>
        /// <param name="source"> Source name of scene data, default value Sentinel_2_L2A (Sentinel 2 L2A). </param>
        /// <param name="startDateTime"> Scene start UTC datetime (inclusive), sample format: yyyy-MM-ddThh:mm:ssZ. </param>
        /// <param name="endDateTime"> Scene end UTC datetime (inclusive), sample format: yyyy-MM-dThh:mm:ssZ. </param>
        /// <param name="maxCloudCoveragePercentage"> Filter scenes with cloud coverage percentage less than max value. Range [0 to 100.0]. </param>
        /// <param name="maxDarkPixelCoveragePercentage"> Filter scenes with dark pixel coverage percentage less than max value. Range [0 to 100.0]. </param>
        /// <param name="imageNames"> List of image names to be filtered. </param>
        /// <param name="imageResolutions"> List of image resolutions in meters to be filtered. </param>
        /// <param name="imageFormats"> List of image formats to be filtered. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// 
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateListRequest(string provider, string farmerId, string boundaryId, string source = null, DateTimeOffset? startDateTime = null, DateTimeOffset? endDateTime = null, double? maxCloudCoveragePercentage = null, double? maxDarkPixelCoveragePercentage = null, IEnumerable<string> imageNames = null, IEnumerable<double> imageResolutions = null, IEnumerable<string> imageFormats = null, int? maxPageSize = null, string skipToken = null, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/scenes", false);
            uri.AppendQuery("provider", provider, true);
            uri.AppendQuery("farmerId", farmerId, true);
            uri.AppendQuery("boundaryId", boundaryId, true);
            if (source != null)
            {
                uri.AppendQuery("source", source, true);
            }
            if (startDateTime != null)
            {
                uri.AppendQuery("startDateTime", startDateTime.Value, "O", true);
            }
            if (endDateTime != null)
            {
                uri.AppendQuery("endDateTime", endDateTime.Value, "O", true);
            }
            if (maxCloudCoveragePercentage != null)
            {
                uri.AppendQuery("maxCloudCoveragePercentage", maxCloudCoveragePercentage.Value, true);
            }
            if (maxDarkPixelCoveragePercentage != null)
            {
                uri.AppendQuery("maxDarkPixelCoveragePercentage", maxDarkPixelCoveragePercentage.Value, true);
            }
            if (imageNames != null)
            {
                uri.AppendQueryDelimited("imageNames", imageNames, ",", true);
            }
            if (imageResolutions != null)
            {
                uri.AppendQueryDelimited("imageResolutions", imageResolutions, ",", true);
            }
            if (imageFormats != null)
            {
                uri.AppendQueryDelimited("imageFormats", imageFormats, ",", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Create a satellite data ingestion job. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>farmerId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Farmer ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>boundaryId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> The id of the boundary object for which satellite data is being fetched. </term>
        ///   </item>
        ///   <item>
        ///     <term>startDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term>Yes</term>
        ///     <term> Start Date. </term>
        ///   </item>
        ///   <item>
        ///     <term>endDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term>Yes</term>
        ///     <term> End Date. </term>
        ///   </item>
        ///   <item>
        ///     <term>provider</term>
        ///     <term>&quot;Microsoft&quot;</term>
        ///     <term></term>
        ///     <term> Provider of satellite data. </term>
        ///   </item>
        ///   <item>
        ///     <term>source</term>
        ///     <term>&quot;Sentinel_2_L2A&quot;</term>
        ///     <term></term>
        ///     <term> Source of satellite data. </term>
        ///   </item>
        ///   <item>
        ///     <term>data</term>
        ///     <term>SatelliteData</term>
        ///     <term></term>
        ///     <term> Data Model for SatelliteIngestionJobRequest. </term>
        ///   </item>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Unique job id. </term>
        ///   </item>
        ///   <item>
        ///     <term>status</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>
        /// Status of the job.
        /// 
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>durationInSeconds</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> Duration of the job in seconds. </term>
        ///   </item>
        ///   <item>
        ///     <term>message</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Status message to capture more details of the job. </term>
        ///   </item>
        ///   <item>
        ///     <term>createdDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>lastActionDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>startTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>endTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>name</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Name to identify resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>description</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Textual description of the resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>properties</term>
        ///     <term>Dictionary&lt;string, AnyObject&gt;</term>
        ///     <term></term>
        ///     <term>
        /// A collection of key value pairs that belongs to the resource.
        /// 
        /// Each pair must not have a key greater than 50 characters
        /// 
        /// and must not have a value greater than 150 characters.
        /// 
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// </term>
        ///   </item>
        /// </list>
        /// Schema for <c>SatelliteData</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>imageNames</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term> List of ImageNames. </term>
        ///   </item>
        ///   <item>
        ///     <term>imageFormats</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term> List of ImageFormats. Available value: TIF. </term>
        ///   </item>
        ///   <item>
        ///     <term>imageResolutions</term>
        ///     <term>number[]</term>
        ///     <term></term>
        ///     <term> List of ImageResolutions in meters. Available values: 10, 20, 60. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="jobId"> JobId provided by user. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateSatelliteDataIngestionJobAsync(string jobId, RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateCreateSatelliteDataIngestionJobRequest(jobId, requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ScenesClient.CreateSatelliteDataIngestionJob");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 202:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a satellite data ingestion job. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>farmerId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Farmer ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>boundaryId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> The id of the boundary object for which satellite data is being fetched. </term>
        ///   </item>
        ///   <item>
        ///     <term>startDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term>Yes</term>
        ///     <term> Start Date. </term>
        ///   </item>
        ///   <item>
        ///     <term>endDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term>Yes</term>
        ///     <term> End Date. </term>
        ///   </item>
        ///   <item>
        ///     <term>provider</term>
        ///     <term>&quot;Microsoft&quot;</term>
        ///     <term></term>
        ///     <term> Provider of satellite data. </term>
        ///   </item>
        ///   <item>
        ///     <term>source</term>
        ///     <term>&quot;Sentinel_2_L2A&quot;</term>
        ///     <term></term>
        ///     <term> Source of satellite data. </term>
        ///   </item>
        ///   <item>
        ///     <term>data</term>
        ///     <term>SatelliteData</term>
        ///     <term></term>
        ///     <term> Data Model for SatelliteIngestionJobRequest. </term>
        ///   </item>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Unique job id. </term>
        ///   </item>
        ///   <item>
        ///     <term>status</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>
        /// Status of the job.
        /// 
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>durationInSeconds</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> Duration of the job in seconds. </term>
        ///   </item>
        ///   <item>
        ///     <term>message</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Status message to capture more details of the job. </term>
        ///   </item>
        ///   <item>
        ///     <term>createdDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>lastActionDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>startTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>endTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>name</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Name to identify resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>description</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Textual description of the resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>properties</term>
        ///     <term>Dictionary&lt;string, AnyObject&gt;</term>
        ///     <term></term>
        ///     <term>
        /// A collection of key value pairs that belongs to the resource.
        /// 
        /// Each pair must not have a key greater than 50 characters
        /// 
        /// and must not have a value greater than 150 characters.
        /// 
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// </term>
        ///   </item>
        /// </list>
        /// Schema for <c>SatelliteData</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>imageNames</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term> List of ImageNames. </term>
        ///   </item>
        ///   <item>
        ///     <term>imageFormats</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term> List of ImageFormats. Available value: TIF. </term>
        ///   </item>
        ///   <item>
        ///     <term>imageResolutions</term>
        ///     <term>number[]</term>
        ///     <term></term>
        ///     <term> List of ImageResolutions in meters. Available values: 10, 20, 60. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="jobId"> JobId provided by user. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateSatelliteDataIngestionJob(string jobId, RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateCreateSatelliteDataIngestionJobRequest(jobId, requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ScenesClient.CreateSatelliteDataIngestionJob");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 202:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="CreateSatelliteDataIngestionJob"/> and <see cref="CreateSatelliteDataIngestionJobAsync"/> operations. </summary>
        /// <param name="jobId"> JobId provided by user. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateCreateSatelliteDataIngestionJobRequest(string jobId, RequestContent requestBody, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/scenes/satellite/ingest-data/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return message;
        }

        /// <summary> Get a satellite data ingestion job. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetSatelliteDataIngestionJobDetailsAsync(string jobId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetSatelliteDataIngestionJobDetailsRequest(jobId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ScenesClient.GetSatelliteDataIngestionJobDetails");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a satellite data ingestion job. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetSatelliteDataIngestionJobDetails(string jobId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetSatelliteDataIngestionJobDetailsRequest(jobId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ScenesClient.GetSatelliteDataIngestionJobDetails");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetSatelliteDataIngestionJobDetails"/> and <see cref="GetSatelliteDataIngestionJobDetailsAsync"/> operations. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateGetSatelliteDataIngestionJobDetailsRequest(string jobId, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/scenes/satellite/ingest-data/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Downloads and returns file stream as response for the given input filePath. </summary>
        /// <param name="filePath"> cloud storage path of scene file. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> DownloadAsync(string filePath, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateDownloadRequest(filePath, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ScenesClient.Download");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Downloads and returns file stream as response for the given input filePath. </summary>
        /// <param name="filePath"> cloud storage path of scene file. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Download(string filePath, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateDownloadRequest(filePath, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ScenesClient.Download");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Download"/> and <see cref="DownloadAsync"/> operations. </summary>
        /// <param name="filePath"> cloud storage path of scene file. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateDownloadRequest(string filePath, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/scenes/downloadFiles", false);
            uri.AppendQuery("filePath", filePath, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/octet-stream, application/json");
            return message;
        }
    }
}
