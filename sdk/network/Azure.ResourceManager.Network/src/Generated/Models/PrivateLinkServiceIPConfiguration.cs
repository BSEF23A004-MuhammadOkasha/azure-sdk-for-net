// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The private link service ip configuration. </summary>
    public partial class PrivateLinkServiceIPConfiguration : NetworkSubResource
    {
        /// <summary> Initializes a new instance of PrivateLinkServiceIPConfiguration. </summary>
        public PrivateLinkServiceIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkServiceIPConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of private link service ip configuration. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="privateIPAddress"> The private IP address of the IP configuration. </param>
        /// <param name="privateIPAllocationMethod"> The private IP address allocation method. </param>
        /// <param name="subnet"> The reference to the subnet resource. </param>
        /// <param name="primary"> Whether the ip configuration is primary or not. </param>
        /// <param name="provisioningState"> The provisioning state of the private link service IP configuration resource. </param>
        /// <param name="privateIPAddressVersion"> Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4. </param>
        internal PrivateLinkServiceIPConfiguration(ResourceIdentifier id, string name, string etag, string resourceType, string privateIPAddress, IPAllocationMethod? privateIPAllocationMethod, SubnetData subnet, bool? primary, NetworkProvisioningState? provisioningState, IPVersion? privateIPAddressVersion) : base(id)
        {
            Name = name;
            Etag = etag;
            ResourceType = resourceType;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            Primary = primary;
            ProvisioningState = provisioningState;
            PrivateIPAddressVersion = privateIPAddressVersion;
        }

        /// <summary> The name of private link service ip configuration. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The resource type. </summary>
        public string ResourceType { get; }
        /// <summary> The private IP address of the IP configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The private IP address allocation method. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> The reference to the subnet resource. </summary>
        public SubnetData Subnet { get; set; }
        /// <summary> Whether the ip configuration is primary or not. </summary>
        public bool? Primary { get; set; }
        /// <summary> The provisioning state of the private link service IP configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4. </summary>
        public IPVersion? PrivateIPAddressVersion { get; set; }
    }
}
