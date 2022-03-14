// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the PrivateLinkService data model. </summary>
    public partial class PrivateLinkServiceData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of PrivateLinkServiceData. </summary>
        public PrivateLinkServiceData()
        {
            LoadBalancerFrontendIPConfigurations = new ChangeTrackingList<FrontendIPConfigurationData>();
            IPConfigurations = new ChangeTrackingList<PrivateLinkServiceIPConfiguration>();
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaceData>();
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionData>();
            Fqdns = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PrivateLinkServiceData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of the load balancer. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="loadBalancerFrontendIPConfigurations"> An array of references to the load balancer IP configurations. </param>
        /// <param name="ipConfigurations"> An array of private link service IP configurations. </param>
        /// <param name="networkInterfaces"> An array of references to the network interfaces created for this private link service. </param>
        /// <param name="provisioningState"> The provisioning state of the private link service resource. </param>
        /// <param name="privateEndpointConnections"> An array of list about connections to the private endpoint. </param>
        /// <param name="visibility"> The visibility list of the private link service. </param>
        /// <param name="autoApproval"> The auto-approval list of the private link service. </param>
        /// <param name="fqdns"> The list of Fqdn. </param>
        /// <param name="alias"> The alias of the private link service. </param>
        /// <param name="enableProxyProtocol"> Whether the private link service is enabled for proxy protocol or not. </param>
        internal PrivateLinkServiceData(string id, string name, string type, string location, IDictionary<string, string> tags, ExtendedLocation extendedLocation, string etag, IList<FrontendIPConfigurationData> loadBalancerFrontendIPConfigurations, IList<PrivateLinkServiceIPConfiguration> ipConfigurations, IReadOnlyList<NetworkInterfaceData> networkInterfaces, ProvisioningState? provisioningState, IReadOnlyList<PrivateEndpointConnectionData> privateEndpointConnections, PrivateLinkServicePropertiesVisibility visibility, PrivateLinkServicePropertiesAutoApproval autoApproval, IList<string> fqdns, string @alias, bool? enableProxyProtocol) : base(id, name, type, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Etag = etag;
            LoadBalancerFrontendIPConfigurations = loadBalancerFrontendIPConfigurations;
            IPConfigurations = ipConfigurations;
            NetworkInterfaces = networkInterfaces;
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
            Visibility = visibility;
            AutoApproval = autoApproval;
            Fqdns = fqdns;
            Alias = @alias;
            EnableProxyProtocol = enableProxyProtocol;
        }

        /// <summary> The extended location of the load balancer. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> An array of references to the load balancer IP configurations. </summary>
        public IList<FrontendIPConfigurationData> LoadBalancerFrontendIPConfigurations { get; }
        /// <summary> An array of private link service IP configurations. </summary>
        public IList<PrivateLinkServiceIPConfiguration> IPConfigurations { get; }
        /// <summary> An array of references to the network interfaces created for this private link service. </summary>
        public IReadOnlyList<NetworkInterfaceData> NetworkInterfaces { get; }
        /// <summary> The provisioning state of the private link service resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> An array of list about connections to the private endpoint. </summary>
        public IReadOnlyList<PrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The visibility list of the private link service. </summary>
        internal PrivateLinkServicePropertiesVisibility Visibility { get; set; }
        /// <summary> The list of subscriptions. </summary>
        public IList<string> VisibilitySubscriptions
        {
            get
            {
                if (Visibility is null)
                    Visibility = new PrivateLinkServicePropertiesVisibility();
                return Visibility.Subscriptions;
            }
        }

        /// <summary> The auto-approval list of the private link service. </summary>
        internal PrivateLinkServicePropertiesAutoApproval AutoApproval { get; set; }
        /// <summary> The list of subscriptions. </summary>
        public IList<string> AutoApprovalSubscriptions
        {
            get
            {
                if (AutoApproval is null)
                    AutoApproval = new PrivateLinkServicePropertiesAutoApproval();
                return AutoApproval.Subscriptions;
            }
        }

        /// <summary> The list of Fqdn. </summary>
        public IList<string> Fqdns { get; }
        /// <summary> The alias of the private link service. </summary>
        public string Alias { get; }
        /// <summary> Whether the private link service is enabled for proxy protocol or not. </summary>
        public bool? EnableProxyProtocol { get; set; }
    }
}
