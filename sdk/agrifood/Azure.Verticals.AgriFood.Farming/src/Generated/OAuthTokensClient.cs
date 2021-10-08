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
    /// <summary> The OAuthTokens service client. </summary>
    public partial class OAuthTokensClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }
        private HttpPipeline _pipeline;
        private readonly string[] AuthorizationScopes = { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of OAuthTokensClient for mocking. </summary>
        protected OAuthTokensClient()
        {
        }

        /// <summary> Initializes a new instance of OAuthTokensClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public OAuthTokensClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
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
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Returns a list of OAuthToken documents. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       farmerId: string,
        ///       authProviderId: string,
        ///       isValid: boolean,
        ///       eTag: string,
        ///       createdDateTime: string (ISO 8601 Format),
        ///       modifiedDateTime: string (ISO 8601 Format)
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="authProviderIds"> Name of AuthProvider. </param>
        /// <param name="farmerIds"> List of farmers. </param>
        /// <param name="isValid"> If the token object is valid. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> ListAsync(IEnumerable<string> authProviderIds = null, IEnumerable<string> farmerIds = null, bool? isValid = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateListRequest(authProviderIds, farmerIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("OAuthTokensClient.List");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
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

        /// <summary> Returns a list of OAuthToken documents. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       farmerId: string,
        ///       authProviderId: string,
        ///       isValid: boolean,
        ///       eTag: string,
        ///       createdDateTime: string (ISO 8601 Format),
        ///       modifiedDateTime: string (ISO 8601 Format)
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="authProviderIds"> Name of AuthProvider. </param>
        /// <param name="farmerIds"> List of farmers. </param>
        /// <param name="isValid"> If the token object is valid. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response List(IEnumerable<string> authProviderIds = null, IEnumerable<string> farmerIds = null, bool? isValid = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateListRequest(authProviderIds, farmerIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("OAuthTokensClient.List");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
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

        private HttpMessage CreateListRequest(IEnumerable<string> authProviderIds, IEnumerable<string> farmerIds, bool? isValid, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/oauth/tokens", false);
            if (authProviderIds != null)
            {
                uri.AppendQueryDelimited("authProviderIds", authProviderIds, ",", true);
            }
            if (farmerIds != null)
            {
                uri.AppendQueryDelimited("farmerIds", farmerIds, ",", true);
            }
            if (isValid != null)
            {
                uri.AppendQuery("isValid", isValid.Value, true);
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
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

        /// <summary> Returns Connection link needed in the OAuth flow. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   farmerId: string (required),
        ///   oAuthProviderId: string (required),
        ///   userRedirectLink: string (required),
        ///   userRedirectState: string
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetOAuthConnectionLinkAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetOAuthConnectionLinkRequest(content);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("OAuthTokensClient.GetOAuthConnectionLink");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
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

        /// <summary> Returns Connection link needed in the OAuth flow. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   farmerId: string (required),
        ///   oAuthProviderId: string (required),
        ///   userRedirectLink: string (required),
        ///   userRedirectState: string
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetOAuthConnectionLink(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetOAuthConnectionLinkRequest(content);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("OAuthTokensClient.GetOAuthConnectionLink");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
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

        private HttpMessage CreateGetOAuthConnectionLinkRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/oauth/tokens/:connect", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Get cascade delete job details for OAuth tokens for specified job ID. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetCascadeDeleteJobDetailsAsync(string jobId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetCascadeDeleteJobDetailsRequest(jobId);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("OAuthTokensClient.GetCascadeDeleteJobDetails");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
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

        /// <summary> Get cascade delete job details for OAuth tokens for specified job ID. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetCascadeDeleteJobDetails(string jobId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetCascadeDeleteJobDetailsRequest(jobId);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("OAuthTokensClient.GetCascadeDeleteJobDetails");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
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

        private HttpMessage CreateGetCascadeDeleteJobDetailsRequest(string jobId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/oauth/tokens/remove/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Create a cascade delete job for OAuth tokens. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="jobId"> Job ID supplied by end user. </param>
        /// <param name="farmerId"> ID of the farmer. </param>
        /// <param name="oauthProviderId"> ID of the OAuthProvider. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Operation<BinaryData>> CreateCascadeDeleteJobAsync(string jobId, string farmerId, string oauthProviderId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateCreateCascadeDeleteJobRequest(jobId, farmerId, oauthProviderId);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("OAuthTokensClient.CreateCascadeDeleteJob");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 202:
                            return new LowLevelBinaryDataOperation(_clientDiagnostics, Pipeline, message.Request, message.Response, OperationFinalStateVia.Location, "OAuthTokensClient.CreateCascadeDeleteJob");
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return new LowLevelBinaryDataOperation(_clientDiagnostics, Pipeline, message.Request, message.Response, OperationFinalStateVia.Location, "OAuthTokensClient.CreateCascadeDeleteJob");
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a cascade delete job for OAuth tokens. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="jobId"> Job ID supplied by end user. </param>
        /// <param name="farmerId"> ID of the farmer. </param>
        /// <param name="oauthProviderId"> ID of the OAuthProvider. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Operation<BinaryData> CreateCascadeDeleteJob(string jobId, string farmerId, string oauthProviderId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateCreateCascadeDeleteJobRequest(jobId, farmerId, oauthProviderId);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("OAuthTokensClient.CreateCascadeDeleteJob");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 202:
                            return new LowLevelBinaryDataOperation(_clientDiagnostics, Pipeline, message.Request, message.Response, OperationFinalStateVia.Location, "OAuthTokensClient.CreateCascadeDeleteJob");
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return new LowLevelBinaryDataOperation(_clientDiagnostics, Pipeline, message.Request, message.Response, OperationFinalStateVia.Location, "OAuthTokensClient.CreateCascadeDeleteJob");
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private HttpMessage CreateCreateCascadeDeleteJobRequest(string jobId, string farmerId, string oauthProviderId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/oauth/tokens/remove/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("farmerId", farmerId, true);
            uri.AppendQuery("oauthProviderId", oauthProviderId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
