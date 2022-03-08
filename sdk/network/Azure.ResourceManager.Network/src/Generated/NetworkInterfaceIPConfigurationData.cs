// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the NetworkInterfaceIPConfiguration data model. </summary>
    public partial class NetworkInterfaceIPConfigurationData : Models.SubResource
    {
        /// <summary> Initializes a new instance of NetworkInterfaceIPConfigurationData. </summary>
        public NetworkInterfaceIPConfigurationData()
        {
            VirtualNetworkTaps = new ChangeTrackingList<VirtualNetworkTapData>();
            ApplicationGatewayBackendAddressPools = new ChangeTrackingList<ApplicationGatewayBackendAddressPool>();
            LoadBalancerBackendAddressPools = new ChangeTrackingList<BackendAddressPoolData>();
            LoadBalancerInboundNatRules = new ChangeTrackingList<InboundNatRuleData>();
            ApplicationSecurityGroups = new ChangeTrackingList<ApplicationSecurityGroupData>();
        }

        /// <summary> Initializes a new instance of NetworkInterfaceIPConfigurationData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="gatewayLoadBalancer"> The reference to gateway load balancer frontend IP. </param>
        /// <param name="virtualNetworkTaps"> The reference to Virtual Network Taps. </param>
        /// <param name="applicationGatewayBackendAddressPools"> The reference to ApplicationGatewayBackendAddressPool resource. </param>
        /// <param name="loadBalancerBackendAddressPools"> The reference to LoadBalancerBackendAddressPool resource. </param>
        /// <param name="loadBalancerInboundNatRules"> A list of references of LoadBalancerInboundNatRules. </param>
        /// <param name="privateIPAddress"> Private IP address of the IP configuration. </param>
        /// <param name="privateIPAllocationMethod"> The private IP address allocation method. </param>
        /// <param name="privateIPAddressVersion"> Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4. </param>
        /// <param name="subnet"> Subnet bound to the IP configuration. </param>
        /// <param name="primary"> Whether this is a primary customer address on the network interface. </param>
        /// <param name="publicIPAddress"> Public IP address bound to the IP configuration. </param>
        /// <param name="applicationSecurityGroups"> Application security groups in which the IP configuration is included. </param>
        /// <param name="provisioningState"> The provisioning state of the network interface IP configuration. </param>
        /// <param name="privateLinkConnectionProperties"> PrivateLinkConnection properties for the network interface. </param>
        internal NetworkInterfaceIPConfigurationData(string id, string name, string etag, string type, WritableSubResource gatewayLoadBalancer, IList<VirtualNetworkTapData> virtualNetworkTaps, IList<ApplicationGatewayBackendAddressPool> applicationGatewayBackendAddressPools, IList<BackendAddressPoolData> loadBalancerBackendAddressPools, IList<InboundNatRuleData> loadBalancerInboundNatRules, string privateIPAddress, IPAllocationMethod? privateIPAllocationMethod, IPVersion? privateIPAddressVersion, SubnetData subnet, bool? primary, PublicIPAddressData publicIPAddress, IList<ApplicationSecurityGroupData> applicationSecurityGroups, ProvisioningState? provisioningState, NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties privateLinkConnectionProperties) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            GatewayLoadBalancer = gatewayLoadBalancer;
            VirtualNetworkTaps = virtualNetworkTaps;
            ApplicationGatewayBackendAddressPools = applicationGatewayBackendAddressPools;
            LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
            LoadBalancerInboundNatRules = loadBalancerInboundNatRules;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            PrivateIPAddressVersion = privateIPAddressVersion;
            Subnet = subnet;
            Primary = primary;
            PublicIPAddress = publicIPAddress;
            ApplicationSecurityGroups = applicationSecurityGroups;
            ProvisioningState = provisioningState;
            PrivateLinkConnectionProperties = privateLinkConnectionProperties;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; set; }
        /// <summary> The reference to gateway load balancer frontend IP. </summary>
        internal WritableSubResource GatewayLoadBalancer { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier GatewayLoadBalancerId
        {
            get => GatewayLoadBalancer is null ? default : GatewayLoadBalancer.Id;
            set
            {
                if (GatewayLoadBalancer is null)
                    GatewayLoadBalancer = new WritableSubResource();
                GatewayLoadBalancer.Id = value;
            }
        }

        /// <summary> The reference to Virtual Network Taps. </summary>
        public IList<VirtualNetworkTapData> VirtualNetworkTaps { get; }
        /// <summary> The reference to ApplicationGatewayBackendAddressPool resource. </summary>
        public IList<ApplicationGatewayBackendAddressPool> ApplicationGatewayBackendAddressPools { get; }
        /// <summary> The reference to LoadBalancerBackendAddressPool resource. </summary>
        public IList<BackendAddressPoolData> LoadBalancerBackendAddressPools { get; }
        /// <summary> A list of references of LoadBalancerInboundNatRules. </summary>
        public IList<InboundNatRuleData> LoadBalancerInboundNatRules { get; }
        /// <summary> Private IP address of the IP configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The private IP address allocation method. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4. </summary>
        public IPVersion? PrivateIPAddressVersion { get; set; }
        /// <summary> Subnet bound to the IP configuration. </summary>
        public SubnetData Subnet { get; set; }
        /// <summary> Whether this is a primary customer address on the network interface. </summary>
        public bool? Primary { get; set; }
        /// <summary> Public IP address bound to the IP configuration. </summary>
        public PublicIPAddressData PublicIPAddress { get; set; }
        /// <summary> Application security groups in which the IP configuration is included. </summary>
        public IList<ApplicationSecurityGroupData> ApplicationSecurityGroups { get; }
        /// <summary> The provisioning state of the network interface IP configuration. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> PrivateLinkConnection properties for the network interface. </summary>
        public NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties PrivateLinkConnectionProperties { get; }
    }
}
