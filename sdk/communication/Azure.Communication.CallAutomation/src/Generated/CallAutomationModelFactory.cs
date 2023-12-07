// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Model factory for models. </summary>
    public static partial class CallAutomationModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="CallAutomation.TransferCallToParticipantResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallAutomation.TransferCallToParticipantResult"/> instance for mocking. </returns>
        public static TransferCallToParticipantResult TransferCallToParticipantResult(string operationContext = null)
        {
            return new TransferCallToParticipantResult(operationContext, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.SendDtmfTonesResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallAutomation.SendDtmfTonesResult"/> instance for mocking. </returns>
        public static SendDtmfTonesResult SendDtmfTonesResult(string operationContext = null)
        {
            return new SendDtmfTonesResult(operationContext, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.MuteParticipantResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallAutomation.MuteParticipantResult"/> instance for mocking. </returns>
        public static MuteParticipantResult MuteParticipantResult(string operationContext = null)
        {
            return new MuteParticipantResult(operationContext, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.UnmuteParticipantResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallAutomation.UnmuteParticipantResult"/> instance for mocking. </returns>
        public static UnmuteParticipantResult UnmuteParticipantResult(string operationContext = null)
        {
            return new UnmuteParticipantResult(operationContext, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.ResultInformation"/>. </summary>
        /// <param name="code"> Code of the current result. This can be helpful to Call Automation team to troubleshoot the issue if this result was unexpected. </param>
        /// <param name="subCode"> Subcode of the current result. This can be helpful to Call Automation team to troubleshoot the issue if this result was unexpected. </param>
        /// <param name="message"> Detail message that describes the current result. </param>
        /// <returns> A new <see cref="CallAutomation.ResultInformation"/> instance for mocking. </returns>
        public static ResultInformation ResultInformation(int? code = null, int? subCode = null, string message = null)
        {
            return new ResultInformation(code, subCode, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.CollectTonesResult"/>. </summary>
        /// <param name="tones"></param>
        /// <returns> A new <see cref="CallAutomation.CollectTonesResult"/> instance for mocking. </returns>
        public static CollectTonesResult CollectTonesResult(IEnumerable<DtmfTone> tones = null)
        {
            tones ??= new List<DtmfTone>();

            return new CollectTonesResult(tones?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.DtmfResult"/>. </summary>
        /// <param name="tones"></param>
        /// <returns> A new <see cref="CallAutomation.DtmfResult"/> instance for mocking. </returns>
        public static DtmfResult DtmfResult(IEnumerable<DtmfTone> tones = null)
        {
            tones ??= new List<DtmfTone>();

            return new DtmfResult(tones?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.SpeechResult"/>. </summary>
        /// <param name="speech"> The recognized speech in string. </param>
        /// <returns> A new <see cref="CallAutomation.SpeechResult"/> instance for mocking. </returns>
        public static SpeechResult SpeechResult(string speech = null)
        {
            return new SpeechResult(speech, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.ChoiceResult"/>. </summary>
        /// <param name="label"> Label is the primary identifier for the choice detected. </param>
        /// <param name="recognizedPhrase">
        /// Phrases are set to the value if choice is selected via phrase detection.
        /// If Dtmf input is recognized, then Label will be the identifier for the choice detected and phrases will be set to null
        /// </param>
        /// <returns> A new <see cref="CallAutomation.ChoiceResult"/> instance for mocking. </returns>
        public static ChoiceResult ChoiceResult(string label = null, string recognizedPhrase = null)
        {
            return new ChoiceResult(label, recognizedPhrase, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.UserConsent"/>. </summary>
        /// <param name="recording"></param>
        /// <returns> A new <see cref="CallAutomation.UserConsent"/> instance for mocking. </returns>
        public static UserConsent UserConsent(int? recording = null)
        {
            return new UserConsent(recording, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionStarted"/>. </summary>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="transcriptionUpdate"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionStarted"/> instance for mocking. </returns>
        public static TranscriptionStarted TranscriptionStarted(string operationContext = null, ResultInformation resultInformation = null, TranscriptionUpdate transcriptionUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null)
        {
            return new TranscriptionStarted(operationContext, resultInformation, transcriptionUpdate, callConnectionId, serverCallId, correlationId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionUpdate"/>. </summary>
        /// <param name="transcriptionStatus"></param>
        /// <param name="transcriptionStatusDetails"></param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionUpdate"/> instance for mocking. </returns>
        public static TranscriptionUpdate TranscriptionUpdate(TranscriptionStatus? transcriptionStatus = null, TranscriptionStatusDetails? transcriptionStatusDetails = null)
        {
            return new TranscriptionUpdate(transcriptionStatus, transcriptionStatusDetails, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionStopped"/>. </summary>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="transcriptionUpdate"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionStopped"/> instance for mocking. </returns>
        public static TranscriptionStopped TranscriptionStopped(string operationContext = null, ResultInformation resultInformation = null, TranscriptionUpdate transcriptionUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null)
        {
            return new TranscriptionStopped(operationContext, resultInformation, transcriptionUpdate, callConnectionId, serverCallId, correlationId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionResumed"/>. </summary>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="transcriptionUpdate"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionResumed"/> instance for mocking. </returns>
        public static TranscriptionResumed TranscriptionResumed(string operationContext = null, ResultInformation resultInformation = null, TranscriptionUpdate transcriptionUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null)
        {
            return new TranscriptionResumed(operationContext, resultInformation, transcriptionUpdate, callConnectionId, serverCallId, correlationId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionFailed"/>. </summary>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="transcriptionUpdate"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionFailed"/> instance for mocking. </returns>
        public static TranscriptionFailed TranscriptionFailed(string operationContext = null, ResultInformation resultInformation = null, TranscriptionUpdate transcriptionUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null)
        {
            return new TranscriptionFailed(operationContext, resultInformation, transcriptionUpdate, callConnectionId, serverCallId, correlationId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionUpdated"/>. </summary>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="transcriptionUpdate"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionUpdated"/> instance for mocking. </returns>
        public static TranscriptionUpdated TranscriptionUpdated(string operationContext = null, ResultInformation resultInformation = null, TranscriptionUpdate transcriptionUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null)
        {
            return new TranscriptionUpdated(operationContext, resultInformation, transcriptionUpdate, callConnectionId, serverCallId, correlationId, serializedAdditionalRawData: null);
        }
    }
}
