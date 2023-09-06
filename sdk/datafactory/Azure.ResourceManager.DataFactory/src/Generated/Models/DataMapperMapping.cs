// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Source and target table mapping details. </summary>
    public partial class DataMapperMapping
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataMapperMapping"/>. </summary>
        public DataMapperMapping()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataMapperMapping"/>. </summary>
        /// <param name="targetEntityName"> Name of the target table. </param>
        /// <param name="sourceEntityName"> Name of the source table. </param>
        /// <param name="sourceConnectionReference"> The connection reference for the source connection. </param>
        /// <param name="attributeMappingInfo"> This holds the user provided attribute mapping information. </param>
        /// <param name="sourceDenormalizeInfo"> This holds the source denormalization information used while joining multiple sources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataMapperMapping(string targetEntityName, string sourceEntityName, MapperConnectionReference sourceConnectionReference, MapperAttributeMappings attributeMappingInfo, BinaryData sourceDenormalizeInfo, Dictionary<string, BinaryData> rawData)
        {
            TargetEntityName = targetEntityName;
            SourceEntityName = sourceEntityName;
            SourceConnectionReference = sourceConnectionReference;
            AttributeMappingInfo = attributeMappingInfo;
            SourceDenormalizeInfo = sourceDenormalizeInfo;
            _rawData = rawData;
        }

        /// <summary> Name of the target table. </summary>
        public string TargetEntityName { get; set; }
        /// <summary> Name of the source table. </summary>
        public string SourceEntityName { get; set; }
        /// <summary> The connection reference for the source connection. </summary>
        public MapperConnectionReference SourceConnectionReference { get; set; }
        /// <summary> This holds the user provided attribute mapping information. </summary>
        internal MapperAttributeMappings AttributeMappingInfo { get; set; }
        /// <summary> List of attribute mappings. </summary>
        public IList<MapperAttributeMapping> AttributeMappings
        {
            get
            {
                if (AttributeMappingInfo is null)
                    AttributeMappingInfo = new MapperAttributeMappings();
                return AttributeMappingInfo.AttributeMappings;
            }
        }

        /// <summary>
        /// This holds the source denormalization information used while joining multiple sources.
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
        public BinaryData SourceDenormalizeInfo { get; set; }
    }
}
