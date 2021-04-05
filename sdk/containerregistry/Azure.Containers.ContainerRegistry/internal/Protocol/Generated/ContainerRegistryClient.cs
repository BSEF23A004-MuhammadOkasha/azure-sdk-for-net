// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

#pragma warning disable AZC0007

namespace Azure.Containers.ContainerRegistry.Protocol
{
    /// <summary> The ContainerRegistry service client. </summary>
    public partial class ContainerRegistryClient
    {
        /// <summary>
        /// </summary>
        protected HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://management.core.windows.net/.default" };
        private string url;

        /// <summary> Initializes a new instance of ContainerRegistryClient for mocking. </summary>
        protected ContainerRegistryClient()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryClient. </summary>
        /// <param name="url"> Registry login URL. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        internal ContainerRegistryClient(string url, TokenCredential credential, ContainerRegistryProtocolClientOptions options = null)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ContainerRegistryProtocolClientOptions();
            Pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, AuthorizationScopes));
            this.url = url;
        }

        /// <summary> Tells whether this Docker Registry instance supports Docker Registry HTTP API v2. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckDockerV2SupportAsync(RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateCheckDockerV2SupportRequest(requestBody);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Tells whether this Docker Registry instance supports Docker Registry HTTP API v2. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckDockerV2Support(RequestContent requestBody, CancellationToken cancellationToken = default)
        {
            Request req = CreateCheckDockerV2SupportRequest(requestBody);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="CheckDockerV2Support"/> and <see cref="CheckDockerV2SupportAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        protected Request CreateCheckDockerV2SupportRequest(RequestContent requestBody)
        {
            var request = Pipeline.CreateRequest();
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/v2/", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Content = requestBody;
            return request;
        }
        /// <summary> List repositories. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="last"> Query parameter for the last item in previous query. Result set will include values lexically after last. </param>
        /// <param name="n"> query parameter for max number of items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetRepositoriesAsync(RequestContent requestBody, string last = null, int? n = null, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetRepositoriesRequest(requestBody, last, n);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> List repositories. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="last"> Query parameter for the last item in previous query. Result set will include values lexically after last. </param>
        /// <param name="n"> query parameter for max number of items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetRepositories(RequestContent requestBody, string last = null, int? n = null, CancellationToken cancellationToken = default)
        {
            Request req = CreateGetRepositoriesRequest(requestBody, last, n);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="GetRepositories"/> and <see cref="GetRepositoriesAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="last"> Query parameter for the last item in previous query. Result set will include values lexically after last. </param>
        /// <param name="n"> query parameter for max number of items. </param>
        protected Request CreateGetRepositoriesRequest(RequestContent requestBody, string last = null, int? n = null)
        {
            var request = Pipeline.CreateRequest();
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/acr/v1/_catalog", false);
            if (last != null)
            {
                uri.AppendQuery("last", last, true);
            }
            if (n != null)
            {
                uri.AppendQuery("n", n.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Content = requestBody;
            return request;
        }
        /// <summary> Delete the repository identified by `name`. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteRepositoryAsync(RequestContent requestBody, string name, CancellationToken cancellationToken = default)
        {
            Request req = CreateDeleteRepositoryRequest(requestBody, name);
            return await Pipeline.SendRequestAsync(req, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Delete the repository identified by `name`. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteRepository(RequestContent requestBody, string name, CancellationToken cancellationToken = default)
        {
            Request req = CreateDeleteRepositoryRequest(requestBody, name);
            return Pipeline.SendRequest(req, cancellationToken);
        }

        /// <summary> Create Request for <see cref="DeleteRepository"/> and <see cref="DeleteRepositoryAsync"/> operations. </summary>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="name"> Name of the image (including the namespace). </param>
        protected Request CreateDeleteRepositoryRequest(RequestContent requestBody, string name)
        {
            var request = Pipeline.CreateRequest();
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/acr/v1/", false);
            uri.AppendPath(name, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Content = requestBody;
            return request;
        }
    }
}
