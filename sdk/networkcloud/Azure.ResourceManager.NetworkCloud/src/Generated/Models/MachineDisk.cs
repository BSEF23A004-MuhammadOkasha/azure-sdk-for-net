// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> Disk represents the properties of the disk. </summary>
    public partial class MachineDisk
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

        /// <summary> Initializes a new instance of <see cref="MachineDisk"/>. </summary>
        internal MachineDisk()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineDisk"/>. </summary>
        /// <param name="capacityGB"> The maximum amount of storage. Measured in gibibytes. </param>
        /// <param name="connection"> The connection type of the rack SKU resource. </param>
        /// <param name="diskType"> The disk type of rack SKU resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineDisk(long? capacityGB, MachineSkuDiskConnectionType? connection, DiskType? diskType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CapacityGB = capacityGB;
            Connection = connection;
            DiskType = diskType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The maximum amount of storage. Measured in gibibytes. </summary>
        public long? CapacityGB { get; }
        /// <summary> The connection type of the rack SKU resource. </summary>
        public MachineSkuDiskConnectionType? Connection { get; }
        /// <summary> The disk type of rack SKU resource. </summary>
        public DiskType? DiskType { get; }
    }
}
