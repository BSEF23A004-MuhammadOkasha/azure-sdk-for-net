// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.AccessControl
{
    /// <summary> The RoleAssignments service client. </summary>
    public partial class RoleAssignmentsClient
    {
        private static readonly string[] AuthorizationScopes = { "https://dev.azuresynapse.net/.default" };
        private readonly TokenCredential _tokenCredential;

        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }

        /// <summary> Initializes a new instance of RoleAssignmentsClient for mocking. </summary>
        protected RoleAssignmentsClient()
        {
        }

        /// <summary> Initializes a new instance of RoleAssignmentsClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public RoleAssignmentsClient(Uri endpoint, TokenCredential credential, AccessControlClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new AccessControlClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Check if the given principalId has access to perform list of actions at a given scope. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   subject: {
        ///     principalId: SubjectInfoPrincipalId (required),
        ///     groupIds: [SubjectInfoGroupIdsItem]
        ///   } (required),
        ///   actions: [
        ///     {
        ///       id: string (required),
        ///       isDataAction: boolean (required)
        ///     }
        ///   ] (required),
        ///   scope: string (required)
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   accessDecisions: [
        ///     {
        ///       accessDecision: string,
        ///       actionId: string,
        ///       roleAssignment: {
        ///         id: string,
        ///         roleDefinitionId: RoleAssignmentDetailsRoleDefinitionId,
        ///         principalId: RoleAssignmentDetailsPrincipalId,
        ///         scope: string,
        ///         principalType: string
        ///       }
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> CheckPrincipalAccessAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentsClient.CheckPrincipalAccess");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCheckPrincipalAccessRequest(content);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check if the given principalId has access to perform list of actions at a given scope. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   subject: {
        ///     principalId: SubjectInfoPrincipalId (required),
        ///     groupIds: [SubjectInfoGroupIdsItem]
        ///   } (required),
        ///   actions: [
        ///     {
        ///       id: string (required),
        ///       isDataAction: boolean (required)
        ///     }
        ///   ] (required),
        ///   scope: string (required)
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   accessDecisions: [
        ///     {
        ///       accessDecision: string,
        ///       actionId: string,
        ///       roleAssignment: {
        ///         id: string,
        ///         roleDefinitionId: RoleAssignmentDetailsRoleDefinitionId,
        ///         principalId: RoleAssignmentDetailsPrincipalId,
        ///         scope: string,
        ///         principalType: string
        ///       }
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response CheckPrincipalAccess(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentsClient.CheckPrincipalAccess");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCheckPrincipalAccessRequest(content);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List role assignments. </summary>
        /// <param name="options"> The request options. </param>
        /// <param name="roleId"> Synapse Built-In Role Id. </param>
        /// <param name="principalId"> Object ID of the AAD principal or security-group. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="continuationToken"> Continuation token. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   count: number,
        ///   value: [
        ///     {
        ///       id: string,
        ///       roleDefinitionId: RoleAssignmentDetailsRoleDefinitionId,
        ///       principalId: RoleAssignmentDetailsPrincipalId,
        ///       scope: string,
        ///       principalType: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> ListRoleAssignmentsAsync(RequestOptions options, string roleId = null, string principalId = null, string scope = null, string continuationToken = null)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.ListRoleAssignments");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateListRoleAssignmentsRequest(roleId, principalId, scope, continuationToken);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List role assignments. </summary>
        /// <param name="options"> The request options. </param>
        /// <param name="roleId"> Synapse Built-In Role Id. </param>
        /// <param name="principalId"> Object ID of the AAD principal or security-group. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="continuationToken"> Continuation token. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   count: number,
        ///   value: [
        ///     {
        ///       id: string,
        ///       roleDefinitionId: RoleAssignmentDetailsRoleDefinitionId,
        ///       principalId: RoleAssignmentDetailsPrincipalId,
        ///       scope: string,
        ///       principalType: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response ListRoleAssignments(RequestOptions options, string roleId = null, string principalId = null, string scope = null, string continuationToken = null)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.ListRoleAssignments");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateListRoleAssignmentsRequest(roleId, principalId, scope, continuationToken);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Create role assignment. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> or <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   roleId: RoleAssignmentRequestRoleId (required),
        ///   principalId: RoleAssignmentRequestPrincipalId (required),
        ///   scope: string (required),
        ///   principalType: string
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   roleDefinitionId: RoleAssignmentDetailsRoleDefinitionId,
        ///   principalId: RoleAssignmentDetailsPrincipalId,
        ///   scope: string,
        ///   principalType: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateRoleAssignmentAsync(string roleAssignmentId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.CreateRoleAssignment");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateCreateRoleAssignmentRequest(roleAssignmentId, content);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Create role assignment. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> or <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   roleId: RoleAssignmentRequestRoleId (required),
        ///   principalId: RoleAssignmentRequestPrincipalId (required),
        ///   scope: string (required),
        ///   principalType: string
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   roleDefinitionId: RoleAssignmentDetailsRoleDefinitionId,
        ///   principalId: RoleAssignmentDetailsPrincipalId,
        ///   scope: string,
        ///   principalType: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response CreateRoleAssignment(string roleAssignmentId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.CreateRoleAssignment");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateCreateRoleAssignmentRequest(roleAssignmentId, content);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Get role assignment by role assignment Id. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   roleDefinitionId: RoleAssignmentDetailsRoleDefinitionId,
        ///   principalId: RoleAssignmentDetailsPrincipalId,
        ///   scope: string,
        ///   principalType: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetRoleAssignmentByIdAsync(string roleAssignmentId, RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.GetRoleAssignmentById");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetRoleAssignmentByIdRequest(roleAssignmentId);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Get role assignment by role assignment Id. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   roleDefinitionId: RoleAssignmentDetailsRoleDefinitionId,
        ///   principalId: RoleAssignmentDetailsPrincipalId,
        ///   scope: string,
        ///   principalType: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetRoleAssignmentById(string roleAssignmentId, RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.GetRoleAssignmentById");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetRoleAssignmentByIdRequest(roleAssignmentId);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Delete role assignment by role assignment Id. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteRoleAssignmentByIdAsync(string roleAssignmentId, string scope = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.DeleteRoleAssignmentById");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateDeleteRoleAssignmentByIdRequest(roleAssignmentId, scope);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Delete role assignment by role assignment Id. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response DeleteRoleAssignmentById(string roleAssignmentId, string scope = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.DeleteRoleAssignmentById");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateDeleteRoleAssignmentByIdRequest(roleAssignmentId, scope);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCheckPrincipalAccessRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/checkAccessSynapseRbac", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateListRoleAssignmentsRequest(string roleId, string principalId, string scope, string continuationToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/roleAssignments", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (roleId != null)
            {
                uri.AppendQuery("roleId", roleId, true);
            }
            if (principalId != null)
            {
                uri.AppendQuery("principalId", principalId, true);
            }
            if (scope != null)
            {
                uri.AppendQuery("scope", scope, true);
            }
            request.Uri = uri;
            if (continuationToken != null)
            {
                request.Headers.Add("x-ms-continuation", continuationToken);
            }
            request.Headers.Add("Accept", "application/json, text/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateRoleAssignmentRequest(string roleAssignmentId, RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/roleAssignments/", false);
            uri.AppendPath(roleAssignmentId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetRoleAssignmentByIdRequest(string roleAssignmentId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/roleAssignments/", false);
            uri.AppendPath(roleAssignmentId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateDeleteRoleAssignmentByIdRequest(string roleAssignmentId, string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/roleAssignments/", false);
            uri.AppendPath(roleAssignmentId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (scope != null)
            {
                uri.AppendQuery("scope", scope, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            message.ResponseClassifier = ResponseClassifier200204.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier200204 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200204();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    204 => false,
                    _ => true
                };
            }
        }
    }
}
