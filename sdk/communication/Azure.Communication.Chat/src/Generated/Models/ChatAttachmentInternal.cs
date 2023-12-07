// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> An attachment in a chat message. </summary>
    internal partial class ChatAttachmentInternal
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

        /// <summary> Initializes a new instance of <see cref="ChatAttachmentInternal"/>. </summary>
        /// <param name="id"> Id of the attachment. </param>
        /// <param name="attachmentType"> The type of attachment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal ChatAttachmentInternal(string id, ChatAttachmentType attachmentType)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            AttachmentType = attachmentType;
        }

        /// <summary> Initializes a new instance of <see cref="ChatAttachmentInternal"/>. </summary>
        /// <param name="id"> Id of the attachment. </param>
        /// <param name="attachmentType"> The type of attachment. </param>
        /// <param name="name"> The name of the attachment content. </param>
        /// <param name="url"> The URL where the attachment can be downloaded. </param>
        /// <param name="previewUrl"> The URL where the preview of attachment can be downloaded. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatAttachmentInternal(string id, ChatAttachmentType attachmentType, string name, Uri url, Uri previewUrl, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            AttachmentType = attachmentType;
            Name = name;
            Url = url;
            PreviewUrl = previewUrl;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatAttachmentInternal"/> for deserialization. </summary>
        internal ChatAttachmentInternal()
        {
        }

        /// <summary> Id of the attachment. </summary>
        public string Id { get; }
        /// <summary> The type of attachment. </summary>
        public ChatAttachmentType AttachmentType { get; }
        /// <summary> The name of the attachment content. </summary>
        public string Name { get; }
        /// <summary> The URL where the attachment can be downloaded. </summary>
        public Uri Url { get; }
        /// <summary> The URL where the preview of attachment can be downloaded. </summary>
        public Uri PreviewUrl { get; }
    }
}
