// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Parameters for a Redis Enterprise export operation. </summary>
    public partial class ExportRedisEnterpriseDatabaseContent
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

        /// <summary> Initializes a new instance of <see cref="ExportRedisEnterpriseDatabaseContent"/>. </summary>
        /// <param name="sasUri"> SAS URI for the target directory to export to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUri"/> is null. </exception>
        public ExportRedisEnterpriseDatabaseContent(Uri sasUri)
        {
            Argument.AssertNotNull(sasUri, nameof(sasUri));

            SasUri = sasUri;
        }

        /// <summary> Initializes a new instance of <see cref="ExportRedisEnterpriseDatabaseContent"/>. </summary>
        /// <param name="sasUri"> SAS URI for the target directory to export to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportRedisEnterpriseDatabaseContent(Uri sasUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SasUri = sasUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExportRedisEnterpriseDatabaseContent"/> for deserialization. </summary>
        internal ExportRedisEnterpriseDatabaseContent()
        {
        }

        /// <summary> SAS URI for the target directory to export to. </summary>
        public Uri SasUri { get; }
    }
}
