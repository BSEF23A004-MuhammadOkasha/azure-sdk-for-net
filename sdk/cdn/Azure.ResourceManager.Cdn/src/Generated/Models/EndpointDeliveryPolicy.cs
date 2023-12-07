// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> A policy that specifies the delivery rules to be used for an endpoint. </summary>
    public partial class EndpointDeliveryPolicy
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

        /// <summary> Initializes a new instance of <see cref="EndpointDeliveryPolicy"/>. </summary>
        /// <param name="rules"> A list of the delivery rules. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rules"/> is null. </exception>
        public EndpointDeliveryPolicy(IEnumerable<DeliveryRule> rules)
        {
            Argument.AssertNotNull(rules, nameof(rules));

            Rules = rules.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="EndpointDeliveryPolicy"/>. </summary>
        /// <param name="description"> User-friendly description of the policy. </param>
        /// <param name="rules"> A list of the delivery rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointDeliveryPolicy(string description, IList<DeliveryRule> rules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            Rules = rules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EndpointDeliveryPolicy"/> for deserialization. </summary>
        internal EndpointDeliveryPolicy()
        {
        }

        /// <summary> User-friendly description of the policy. </summary>
        public string Description { get; set; }
        /// <summary> A list of the delivery rules. </summary>
        public IList<DeliveryRule> Rules { get; }
    }
}
