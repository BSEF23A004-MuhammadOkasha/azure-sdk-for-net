// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of the application rule protocol. </summary>
    public partial class AzureFirewallApplicationRuleProtocol
    {
        /// <summary> Initializes a new instance of AzureFirewallApplicationRuleProtocol. </summary>
        public AzureFirewallApplicationRuleProtocol()
        {
        }

        /// <summary> Initializes a new instance of AzureFirewallApplicationRuleProtocol. </summary>
        /// <param name="protocolType"> Protocol type. </param>
        /// <param name="port"> Port number for the protocol, cannot be greater than 64000. This field is optional. </param>
        internal AzureFirewallApplicationRuleProtocol(AzureFirewallApplicationRuleProtocolType? protocolType, int? port)
        {
            ProtocolType = protocolType;
            Port = port;
        }

        /// <summary> Protocol type. </summary>
        public AzureFirewallApplicationRuleProtocolType? ProtocolType { get; set; }
        /// <summary> Port number for the protocol, cannot be greater than 64000. This field is optional. </summary>
        public int? Port { get; set; }
    }
}
