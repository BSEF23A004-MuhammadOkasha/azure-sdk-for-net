// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the PeerExpressRouteCircuitConnection data model. </summary>
    public partial class PeerExpressRouteCircuitConnectionData : Models.SubResource
    {
        /// <summary> Initializes a new instance of PeerExpressRouteCircuitConnectionData. </summary>
        public PeerExpressRouteCircuitConnectionData()
        {
        }

        /// <summary> Initializes a new instance of PeerExpressRouteCircuitConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="expressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the circuit. </param>
        /// <param name="peerExpressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </param>
        /// <param name="addressPrefix"> /29 IP address space to carve out Customer addresses for tunnels. </param>
        /// <param name="circuitConnectionStatus"> Express Route Circuit connection state. </param>
        /// <param name="connectionName"> The name of the express route circuit connection resource. </param>
        /// <param name="authResourceGuid"> The resource guid of the authorization used for the express route circuit connection. </param>
        /// <param name="provisioningState"> The provisioning state of the peer express route circuit connection resource. </param>
        internal PeerExpressRouteCircuitConnectionData(string id, string name, string etag, string type, WritableSubResource expressRouteCircuitPeering, WritableSubResource peerExpressRouteCircuitPeering, string addressPrefix, CircuitConnectionStatus? circuitConnectionStatus, string connectionName, string authResourceGuid, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            PeerExpressRouteCircuitPeering = peerExpressRouteCircuitPeering;
            AddressPrefix = addressPrefix;
            CircuitConnectionStatus = circuitConnectionStatus;
            ConnectionName = connectionName;
            AuthResourceGuid = authResourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> Reference to Express Route Circuit Private Peering Resource of the circuit. </summary>
        public WritableSubResource ExpressRouteCircuitPeering { get; set; }
        /// <summary> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </summary>
        public WritableSubResource PeerExpressRouteCircuitPeering { get; set; }
        /// <summary> /29 IP address space to carve out Customer addresses for tunnels. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> Express Route Circuit connection state. </summary>
        public CircuitConnectionStatus? CircuitConnectionStatus { get; }
        /// <summary> The name of the express route circuit connection resource. </summary>
        public string ConnectionName { get; set; }
        /// <summary> The resource guid of the authorization used for the express route circuit connection. </summary>
        public string AuthResourceGuid { get; set; }
        /// <summary> The provisioning state of the peer express route circuit connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
