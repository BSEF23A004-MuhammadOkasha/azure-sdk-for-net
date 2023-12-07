// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The PlayOptions. </summary>
    internal partial class PlayOptionsInternal
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

        /// <summary> Initializes a new instance of <see cref="PlayOptionsInternal"/>. </summary>
        /// <param name="loop"> The option to play the provided audio source in loop when set to true. </param>
        public PlayOptionsInternal(bool loop)
        {
            Loop = loop;
        }

        /// <summary> Initializes a new instance of <see cref="PlayOptionsInternal"/>. </summary>
        /// <param name="loop"> The option to play the provided audio source in loop when set to true. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PlayOptionsInternal(bool loop, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Loop = loop;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PlayOptionsInternal"/> for deserialization. </summary>
        internal PlayOptionsInternal()
        {
        }

        /// <summary> The option to play the provided audio source in loop when set to true. </summary>
        public bool Loop { get; }
    }
}
