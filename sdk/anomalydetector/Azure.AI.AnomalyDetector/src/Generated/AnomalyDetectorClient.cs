// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.AnomalyDetector.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> The AnomalyDetector service client. </summary>
    public partial class AnomalyDetectorClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AnomalyDetectorRestClient RestClient { get; }

        /// <summary> Initializes a new instance of AnomalyDetectorClient for mocking. </summary>
        protected AnomalyDetectorClient()
        {
        }

        /// <summary> Initializes a new instance of AnomalyDetectorClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="apiVersion"> Anomaly Detector API version (for example, v1.0). </param>
        /// <param name="options"> The options for configuring the client. </param>
        public AnomalyDetectorClient(Uri endpoint, TokenCredential credential, ApiVersion? apiVersion = default, AnomalyDetectorClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            apiVersion ??= ApiVersion.V11Preview1;

            options ??= new AnomalyDetectorClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://cognitiveservices.azure.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new AnomalyDetectorRestClient(_clientDiagnostics, _pipeline, endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of AnomalyDetectorClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="apiVersion"> Anomaly Detector API version (for example, v1.0). </param>
        /// <param name="options"> The options for configuring the client. </param>
        public AnomalyDetectorClient(Uri endpoint, AzureKeyCredential credential, ApiVersion? apiVersion = default, AnomalyDetectorClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            apiVersion ??= ApiVersion.V11Preview1;

            options ??= new AnomalyDetectorClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "Ocp-Apim-Subscription-Key"));
            RestClient = new AnomalyDetectorRestClient(_clientDiagnostics, _pipeline, endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of AnomalyDetectorClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="apiVersion"> Anomaly Detector API version (for example, v1.0). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal AnomalyDetectorClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, ApiVersion? apiVersion = default)
        {
            RestClient = new AnomalyDetectorRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> This operation generates a model with an entire series, each point is detected with the same model. With this method, points before and after a certain point are used to determine whether it is an anomaly. The entire detection can give user an overall status of the time series. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EntireDetectResponse>> DetectEntireSeriesAsync(DetectRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.DetectEntireSeries");
            scope.Start();
            try
            {
                return await RestClient.DetectEntireSeriesAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation generates a model with an entire series, each point is detected with the same model. With this method, points before and after a certain point are used to determine whether it is an anomaly. The entire detection can give user an overall status of the time series. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EntireDetectResponse> DetectEntireSeries(DetectRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.DetectEntireSeries");
            scope.Start();
            try
            {
                return RestClient.DetectEntireSeries(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation generates a model using points before the latest one. With this method, only historical points are used to determine whether the target point is an anomaly. The latest point detecting operation matches the scenario of real-time monitoring of business metrics. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LastDetectResponse>> DetectLastPointAsync(DetectRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.DetectLastPoint");
            scope.Start();
            try
            {
                return await RestClient.DetectLastPointAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation generates a model using points before the latest one. With this method, only historical points are used to determine whether the target point is an anomaly. The latest point detecting operation matches the scenario of real-time monitoring of business metrics. </summary>
        /// <param name="body"> Time series points and period if needed. Advanced model parameters can also be set in the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LastDetectResponse> DetectLastPoint(DetectRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.DetectLastPoint");
            scope.Start();
            try
            {
                return RestClient.DetectLastPoint(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Evaluate change point score of every series point. </summary>
        /// <param name="body"> Time series points and granularity is needed. Advanced model parameters can also be set in the request if needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ChangePointDetectResponse>> DetectChangePointAsync(ChangePointDetectRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.DetectChangePoint");
            scope.Start();
            try
            {
                return await RestClient.DetectChangePointAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Evaluate change point score of every series point. </summary>
        /// <param name="body"> Time series points and granularity is needed. Advanced model parameters can also be set in the request if needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ChangePointDetectResponse> DetectChangePoint(ChangePointDetectRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.DetectChangePoint");
            scope.Start();
            try
            {
                return RestClient.DetectChangePoint(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create and train a multivariate anomaly detection model. The request must include a source parameter to indicate an externally accessible Azure storage Uri (preferably a Shared Access Signature Uri). All time-series used in generate the model must be zipped into one single file. Each time-series will be in a single CSV file in which the first column is timestamp and the second column is value. </summary>
        /// <param name="body"> Training request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> TrainMultivariateModelAsync(ModelInfo body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.TrainMultivariateModel");
            scope.Start();
            try
            {
                return (await RestClient.TrainMultivariateModelAsync(body, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create and train a multivariate anomaly detection model. The request must include a source parameter to indicate an externally accessible Azure storage Uri (preferably a Shared Access Signature Uri). All time-series used in generate the model must be zipped into one single file. Each time-series will be in a single CSV file in which the first column is timestamp and the second column is value. </summary>
        /// <param name="body"> Training request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response TrainMultivariateModel(ModelInfo body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.TrainMultivariateModel");
            scope.Start();
            try
            {
                return RestClient.TrainMultivariateModel(body, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get detailed information of multivariate model, including the training status and variables used in the model. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Model>> GetMultivariateModelAsync(Guid modelId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.GetMultivariateModel");
            scope.Start();
            try
            {
                return await RestClient.GetMultivariateModelAsync(modelId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get detailed information of multivariate model, including the training status and variables used in the model. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Model> GetMultivariateModel(Guid modelId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.GetMultivariateModel");
            scope.Start();
            try
            {
                return RestClient.GetMultivariateModel(modelId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an existing multivariate model according to the modelId. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteMultivariateModelAsync(Guid modelId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.DeleteMultivariateModel");
            scope.Start();
            try
            {
                return await RestClient.DeleteMultivariateModelAsync(modelId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an existing multivariate model according to the modelId. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteMultivariateModel(Guid modelId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.DeleteMultivariateModel");
            scope.Start();
            try
            {
                return RestClient.DeleteMultivariateModel(modelId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit detection multivariate anomaly task with the trained model of modelId, the input schema should be the same with the training request. Thus request will be complete asynchronously and will return a resultId for querying the detection result.The request should be a source link to indicate an externally accessible Azure storage Uri (preferably a Shared Access Signature Uri). All time-series used in generate the model must be zipped into one single file. Each time-series will be as follows: the first column is timestamp and the second column is value. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="body"> Detect anomaly request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DetectAnomalyAsync(Guid modelId, DetectionRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.DetectAnomaly");
            scope.Start();
            try
            {
                return (await RestClient.DetectAnomalyAsync(modelId, body, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit detection multivariate anomaly task with the trained model of modelId, the input schema should be the same with the training request. Thus request will be complete asynchronously and will return a resultId for querying the detection result.The request should be a source link to indicate an externally accessible Azure storage Uri (preferably a Shared Access Signature Uri). All time-series used in generate the model must be zipped into one single file. Each time-series will be as follows: the first column is timestamp and the second column is value. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="body"> Detect anomaly request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DetectAnomaly(Guid modelId, DetectionRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.DetectAnomaly");
            scope.Start();
            try
            {
                return RestClient.DetectAnomaly(modelId, body, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get multivariate anomaly detection result based on resultId returned by the DetectAnomalyAsync api. </summary>
        /// <param name="resultId"> Result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DetectionResult>> GetDetectionResultAsync(Guid resultId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.GetDetectionResult");
            scope.Start();
            try
            {
                return await RestClient.GetDetectionResultAsync(resultId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get multivariate anomaly detection result based on resultId returned by the DetectAnomalyAsync api. </summary>
        /// <param name="resultId"> Result identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DetectionResult> GetDetectionResult(Guid resultId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.GetDetectionResult");
            scope.Start();
            try
            {
                return RestClient.GetDetectionResult(resultId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Export multivariate anomaly detection model based on modelId. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Stream>> ExportModelAsync(Guid modelId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.ExportModel");
            scope.Start();
            try
            {
                return await RestClient.ExportModelAsync(modelId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Export multivariate anomaly detection model based on modelId. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Stream> ExportModel(Guid modelId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.ExportModel");
            scope.Start();
            try
            {
                return RestClient.ExportModel(modelId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Synchronized API for anomaly detection. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="body"> Request for last detection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LastDetectionResult>> LastDetectAnomalyAsync(Guid modelId, LastDetectionRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.LastDetectAnomaly");
            scope.Start();
            try
            {
                return await RestClient.LastDetectAnomalyAsync(modelId, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Synchronized API for anomaly detection. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="body"> Request for last detection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LastDetectionResult> LastDetectAnomaly(Guid modelId, LastDetectionRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.LastDetectAnomaly");
            scope.Start();
            try
            {
                return RestClient.LastDetectAnomaly(modelId, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List models of a subscription. </summary>
        /// <param name="skip"> $skip indicates how many models will be skipped. </param>
        /// <param name="top"> $top indicates how many models will be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ModelSnapshot> ListMultivariateModelAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ModelSnapshot>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.ListMultivariateModel");
                scope.Start();
                try
                {
                    var response = await RestClient.ListMultivariateModelAsync(skip, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Models, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ModelSnapshot>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.ListMultivariateModel");
                scope.Start();
                try
                {
                    var response = await RestClient.ListMultivariateModelNextPageAsync(nextLink, skip, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Models, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List models of a subscription. </summary>
        /// <param name="skip"> $skip indicates how many models will be skipped. </param>
        /// <param name="top"> $top indicates how many models will be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ModelSnapshot> ListMultivariateModel(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ModelSnapshot> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.ListMultivariateModel");
                scope.Start();
                try
                {
                    var response = RestClient.ListMultivariateModel(skip, top, cancellationToken);
                    return Page.FromValues(response.Value.Models, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ModelSnapshot> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnomalyDetectorClient.ListMultivariateModel");
                scope.Start();
                try
                {
                    var response = RestClient.ListMultivariateModelNextPage(nextLink, skip, top, cancellationToken);
                    return Page.FromValues(response.Value.Models, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
