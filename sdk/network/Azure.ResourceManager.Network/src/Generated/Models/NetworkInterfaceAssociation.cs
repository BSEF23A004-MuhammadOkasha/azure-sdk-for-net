// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network interface and its custom security rules. </summary>
    public partial class NetworkInterfaceAssociation
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

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceAssociation"/>. </summary>
        internal NetworkInterfaceAssociation()
        {
            SecurityRules = new ChangeTrackingList<SecurityRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceAssociation"/>. </summary>
        /// <param name="id"> Network interface ID. </param>
        /// <param name="securityRules"> Collection of custom security rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkInterfaceAssociation(ResourceIdentifier id, IReadOnlyList<SecurityRuleData> securityRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            SecurityRules = securityRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Network interface ID. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Collection of custom security rules. </summary>
        public IReadOnlyList<SecurityRuleData> SecurityRules { get; }
    }
}
