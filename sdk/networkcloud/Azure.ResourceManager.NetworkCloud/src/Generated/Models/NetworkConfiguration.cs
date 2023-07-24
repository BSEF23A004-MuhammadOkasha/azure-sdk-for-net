// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> NetworkConfiguration specifies the Kubernetes cluster network related configuration. </summary>
    public partial class NetworkConfiguration
    {
        /// <summary> Initializes a new instance of NetworkConfiguration. </summary>
        /// <param name="cloudServicesNetworkId"> The resource ID of the associated Cloud Services network. </param>
        /// <param name="cniNetworkId"> The resource ID of the Layer 3 network that is used for creation of the Container Networking Interface network. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServicesNetworkId"/> or <paramref name="cniNetworkId"/> is null. </exception>
        public NetworkConfiguration(string cloudServicesNetworkId, string cniNetworkId)
        {
            Argument.AssertNotNull(cloudServicesNetworkId, nameof(cloudServicesNetworkId));
            Argument.AssertNotNull(cniNetworkId, nameof(cniNetworkId));

            CloudServicesNetworkId = cloudServicesNetworkId;
            CniNetworkId = cniNetworkId;
            PodCidrs = new ChangeTrackingList<string>();
            ServiceCidrs = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of NetworkConfiguration. </summary>
        /// <param name="attachedNetworkConfiguration"> The configuration of networks being attached to the cluster for use by the workloads that run on this Kubernetes cluster. </param>
        /// <param name="bgpServiceLoadBalancerConfiguration"> The configuration of the BGP service load balancer for this Kubernetes cluster. </param>
        /// <param name="cloudServicesNetworkId"> The resource ID of the associated Cloud Services network. </param>
        /// <param name="cniNetworkId"> The resource ID of the Layer 3 network that is used for creation of the Container Networking Interface network. </param>
        /// <param name="dnsServiceIP"> The IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in service CIDR. </param>
        /// <param name="podCidrs"> The CIDR notation IP ranges from which to assign pod IPs. One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. </param>
        /// <param name="serviceCidrs"> The CIDR notation IP ranges from which to assign service IPs. One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. </param>
        internal NetworkConfiguration(AttachedNetworkConfiguration attachedNetworkConfiguration, BgpServiceLoadBalancerConfiguration bgpServiceLoadBalancerConfiguration, string cloudServicesNetworkId, string cniNetworkId, string dnsServiceIP, IList<string> podCidrs, IList<string> serviceCidrs)
        {
            AttachedNetworkConfiguration = attachedNetworkConfiguration;
            BgpServiceLoadBalancerConfiguration = bgpServiceLoadBalancerConfiguration;
            CloudServicesNetworkId = cloudServicesNetworkId;
            CniNetworkId = cniNetworkId;
            DnsServiceIP = dnsServiceIP;
            PodCidrs = podCidrs;
            ServiceCidrs = serviceCidrs;
        }

        /// <summary> The configuration of networks being attached to the cluster for use by the workloads that run on this Kubernetes cluster. </summary>
        public AttachedNetworkConfiguration AttachedNetworkConfiguration { get; set; }
        /// <summary> The configuration of the BGP service load balancer for this Kubernetes cluster. </summary>
        public BgpServiceLoadBalancerConfiguration BgpServiceLoadBalancerConfiguration { get; set; }
        /// <summary> The resource ID of the associated Cloud Services network. </summary>
        public string CloudServicesNetworkId { get; set; }
        /// <summary> The resource ID of the Layer 3 network that is used for creation of the Container Networking Interface network. </summary>
        public string CniNetworkId { get; set; }
        /// <summary> The IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in service CIDR. </summary>
        public string DnsServiceIP { get; set; }
        /// <summary> The CIDR notation IP ranges from which to assign pod IPs. One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. </summary>
        public IList<string> PodCidrs { get; }
        /// <summary> The CIDR notation IP ranges from which to assign service IPs. One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. </summary>
        public IList<string> ServiceCidrs { get; }
    }
}
