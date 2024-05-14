// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Shared status properties between all blueprint resources. </summary>
    public partial class BlueprintResourceStatusBase
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlueprintResourceStatusBase"/>. </summary>
        internal BlueprintResourceStatusBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BlueprintResourceStatusBase"/>. </summary>
        /// <param name="timeCreated"> Creation time of this blueprint definition. </param>
        /// <param name="lastModified"> Last modified time of this blueprint definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlueprintResourceStatusBase(DateTimeOffset? timeCreated, DateTimeOffset? lastModified, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TimeCreated = timeCreated;
            LastModified = lastModified;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Creation time of this blueprint definition. </summary>
        public DateTimeOffset? TimeCreated { get; }
        /// <summary> Last modified time of this blueprint definition. </summary>
        public DateTimeOffset? LastModified { get; }
    }
}
