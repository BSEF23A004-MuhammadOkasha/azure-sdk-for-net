// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The audio routing group request. </summary>
    internal partial class AudioRoutingGroupRequestInternal
    {
        /// <summary> Initializes a new instance of AudioRoutingGroupRequestInternal. </summary>
        public AudioRoutingGroupRequestInternal()
        {
            Targets = new ChangeTrackingList<CommunicationIdentifierModel>();
        }

        /// <summary> The audio routing mode. </summary>
        public AudioRoutingMode? AudioRoutingMode { get; set; }
        /// <summary> The target identities that would be receivers in the audio routing group. </summary>
        public IList<CommunicationIdentifierModel> Targets { get; }
    }
}
