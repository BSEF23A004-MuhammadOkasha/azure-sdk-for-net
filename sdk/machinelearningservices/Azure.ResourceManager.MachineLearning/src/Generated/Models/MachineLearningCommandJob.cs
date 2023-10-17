// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Command job definition. </summary>
    public partial class MachineLearningCommandJob : MachineLearningJobProperties
    {
        /// <summary> Initializes a new instance of MachineLearningCommandJob. </summary>
        /// <param name="command"> [Required] The command to execute on startup of the job. eg. "python train.py". </param>
        /// <param name="environmentId"> [Required] The ARM resource ID of the Environment specification for the job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="command"/> or <paramref name="environmentId"/> is null. </exception>
        public MachineLearningCommandJob(string command, ResourceIdentifier environmentId)
        {
            Argument.AssertNotNull(command, nameof(command));
            Argument.AssertNotNull(environmentId, nameof(environmentId));

            Command = command;
            EnvironmentId = environmentId;
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
            Inputs = new ChangeTrackingDictionary<string, MachineLearningJobInput>();
            Outputs = new ChangeTrackingDictionary<string, MachineLearningJobOutput>();
            JobType = JobType.Command;
        }

        /// <summary> Initializes a new instance of MachineLearningCommandJob. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="componentId"> ARM resource ID of the component resource. </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="MachineLearningIdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="MachineLearningManagedIdentity"/> and <see cref="MachineLearningUserIdentity"/>.
        /// </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="notificationSetting"> Notification setting for the job. </param>
        /// <param name="secretsConfiguration"> Configuration for secrets to be made available during runtime. </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="status"> Status of the job. </param>
        /// <param name="autologgerSettings"> Distribution configuration of the job. If set, this should be one of Mpi, Tensorflow, PyTorch, or null. </param>
        /// <param name="codeId"> ARM resource ID of the code asset. </param>
        /// <param name="command"> [Required] The command to execute on startup of the job. eg. "python train.py". </param>
        /// <param name="distribution">
        /// Distribution configuration of the job. If set, this should be one of Mpi, Tensorflow, PyTorch, Ray, or null.
        /// Please note <see cref="MachineLearningDistributionConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MpiDistributionConfiguration"/>, <see cref="PyTorchDistributionConfiguration"/>, <see cref="RayDistributionConfiguration"/> and <see cref="TensorFlowDistributionConfiguration"/>.
        /// </param>
        /// <param name="environmentId"> [Required] The ARM resource ID of the Environment specification for the job. </param>
        /// <param name="environmentVariables"> Environment variables included in the job. </param>
        /// <param name="inputs">
        /// Mapping of input data bindings used in the job.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </param>
        /// <param name="limits"> Command Job limit. </param>
        /// <param name="outputs">
        /// Mapping of output data bindings used in the job.
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </param>
        /// <param name="parameters"> Input parameters. </param>
        /// <param name="queueSettings"> Queue settings for the job. </param>
        /// <param name="resources"> Compute Resource configuration for the job. </param>
        internal MachineLearningCommandJob(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, ResourceIdentifier componentId, ResourceIdentifier computeId, string displayName, string experimentName, MachineLearningIdentityConfiguration identity, bool? isArchived, JobType jobType, NotificationSetting notificationSetting, IDictionary<string, SecretConfiguration> secretsConfiguration, IDictionary<string, MachineLearningJobService> services, MachineLearningJobStatus? status, AutologgerSettings autologgerSettings, ResourceIdentifier codeId, string command, MachineLearningDistributionConfiguration distribution, ResourceIdentifier environmentId, IDictionary<string, string> environmentVariables, IDictionary<string, MachineLearningJobInput> inputs, MachineLearningCommandJobLimits limits, IDictionary<string, MachineLearningJobOutput> outputs, BinaryData parameters, JobQueueSettings queueSettings, MachineLearningJobResourceConfiguration resources) : base(description, properties, tags, componentId, computeId, displayName, experimentName, identity, isArchived, jobType, notificationSetting, secretsConfiguration, services, status)
        {
            AutologgerSettings = autologgerSettings;
            CodeId = codeId;
            Command = command;
            Distribution = distribution;
            EnvironmentId = environmentId;
            EnvironmentVariables = environmentVariables;
            Inputs = inputs;
            Limits = limits;
            Outputs = outputs;
            Parameters = parameters;
            QueueSettings = queueSettings;
            Resources = resources;
            JobType = jobType;
        }

        /// <summary> Distribution configuration of the job. If set, this should be one of Mpi, Tensorflow, PyTorch, or null. </summary>
        internal AutologgerSettings AutologgerSettings { get; set; }
        /// <summary> [Required] Indicates whether mlflow autologger is enabled. </summary>
        public MachineLearningFlowAutoLoggerState? MlflowAutologger
        {
            get => AutologgerSettings is null ? default(MachineLearningFlowAutoLoggerState?) : AutologgerSettings.MlflowAutologger;
            set
            {
                AutologgerSettings = value.HasValue ? new AutologgerSettings(value.Value) : null;
            }
        }

        /// <summary> ARM resource ID of the code asset. </summary>
        public ResourceIdentifier CodeId { get; set; }
        /// <summary> [Required] The command to execute on startup of the job. eg. "python train.py". </summary>
        public string Command { get; set; }
        /// <summary>
        /// Distribution configuration of the job. If set, this should be one of Mpi, Tensorflow, PyTorch, Ray, or null.
        /// Please note <see cref="MachineLearningDistributionConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MpiDistributionConfiguration"/>, <see cref="PyTorchDistributionConfiguration"/>, <see cref="RayDistributionConfiguration"/> and <see cref="TensorFlowDistributionConfiguration"/>.
        /// </summary>
        public MachineLearningDistributionConfiguration Distribution { get; set; }
        /// <summary> [Required] The ARM resource ID of the Environment specification for the job. </summary>
        public ResourceIdentifier EnvironmentId { get; set; }
        /// <summary> Environment variables included in the job. </summary>
        public IDictionary<string, string> EnvironmentVariables { get; set; }
        /// <summary>
        /// Mapping of input data bindings used in the job.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </summary>
        public IDictionary<string, MachineLearningJobInput> Inputs { get; set; }
        /// <summary> Command Job limit. </summary>
        public MachineLearningCommandJobLimits Limits { get; set; }
        /// <summary>
        /// Mapping of output data bindings used in the job.
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </summary>
        public IDictionary<string, MachineLearningJobOutput> Outputs { get; set; }
        /// <summary>
        /// Input parameters.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Parameters { get; }
        /// <summary> Queue settings for the job. </summary>
        public JobQueueSettings QueueSettings { get; set; }
        /// <summary> Compute Resource configuration for the job. </summary>
        public MachineLearningJobResourceConfiguration Resources { get; set; }
    }
}
