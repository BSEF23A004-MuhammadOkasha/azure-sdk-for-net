// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    // Data plane generated sub-client.
    /// <summary> The FarmerOAuthTokens sub-client. </summary>
    public partial class FarmerOAuthTokens
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of FarmerOAuthTokens for mocking. </summary>
        protected FarmerOAuthTokens()
        {
        }

        /// <summary> Initializes a new instance of FarmerOAuthTokens. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal FarmerOAuthTokens(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary>
        /// [Protocol Method] Returns Connection link needed in the OAuth flow.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/FarmerOAuthTokens.xml" path="doc/members/member[@name='GetOAuthConnectionLinkAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> GetOAuthConnectionLinkAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("FarmerOAuthTokens.GetOAuthConnectionLink");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetOAuthConnectionLinkRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Returns Connection link needed in the OAuth flow.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/FarmerOAuthTokens.xml" path="doc/members/member[@name='GetOAuthConnectionLink(RequestContent,RequestContext)']/*" />
        public virtual Response GetOAuthConnectionLink(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("FarmerOAuthTokens.GetOAuthConnectionLink");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetOAuthConnectionLinkRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get remove job for OAuth token.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/FarmerOAuthTokens.xml" path="doc/members/member[@name='GetCascadeDeleteJobDetailsAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> GetCascadeDeleteJobDetailsAsync(string jobId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("FarmerOAuthTokens.GetCascadeDeleteJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCascadeDeleteJobDetailsRequest(jobId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get remove job for OAuth token.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/FarmerOAuthTokens.xml" path="doc/members/member[@name='GetCascadeDeleteJobDetails(string,RequestContext)']/*" />
        public virtual Response GetCascadeDeleteJobDetails(string jobId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("FarmerOAuthTokens.GetCascadeDeleteJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCascadeDeleteJobDetailsRequest(jobId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Returns a list of OAuthToken documents.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authProviderIds"> Name of AuthProvider. </param>
        /// <param name="partyIds"> List of parties. </param>
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
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/FarmerOAuthTokens.xml" path="doc/members/member[@name='GetAuthenticatedFarmersDetailsAsync(IEnumerable{string},IEnumerable{string},bool?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetAuthenticatedFarmersDetailsAsync(IEnumerable<string> authProviderIds, IEnumerable<string> partyIds, bool? isValid, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetAuthenticatedFarmersDetailsRequest(authProviderIds, partyIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetAuthenticatedFarmersDetailsNextPageRequest(nextLink, authProviderIds, partyIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "FarmerOAuthTokens.GetAuthenticatedFarmersDetails", "value", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] Returns a list of OAuthToken documents.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authProviderIds"> Name of AuthProvider. </param>
        /// <param name="partyIds"> List of parties. </param>
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
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/FarmerOAuthTokens.xml" path="doc/members/member[@name='GetAuthenticatedFarmersDetails(IEnumerable{string},IEnumerable{string},bool?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetAuthenticatedFarmersDetails(IEnumerable<string> authProviderIds, IEnumerable<string> partyIds, bool? isValid, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetAuthenticatedFarmersDetailsRequest(authProviderIds, partyIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetAuthenticatedFarmersDetailsNextPageRequest(nextLink, authProviderIds, partyIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "FarmerOAuthTokens.GetAuthenticatedFarmersDetails", "value", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] Create remove job for OAuth token.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job Id supplied by end user. </param>
        /// <param name="partyId"> Id of the party. </param>
        /// <param name="oauthProviderId"> Id of the OAuthProvider. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/>, <paramref name="partyId"/> or <paramref name="oauthProviderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/FarmerOAuthTokens.xml" path="doc/members/member[@name='CreateCascadeDeleteJobAsync(WaitUntil,string,string,string,RequestContext)']/*" />
        public virtual async Task<Operation<BinaryData>> CreateCascadeDeleteJobAsync(WaitUntil waitUntil, string jobId, string partyId, string oauthProviderId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));
            Argument.AssertNotNull(partyId, nameof(partyId));
            Argument.AssertNotNull(oauthProviderId, nameof(oauthProviderId));

            using var scope = ClientDiagnostics.CreateScope("FarmerOAuthTokens.CreateCascadeDeleteJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateCascadeDeleteJobRequest(jobId, partyId, oauthProviderId, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "FarmerOAuthTokens.CreateCascadeDeleteJob", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create remove job for OAuth token.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job Id supplied by end user. </param>
        /// <param name="partyId"> Id of the party. </param>
        /// <param name="oauthProviderId"> Id of the OAuthProvider. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/>, <paramref name="partyId"/> or <paramref name="oauthProviderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/FarmerOAuthTokens.xml" path="doc/members/member[@name='CreateCascadeDeleteJob(WaitUntil,string,string,string,RequestContext)']/*" />
        public virtual Operation<BinaryData> CreateCascadeDeleteJob(WaitUntil waitUntil, string jobId, string partyId, string oauthProviderId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));
            Argument.AssertNotNull(partyId, nameof(partyId));
            Argument.AssertNotNull(oauthProviderId, nameof(oauthProviderId));

            using var scope = ClientDiagnostics.CreateScope("FarmerOAuthTokens.CreateCascadeDeleteJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateCascadeDeleteJobRequest(jobId, partyId, oauthProviderId, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "FarmerOAuthTokens.CreateCascadeDeleteJob", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetAuthenticatedFarmersDetailsRequest(IEnumerable<string> authProviderIds, IEnumerable<string> partyIds, bool? isValid, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oauth/tokens", false);
            if (authProviderIds != null && Optional.IsCollectionDefined(authProviderIds))
            {
                foreach (var param in authProviderIds)
                {
                    uri.AppendQuery("authProviderIds", param, true);
                }
            }
            if (partyIds != null && Optional.IsCollectionDefined(partyIds))
            {
                foreach (var param in partyIds)
                {
                    uri.AppendQuery("partyIds", param, true);
                }
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
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetOAuthConnectionLinkRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oauth/tokens/:connect", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetCascadeDeleteJobDetailsRequest(string jobId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oauth/tokens/remove/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateCascadeDeleteJobRequest(string jobId, string partyId, string oauthProviderId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oauth/tokens/remove/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("partyId", partyId, true);
            uri.AppendQuery("oauthProviderId", oauthProviderId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetAuthenticatedFarmersDetailsNextPageRequest(string nextLink, IEnumerable<string> authProviderIds, IEnumerable<string> partyIds, bool? isValid, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
