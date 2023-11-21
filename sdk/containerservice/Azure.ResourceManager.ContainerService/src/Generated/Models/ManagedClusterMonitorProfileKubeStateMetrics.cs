// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Kube State Metrics for prometheus addon profile for the container service cluster. </summary>
    public partial class ManagedClusterMonitorProfileKubeStateMetrics
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterMonitorProfileKubeStateMetrics"/>. </summary>
        public ManagedClusterMonitorProfileKubeStateMetrics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterMonitorProfileKubeStateMetrics"/>. </summary>
        /// <param name="metricLabelsAllowlist"> Comma-separated list of Kubernetes annotations keys that will be used in the resource's labels metric. </param>
        /// <param name="metricAnnotationsAllowList"> Comma-separated list of additional Kubernetes label keys that will be used in the resource's labels metric. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterMonitorProfileKubeStateMetrics(string metricLabelsAllowlist, string metricAnnotationsAllowList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MetricLabelsAllowlist = metricLabelsAllowlist;
            MetricAnnotationsAllowList = metricAnnotationsAllowList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Comma-separated list of Kubernetes annotations keys that will be used in the resource's labels metric. </summary>
        public string MetricLabelsAllowlist { get; set; }
        /// <summary> Comma-separated list of additional Kubernetes label keys that will be used in the resource's labels metric. </summary>
        public string MetricAnnotationsAllowList { get; set; }
    }
}
