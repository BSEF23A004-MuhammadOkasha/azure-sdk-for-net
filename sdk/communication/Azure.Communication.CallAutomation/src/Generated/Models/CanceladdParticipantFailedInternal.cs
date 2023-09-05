// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> Failed cancel add participant event. </summary>
    internal partial class CanceladdParticipantFailedInternal
    {
        /// <summary> Initializes a new instance of CanceladdParticipantFailedInternal. </summary>
        internal CanceladdParticipantFailedInternal()
        {
        }

        /// <summary> Initializes a new instance of CanceladdParticipantFailedInternal. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="invitiationId"> Invitation ID used to cancel the request. </param>
        internal CanceladdParticipantFailedInternal(string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation, string invitiationId)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            InvitiationId = invitiationId;
        }

        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code/sub-code and message from NGC services. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Invitation ID used to cancel the request. </summary>
        public string InvitiationId { get; }
    }
}
