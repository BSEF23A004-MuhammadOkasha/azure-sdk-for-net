// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Router Communication Error. </summary>
    internal partial class AcsRouterCommunicationError
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

        /// <summary> Initializes a new instance of <see cref="AcsRouterCommunicationError"/>. </summary>
        internal AcsRouterCommunicationError()
        {
            Details = new ChangeTrackingList<AcsRouterCommunicationError>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterCommunicationError"/>. </summary>
        /// <param name="code"> Router Communication Error Code. </param>
        /// <param name="message"> Router Communication Error Message. </param>
        /// <param name="target"> Router Communication Error Target. </param>
        /// <param name="innererror"> Router Communication Inner Error. </param>
        /// <param name="details"> List of Router Communication Errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsRouterCommunicationError(string code, string message, string target, AcsRouterCommunicationError innererror, IReadOnlyList<AcsRouterCommunicationError> details, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Target = target;
            Innererror = innererror;
            Details = details;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Router Communication Error Code. </summary>
        public string Code { get; }
        /// <summary> Router Communication Error Message. </summary>
        public string Message { get; }
        /// <summary> Router Communication Error Target. </summary>
        public string Target { get; }
        /// <summary> Router Communication Inner Error. </summary>
        public AcsRouterCommunicationError Innererror { get; }
        /// <summary> List of Router Communication Errors. </summary>
        public IReadOnlyList<AcsRouterCommunicationError> Details { get; }
    }
}
