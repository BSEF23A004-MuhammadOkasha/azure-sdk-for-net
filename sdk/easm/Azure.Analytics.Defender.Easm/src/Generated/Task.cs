// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The Task. </summary>
    public partial class Task
    {
        /// <summary> Initializes a new instance of Task. </summary>
        internal Task()
        {
            Metadata = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of Task. </summary>
        /// <param name="id"> The unique identifier of the task. </param>
        /// <param name="startedAt"> The time the task started. </param>
        /// <param name="completedAt"> The time the task completed. </param>
        /// <param name="lastPolledAt"> The last time the status of the task was updated. </param>
        /// <param name="state"> The state the task is in. </param>
        /// <param name="phase"> The phase the task is in. </param>
        /// <param name="reason"> The reason the task was moved into its current state, if the task wasn't completed. </param>
        /// <param name="metadata"> Attributes unique to the task.  This differs by task type. </param>
        internal Task(string id, DateTimeOffset? startedAt, DateTimeOffset? completedAt, DateTimeOffset? lastPolledAt, TaskState? state, TaskPhase? phase, string reason, IReadOnlyDictionary<string, BinaryData> metadata)
        {
            Id = id;
            StartedAt = startedAt;
            CompletedAt = completedAt;
            LastPolledAt = lastPolledAt;
            State = state;
            Phase = phase;
            Reason = reason;
            Metadata = metadata;
        }

        /// <summary> The unique identifier of the task. </summary>
        public string Id { get; }
        /// <summary> The time the task started. </summary>
        public DateTimeOffset? StartedAt { get; }
        /// <summary> The time the task completed. </summary>
        public DateTimeOffset? CompletedAt { get; }
        /// <summary> The last time the status of the task was updated. </summary>
        public DateTimeOffset? LastPolledAt { get; }
        /// <summary> The state the task is in. </summary>
        public TaskState? State { get; }
        /// <summary> The phase the task is in. </summary>
        public TaskPhase? Phase { get; }
        /// <summary> The reason the task was moved into its current state, if the task wasn't completed. </summary>
        public string Reason { get; }
        /// <summary>
        /// Attributes unique to the task.  This differs by task type.
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
        public IReadOnlyDictionary<string, BinaryData> Metadata { get; }
    }
}
