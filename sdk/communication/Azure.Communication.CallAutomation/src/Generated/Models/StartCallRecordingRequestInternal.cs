// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload start for call recording operation with call locator. </summary>
    internal partial class StartCallRecordingRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="StartCallRecordingRequestInternal"/>. </summary>
        /// <param name="callLocator"> The call locator. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callLocator"/> is null. </exception>
        public StartCallRecordingRequestInternal(CallLocatorInternal callLocator)
        {
            Argument.AssertNotNull(callLocator, nameof(callLocator));

            CallLocator = callLocator;
            AudioChannelParticipantOrdering = new ChangeTrackingList<CommunicationIdentifierModel>();
            ChannelAffinity = new ChangeTrackingList<ChannelAffinityInternal>();
        }

        /// <summary> Initializes a new instance of <see cref="StartCallRecordingRequestInternal"/>. </summary>
        /// <param name="callLocator"> The call locator. </param>
        /// <param name="recordingStateCallbackUri"> The uri to send notifications to. </param>
        /// <param name="recordingContentType"> The content type of call recording. </param>
        /// <param name="recordingChannelType"> The channel type of call recording. </param>
        /// <param name="recordingFormatType"> The format type of call recording. </param>
        /// <param name="audioChannelParticipantOrdering">
        /// The sequential order in which audio channels are assigned to participants in the unmixed recording.
        /// When 'recordingChannelType' is set to 'unmixed' and `audioChannelParticipantOrdering is not specified,
        /// the audio channel to participant mapping will be automatically assigned based on the order in which participant
        /// first audio was detected.  Channel to participant mapping details can be found in the metadata of the recording.
        /// </param>
        /// <param name="channelAffinity">
        /// The channel affinity of call recording
        /// When 'recordingChannelType' is set to 'unmixed', if channelAffinity is not specified, 'channel' will be automatically assigned.
        /// Channel-Participant mapping details can be found in the metadata of the recording.
        /// ///
        /// </param>
        /// <param name="externalStorage"> Optional property to specify location where recording will be stored. </param>
        /// <param name="pauseOnStart"> When set to true will start recording in Pause mode, which could be resumed. </param>
        internal StartCallRecordingRequestInternal(CallLocatorInternal callLocator, string recordingStateCallbackUri, RecordingContent? recordingContentType, RecordingChannel? recordingChannelType, RecordingFormat? recordingFormatType, IList<CommunicationIdentifierModel> audioChannelParticipantOrdering, IList<ChannelAffinityInternal> channelAffinity, ExternalStorageInternal externalStorage, bool? pauseOnStart)
        {
            CallLocator = callLocator;
            RecordingStateCallbackUri = recordingStateCallbackUri;
            RecordingContentType = recordingContentType;
            RecordingChannelType = recordingChannelType;
            RecordingFormatType = recordingFormatType;
            AudioChannelParticipantOrdering = audioChannelParticipantOrdering;
            ChannelAffinity = channelAffinity;
            ExternalStorage = externalStorage;
            PauseOnStart = pauseOnStart;
        }

        /// <summary> The call locator. </summary>
        public CallLocatorInternal CallLocator { get; }
        /// <summary> The uri to send notifications to. </summary>
        public string RecordingStateCallbackUri { get; set; }
        /// <summary> The content type of call recording. </summary>
        public RecordingContent? RecordingContentType { get; set; }
        /// <summary> The channel type of call recording. </summary>
        public RecordingChannel? RecordingChannelType { get; set; }
        /// <summary> The format type of call recording. </summary>
        public RecordingFormat? RecordingFormatType { get; set; }
        /// <summary>
        /// The sequential order in which audio channels are assigned to participants in the unmixed recording.
        /// When 'recordingChannelType' is set to 'unmixed' and `audioChannelParticipantOrdering is not specified,
        /// the audio channel to participant mapping will be automatically assigned based on the order in which participant
        /// first audio was detected.  Channel to participant mapping details can be found in the metadata of the recording.
        /// </summary>
        public IList<CommunicationIdentifierModel> AudioChannelParticipantOrdering { get; }
        /// <summary>
        /// The channel affinity of call recording
        /// When 'recordingChannelType' is set to 'unmixed', if channelAffinity is not specified, 'channel' will be automatically assigned.
        /// Channel-Participant mapping details can be found in the metadata of the recording.
        /// ///
        /// </summary>
        public IList<ChannelAffinityInternal> ChannelAffinity { get; }
        /// <summary> Optional property to specify location where recording will be stored. </summary>
        public ExternalStorageInternal ExternalStorage { get; set; }
        /// <summary> When set to true will start recording in Pause mode, which could be resumed. </summary>
        public bool? PauseOnStart { get; set; }
    }
}
