// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> Request payload for creating a chat thread. </summary>
    internal partial class CreateChatThreadRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateChatThreadRequest"/>. </summary>
        /// <param name="topic"> The chat thread topic. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topic"/> is null. </exception>
        public CreateChatThreadRequest(string topic)
        {
            Argument.AssertNotNull(topic, nameof(topic));

            Topic = topic;
            Participants = new ChangeTrackingList<ChatParticipantInternal>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateChatThreadRequest"/>. </summary>
        /// <param name="topic"> The chat thread topic. </param>
        /// <param name="participants"> Participants to be added to the chat thread. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateChatThreadRequest(string topic, IList<ChatParticipantInternal> participants, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Topic = topic;
            Participants = participants;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateChatThreadRequest"/> for deserialization. </summary>
        internal CreateChatThreadRequest()
        {
        }

        /// <summary> The chat thread topic. </summary>
        public string Topic { get; }
        /// <summary> Participants to be added to the chat thread. </summary>
        public IList<ChatParticipantInternal> Participants { get; }
    }
}
