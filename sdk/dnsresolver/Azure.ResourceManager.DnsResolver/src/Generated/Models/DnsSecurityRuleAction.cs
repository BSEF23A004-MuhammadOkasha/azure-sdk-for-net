// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> The action to take on DNS requests that match the DNS security rule. </summary>
    public partial class DnsSecurityRuleAction
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

        /// <summary> Initializes a new instance of <see cref="DnsSecurityRuleAction"/>. </summary>
        public DnsSecurityRuleAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DnsSecurityRuleAction"/>. </summary>
        /// <param name="actionType"> The type of action to take. </param>
        /// <param name="blockResponseCode"> The response code for block actions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsSecurityRuleAction(DnsSecurityRuleActionType? actionType, BlockResponseCode? blockResponseCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionType = actionType;
            BlockResponseCode = blockResponseCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of action to take. </summary>
        public DnsSecurityRuleActionType? ActionType { get; set; }
        /// <summary> The response code for block actions. </summary>
        public BlockResponseCode? BlockResponseCode { get; set; }
    }
}
