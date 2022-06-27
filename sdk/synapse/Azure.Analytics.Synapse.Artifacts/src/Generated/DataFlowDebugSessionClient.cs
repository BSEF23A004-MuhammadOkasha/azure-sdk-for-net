// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The DataFlowDebugSession service client. </summary>
    public partial class DataFlowDebugSessionClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DataFlowDebugSessionRestClient RestClient { get; }

        public Uri Endpoint { get; }

        /// <summary> Initializes a new instance of DataFlowDebugSessionClient for mocking. </summary>
        protected DataFlowDebugSessionClient()
        {
        }

        /// <summary> Initializes a new instance of DataFlowDebugSessionClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public DataFlowDebugSessionClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new DataFlowDebugSessionRestClient(_clientDiagnostics, _pipeline, endpoint); Endpoint = endpoint;
        }

        /// <summary> Initializes a new instance of DataFlowDebugSessionClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal DataFlowDebugSessionClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new DataFlowDebugSessionRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            Endpoint = endpoint;
        }

        /// <summary> Add a data flow into debug session. </summary>
        /// <param name="request"> Data flow debug session definition with debug content. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AddDataFlowToDebugSessionResponse>> AddDataFlowAsync(DataFlowDebugPackage request, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.AddDataFlow");
            scope.Start();
            try
            {
                return await RestClient.AddDataFlowAsync(request, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a data flow into debug session. </summary>
        /// <param name="request"> Data flow debug session definition with debug content. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AddDataFlowToDebugSessionResponse> AddDataFlow(DataFlowDebugPackage request, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.AddDataFlow");
            scope.Start();
            try
            {
                return RestClient.AddDataFlow(request, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a data flow debug session. </summary>
        /// <param name="request"> Data flow debug session definition for deletion. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteDataFlowDebugSessionAsync(DeleteDataFlowDebugSessionRequest request, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.DeleteDataFlowDebugSession");
            scope.Start();
            try
            {
                return await RestClient.DeleteDataFlowDebugSessionAsync(request, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a data flow debug session. </summary>
        /// <param name="request"> Data flow debug session definition for deletion. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteDataFlowDebugSession(DeleteDataFlowDebugSessionRequest request, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.DeleteDataFlowDebugSession");
            scope.Start();
            try
            {
                return RestClient.DeleteDataFlowDebugSession(request, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query all active data flow debug sessions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DataFlowDebugSessionInfo> QueryDataFlowDebugSessionsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataFlowDebugSessionInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.QueryDataFlowDebugSessionsByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.QueryDataFlowDebugSessionsByWorkspaceAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataFlowDebugSessionInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.QueryDataFlowDebugSessionsByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.QueryDataFlowDebugSessionsByWorkspaceNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Query all active data flow debug sessions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DataFlowDebugSessionInfo> QueryDataFlowDebugSessionsByWorkspace(CancellationToken cancellationToken = default)
        {
            Page<DataFlowDebugSessionInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.QueryDataFlowDebugSessionsByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.QueryDataFlowDebugSessionsByWorkspace(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataFlowDebugSessionInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.QueryDataFlowDebugSessionsByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.QueryDataFlowDebugSessionsByWorkspaceNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates a data flow debug session. </summary>
        /// <param name="request"> Data flow debug session definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public virtual async Task<DataFlowDebugSessionCreateDataFlowDebugSessionOperation> StartCreateDataFlowDebugSessionAsync(CreateDataFlowDebugSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.StartCreateDataFlowDebugSession");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateDataFlowDebugSessionAsync(request, cancellationToken).ConfigureAwait(false);
                return new DataFlowDebugSessionCreateDataFlowDebugSessionOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateDataFlowDebugSessionRequest(request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a data flow debug session. </summary>
        /// <param name="request"> Data flow debug session definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public virtual DataFlowDebugSessionCreateDataFlowDebugSessionOperation StartCreateDataFlowDebugSession(CreateDataFlowDebugSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.StartCreateDataFlowDebugSession");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateDataFlowDebugSession(request, cancellationToken);
                return new DataFlowDebugSessionCreateDataFlowDebugSessionOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateDataFlowDebugSessionRequest(request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Execute a data flow debug command. </summary>
        /// <param name="request"> Data flow debug command definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public virtual async Task<DataFlowDebugSessionExecuteCommandOperation> StartExecuteCommandAsync(DataFlowDebugCommandRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.StartExecuteCommand");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ExecuteCommandAsync(request, cancellationToken).ConfigureAwait(false);
                return new DataFlowDebugSessionExecuteCommandOperation(_clientDiagnostics, _pipeline, RestClient.CreateExecuteCommandRequest(request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Execute a data flow debug command. </summary>
        /// <param name="request"> Data flow debug command definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public virtual DataFlowDebugSessionExecuteCommandOperation StartExecuteCommand(DataFlowDebugCommandRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("DataFlowDebugSessionClient.StartExecuteCommand");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ExecuteCommand(request, cancellationToken);
                return new DataFlowDebugSessionExecuteCommandOperation(_clientDiagnostics, _pipeline, RestClient.CreateExecuteCommandRequest(request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
