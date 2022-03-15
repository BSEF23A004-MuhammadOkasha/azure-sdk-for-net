// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Batch inference settings per deployment. </summary>
    public partial class BatchDeploymentDetails : EndpointDeploymentPropertiesBase
    {
        /// <summary> Initializes a new instance of BatchDeploymentDetails. </summary>
        public BatchDeploymentDetails()
        {
        }

        /// <summary> Initializes a new instance of BatchDeploymentDetails. </summary>
        /// <param name="codeConfiguration"> Code configuration for the endpoint deployment. </param>
        /// <param name="description"> Description of the endpoint deployment. </param>
        /// <param name="environmentId"> ARM resource ID of the environment specification for the endpoint deployment. </param>
        /// <param name="environmentVariables"> Environment variables configuration for the deployment. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="compute"> Compute target for batch inference operation. </param>
        /// <param name="errorThreshold">
        /// Error threshold, if the error count for the entire input goes above this value,
        /// the batch inference will be aborted. Range is [-1, int.MaxValue].
        /// For FileDataset, this value is the count of file failures.
        /// For TabularDataset, this value is the count of record failures.
        /// If set to -1 (the lower bound), all failures during batch inference will be ignored.
        /// </param>
        /// <param name="loggingLevel"> Logging level for batch inference operation. </param>
        /// <param name="maxConcurrencyPerInstance"> Indicates maximum number of parallelism per instance. </param>
        /// <param name="miniBatchSize">
        /// Size of the mini-batch passed to each batch invocation.
        /// For FileDataset, this is the number of files per mini-batch.
        /// For TabularDataset, this is the size of the records in bytes, per mini-batch.
        /// </param>
        /// <param name="model"> Reference to the model asset for the endpoint deployment. </param>
        /// <param name="outputAction"> Indicates how the output will be organized. </param>
        /// <param name="outputFileName"> Customized output file name for append_row output action. </param>
        /// <param name="provisioningState"> Provisioning state for the endpoint deployment. </param>
        /// <param name="resources">
        /// Indicates compute configuration for the job.
        /// If not provided, will default to the defaults defined in ResourceConfiguration.
        /// </param>
        /// <param name="retrySettings">
        /// Retry Settings for the batch inference operation.
        /// If not provided, will default to the defaults defined in BatchRetrySettings.
        /// </param>
        internal BatchDeploymentDetails(CodeConfiguration codeConfiguration, string description, string environmentId, IDictionary<string, string> environmentVariables, IDictionary<string, string> properties, string compute, int? errorThreshold, BatchLoggingLevel? loggingLevel, int? maxConcurrencyPerInstance, long? miniBatchSize, AssetReferenceBase model, BatchOutputAction? outputAction, string outputFileName, DeploymentProvisioningState? provisioningState, ResourceConfiguration resources, BatchRetrySettings retrySettings) : base(codeConfiguration, description, environmentId, environmentVariables, properties)
        {
            Compute = compute;
            ErrorThreshold = errorThreshold;
            LoggingLevel = loggingLevel;
            MaxConcurrencyPerInstance = maxConcurrencyPerInstance;
            MiniBatchSize = miniBatchSize;
            Model = model;
            OutputAction = outputAction;
            OutputFileName = outputFileName;
            ProvisioningState = provisioningState;
            Resources = resources;
            RetrySettings = retrySettings;
        }

        /// <summary> Compute target for batch inference operation. </summary>
        public string Compute { get; set; }
        /// <summary>
        /// Error threshold, if the error count for the entire input goes above this value,
        /// the batch inference will be aborted. Range is [-1, int.MaxValue].
        /// For FileDataset, this value is the count of file failures.
        /// For TabularDataset, this value is the count of record failures.
        /// If set to -1 (the lower bound), all failures during batch inference will be ignored.
        /// </summary>
        public int? ErrorThreshold { get; set; }
        /// <summary> Logging level for batch inference operation. </summary>
        public BatchLoggingLevel? LoggingLevel { get; set; }
        /// <summary> Indicates maximum number of parallelism per instance. </summary>
        public int? MaxConcurrencyPerInstance { get; set; }
        /// <summary>
        /// Size of the mini-batch passed to each batch invocation.
        /// For FileDataset, this is the number of files per mini-batch.
        /// For TabularDataset, this is the size of the records in bytes, per mini-batch.
        /// </summary>
        public long? MiniBatchSize { get; set; }
        /// <summary> Reference to the model asset for the endpoint deployment. </summary>
        internal AssetReferenceBase Model { get; set; }
        /// <summary> Specifies the type of asset reference. </summary>
        internal ReferenceType ModelReferenceType
        {
            get => Model is null ? default : Model.ReferenceType;
            set
            {
                if (Model is null)
                    Model = new AssetReferenceBase();
                Model.ReferenceType = value;
            }
        }

        /// <summary> Indicates how the output will be organized. </summary>
        public BatchOutputAction? OutputAction { get; set; }
        /// <summary> Customized output file name for append_row output action. </summary>
        public string OutputFileName { get; set; }
        /// <summary> Provisioning state for the endpoint deployment. </summary>
        public DeploymentProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// Indicates compute configuration for the job.
        /// If not provided, will default to the defaults defined in ResourceConfiguration.
        /// </summary>
        public ResourceConfiguration Resources { get; set; }
        /// <summary>
        /// Retry Settings for the batch inference operation.
        /// If not provided, will default to the defaults defined in BatchRetrySettings.
        /// </summary>
        public BatchRetrySettings RetrySettings { get; set; }
    }
}
