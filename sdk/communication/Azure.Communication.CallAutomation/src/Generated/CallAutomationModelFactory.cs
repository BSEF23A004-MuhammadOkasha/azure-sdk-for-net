// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class CallAutomationModelFactory
    {
        /// <summary> Initializes a new instance of TransferCallToParticipantResult. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallAutomation.TransferCallToParticipantResult"/> instance for mocking. </returns>
        public static TransferCallToParticipantResult TransferCallToParticipantResult(string operationContext = null)
        {
            return new TransferCallToParticipantResult(operationContext);
        }

        /// <summary> Initializes a new instance of RemoveParticipantsResult. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallAutomation.RemoveParticipantsResult"/> instance for mocking. </returns>
        public static RemoveParticipantsResult RemoveParticipantsResult(string operationContext = null)
        {
            return new RemoveParticipantsResult(operationContext);
        }

        /// <summary> Initializes a new instance of RecordingStateResult. </summary>
        /// <param name="recordingId"></param>
        /// <param name="recordingState"></param>
        /// <returns> A new <see cref="CallAutomation.RecordingStateResult"/> instance for mocking. </returns>
        public static RecordingStateResult RecordingStateResult(string recordingId = null, RecordingState? recordingState = null)
        {
            return new RecordingStateResult(recordingId, recordingState);
        }

        /// <summary> Initializes a new instance of ResultInformation. </summary>
        /// <param name="code"></param>
        /// <param name="subCode"></param>
        /// <param name="message"></param>
        /// <returns> A new <see cref="CallAutomation.ResultInformation"/> instance for mocking. </returns>
        public static ResultInformation ResultInformation(int? code = null, int? subCode = null, string message = null)
        {
            return new ResultInformation(code, subCode, message);
        }

        /// <summary> Initializes a new instance of CallConnected. </summary>
        /// <param name="eventSource"></param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </param>
        /// <returns> A new <see cref="CallAutomation.CallConnected"/> instance for mocking. </returns>
        public static CallConnected CallConnected(string eventSource = null, string version = null, string operationContext = null, ResultInformation resultInformation = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string publicEventType = null)
        {
            return new CallConnected(eventSource, version, operationContext, resultInformation, callConnectionId, serverCallId, correlationId, publicEventType);
        }

        /// <summary> Initializes a new instance of CallDisconnected. </summary>
        /// <param name="eventSource"></param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </param>
        /// <returns> A new <see cref="CallAutomation.CallDisconnected"/> instance for mocking. </returns>
        public static CallDisconnected CallDisconnected(string eventSource = null, string version = null, string operationContext = null, ResultInformation resultInformation = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string publicEventType = null)
        {
            return new CallDisconnected(eventSource, version, operationContext, resultInformation, callConnectionId, serverCallId, correlationId, publicEventType);
        }

        /// <summary> Initializes a new instance of CallTransferAccepted. </summary>
        /// <param name="eventSource"></param>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"></param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </param>
        /// <returns> A new <see cref="CallAutomation.CallTransferAccepted"/> instance for mocking. </returns>
        public static CallTransferAccepted CallTransferAccepted(string eventSource = null, string operationContext = null, ResultInformation resultInformation = null, string version = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string publicEventType = null)
        {
            return new CallTransferAccepted(eventSource, operationContext, resultInformation, version, callConnectionId, serverCallId, correlationId, publicEventType);
        }

        /// <summary> Initializes a new instance of CallTransferFailed. </summary>
        /// <param name="eventSource"></param>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"></param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </param>
        /// <returns> A new <see cref="CallAutomation.CallTransferFailed"/> instance for mocking. </returns>
        public static CallTransferFailed CallTransferFailed(string eventSource = null, string operationContext = null, ResultInformation resultInformation = null, string version = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string publicEventType = null)
        {
            return new CallTransferFailed(eventSource, operationContext, resultInformation, version, callConnectionId, serverCallId, correlationId, publicEventType);
        }

        /// <summary> Initializes a new instance of CallRecordingStateChanged. </summary>
        /// <param name="eventSource"></param>
        /// <param name="recordingId"> The call recording id. </param>
        /// <param name="state"></param>
        /// <param name="startDateTime"> The time of the recording started. </param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </param>
        /// <returns> A new <see cref="CallAutomation.CallRecordingStateChanged"/> instance for mocking. </returns>
        public static CallRecordingStateChanged CallRecordingStateChanged(string eventSource = null, string recordingId = null, RecordingState state = default, DateTimeOffset? startDateTime = null, string version = null, string operationContext = null, ResultInformation resultInformation = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string publicEventType = null)
        {
            return new CallRecordingStateChanged(eventSource, recordingId, state, startDateTime, version, operationContext, resultInformation, callConnectionId, serverCallId, correlationId, publicEventType);
        }

        /// <summary> Initializes a new instance of PlayCompleted. </summary>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"></param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </param>
        /// <returns> A new <see cref="CallAutomation.PlayCompleted"/> instance for mocking. </returns>
        public static PlayCompleted PlayCompleted(string operationContext = null, ResultInformation resultInformation = null, string version = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string publicEventType = null)
        {
            return new PlayCompleted(operationContext, resultInformation, version, callConnectionId, serverCallId, correlationId, publicEventType);
        }

        /// <summary> Initializes a new instance of PlayFailed. </summary>
        /// <param name="eventSource"></param>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"></param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </param>
        /// <returns> A new <see cref="CallAutomation.PlayFailed"/> instance for mocking. </returns>
        public static PlayFailed PlayFailed(string eventSource = null, string operationContext = null, ResultInformation resultInformation = null, string version = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string publicEventType = null)
        {
            return new PlayFailed(eventSource, operationContext, resultInformation, version, callConnectionId, serverCallId, correlationId, publicEventType);
        }

        /// <summary> Initializes a new instance of RecognizeCompleted. </summary>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"> Result information defines the code, subcode and message. </param>
        /// <param name="recognitionType">
        /// Determines the sub-type of the recognize operation.
        /// In case of cancel operation the this field is not set and is returned empty
        /// </param>
        /// <param name="collectTonesResult"> Defines the result for RecognitionType = Dtmf. </param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </param>
        /// <returns> A new <see cref="CallAutomation.RecognizeCompleted"/> instance for mocking. </returns>
        public static RecognizeCompleted RecognizeCompleted(string operationContext = null, ResultInformation resultInformation = null, CallMediaRecognitionType recognitionType = default, CollectTonesResult collectTonesResult = null, string version = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string publicEventType = null)
        {
            return new RecognizeCompleted(operationContext, resultInformation, recognitionType, collectTonesResult, version, callConnectionId, serverCallId, correlationId, publicEventType);
        }

        /// <summary> Initializes a new instance of CollectTonesResult. </summary>
        /// <param name="tones"></param>
        /// <returns> A new <see cref="CallAutomation.CollectTonesResult"/> instance for mocking. </returns>
        public static CollectTonesResult CollectTonesResult(IEnumerable<DtmfTone> tones = null)
        {
            tones ??= new List<DtmfTone>();

            return new CollectTonesResult(tones?.ToList());
        }
    }
}
