// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry
    {
        /// <summary> The ContainerRegistry service client. </summary>
        public partial class ContainerRegistryClient
        {
            private readonly ClientDiagnostics _clientDiagnostics;
            private readonly HttpPipeline _pipeline;
            internal ContainerRegistryRestClient RestClient { get; }

            /// <summary>
            /// Initializes a new instance of the <see cref="ContainerRegistryClient"/>.
            /// </summary>
            public ContainerRegistryClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new ContainerRegistryClientOptions())
            {
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="ContainerRegistryClient"/>.
            /// </summary>
            public ContainerRegistryClient(Uri endpoint, TokenCredential credential, ContainerRegistryClientOptions options)
            {
            }

            /// <summary> Initializes a new instance of ContainerRegistryClient for mocking. </summary>
            protected ContainerRegistryClient()
            {
            }

            /// <summary> Initializes a new instance of ContainerRegistryClient. </summary>
            /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
            /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
            /// <param name="url"> Registry login URL. </param>
            internal ContainerRegistryClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
            {
                RestClient = new ContainerRegistryRestClient(clientDiagnostics, pipeline, url);
                _clientDiagnostics = clientDiagnostics;
                _pipeline = pipeline;
            }

            /// <summary> Tells whether this Docker Registry instance supports Docker Registry HTTP API v2. </summary>
            /// <param name="cancellationToken"> The cancellation token to use. </param>
            public virtual async Task<Response> CheckDockerV2SupportAsync(CancellationToken cancellationToken = default)
            {
                using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.CheckDockerV2Support");
                scope.Start();
                try
                {
                    return await RestClient.CheckDockerV2SupportAsync(cancellationToken).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            /// <summary> Tells whether this Docker Registry instance supports Docker Registry HTTP API v2. </summary>
            /// <param name="cancellationToken"> The cancellation token to use. </param>
            public virtual Response CheckDockerV2Support(CancellationToken cancellationToken = default)
            {
                using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.CheckDockerV2Support");
                scope.Start();
                try
                {
                    return RestClient.CheckDockerV2Support(cancellationToken);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            /// <summary> List repositories. </summary>
            /// <param name="last"> Query parameter for the last item in previous query. Result set will include values lexically after last. </param>
            /// <param name="n"> query parameter for max number of items. </param>
            /// <param name="cancellationToken"> The cancellation token to use. </param>
            public virtual async Task<Response<Repositories>> GetRepositoriesAsync(string last = null, int? n = null, CancellationToken cancellationToken = default)
            {
                using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.GetRepositories");
                scope.Start();
                try
                {
                    return await RestClient.GetRepositoriesAsync(last, n, cancellationToken).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            /// <summary> List repositories. </summary>
            /// <param name="last"> Query parameter for the last item in previous query. Result set will include values lexically after last. </param>
            /// <param name="n"> query parameter for max number of items. </param>
            /// <param name="cancellationToken"> The cancellation token to use. </param>
            public virtual Response<Repositories> GetRepositories(string last = null, int? n = null, CancellationToken cancellationToken = default)
            {
                using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.GetRepositories");
                scope.Start();
                try
                {
                    return RestClient.GetRepositories(last, n, cancellationToken);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            /// <summary> Get repository attributes. </summary>
            /// <param name="name"> Name of the image (including the namespace). </param>
            /// <param name="cancellationToken"> The cancellation token to use. </param>
            public virtual async Task<Response<RepositoryAttributes>> GetRepositoryAttributesAsync(string name, CancellationToken cancellationToken = default)
            {
                using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.GetRepositoryAttributes");
                scope.Start();
                try
                {
                    return await RestClient.GetRepositoryAttributesAsync(name, cancellationToken).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            /// <summary> Get repository attributes. </summary>
            /// <param name="name"> Name of the image (including the namespace). </param>
            /// <param name="cancellationToken"> The cancellation token to use. </param>
            public virtual Response<RepositoryAttributes> GetRepositoryAttributes(string name, CancellationToken cancellationToken = default)
            {
                using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.GetRepositoryAttributes");
                scope.Start();
                try
                {
                    return RestClient.GetRepositoryAttributes(name, cancellationToken);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            /// <summary> Delete the repository identified by `name`. </summary>
            /// <param name="name"> Name of the image (including the namespace). </param>
            /// <param name="cancellationToken"> The cancellation token to use. </param>
            public virtual async Task<Response<DeletedRepository>> DeleteRepositoryAsync(string name, CancellationToken cancellationToken = default)
            {
                using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.DeleteRepository");
                scope.Start();
                try
                {
                    return await RestClient.DeleteRepositoryAsync(name, cancellationToken).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            /// <summary> Delete the repository identified by `name`. </summary>
            /// <param name="name"> Name of the image (including the namespace). </param>
            /// <param name="cancellationToken"> The cancellation token to use. </param>
            public virtual Response<DeletedRepository> DeleteRepository(string name, CancellationToken cancellationToken = default)
            {
                using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.DeleteRepository");
                scope.Start();
                try
                {
                    return RestClient.DeleteRepository(name, cancellationToken);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            /// <summary> Update the attribute identified by `name` where `reference` is the name of the repository. </summary>
            /// <param name="name"> Name of the image (including the namespace). </param>
            /// <param name="value"> Repository attribute value. </param>
            /// <param name="cancellationToken"> The cancellation token to use. </param>
            public virtual async Task<Response> UpdateRepositoryAttributesAsync(string name, ChangeableAttributes value = null, CancellationToken cancellationToken = default)
            {
                using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.UpdateRepositoryAttributes");
                scope.Start();
                try
                {
                    return await RestClient.UpdateRepositoryAttributesAsync(name, value, cancellationToken).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            /// <summary> Update the attribute identified by `name` where `reference` is the name of the repository. </summary>
            /// <param name="name"> Name of the image (including the namespace). </param>
            /// <param name="value"> Repository attribute value. </param>
            /// <param name="cancellationToken"> The cancellation token to use. </param>
            public virtual Response UpdateRepositoryAttributes(string name, ChangeableAttributes value = null, CancellationToken cancellationToken = default)
            {
                using var scope = _clientDiagnostics.CreateScope("ContainerRegistryClient.UpdateRepositoryAttributes");
                scope.Start();
                try
                {
                    return RestClient.UpdateRepositoryAttributes(name, value, cancellationToken);
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
        }
    }
