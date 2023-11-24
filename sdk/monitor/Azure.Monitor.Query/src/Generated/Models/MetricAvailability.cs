// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Metric availability specifies the time grain (aggregation interval or frequency) and the retention period for that time grain. </summary>
    public partial class MetricAvailability
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

        /// <summary> Initializes a new instance of <see cref="MetricAvailability"/>. </summary>
        internal MetricAvailability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MetricAvailability"/>. </summary>
        /// <param name="granularity"> the time grain specifies the aggregation interval for the metric. Expressed as a duration 'PT1M', 'P1D', etc. </param>
        /// <param name="retention"> the retention period for the metric at the specified timegrain.  Expressed as a duration 'PT1M', 'P1D', etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricAvailability(TimeSpan? granularity, TimeSpan? retention, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Granularity = granularity;
            Retention = retention;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary> the retention period for the metric at the specified timegrain.  Expressed as a duration 'PT1M', 'P1D', etc. </summary>
        public TimeSpan? Retention { get; }
    }
}
