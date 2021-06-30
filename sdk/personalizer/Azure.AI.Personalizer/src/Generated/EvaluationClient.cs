// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Personalizer.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Personalizer
{
    /// <summary> The Evaluation service client. </summary>
    public partial class EvaluationClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal EvaluationRestClient RestClient { get; }

        /// <summary> Initializes a new instance of EvaluationClient for mocking. </summary>
        protected EvaluationClient()
        {
        }

        /// <summary> Initializes a new instance of EvaluationClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public EvaluationClient(string endpoint, TokenCredential credential, PersonalizerBaseClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PersonalizerBaseClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://cognitiveservices.azure.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new EvaluationRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of EvaluationClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public EvaluationClient(string endpoint, AzureKeyCredential credential, PersonalizerBaseClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PersonalizerBaseClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "Ocp-Apim-Subscription-Key"));
            RestClient = new EvaluationRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of EvaluationClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        internal EvaluationClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            RestClient = new EvaluationRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Apply Learning Settings and model from a pre-existing Offline Evaluation, making them the current online Learning Settings and model and replacing the previous ones. </summary>
        /// <param name="body"> The PolicyReferenceContract to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ApplyAsync(PolicyReferenceContract body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EvaluationClient.Apply");
            scope.Start();
            try
            {
                return await RestClient.ApplyAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Apply Learning Settings and model from a pre-existing Offline Evaluation, making them the current online Learning Settings and model and replacing the previous ones. </summary>
        /// <param name="body"> The PolicyReferenceContract to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Apply(PolicyReferenceContract body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EvaluationClient.Apply");
            scope.Start();
            try
            {
                return RestClient.Apply(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
