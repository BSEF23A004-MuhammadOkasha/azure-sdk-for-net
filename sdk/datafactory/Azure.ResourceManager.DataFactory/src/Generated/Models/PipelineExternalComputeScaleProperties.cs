// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> PipelineExternalComputeScale properties for managed integration runtime. </summary>
    public partial class PipelineExternalComputeScaleProperties
    {
        /// <summary> Initializes a new instance of PipelineExternalComputeScaleProperties. </summary>
        public PipelineExternalComputeScaleProperties()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of PipelineExternalComputeScaleProperties. </summary>
        /// <param name="timeToLive"> Time to live (in minutes) setting of integration runtime which will execute pipeline and external activity. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal PipelineExternalComputeScaleProperties(int? timeToLive, IDictionary<string, BinaryData> additionalProperties)
        {
            TimeToLive = timeToLive;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Time to live (in minutes) setting of integration runtime which will execute pipeline and external activity. </summary>
        public int? TimeToLive { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
