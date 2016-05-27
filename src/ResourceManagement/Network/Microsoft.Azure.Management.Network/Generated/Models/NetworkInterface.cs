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
    /// A NetworkInterface in a resource group
    /// </summary>
    [JsonTransformation]
    public partial class NetworkInterface : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterface class.
        /// </summary>
        public NetworkInterface() { }

        /// <summary>
        /// Initializes a new instance of the NetworkInterface class.
        /// </summary>
        public NetworkInterface(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SubResource virtualMachine = default(SubResource), NetworkSecurityGroup networkSecurityGroup = default(NetworkSecurityGroup), IList<NetworkInterfaceIPConfiguration> ipConfigurations = default(IList<NetworkInterfaceIPConfiguration>), NetworkInterfaceDnsSettings dnsSettings = default(NetworkInterfaceDnsSettings), string macAddress = default(string), bool? primary = default(bool?), bool? enableIPForwarding = default(bool?), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            VirtualMachine = virtualMachine;
            NetworkSecurityGroup = networkSecurityGroup;
            IpConfigurations = ipConfigurations;
            DnsSettings = dnsSettings;
            MacAddress = macAddress;
            Primary = primary;
            EnableIPForwarding = enableIPForwarding;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets the reference of a VirtualMachine
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachine")]
        public SubResource VirtualMachine { get; set; }

        /// <summary>
        /// Gets or sets the reference of the NetworkSecurityGroup resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkSecurityGroup")]
        public NetworkSecurityGroup NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Gets or sets list of IPConfigurations of the NetworkInterface
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<NetworkInterfaceIPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// Gets or sets DNS Settings in  NetworkInterface
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public NetworkInterfaceDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// Gets the MAC Address of the network interface
        /// </summary>
        [JsonProperty(PropertyName = "properties.macAddress")]
        public string MacAddress { get; set; }

        /// <summary>
        /// Gets whether this is a primary NIC on a virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "properties.primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// Gets or sets whether IPForwarding is enabled on the NIC
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableIPForwarding")]
        public bool? EnableIPForwarding { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the network interface
        /// resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
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
