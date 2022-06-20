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
    /// <summary> The Template service client. </summary>
    public partial class TemplateClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://vault.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly string _vaultBaseUrl;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of TemplateClient for mocking. </summary>
        protected TemplateClient()
        {
        }

        /// <summary> Initializes a new instance of TemplateClient. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="credential"/> is null. </exception>
        public TemplateClient(string vaultBaseUrl, TokenCredential credential) : this(vaultBaseUrl, credential, new TemplateClientOptions())
        {
        }

        /// <summary> Initializes a new instance of TemplateClient. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="credential"/> is null. </exception>
        public TemplateClient(string vaultBaseUrl, TokenCredential credential, TemplateClientOptions options)
        {
            Argument.AssertNotNull(vaultBaseUrl, nameof(vaultBaseUrl));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new TemplateClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _vaultBaseUrl = vaultBaseUrl;
            _apiVersion = options.Version;
        }

        /// <summary> The GET operation is applicable to any secret stored in Azure Key Vault. This operation requires the secrets/get permission. </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Response"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: string,
        ///   id: string,
        ///   contentType: string,
        ///   tags: Dictionary&lt;string, string&gt;,
        ///   kid: string,
        ///   managed: boolean
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetSecretAsync(string secretName, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = ClientDiagnostics.CreateScope("TemplateClient.GetSecret");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSecretRequest(secretName, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The GET operation is applicable to any secret stored in Azure Key Vault. This operation requires the secrets/get permission. </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns cref="Response"> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: string,
        ///   id: string,
        ///   contentType: string,
        ///   tags: Dictionary&lt;string, string&gt;,
        ///   kid: string,
        ///   managed: boolean
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetSecret(string secretName, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = ClientDiagnostics.CreateScope("TemplateClient.GetSecret");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSecretRequest(secretName, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetSecretRequest(string secretName, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_vaultBaseUrl, false);
            uri.AppendPath("/secrets/", false);
            uri.AppendPath(secretName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
