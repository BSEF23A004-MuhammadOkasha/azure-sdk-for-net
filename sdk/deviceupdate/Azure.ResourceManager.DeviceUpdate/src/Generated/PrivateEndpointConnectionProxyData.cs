// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class representing the PrivateEndpointConnectionProxy data model. </summary>
    public partial class PrivateEndpointConnectionProxyData : ResourceData
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionProxyData. </summary>
        public PrivateEndpointConnectionProxyData()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionProxyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="eTag"> ETag from NRP. </param>
        /// <param name="remotePrivateEndpoint"> Remote private endpoint details. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection proxy resource. </param>
        /// <param name="status"> Operation status. </param>
        internal PrivateEndpointConnectionProxyData(ResourceIdentifier id, string name, ResourceType resourceType, ResourceManager.Models.SystemData systemData, string eTag, RemotePrivateEndpoint remotePrivateEndpoint, PrivateEndpointConnectionProxyProvisioningState? provisioningState, string status) : base(id, name, resourceType, systemData)
        {
            ETag = eTag;
            RemotePrivateEndpoint = remotePrivateEndpoint;
            ProvisioningState = provisioningState;
            Status = status;
        }

        /// <summary> ETag from NRP. </summary>
        public string ETag { get; }
        /// <summary> Remote private endpoint details. </summary>
        public RemotePrivateEndpoint RemotePrivateEndpoint { get; set; }
        /// <summary> The provisioning state of the private endpoint connection proxy resource. </summary>
        public PrivateEndpointConnectionProxyProvisioningState? ProvisioningState { get; }
        /// <summary> Operation status. </summary>
        public string Status { get; set; }
    }
}
