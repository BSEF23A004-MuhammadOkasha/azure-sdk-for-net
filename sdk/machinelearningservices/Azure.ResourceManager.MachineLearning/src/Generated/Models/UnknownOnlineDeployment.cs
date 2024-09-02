// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Unknown version of OnlineDeployment. </summary>
    internal partial class UnknownOnlineDeployment : MachineLearningOnlineDeploymentProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownOnlineDeployment"/>. </summary>
        /// <param name="description"> Description of the endpoint deployment. </param>
<<<<<<< HEAD
=======
        /// <param name="environmentId"> ARM resource ID or AssetId of the environment specification for the endpoint deployment. </param>
        /// <param name="environmentVariables"> Environment variables configuration for the deployment. </param>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="codeConfiguration"> Code configuration for the endpoint deployment. </param>
        /// <param name="environmentId"> ARM resource ID or AssetId of the environment specification for the endpoint deployment. </param>
        /// <param name="environmentVariables"> Environment variables configuration for the deployment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="endpointComputeType"> [Required] The compute type of the endpoint. </param>
        /// <param name="scaleSettings">
        /// Scale settings for the deployment.
        /// If it is null or not provided,
        /// it defaults to TargetUtilizationScaleSettings for KubernetesOnlineDeployment
        /// and to DefaultScaleSettings for ManagedOnlineDeployment.
        /// Please note <see cref="MachineLearningOnlineScaleSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningDefaultScaleSettings"/> and <see cref="MachineLearningTargetUtilizationScaleSettings"/>.
        /// </param>
        /// <param name="requestSettings"> Request settings for the deployment. </param>
        /// <param name="modelMountPath"> The path to mount the model in custom container. </param>
        /// <param name="appInsightsEnabled"> If true, enables Application Insights logging. </param>
        /// <param name="livenessProbe"> Liveness probe monitors the health of the container regularly. </param>
        /// <param name="readinessProbe"> Readiness probe validates if the container is ready to serve traffic. The properties and defaults are the same as liveness probe. </param>
        /// <param name="provisioningState"> Provisioning state for the endpoint deployment. </param>
        /// <param name="instanceType"> Compute instance type. </param>
        /// <param name="model"> The URI path to the model. </param>
        /// <param name="egressPublicNetworkAccess"> If Enabled, allow egress public network access. If Disabled, this will create secure egress. Default: Enabled. </param>
        /// <param name="dataCollector"> The mdc configuration, we disable mdc when it's null. </param>
        internal UnknownOnlineDeployment(string description, IDictionary<string, string> properties, MachineLearningCodeConfiguration codeConfiguration, string environmentId, IDictionary<string, string> environmentVariables, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningEndpointComputeType endpointComputeType, MachineLearningOnlineScaleSettings scaleSettings, MachineLearningOnlineRequestSettings requestSettings, string modelMountPath, bool? appInsightsEnabled, MachineLearningProbeSettings livenessProbe, MachineLearningProbeSettings readinessProbe, MachineLearningDeploymentProvisioningState? provisioningState, string instanceType, string model, MachineLearningEgressPublicNetworkAccessType? egressPublicNetworkAccess, DataCollector dataCollector) : base(description, properties, codeConfiguration, environmentId, environmentVariables, serializedAdditionalRawData, endpointComputeType, scaleSettings, requestSettings, modelMountPath, appInsightsEnabled, livenessProbe, readinessProbe, provisioningState, instanceType, model, egressPublicNetworkAccess, dataCollector)
        {
            EndpointComputeType = endpointComputeType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownOnlineDeployment"/> for deserialization. </summary>
        internal UnknownOnlineDeployment()
        {
        }
    }
}
