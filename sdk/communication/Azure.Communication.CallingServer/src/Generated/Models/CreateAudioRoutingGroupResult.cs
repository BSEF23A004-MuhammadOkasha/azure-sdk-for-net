// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The response payload of the create audio routing group operation. </summary>
    public partial class CreateAudioRoutingGroupResult
    {
        /// <summary> Initializes a new instance of CreateAudioRoutingGroupResult. </summary>
        internal CreateAudioRoutingGroupResult()
        {
        }

        /// <summary> Initializes a new instance of CreateAudioRoutingGroupResult. </summary>
        /// <param name="audioRoutingGroupId"> The audio routing group id. </param>
        internal CreateAudioRoutingGroupResult(string audioRoutingGroupId)
        {
            AudioRoutingGroupId = audioRoutingGroupId;
        }

        /// <summary> The audio routing group id. </summary>
        public string AudioRoutingGroupId { get; }
    }
}
