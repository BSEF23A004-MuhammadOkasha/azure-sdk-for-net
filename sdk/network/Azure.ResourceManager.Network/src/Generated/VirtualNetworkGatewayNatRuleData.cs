// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the VirtualNetworkGatewayNatRule data model. </summary>
    public partial class VirtualNetworkGatewayNatRuleData : SubResource
    {
        /// <summary> Initializes a new instance of VirtualNetworkGatewayNatRuleData. </summary>
        public VirtualNetworkGatewayNatRuleData()
        {
            InternalMappings = new ChangeTrackingList<VpnNatRuleMapping>();
            ExternalMappings = new ChangeTrackingList<VpnNatRuleMapping>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayNatRuleData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="provisioningState"> The provisioning state of the NAT Rule resource. </param>
        /// <param name="typePropertiesType"> The type of NAT rule for VPN NAT. </param>
        /// <param name="mode"> The Source NAT direction of a VPN NAT. </param>
        /// <param name="internalMappings"> The private IP address internal mapping for NAT. </param>
        /// <param name="externalMappings"> The private IP address external mapping for NAT. </param>
        /// <param name="ipConfigurationId"> The IP Configuration ID this NAT rule applies to. </param>
        internal VirtualNetworkGatewayNatRuleData(string id, string name, string etag, string type, ProvisioningState? provisioningState, VpnNatRuleType? typePropertiesType, VpnNatRuleMode? mode, IList<VpnNatRuleMapping> internalMappings, IList<VpnNatRuleMapping> externalMappings, string ipConfigurationId) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            ProvisioningState = provisioningState;
            TypePropertiesType = typePropertiesType;
            Mode = mode;
            InternalMappings = internalMappings;
            ExternalMappings = externalMappings;
            IPConfigurationId = ipConfigurationId;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
        /// <summary> The provisioning state of the NAT Rule resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The type of NAT rule for VPN NAT. </summary>
        public VpnNatRuleType? TypePropertiesType { get; set; }
        /// <summary> The Source NAT direction of a VPN NAT. </summary>
        public VpnNatRuleMode? Mode { get; set; }
        /// <summary> The private IP address internal mapping for NAT. </summary>
        public IList<VpnNatRuleMapping> InternalMappings { get; }
        /// <summary> The private IP address external mapping for NAT. </summary>
        public IList<VpnNatRuleMapping> ExternalMappings { get; }
        /// <summary> The IP Configuration ID this NAT rule applies to. </summary>
        public string IPConfigurationId { get; set; }
    }
}
