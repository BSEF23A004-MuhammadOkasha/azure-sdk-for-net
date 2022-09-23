// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the source control sync job stream by id. </summary>
    public partial class SourceControlSyncJobStreamById
    {
        /// <summary> Initializes a new instance of SourceControlSyncJobStreamById. </summary>
        internal SourceControlSyncJobStreamById()
        {
            Value = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of SourceControlSyncJobStreamById. </summary>
        /// <param name="id"> Resource id. </param>
        /// <param name="sourceControlSyncJobStreamId"> The sync job stream id. </param>
        /// <param name="summary"> The summary of the sync job stream. </param>
        /// <param name="time"> The time of the sync job stream. </param>
        /// <param name="streamType"> The type of the sync job stream. </param>
        /// <param name="streamText"> The text of the sync job stream. </param>
        /// <param name="value"> The values of the job stream. </param>
        internal SourceControlSyncJobStreamById(string id, string sourceControlSyncJobStreamId, string summary, DateTimeOffset? time, StreamType? streamType, string streamText, IReadOnlyDictionary<string, BinaryData> value)
        {
            Id = id;
            SourceControlSyncJobStreamId = sourceControlSyncJobStreamId;
            Summary = summary;
            Time = time;
            StreamType = streamType;
            StreamText = streamText;
            Value = value;
        }

        /// <summary> Resource id. </summary>
        public string Id { get; }
        /// <summary> The sync job stream id. </summary>
        public string SourceControlSyncJobStreamId { get; }
        /// <summary> The summary of the sync job stream. </summary>
        public string Summary { get; }
        /// <summary> The time of the sync job stream. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> The type of the sync job stream. </summary>
        public StreamType? StreamType { get; }
        /// <summary> The text of the sync job stream. </summary>
        public string StreamText { get; }
        /// <summary>
        /// The values of the job stream.
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
        public IReadOnlyDictionary<string, BinaryData> Value { get; }
    }
}
