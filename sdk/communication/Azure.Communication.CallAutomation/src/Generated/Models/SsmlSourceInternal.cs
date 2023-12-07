// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The SsmlSource. </summary>
    internal partial class SsmlSourceInternal
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

        /// <summary> Initializes a new instance of <see cref="SsmlSourceInternal"/>. </summary>
        /// <param name="ssmlText"> Ssml string for the cognitive service to be played. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ssmlText"/> is null. </exception>
        public SsmlSourceInternal(string ssmlText)
        {
            Argument.AssertNotNull(ssmlText, nameof(ssmlText));

            SsmlText = ssmlText;
        }

        /// <summary> Initializes a new instance of <see cref="SsmlSourceInternal"/>. </summary>
        /// <param name="ssmlText"> Ssml string for the cognitive service to be played. </param>
        /// <param name="customVoiceEndpointId"> Endpoint where the custom voice was deployed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SsmlSourceInternal(string ssmlText, string customVoiceEndpointId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SsmlText = ssmlText;
            CustomVoiceEndpointId = customVoiceEndpointId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SsmlSourceInternal"/> for deserialization. </summary>
        internal SsmlSourceInternal()
        {
        }

        /// <summary> Ssml string for the cognitive service to be played. </summary>
        public string SsmlText { get; }
        /// <summary> Endpoint where the custom voice was deployed. </summary>
        public string CustomVoiceEndpointId { get; set; }
    }
}
