// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Spark.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Spark
{
    /// <summary> The SparkBatch service client. </summary>
    public partial class SparkBatchClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SparkBatchRestClient RestClient { get; }

        public Uri Endpoint { get; }

        /// <summary> Initializes a new instance of SparkBatchClient for mocking. </summary>
        protected SparkBatchClient()
        {
        }

        /// <summary> Initializes a new instance of SparkBatchClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="sparkPoolName"> Name of the spark pool. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="livyApiVersion"> Valid api-version for the request. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public SparkBatchClient(Uri endpoint, string sparkPoolName, TokenCredential credential, string livyApiVersion = "2019-11-01-preview", SparkClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (sparkPoolName == null)
            {
                throw new ArgumentNullException(nameof(sparkPoolName));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            if (livyApiVersion == null)
            {
                throw new ArgumentNullException(nameof(livyApiVersion));
            }

            options ??= new SparkClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new SparkBatchRestClient(_clientDiagnostics, _pipeline, endpoint, sparkPoolName, livyApiVersion); Endpoint = endpoint;
        }

        /// <summary> Initializes a new instance of SparkBatchClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="sparkPoolName"> Name of the spark pool. </param>
        /// <param name="livyApiVersion"> Valid api-version for the request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/>, <paramref name="sparkPoolName"/> or <paramref name="livyApiVersion"/> is null. </exception>
        internal SparkBatchClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string sparkPoolName, string livyApiVersion = "2019-11-01-preview")
        {
            RestClient = new SparkBatchRestClient(clientDiagnostics, pipeline, endpoint, sparkPoolName, livyApiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            Endpoint = endpoint;
        }

        /// <summary> List all spark batch jobs which are running under a particular spark pool. </summary>
        /// <param name="from"> Optional param specifying which index the list should begin from. </param>
        /// <param name="size">
        /// Optional param specifying the size of the returned list.
        ///             By default it is 20 and that is the maximum.
        /// </param>
        /// <param name="detailed"> Optional query param specifying whether detailed response is returned beyond plain livy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SparkBatchJobCollection>> GetSparkBatchJobsAsync(int? @from = null, int? size = null, bool? detailed = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SparkBatchClient.GetSparkBatchJobs");
            scope.Start();
            try
            {
                return await RestClient.GetSparkBatchJobsAsync(@from, size, detailed, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all spark batch jobs which are running under a particular spark pool. </summary>
        /// <param name="from"> Optional param specifying which index the list should begin from. </param>
        /// <param name="size">
        /// Optional param specifying the size of the returned list.
        ///             By default it is 20 and that is the maximum.
        /// </param>
        /// <param name="detailed"> Optional query param specifying whether detailed response is returned beyond plain livy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SparkBatchJobCollection> GetSparkBatchJobs(int? @from = null, int? size = null, bool? detailed = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SparkBatchClient.GetSparkBatchJobs");
            scope.Start();
            try
            {
                return RestClient.GetSparkBatchJobs(@from, size, detailed, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a single spark batch job. </summary>
        /// <param name="batchId"> Identifier for the batch job. </param>
        /// <param name="detailed"> Optional query param specifying whether detailed response is returned beyond plain livy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SparkBatchJob>> GetSparkBatchJobAsync(int batchId, bool? detailed = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SparkBatchClient.GetSparkBatchJob");
            scope.Start();
            try
            {
                return await RestClient.GetSparkBatchJobAsync(batchId, detailed, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a single spark batch job. </summary>
        /// <param name="batchId"> Identifier for the batch job. </param>
        /// <param name="detailed"> Optional query param specifying whether detailed response is returned beyond plain livy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SparkBatchJob> GetSparkBatchJob(int batchId, bool? detailed = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SparkBatchClient.GetSparkBatchJob");
            scope.Start();
            try
            {
                return RestClient.GetSparkBatchJob(batchId, detailed, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels a running spark batch job. </summary>
        /// <param name="batchId"> Identifier for the batch job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelSparkBatchJobAsync(int batchId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SparkBatchClient.CancelSparkBatchJob");
            scope.Start();
            try
            {
                return await RestClient.CancelSparkBatchJobAsync(batchId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels a running spark batch job. </summary>
        /// <param name="batchId"> Identifier for the batch job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CancelSparkBatchJob(int batchId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SparkBatchClient.CancelSparkBatchJob");
            scope.Start();
            try
            {
                return RestClient.CancelSparkBatchJob(batchId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
