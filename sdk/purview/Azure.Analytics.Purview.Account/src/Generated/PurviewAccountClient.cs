// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Account
{
    /// <summary> The PurviewAccount service client. </summary>
    public partial class PurviewAccountClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of PurviewAccountClient for mocking. </summary>
        protected PurviewAccountClient()
        {
        }

        /// <summary> Initializes a new instance of PurviewAccountClient. </summary>
        /// <param name="endpoint"> The account endpoint of your Purview account. Example: https://{accountName}.purview.azure.com/account/. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PurviewAccountClient(Uri endpoint, TokenCredential credential, PurviewAccountClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PurviewAccountClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Get an account. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetAccountPropertiesAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetAccountPropertiesRequest(options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.GetAccountProperties");
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

        /// <summary> Get an account. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetAccountProperties(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetAccountPropertiesRequest(options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.GetAccountProperties");
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

        /// <summary> Create Request for <see cref="GetAccountProperties"/> and <see cref="GetAccountPropertiesAsync"/> operations. </summary>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetAccountPropertiesRequest(RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Updates an account. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>friendlyName</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The friendly name for the azure resource.</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> UpdateAccountPropertiesAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateUpdateAccountPropertiesRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.UpdateAccountProperties");
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

        /// <summary> Updates an account. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>friendlyName</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>The friendly name for the azure resource.</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response UpdateAccountProperties(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateUpdateAccountPropertiesRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.UpdateAccountProperties");
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

        /// <summary> Create Request for <see cref="UpdateAccountProperties"/> and <see cref="UpdateAccountPropertiesAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateUpdateAccountPropertiesRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> List the authorization keys associated with this account. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetAccessKeysAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetAccessKeysRequest(options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.GetAccessKeys");
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

        /// <summary> List the authorization keys associated with this account. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetAccessKeys(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetAccessKeysRequest(options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.GetAccessKeys");
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

        /// <summary> Create Request for <see cref="GetAccessKeys"/> and <see cref="GetAccessKeysAsync"/> operations. </summary>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetAccessKeysRequest(RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/listkeys", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Regenerate the authorization keys associated with this data catalog. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>keyType</term>
        ///     <term>&quot;PrimaryAtlasKafkaKey&quot; | &quot;SecondaryAtlasKafkaKey&quot;</term>
        ///     <term></term>
        ///     <term>The access key type.</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> RegenerateAccessKeyAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateRegenerateAccessKeyRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.RegenerateAccessKey");
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

        /// <summary> Regenerate the authorization keys associated with this data catalog. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>keyType</term>
        ///     <term>&quot;PrimaryAtlasKafkaKey&quot; | &quot;SecondaryAtlasKafkaKey&quot;</term>
        ///     <term></term>
        ///     <term>The access key type.</term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response RegenerateAccessKey(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateRegenerateAccessKeyRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.RegenerateAccessKey");
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

        /// <summary> Create Request for <see cref="RegenerateAccessKey"/> and <see cref="RegenerateAccessKeyAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateRegenerateAccessKeyRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/regeneratekeys", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> List the collections in the account. </summary>
        /// <param name="skipToken"> The String to use. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetCollectionsAsync(string skipToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetCollectionsRequest(skipToken, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.GetCollections");
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

        /// <summary> List the collections in the account. </summary>
        /// <param name="skipToken"> The String to use. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetCollections(string skipToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetCollectionsRequest(skipToken, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.GetCollections");
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

        /// <summary> Create Request for <see cref="GetCollections"/> and <see cref="GetCollectionsAsync"/> operations. </summary>
        /// <param name="skipToken"> The String to use. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetCollectionsRequest(string skipToken = null, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/collections", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get a resource set config service model. </summary>
        /// <param name="skipToken"> The String to use. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetResourceSetRulesAsync(string skipToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetResourceSetRulesRequest(skipToken, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.GetResourceSetRules");
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

        /// <summary> Get a resource set config service model. </summary>
        /// <param name="skipToken"> The String to use. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetResourceSetRules(string skipToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetResourceSetRulesRequest(skipToken, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountClient.GetResourceSetRules");
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

        /// <summary> Create Request for <see cref="GetResourceSetRules"/> and <see cref="GetResourceSetRulesAsync"/> operations. </summary>
        /// <param name="skipToken"> The String to use. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetResourceSetRulesRequest(string skipToken = null, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/resourceSetRuleConfigs", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
