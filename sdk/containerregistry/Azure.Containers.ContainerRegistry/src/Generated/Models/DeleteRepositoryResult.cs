// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Deleted repository. </summary>
    internal partial class DeleteRepositoryResult
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

        /// <summary> Initializes a new instance of <see cref="DeleteRepositoryResult"/>. </summary>
        internal DeleteRepositoryResult()
        {
            DeletedManifests = new ChangeTrackingList<string>();
            DeletedTags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DeleteRepositoryResult"/>. </summary>
        /// <param name="deletedManifests"> SHA of the deleted image. </param>
        /// <param name="deletedTags"> Tag of the deleted image. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeleteRepositoryResult(IReadOnlyList<string> deletedManifests, IReadOnlyList<string> deletedTags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeletedManifests = deletedManifests;
            DeletedTags = deletedTags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> SHA of the deleted image. </summary>
        public IReadOnlyList<string> DeletedManifests { get; }
        /// <summary> Tag of the deleted image. </summary>
        public IReadOnlyList<string> DeletedTags { get; }
    }
}
