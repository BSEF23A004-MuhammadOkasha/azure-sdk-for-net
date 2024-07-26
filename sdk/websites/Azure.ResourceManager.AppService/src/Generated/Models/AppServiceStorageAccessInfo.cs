// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Azure Files or Blob Storage access information value for dictionary storage. </summary>
    public partial class AppServiceStorageAccessInfo
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

        /// <summary> Initializes a new instance of <see cref="AppServiceStorageAccessInfo"/>. </summary>
        public AppServiceStorageAccessInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceStorageAccessInfo"/>. </summary>
        /// <param name="storageType"> Type of storage. </param>
        /// <param name="accountName"> Name of the storage account. </param>
        /// <param name="shareName"> Name of the file share (container name, for Blob storage). </param>
        /// <param name="accessKey"> Access key for the storage account. </param>
        /// <param name="mountPath"> Path to mount the storage within the site's runtime environment. </param>
        /// <param name="state"> State of the storage account. </param>
        /// <param name="protocol"> Mounting protocol to use for the storage account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceStorageAccessInfo(AppServiceStorageType? storageType, string accountName, string shareName, string accessKey, string mountPath, AppServiceStorageAccountState? state, AppServiceStorageProtocol? protocol, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageType = storageType;
            AccountName = accountName;
            ShareName = shareName;
            AccessKey = accessKey;
            MountPath = mountPath;
            State = state;
            Protocol = protocol;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of storage. </summary>
        [WirePath("type")]
        public AppServiceStorageType? StorageType { get; set; }
        /// <summary> Name of the storage account. </summary>
        [WirePath("accountName")]
        public string AccountName { get; set; }
        /// <summary> Name of the file share (container name, for Blob storage). </summary>
        [WirePath("shareName")]
        public string ShareName { get; set; }
        /// <summary> Access key for the storage account. </summary>
        [WirePath("accessKey")]
        public string AccessKey { get; set; }
        /// <summary> Path to mount the storage within the site's runtime environment. </summary>
        [WirePath("mountPath")]
        public string MountPath { get; set; }
        /// <summary> State of the storage account. </summary>
        [WirePath("state")]
        public AppServiceStorageAccountState? State { get; }
        /// <summary> Mounting protocol to use for the storage account. </summary>
        [WirePath("protocol")]
        public AppServiceStorageProtocol? Protocol { get; set; }
    }
}
