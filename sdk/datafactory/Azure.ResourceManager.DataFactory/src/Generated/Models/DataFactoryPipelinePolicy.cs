// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Pipeline Policy. </summary>
    internal partial class DataFactoryPipelinePolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelinePolicy"/>. </summary>
        public DataFactoryPipelinePolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelinePolicy"/>. </summary>
        /// <param name="elapsedTimeMetric"> Pipeline ElapsedTime Metric Policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryPipelinePolicy(PipelineElapsedTimeMetricPolicy elapsedTimeMetric, Dictionary<string, BinaryData> rawData)
        {
            ElapsedTimeMetric = elapsedTimeMetric;
            _rawData = rawData;
        }

        /// <summary> Pipeline ElapsedTime Metric Policy. </summary>
        internal PipelineElapsedTimeMetricPolicy ElapsedTimeMetric { get; set; }
        /// <summary>
        /// TimeSpan value, after which an Azure Monitoring Metric is fired.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData ElapsedTimeMetricDuration
        {
            get => ElapsedTimeMetric is null ? default : ElapsedTimeMetric.Duration;
            set
            {
                if (ElapsedTimeMetric is null)
                    ElapsedTimeMetric = new PipelineElapsedTimeMetricPolicy();
                ElapsedTimeMetric.Duration = value;
            }
        }
    }
}
