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
    /// <summary> A class representing the VirtualHub data model. </summary>
    public partial class VirtualHubData : Resource
    {
        /// <summary> Initializes a new instance of VirtualHubData. </summary>
        public VirtualHubData()
        {
            VirtualHubRouteTableV2S = new ChangeTrackingList<VirtualHubRouteTableV2Data>();
            BgpConnections = new ChangeTrackingList<WritableSubResource>();
            IPConfigurations = new ChangeTrackingList<WritableSubResource>();
            VirtualRouterIPs = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualHubData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualWan"> The VirtualWAN to which the VirtualHub belongs. </param>
        /// <param name="vpnGateway"> The VpnGateway associated with this VirtualHub. </param>
        /// <param name="p2SVpnGateway"> The P2SVpnGateway associated with this VirtualHub. </param>
        /// <param name="expressRouteGateway"> The expressRouteGateway associated with this VirtualHub. </param>
        /// <param name="azureFirewall"> The azureFirewall associated with this VirtualHub. </param>
        /// <param name="securityPartnerProvider"> The securityPartnerProvider associated with this VirtualHub. </param>
        /// <param name="addressPrefix"> Address-prefix for this VirtualHub. </param>
        /// <param name="routeTable"> The routeTable associated with this virtual hub. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual hub resource. </param>
        /// <param name="securityProviderName"> The Security Provider name. </param>
        /// <param name="virtualHubRouteTableV2S"> List of all virtual hub route table v2s associated with this VirtualHub. </param>
        /// <param name="sku"> The sku of this VirtualHub. </param>
        /// <param name="routingState"> The routing state. </param>
        /// <param name="bgpConnections"> List of references to Bgp Connections. </param>
        /// <param name="iPConfigurations"> List of references to IpConfigurations. </param>
        /// <param name="virtualRouterAsn"> VirtualRouter ASN. </param>
        /// <param name="virtualRouterIPs"> VirtualRouter IPs. </param>
        /// <param name="allowBranchToBranchTraffic"> Flag to control transit for VirtualRouter hub. </param>
        /// <param name="preferredRoutingGateway"> The preferred gateway to route on-prem traffic. </param>
        internal VirtualHubData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, WritableSubResource virtualWan, WritableSubResource vpnGateway, WritableSubResource p2SVpnGateway, WritableSubResource expressRouteGateway, WritableSubResource azureFirewall, WritableSubResource securityPartnerProvider, string addressPrefix, VirtualHubRouteTable routeTable, ProvisioningState? provisioningState, string securityProviderName, IList<VirtualHubRouteTableV2Data> virtualHubRouteTableV2S, string sku, RoutingState? routingState, IReadOnlyList<WritableSubResource> bgpConnections, IReadOnlyList<WritableSubResource> iPConfigurations, long? virtualRouterAsn, IList<string> virtualRouterIPs, bool? allowBranchToBranchTraffic, PreferredRoutingGateway? preferredRoutingGateway) : base(id, name, type, location, tags)
        {
            Etag = etag;
            VirtualWan = virtualWan;
            VpnGateway = vpnGateway;
            P2SVpnGateway = p2SVpnGateway;
            ExpressRouteGateway = expressRouteGateway;
            AzureFirewall = azureFirewall;
            SecurityPartnerProvider = securityPartnerProvider;
            AddressPrefix = addressPrefix;
            RouteTable = routeTable;
            ProvisioningState = provisioningState;
            SecurityProviderName = securityProviderName;
            VirtualHubRouteTableV2S = virtualHubRouteTableV2S;
            Sku = sku;
            RoutingState = routingState;
            BgpConnections = bgpConnections;
            IPConfigurations = iPConfigurations;
            VirtualRouterAsn = virtualRouterAsn;
            VirtualRouterIPs = virtualRouterIPs;
            AllowBranchToBranchTraffic = allowBranchToBranchTraffic;
            PreferredRoutingGateway = preferredRoutingGateway;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The VirtualWAN to which the VirtualHub belongs. </summary>
        public WritableSubResource VirtualWan { get; set; }
        /// <summary> The VpnGateway associated with this VirtualHub. </summary>
        public WritableSubResource VpnGateway { get; set; }
        /// <summary> The P2SVpnGateway associated with this VirtualHub. </summary>
        public WritableSubResource P2SVpnGateway { get; set; }
        /// <summary> The expressRouteGateway associated with this VirtualHub. </summary>
        public WritableSubResource ExpressRouteGateway { get; set; }
        /// <summary> The azureFirewall associated with this VirtualHub. </summary>
        public WritableSubResource AzureFirewall { get; set; }
        /// <summary> The securityPartnerProvider associated with this VirtualHub. </summary>
        public WritableSubResource SecurityPartnerProvider { get; set; }
        /// <summary> Address-prefix for this VirtualHub. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> The routeTable associated with this virtual hub. </summary>
        public VirtualHubRouteTable RouteTable { get; set; }
        /// <summary> The provisioning state of the virtual hub resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The Security Provider name. </summary>
        public string SecurityProviderName { get; set; }
        /// <summary> List of all virtual hub route table v2s associated with this VirtualHub. </summary>
        public IList<VirtualHubRouteTableV2Data> VirtualHubRouteTableV2S { get; }
        /// <summary> The sku of this VirtualHub. </summary>
        public string Sku { get; set; }
        /// <summary> The routing state. </summary>
        public RoutingState? RoutingState { get; }
        /// <summary> List of references to Bgp Connections. </summary>
        public IReadOnlyList<WritableSubResource> BgpConnections { get; }
        /// <summary> List of references to IpConfigurations. </summary>
        public IReadOnlyList<WritableSubResource> IPConfigurations { get; }
        /// <summary> VirtualRouter ASN. </summary>
        public long? VirtualRouterAsn { get; set; }
        /// <summary> VirtualRouter IPs. </summary>
        public IList<string> VirtualRouterIPs { get; }
        /// <summary> Flag to control transit for VirtualRouter hub. </summary>
        public bool? AllowBranchToBranchTraffic { get; set; }
        /// <summary> The preferred gateway to route on-prem traffic. </summary>
        public PreferredRoutingGateway? PreferredRoutingGateway { get; set; }
    }
}
