// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> A wrap up of Conversation project response. </summary>
    public partial class ConversationTargetIntentResult : TargetIntentResult
    {
        /// <summary> Initializes a new instance of <see cref="ConversationTargetIntentResult"/>. </summary>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        internal ConversationTargetIntentResult(double confidence) : base(confidence)
        {
            TargetProjectKind = TargetProjectKind.Conversation;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationTargetIntentResult"/>. </summary>
        /// <param name="targetProjectKind"> This is the base class of an intent prediction. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="result"> The actual response from a Conversation project. </param>
        internal ConversationTargetIntentResult(TargetProjectKind targetProjectKind, string apiVersion, double confidence, IDictionary<string, BinaryData> serializedAdditionalRawData, ConversationResult result) : base(targetProjectKind, apiVersion, confidence, serializedAdditionalRawData)
        {
            Result = result;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationTargetIntentResult"/> for deserialization. </summary>
        internal ConversationTargetIntentResult()
        {
        }

        /// <summary> The actual response from a Conversation project. </summary>
        public ConversationResult Result { get; }
    }
}
