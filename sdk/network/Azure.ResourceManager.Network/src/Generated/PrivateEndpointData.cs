// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the PrivateEndpoint data model. </summary>
    public partial class PrivateEndpointData : Resource
    {
        /// <summary> Initializes a new instance of PrivateEndpointData. </summary>
        public PrivateEndpointData()
        {
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaceData>();
            PrivateLinkServiceConnections = new ChangeTrackingList<PrivateLinkServiceConnection>();
            ManualPrivateLinkServiceConnections = new ChangeTrackingList<PrivateLinkServiceConnection>();
            CustomDnsConfigs = new ChangeTrackingList<CustomDnsConfigPropertiesFormat>();
        }

        /// <summary> Initializes a new instance of PrivateEndpointData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of the load balancer. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceGuid"> The resource id of private endpoint. </param>
        /// <param name="subnet"> The ID of the subnet from which the private IP will be allocated. </param>
        /// <param name="networkInterfaces"> An array of references to the network interfaces created for this private endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint resource. </param>
        /// <param name="privateLinkServiceConnections"> A grouping of information about the connection to the remote resource. </param>
        /// <param name="manualPrivateLinkServiceConnections"> A grouping of information about the connection to the remote resource. Used when the network admin does not have access to approve connections to the remote resource. </param>
        /// <param name="customDnsConfigs"> An array of custom dns configurations. </param>
        internal PrivateEndpointData(string id, string name, string type, string location, IDictionary<string, string> tags, ExtendedLocation extendedLocation, string etag, string resourceGuid, SubnetData subnet, IReadOnlyList<NetworkInterfaceData> networkInterfaces, ProvisioningState? provisioningState, IList<PrivateLinkServiceConnection> privateLinkServiceConnections, IList<PrivateLinkServiceConnection> manualPrivateLinkServiceConnections, IList<CustomDnsConfigPropertiesFormat> customDnsConfigs) : base(id, name, type, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Etag = etag;
            ResourceGuid = resourceGuid;
            Subnet = subnet;
            NetworkInterfaces = networkInterfaces;
            ProvisioningState = provisioningState;
            PrivateLinkServiceConnections = privateLinkServiceConnections;
            ManualPrivateLinkServiceConnections = manualPrivateLinkServiceConnections;
            CustomDnsConfigs = customDnsConfigs;
        }

        /// <summary> The extended location of the load balancer. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The resource id of private endpoint. </summary>
        public string ResourceGuid { get; set; }
        /// <summary> The ID of the subnet from which the private IP will be allocated. </summary>
        public SubnetData Subnet { get; set; }
        /// <summary> An array of references to the network interfaces created for this private endpoint. </summary>
        public IReadOnlyList<NetworkInterfaceData> NetworkInterfaces { get; }
        /// <summary> The provisioning state of the private endpoint resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> A grouping of information about the connection to the remote resource. </summary>
        public IList<PrivateLinkServiceConnection> PrivateLinkServiceConnections { get; }
        /// <summary> A grouping of information about the connection to the remote resource. Used when the network admin does not have access to approve connections to the remote resource. </summary>
        public IList<PrivateLinkServiceConnection> ManualPrivateLinkServiceConnections { get; }
        /// <summary> An array of custom dns configurations. </summary>
        public IList<CustomDnsConfigPropertiesFormat> CustomDnsConfigs { get; }
    }
}
