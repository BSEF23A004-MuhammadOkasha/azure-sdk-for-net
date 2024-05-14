// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Intrusion detection bypass traffic specification. </summary>
    public partial class FirewallPolicyIntrusionDetectionBypassTrafficSpecifications
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyIntrusionDetectionBypassTrafficSpecifications"/>. </summary>
        public FirewallPolicyIntrusionDetectionBypassTrafficSpecifications()
        {
            SourceAddresses = new ChangeTrackingList<string>();
            DestinationAddresses = new ChangeTrackingList<string>();
            DestinationPorts = new ChangeTrackingList<string>();
            SourceIPGroups = new ChangeTrackingList<string>();
            DestinationIPGroups = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyIntrusionDetectionBypassTrafficSpecifications"/>. </summary>
        /// <param name="name"> Name of the bypass traffic rule. </param>
        /// <param name="description"> Description of the bypass traffic rule. </param>
        /// <param name="protocol"> The rule bypass protocol. </param>
        /// <param name="sourceAddresses"> List of source IP addresses or ranges for this rule. </param>
        /// <param name="destinationAddresses"> List of destination IP addresses or ranges for this rule. </param>
        /// <param name="destinationPorts"> List of destination ports or ranges. </param>
        /// <param name="sourceIPGroups"> List of source IpGroups for this rule. </param>
        /// <param name="destinationIPGroups"> List of destination IpGroups for this rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallPolicyIntrusionDetectionBypassTrafficSpecifications(string name, string description, FirewallPolicyIntrusionDetectionProtocol? protocol, IList<string> sourceAddresses, IList<string> destinationAddresses, IList<string> destinationPorts, IList<string> sourceIPGroups, IList<string> destinationIPGroups, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Description = description;
            Protocol = protocol;
            SourceAddresses = sourceAddresses;
            DestinationAddresses = destinationAddresses;
            DestinationPorts = destinationPorts;
            SourceIPGroups = sourceIPGroups;
            DestinationIPGroups = destinationIPGroups;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the bypass traffic rule. </summary>
        public string Name { get; set; }
        /// <summary> Description of the bypass traffic rule. </summary>
        public string Description { get; set; }
        /// <summary> The rule bypass protocol. </summary>
        public FirewallPolicyIntrusionDetectionProtocol? Protocol { get; set; }
        /// <summary> List of source IP addresses or ranges for this rule. </summary>
        public IList<string> SourceAddresses { get; }
        /// <summary> List of destination IP addresses or ranges for this rule. </summary>
        public IList<string> DestinationAddresses { get; }
        /// <summary> List of destination ports or ranges. </summary>
        public IList<string> DestinationPorts { get; }
        /// <summary> List of source IpGroups for this rule. </summary>
        public IList<string> SourceIPGroups { get; }
        /// <summary> List of destination IpGroups for this rule. </summary>
        public IList<string> DestinationIPGroups { get; }
    }
}
