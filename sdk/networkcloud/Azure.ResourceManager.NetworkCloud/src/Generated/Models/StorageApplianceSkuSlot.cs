// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> StorageApplianceSkuSlot represents the single SKU and rack slot associated with the storage appliance. </summary>
    public partial class StorageApplianceSkuSlot
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

        /// <summary> Initializes a new instance of <see cref="StorageApplianceSkuSlot"/>. </summary>
        internal StorageApplianceSkuSlot()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageApplianceSkuSlot"/>. </summary>
        /// <param name="rackSlot"> The position in the rack for the storage appliance. </param>
        /// <param name="capacityGB"> The maximum capacity of the storage appliance. Measured in gibibytes. </param>
        /// <param name="model"> The model of the storage appliance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageApplianceSkuSlot(long? rackSlot, long? capacityGB, string model, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RackSlot = rackSlot;
            CapacityGB = capacityGB;
            Model = model;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The position in the rack for the storage appliance. </summary>
        public long? RackSlot { get; }
        /// <summary> The maximum capacity of the storage appliance. Measured in gibibytes. </summary>
        public long? CapacityGB { get; }
        /// <summary> The model of the storage appliance. </summary>
        public string Model { get; }
    }
}
