// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Peering in an ExpressRoute Cross Connection resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCrossConnectionPeering : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteCrossConnectionPeering class.
        /// </summary>
        public ExpressRouteCrossConnectionPeering()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteCrossConnectionPeering class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="peeringType">The peering type. Possible values
        /// include: 'AzurePublicPeering', 'AzurePrivatePeering',
        /// 'MicrosoftPeering'</param>
        /// <param name="state">The peering state. Possible values include:
        /// 'Disabled', 'Enabled'</param>
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
        /// <param name="provisioningState">The provisioning state of the
        /// express route cross connection peering resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="gatewayManagerEtag">The GatewayManager Etag.</param>
        /// <param name="lastModifiedBy">Who was the last to modify the
        /// peering.</param>
        /// <param name="ipv6PeeringConfig">The IPv6 peering
        /// configuration.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ExpressRouteCrossConnectionPeering(string id = default(string), string peeringType = default(string), string state = default(string), int? azureASN = default(int?), long? peerASN = default(long?), string primaryPeerAddressPrefix = default(string), string secondaryPeerAddressPrefix = default(string), string primaryAzurePort = default(string), string secondaryAzurePort = default(string), string sharedKey = default(string), int? vlanId = default(int?), ExpressRouteCircuitPeeringConfig microsoftPeeringConfig = default(ExpressRouteCircuitPeeringConfig), string provisioningState = default(string), string gatewayManagerEtag = default(string), string lastModifiedBy = default(string), Ipv6ExpressRouteCircuitPeeringConfig ipv6PeeringConfig = default(Ipv6ExpressRouteCircuitPeeringConfig), string name = default(string), string etag = default(string))
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
            ProvisioningState = provisioningState;
            GatewayManagerEtag = gatewayManagerEtag;
            LastModifiedBy = lastModifiedBy;
            Ipv6PeeringConfig = ipv6PeeringConfig;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the peering type. Possible values include:
        /// 'AzurePublicPeering', 'AzurePrivatePeering', 'MicrosoftPeering'
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringType")]
        public string PeeringType { get; set; }

        /// <summary>
        /// Gets or sets the peering state. Possible values include:
        /// 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets the Azure ASN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureASN")]
        public int? AzureASN { get; private set; }

        /// <summary>
        /// Gets or sets the peer ASN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerASN")]
        public long? PeerASN { get; set; }

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
        /// Gets the primary port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryAzurePort")]
        public string PrimaryAzurePort { get; private set; }

        /// <summary>
        /// Gets the secondary port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryAzurePort")]
        public string SecondaryAzurePort { get; private set; }

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
        /// Gets the provisioning state of the express route cross connection
        /// peering resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the GatewayManager Etag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayManagerEtag")]
        public string GatewayManagerEtag { get; set; }

        /// <summary>
        /// Gets who was the last to modify the peering.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedBy")]
        public string LastModifiedBy { get; private set; }

        /// <summary>
        /// Gets or sets the IPv6 peering configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipv6PeeringConfig")]
        public Ipv6ExpressRouteCircuitPeeringConfig Ipv6PeeringConfig { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PeerASN != null)
            {
                if (PeerASN > 4294967295)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "PeerASN", 4294967295);
                }
                if (PeerASN < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "PeerASN", 1);
                }
            }
        }
    }
}
