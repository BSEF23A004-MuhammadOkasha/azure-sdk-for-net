// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    /// <summary> Encoder connection rejected event data. </summary>
    public partial class MediaLiveEventConnectionRejectedEventData
    {
        /// <summary> Initializes a new instance of MediaLiveEventConnectionRejectedEventData. </summary>
        internal MediaLiveEventConnectionRejectedEventData()
        {
        }

        /// <summary> Initializes a new instance of MediaLiveEventConnectionRejectedEventData. </summary>
        /// <param name="ingestUrl"> Gets the ingest URL provided by the live event. </param>
        /// <param name="streamId"> Gets the stream Id. </param>
        /// <param name="encoderIp"> Gets the remote IP. </param>
        /// <param name="encoderPort"> Gets the remote port. </param>
        /// <param name="resultCode"> Gets the result code. </param>
        internal MediaLiveEventConnectionRejectedEventData(string ingestUrl, string streamId, string encoderIp, string encoderPort, string resultCode)
        {
            IngestUrl = ingestUrl;
            StreamId = streamId;
            EncoderIp = encoderIp;
            EncoderPort = encoderPort;
            ResultCode = resultCode;
        }

        /// <summary> Gets the ingest URL provided by the live event. </summary>
        public string IngestUrl { get; }
        /// <summary> Gets the stream Id. </summary>
        public string StreamId { get; }
        /// <summary> Gets the remote IP. </summary>
        public string EncoderIp { get; }
        /// <summary> Gets the remote port. </summary>
        public string EncoderPort { get; }
        /// <summary> Gets the result code. </summary>
        public string ResultCode { get; }
    }
}
