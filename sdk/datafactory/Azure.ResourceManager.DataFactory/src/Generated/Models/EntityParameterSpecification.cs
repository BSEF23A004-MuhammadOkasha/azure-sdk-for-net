// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Definition of a single parameter for an entity. </summary>
    public partial class EntityParameterSpecification
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EntityParameterSpecification"/>. </summary>
        /// <param name="parameterType"> Parameter type. </param>
        public EntityParameterSpecification(EntityParameterType parameterType)
        {
            ParameterType = parameterType;
        }

        /// <summary> Initializes a new instance of <see cref="EntityParameterSpecification"/>. </summary>
        /// <param name="parameterType"> Parameter type. </param>
        /// <param name="defaultValue"> Default value of parameter. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityParameterSpecification(EntityParameterType parameterType, BinaryData defaultValue, Dictionary<string, BinaryData> rawData)
        {
            ParameterType = parameterType;
            DefaultValue = defaultValue;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EntityParameterSpecification"/> for deserialization. </summary>
        internal EntityParameterSpecification()
        {
        }

        /// <summary> Parameter type. </summary>
        public EntityParameterType ParameterType { get; set; }
        /// <summary>
        /// Default value of parameter.
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
        public BinaryData DefaultValue { get; set; }
    }
}
