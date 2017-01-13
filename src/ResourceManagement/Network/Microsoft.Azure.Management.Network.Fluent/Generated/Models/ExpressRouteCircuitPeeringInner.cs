// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Azure;
    using Management;
    using Network;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Peering in an ExpressRouteCircuit resource.
    /// </summary>
    [JsonTransformation]
    public partial class ExpressRouteCircuitPeeringInner : Microsoft.Azure.Management.Resource.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitPeeringInner
        /// class.
        /// </summary>
        public ExpressRouteCircuitPeeringInner() { }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitPeeringInner
        /// class.
        /// </summary>
        /// <param name="peeringType">The PeeringType. Possible values are:
        /// 'AzurePublicPeering', 'AzurePrivatePeering', and
        /// 'MicrosoftPeering'. Possible values include: 'AzurePublicPeering',
        /// 'AzurePrivatePeering', 'MicrosoftPeering'</param>
        /// <param name="state">The state of peering. Possible values are:
        /// 'Disabled' and 'Enbaled'. Possible values include: 'Disabled',
        /// 'Enabled'</param>
        /// <param name="azureASN">The Azure ASN.</param>
        /// <param name="peerASN">The peer ASN.</param>
        /// <param name="primaryPeerAddressPrefix">The primary address
        /// prefix.</param>
        /// <param name="secondaryPeerAddressPrefix">The secondary address
        /// prefix.</param>
        /// <param name="primaryAzurePort">The primary port.</param>
        /// <param name="secondaryAzurePort">The secondary port.</param>
        /// <param name="sharedKey">The shared key.</param>
        /// <param name="vlanId">The VLAN ID.</param>
        /// <param name="microsoftPeeringConfig">The Microsoft peering
        /// configuration.</param>
        /// <param name="stats">Gets peering stats.</param>
        /// <param name="provisioningState">Gets the provisioning state of the
        /// public IP resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="gatewayManagerEtag">The GatewayManager Etag.</param>
        /// <param name="lastModifiedBy">Gets whether the provider or the
        /// customer last modified the peering.</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ExpressRouteCircuitPeeringInner(string id = default(string), string peeringType = default(string), string state = default(string), int? azureASN = default(int?), int? peerASN = default(int?), string primaryPeerAddressPrefix = default(string), string secondaryPeerAddressPrefix = default(string), string primaryAzurePort = default(string), string secondaryAzurePort = default(string), string sharedKey = default(string), int? vlanId = default(int?), ExpressRouteCircuitPeeringConfig microsoftPeeringConfig = default(ExpressRouteCircuitPeeringConfig), ExpressRouteCircuitStatsInner stats = default(ExpressRouteCircuitStatsInner), string provisioningState = default(string), string gatewayManagerEtag = default(string), string lastModifiedBy = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            PeeringType = peeringType;
            State = state;
            AzureASN = azureASN;
            PeerASN = peerASN;
            PrimaryPeerAddressPrefix = primaryPeerAddressPrefix;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            PrimaryAzurePort = primaryAzurePort;
            SecondaryAzurePort = secondaryAzurePort;
            SharedKey = sharedKey;
            VlanId = vlanId;
            MicrosoftPeeringConfig = microsoftPeeringConfig;
            Stats = stats;
            ProvisioningState = provisioningState;
            GatewayManagerEtag = gatewayManagerEtag;
            LastModifiedBy = lastModifiedBy;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets the PeeringType. Possible values are:
        /// 'AzurePublicPeering', 'AzurePrivatePeering', and
        /// 'MicrosoftPeering'. Possible values include: 'AzurePublicPeering',
        /// 'AzurePrivatePeering', 'MicrosoftPeering'
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringType")]
        public string PeeringType { get; set; }

        /// <summary>
        /// Gets or sets the state of peering. Possible values are: 'Disabled'
        /// and 'Enbaled'. Possible values include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the Azure ASN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureASN")]
        public int? AzureASN { get; set; }

        /// <summary>
        /// Gets or sets the peer ASN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerASN")]
        public int? PeerASN { get; set; }

        /// <summary>
        /// Gets or sets the primary address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryPeerAddressPrefix")]
        public string PrimaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the secondary address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryPeerAddressPrefix")]
        public string SecondaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the primary port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryAzurePort")]
        public string PrimaryAzurePort { get; set; }

        /// <summary>
        /// Gets or sets the secondary port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryAzurePort")]
        public string SecondaryAzurePort { get; set; }

        /// <summary>
        /// Gets or sets the shared key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets or sets the VLAN ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vlanId")]
        public int? VlanId { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft peering configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.microsoftPeeringConfig")]
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig { get; set; }

        /// <summary>
        /// Gets peering stats.
        /// </summary>
        [JsonProperty(PropertyName = "properties.stats")]
        public ExpressRouteCircuitStatsInner Stats { get; set; }

        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the GatewayManager Etag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayManagerEtag")]
        public string GatewayManagerEtag { get; set; }

        /// <summary>
        /// Gets whether the provider or the customer last modified the
        /// peering.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}

