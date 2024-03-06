// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Post Restore Request. </summary>
    public partial class PostRestoreContent
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

        /// <summary> Initializes a new instance of <see cref="PostRestoreContent"/>. </summary>
        public PostRestoreContent()
        {
            RestoreFileSpec = new ChangeTrackingList<RestoreFileSpec>();
        }

        /// <summary> Initializes a new instance of <see cref="PostRestoreContent"/>. </summary>
        /// <param name="partition"> Post Restore partition. </param>
        /// <param name="replicaGroup"> Post Restore replica group. </param>
        /// <param name="requestId"> Post Restore request id. </param>
        /// <param name="azureFileShareUri"> Post Restore Azure file share uri. </param>
        /// <param name="status"> Post Restore Azure status. </param>
        /// <param name="sourceAzureFileShareUri"> Post Restore Azure source azure file share uri. </param>
        /// <param name="failedFileList"> Post Restore Azure failed file list. </param>
        /// <param name="restoreFileSpec"> Post Restore restore file spec array. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostRestoreContent(string partition, string replicaGroup, string requestId, Uri azureFileShareUri, string status, Uri sourceAzureFileShareUri, string failedFileList, IList<RestoreFileSpec> restoreFileSpec, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Partition = partition;
            ReplicaGroup = replicaGroup;
            RequestId = requestId;
            AzureFileShareUri = azureFileShareUri;
            Status = status;
            SourceAzureFileShareUri = sourceAzureFileShareUri;
            FailedFileList = failedFileList;
            RestoreFileSpec = restoreFileSpec;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Post Restore partition. </summary>
        public string Partition { get; set; }
        /// <summary> Post Restore replica group. </summary>
        public string ReplicaGroup { get; set; }
        /// <summary> Post Restore request id. </summary>
        public string RequestId { get; set; }
        /// <summary> Post Restore Azure file share uri. </summary>
        public Uri AzureFileShareUri { get; set; }
        /// <summary> Post Restore Azure status. </summary>
        public string Status { get; set; }
        /// <summary> Post Restore Azure source azure file share uri. </summary>
        public Uri SourceAzureFileShareUri { get; set; }
        /// <summary> Post Restore Azure failed file list. </summary>
        public string FailedFileList { get; set; }
        /// <summary> Post Restore restore file spec array. </summary>
        public IList<RestoreFileSpec> RestoreFileSpec { get; }
    }
}
