// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Route - Route resource. </summary>
    public partial class Route
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

        /// <summary> Initializes a new instance of <see cref="Route"/>. </summary>
        public Route()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Route"/>. </summary>
        /// <param name="name"> Name - name of the subnet. </param>
        /// <param name="addressPrefix"> The destination CIDR to which the route applies. </param>
        /// <param name="nextHopIPAddress"> The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Route(string name, string addressPrefix, string nextHopIPAddress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AddressPrefix = addressPrefix;
            NextHopIPAddress = nextHopIPAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name - name of the subnet. </summary>
        public string Name { get; set; }
        /// <summary> The destination CIDR to which the route applies. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance. </summary>
        public string NextHopIPAddress { get; set; }
    }
}
