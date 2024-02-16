// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Storage account keys creation time. </summary>
    public partial class StorageAccountKeyCreationTime
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

        /// <summary> Initializes a new instance of <see cref="StorageAccountKeyCreationTime"/>. </summary>
        internal StorageAccountKeyCreationTime()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountKeyCreationTime"/>. </summary>
        /// <param name="key1"></param>
        /// <param name="key2"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountKeyCreationTime(DateTimeOffset? key1, DateTimeOffset? key2, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key1 = key1;
            Key2 = key2;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the key 1. </summary>
        [WirePath("key1")]
        public DateTimeOffset? Key1 { get; }
        /// <summary> Gets the key 2. </summary>
        [WirePath("key2")]
        public DateTimeOffset? Key2 { get; }
    }
}
