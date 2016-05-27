// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A common class for general resource information
    /// </summary>
    [JsonTransformation]
    public partial class LocalNetworkGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LocalNetworkGateway class.
        /// </summary>
        public LocalNetworkGateway() { }

        /// <summary>
        /// Initializes a new instance of the LocalNetworkGateway class.
        /// </summary>
        public LocalNetworkGateway(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), AddressSpace localNetworkAddressSpace = default(AddressSpace), string gatewayIpAddress = default(string), BgpSettings bgpSettings = default(BgpSettings), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            LocalNetworkAddressSpace = localNetworkAddressSpace;
            GatewayIpAddress = gatewayIpAddress;
            BgpSettings = bgpSettings;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
        }

        /// <summary>
        /// Local network site Address space
        /// </summary>
        [JsonProperty(PropertyName = "properties.localNetworkAddressSpace")]
        public AddressSpace LocalNetworkAddressSpace { get; set; }

        /// <summary>
        /// IP address of local network gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayIpAddress")]
        public string GatewayIpAddress { get; set; }

        /// <summary>
        /// Local network gateway's BGP speaker settings
        /// </summary>
        [JsonProperty(PropertyName = "properties.bgpSettings")]
        public BgpSettings BgpSettings { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the LocalNetworkGateway
        /// resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the LocalNetworkGateway
        /// resource Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
