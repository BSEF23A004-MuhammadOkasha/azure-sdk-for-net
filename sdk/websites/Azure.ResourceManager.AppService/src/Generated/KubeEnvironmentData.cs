// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the KubeEnvironment data model. </summary>
    public partial class KubeEnvironmentData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of KubeEnvironmentData. </summary>
        /// <param name="location"> The location. </param>
        public KubeEnvironmentData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of KubeEnvironmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation">
        /// Extended Location.
        /// Serialized Name: KubeEnvironment.extendedLocation
        /// </param>
        /// <param name="provisioningState">
        /// Provisioning state of the Kubernetes Environment.
        /// Serialized Name: KubeEnvironment.properties.provisioningState
        /// </param>
        /// <param name="deploymentErrors">
        /// Any errors that occurred during deployment or deployment validation
        /// Serialized Name: KubeEnvironment.properties.deploymentErrors
        /// </param>
        /// <param name="isInternalLoadBalancerEnabled">
        /// Only visible within Vnet/Subnet
        /// Serialized Name: KubeEnvironment.properties.internalLoadBalancerEnabled
        /// </param>
        /// <param name="defaultDomain">
        /// Default Domain Name for the cluster
        /// Serialized Name: KubeEnvironment.properties.defaultDomain
        /// </param>
        /// <param name="staticIP">
        /// Static IP of the KubeEnvironment
        /// Serialized Name: KubeEnvironment.properties.staticIp
        /// </param>
        /// <param name="arcConfiguration">
        /// Cluster configuration which determines the ARC cluster
        /// components types. Eg: Choosing between BuildService kind,
        /// FrontEnd Service ArtifactsStorageType etc.
        /// Serialized Name: KubeEnvironment.properties.arcConfiguration
        /// </param>
        /// <param name="appLogsConfiguration">
        /// Cluster configuration which enables the log daemon to export
        /// app logs to a destination. Currently only &quot;log-analytics&quot; is
        /// supported
        /// Serialized Name: KubeEnvironment.properties.appLogsConfiguration
        /// </param>
        /// <param name="aksResourceId"> Serialized Name: KubeEnvironment.properties.aksResourceID. </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: Resource.kind
        /// </param>
        internal KubeEnvironmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, KubeEnvironmentProvisioningState? provisioningState, string deploymentErrors, bool? isInternalLoadBalancerEnabled, string defaultDomain, string staticIP, ArcConfiguration arcConfiguration, AppLogsConfiguration appLogsConfiguration, ResourceIdentifier aksResourceId, string kind) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            ProvisioningState = provisioningState;
            DeploymentErrors = deploymentErrors;
            IsInternalLoadBalancerEnabled = isInternalLoadBalancerEnabled;
            DefaultDomain = defaultDomain;
            StaticIP = staticIP;
            ArcConfiguration = arcConfiguration;
            AppLogsConfiguration = appLogsConfiguration;
            AksResourceId = aksResourceId;
            Kind = kind;
        }

        /// <summary>
        /// Extended Location.
        /// Serialized Name: KubeEnvironment.extendedLocation
        /// </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary>
        /// Provisioning state of the Kubernetes Environment.
        /// Serialized Name: KubeEnvironment.properties.provisioningState
        /// </summary>
        public KubeEnvironmentProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// Any errors that occurred during deployment or deployment validation
        /// Serialized Name: KubeEnvironment.properties.deploymentErrors
        /// </summary>
        public string DeploymentErrors { get; }
        /// <summary>
        /// Only visible within Vnet/Subnet
        /// Serialized Name: KubeEnvironment.properties.internalLoadBalancerEnabled
        /// </summary>
        public bool? IsInternalLoadBalancerEnabled { get; set; }
        /// <summary>
        /// Default Domain Name for the cluster
        /// Serialized Name: KubeEnvironment.properties.defaultDomain
        /// </summary>
        public string DefaultDomain { get; }
        /// <summary>
        /// Static IP of the KubeEnvironment
        /// Serialized Name: KubeEnvironment.properties.staticIp
        /// </summary>
        public string StaticIP { get; set; }
        /// <summary>
        /// Cluster configuration which determines the ARC cluster
        /// components types. Eg: Choosing between BuildService kind,
        /// FrontEnd Service ArtifactsStorageType etc.
        /// Serialized Name: KubeEnvironment.properties.arcConfiguration
        /// </summary>
        public ArcConfiguration ArcConfiguration { get; set; }
        /// <summary>
        /// Cluster configuration which enables the log daemon to export
        /// app logs to a destination. Currently only &quot;log-analytics&quot; is
        /// supported
        /// Serialized Name: KubeEnvironment.properties.appLogsConfiguration
        /// </summary>
        public AppLogsConfiguration AppLogsConfiguration { get; set; }
        /// <summary> Serialized Name: KubeEnvironment.properties.aksResourceID. </summary>
        public ResourceIdentifier AksResourceId { get; set; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: Resource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
