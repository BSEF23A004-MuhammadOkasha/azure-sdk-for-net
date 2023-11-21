// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Cluster Storage Data. </summary>
    public partial class EdgeClusterStorageViewInfo
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

        /// <summary> Initializes a new instance of <see cref="EdgeClusterStorageViewInfo"/>. </summary>
        public EdgeClusterStorageViewInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EdgeClusterStorageViewInfo"/>. </summary>
        /// <param name="clusterTotalStorageInMB"> Total storage on the cluster in MB. </param>
        /// <param name="clusterFreeStorageInMB"> The available or free storage on the cluster in MB. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeClusterStorageViewInfo(double? clusterTotalStorageInMB, double? clusterFreeStorageInMB, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClusterTotalStorageInMB = clusterTotalStorageInMB;
            ClusterFreeStorageInMB = clusterFreeStorageInMB;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Total storage on the cluster in MB. </summary>
        public double? ClusterTotalStorageInMB { get; set; }
        /// <summary> The available or free storage on the cluster in MB. </summary>
        public double? ClusterFreeStorageInMB { get; set; }
    }
}
