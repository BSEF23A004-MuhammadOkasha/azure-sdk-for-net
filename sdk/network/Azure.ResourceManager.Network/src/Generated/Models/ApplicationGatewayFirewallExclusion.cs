// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Allow to exclude some variable satisfy the condition for the WAF check. </summary>
    public partial class ApplicationGatewayFirewallExclusion
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

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallExclusion"/>. </summary>
        /// <param name="matchVariable"> The variable to be excluded. </param>
        /// <param name="selectorMatchOperator"> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </param>
        /// <param name="selector"> When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="matchVariable"/>, <paramref name="selectorMatchOperator"/> or <paramref name="selector"/> is null. </exception>
        public ApplicationGatewayFirewallExclusion(string matchVariable, string selectorMatchOperator, string selector)
        {
            Argument.AssertNotNull(matchVariable, nameof(matchVariable));
            Argument.AssertNotNull(selectorMatchOperator, nameof(selectorMatchOperator));
            Argument.AssertNotNull(selector, nameof(selector));

            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
            Selector = selector;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallExclusion"/>. </summary>
        /// <param name="matchVariable"> The variable to be excluded. </param>
        /// <param name="selectorMatchOperator"> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </param>
        /// <param name="selector"> When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayFirewallExclusion(string matchVariable, string selectorMatchOperator, string selector, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
            Selector = selector;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallExclusion"/> for deserialization. </summary>
        internal ApplicationGatewayFirewallExclusion()
        {
        }

        /// <summary> The variable to be excluded. </summary>
        public string MatchVariable { get; set; }
        /// <summary> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </summary>
        public string SelectorMatchOperator { get; set; }
        /// <summary> When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to. </summary>
        public string Selector { get; set; }
    }
}
