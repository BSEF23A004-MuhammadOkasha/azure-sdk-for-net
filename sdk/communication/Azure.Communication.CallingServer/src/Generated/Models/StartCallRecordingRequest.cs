// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallingServer
{
    /// <summary> The request payload start for call recording operation with call locator. </summary>
    public partial class StartCallRecordingRequest
    {
        /// <summary> Initializes a new instance of StartCallRecordingRequest. </summary>
        /// <param name="callLocator"> The call locator. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callLocator"/> is null. </exception>
        public StartCallRecordingRequest(CallLocator callLocator)
        {
            if (callLocator == null)
            {
                throw new ArgumentNullException(nameof(callLocator));
            }

            CallLocator = callLocator;
        }

        /// <summary> The call locator. </summary>
        public CallLocator CallLocator { get; }
        /// <summary> The uri to send notifications to. </summary>
        public string RecordingStateCallbackUri { get; set; }
        /// <summary> The content type of call recording. </summary>
        public RecordingContentType? RecordingContentType { get; set; }
        /// <summary> The channel type of call recording. </summary>
        public RecordingChannelType? RecordingChannelType { get; set; }
        /// <summary> The format type of call recording. </summary>
        public RecordingFormatType? RecordingFormatType { get; set; }
    }
}
