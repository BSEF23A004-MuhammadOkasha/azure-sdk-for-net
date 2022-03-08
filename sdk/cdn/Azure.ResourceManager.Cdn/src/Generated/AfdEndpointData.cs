// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the AfdEndpoint data model. </summary>
    public partial class AfdEndpointData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AfdEndpointData. </summary>
        /// <param name="location"> The location. </param>
        public AfdEndpointData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of AfdEndpointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="originResponseTimeoutSeconds"> Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns. </param>
        /// <param name="enabledState"> Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        /// <param name="hostName"> The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net. </param>
        internal AfdEndpointData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, int? originResponseTimeoutSeconds, EnabledState? enabledState, AfdProvisioningState? provisioningState, DeploymentStatus? deploymentStatus, string hostName) : base(id, name, type, systemData, tags, location)
        {
            OriginResponseTimeoutSeconds = originResponseTimeoutSeconds;
            EnabledState = enabledState;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            HostName = hostName;
        }

        /// <summary> Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns. </summary>
        public int? OriginResponseTimeoutSeconds { get; set; }
        /// <summary> Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public EnabledState? EnabledState { get; set; }
        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public DeploymentStatus? DeploymentStatus { get; }
        /// <summary> The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net. </summary>
        public string HostName { get; }
    }
}
