// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the SecurityRule data model. </summary>
    public partial class SecurityRuleData : WritableResourceData
    {
        /// <summary> Initializes a new instance of SecurityRuleData. </summary>
        public SecurityRuleData()
        {
            SourceAddressPrefixes = new ChangeTrackingList<string>();
            SourceApplicationSecurityGroups = new ChangeTrackingList<ApplicationSecurityGroupData>();
            DestinationAddressPrefixes = new ChangeTrackingList<string>();
            DestinationApplicationSecurityGroups = new ChangeTrackingList<ApplicationSecurityGroupData>();
            SourcePortRanges = new ChangeTrackingList<string>();
            DestinationPortRanges = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SecurityRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="description"> A description for this rule. Restricted to 140 chars. </param>
        /// <param name="protocol"> Network protocol this rule applies to. </param>
        /// <param name="sourcePortRange"> The source port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match all ports. </param>
        /// <param name="destinationPortRange"> The destination port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match all ports. </param>
        /// <param name="sourceAddressPrefix"> The CIDR or source IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. If this is an ingress rule, specifies where network traffic originates from. </param>
        /// <param name="sourceAddressPrefixes"> The CIDR or source IP ranges. </param>
        /// <param name="sourceApplicationSecurityGroups"> The application security group specified as source. </param>
        /// <param name="destinationAddressPrefix"> The destination address prefix. CIDR or destination IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. </param>
        /// <param name="destinationAddressPrefixes"> The destination address prefixes. CIDR or destination IP ranges. </param>
        /// <param name="destinationApplicationSecurityGroups"> The application security group specified as destination. </param>
        /// <param name="sourcePortRanges"> The source port ranges. </param>
        /// <param name="destinationPortRanges"> The destination port ranges. </param>
        /// <param name="access"> The network traffic is allowed or denied. </param>
        /// <param name="priority"> The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. </param>
        /// <param name="direction"> The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. </param>
        /// <param name="provisioningState"> The provisioning state of the security rule resource. </param>
        internal SecurityRuleData(ResourceIdentifier id, string name, ResourceType? resourceType, SystemData systemData, ETag? etag, string description, SecurityRuleProtocol? protocol, string sourcePortRange, string destinationPortRange, string sourceAddressPrefix, IList<string> sourceAddressPrefixes, IList<ApplicationSecurityGroupData> sourceApplicationSecurityGroups, string destinationAddressPrefix, IList<string> destinationAddressPrefixes, IList<ApplicationSecurityGroupData> destinationApplicationSecurityGroups, IList<string> sourcePortRanges, IList<string> destinationPortRanges, SecurityRuleAccess? access, int? priority, SecurityRuleDirection? direction, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Etag = etag;
            Description = description;
            Protocol = protocol;
            SourcePortRange = sourcePortRange;
            DestinationPortRange = destinationPortRange;
            SourceAddressPrefix = sourceAddressPrefix;
            SourceAddressPrefixes = sourceAddressPrefixes;
            SourceApplicationSecurityGroups = sourceApplicationSecurityGroups;
            DestinationAddressPrefix = destinationAddressPrefix;
            DestinationAddressPrefixes = destinationAddressPrefixes;
            DestinationApplicationSecurityGroups = destinationApplicationSecurityGroups;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            Access = access;
            Priority = priority;
            Direction = direction;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> A description for this rule. Restricted to 140 chars. </summary>
        public string Description { get; set; }
        /// <summary> Network protocol this rule applies to. </summary>
        public SecurityRuleProtocol? Protocol { get; set; }
        /// <summary> The source port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match all ports. </summary>
        public string SourcePortRange { get; set; }
        /// <summary> The destination port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match all ports. </summary>
        public string DestinationPortRange { get; set; }
        /// <summary> The CIDR or source IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. If this is an ingress rule, specifies where network traffic originates from. </summary>
        public string SourceAddressPrefix { get; set; }
        /// <summary> The CIDR or source IP ranges. </summary>
        public IList<string> SourceAddressPrefixes { get; }
        /// <summary> The application security group specified as source. </summary>
        public IList<ApplicationSecurityGroupData> SourceApplicationSecurityGroups { get; }
        /// <summary> The destination address prefix. CIDR or destination IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. </summary>
        public string DestinationAddressPrefix { get; set; }
        /// <summary> The destination address prefixes. CIDR or destination IP ranges. </summary>
        public IList<string> DestinationAddressPrefixes { get; }
        /// <summary> The application security group specified as destination. </summary>
        public IList<ApplicationSecurityGroupData> DestinationApplicationSecurityGroups { get; }
        /// <summary> The source port ranges. </summary>
        public IList<string> SourcePortRanges { get; }
        /// <summary> The destination port ranges. </summary>
        public IList<string> DestinationPortRanges { get; }
        /// <summary> The network traffic is allowed or denied. </summary>
        public SecurityRuleAccess? Access { get; set; }
        /// <summary> The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. </summary>
        public int? Priority { get; set; }
        /// <summary> The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. </summary>
        public SecurityRuleDirection? Direction { get; set; }
        /// <summary> The provisioning state of the security rule resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
