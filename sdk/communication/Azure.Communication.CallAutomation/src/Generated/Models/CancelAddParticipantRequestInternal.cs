// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Request payload for cancelling add participant request. </summary>
    internal partial class CancelAddParticipantRequestInternal
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

        /// <summary> Initializes a new instance of <see cref="CancelAddParticipantRequestInternal"/>. </summary>
        /// <param name="invitationId"> Invitation ID used to add a participant. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationId"/> is null. </exception>
        public CancelAddParticipantRequestInternal(string invitationId)
        {
            Argument.AssertNotNull(invitationId, nameof(invitationId));

            InvitationId = invitationId;
        }

        /// <summary> Initializes a new instance of <see cref="CancelAddParticipantRequestInternal"/>. </summary>
        /// <param name="invitationId"> Invitation ID used to add a participant. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="operationCallbackUri">
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CancelAddParticipantRequestInternal(string invitationId, string operationContext, string operationCallbackUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InvitationId = invitationId;
            OperationContext = operationContext;
            OperationCallbackUri = operationCallbackUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CancelAddParticipantRequestInternal"/> for deserialization. </summary>
        internal CancelAddParticipantRequestInternal()
        {
        }

        /// <summary> Invitation ID used to add a participant. </summary>
        public string InvitationId { get; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; set; }
        /// <summary>
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </summary>
        public string OperationCallbackUri { get; set; }
    }
}
