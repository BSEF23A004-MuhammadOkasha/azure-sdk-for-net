// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the connection monitor endpoint filter. </summary>
    public partial class ConnectionMonitorEndpointFilter
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

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorEndpointFilter"/>. </summary>
        public ConnectionMonitorEndpointFilter()
        {
            Items = new ChangeTrackingList<ConnectionMonitorEndpointFilterItem>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorEndpointFilter"/>. </summary>
        /// <param name="filterType"> The behavior of the endpoint filter. Currently only 'Include' is supported. </param>
        /// <param name="items"> List of items in the filter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionMonitorEndpointFilter(ConnectionMonitorEndpointFilterType? filterType, IList<ConnectionMonitorEndpointFilterItem> items, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FilterType = filterType;
            Items = items;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The behavior of the endpoint filter. Currently only 'Include' is supported. </summary>
        public ConnectionMonitorEndpointFilterType? FilterType { get; set; }
        /// <summary> List of items in the filter. </summary>
        public IList<ConnectionMonitorEndpointFilterItem> Items { get; }
    }
}
