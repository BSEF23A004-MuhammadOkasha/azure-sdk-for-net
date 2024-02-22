// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters used to add a new Azure Storage account.
    /// Serialized Name: AddStorageAccountParameters
    /// </summary>
    public partial class DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent"/>. </summary>
        /// <param name="accessKey">
        /// The access key associated with this Azure Storage account that will be used to connect to it.
        /// Serialized Name: AddStorageAccountParameters.properties.accessKey
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accessKey"/> is null. </exception>
        public DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent(string accessKey)
        {
            if (accessKey == null)
            {
                throw new ArgumentNullException(nameof(accessKey));
            }

            AccessKey = accessKey;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent"/>. </summary>
        /// <param name="accessKey">
        /// The access key associated with this Azure Storage account that will be used to connect to it.
        /// Serialized Name: AddStorageAccountParameters.properties.accessKey
        /// </param>
        /// <param name="suffix">
        /// The optional suffix for the storage account.
        /// Serialized Name: AddStorageAccountParameters.properties.suffix
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent(string accessKey, string suffix, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccessKey = accessKey;
            Suffix = suffix;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent"/> for deserialization. </summary>
        internal DataLakeAnalyticsStorageAccountInformationCreateOrUpdateContent()
        {
        }

        /// <summary>
        /// The access key associated with this Azure Storage account that will be used to connect to it.
        /// Serialized Name: AddStorageAccountParameters.properties.accessKey
        /// </summary>
        public string AccessKey { get; }
        /// <summary>
        /// The optional suffix for the storage account.
        /// Serialized Name: AddStorageAccountParameters.properties.suffix
        /// </summary>
        public string Suffix { get; set; }
    }
}
