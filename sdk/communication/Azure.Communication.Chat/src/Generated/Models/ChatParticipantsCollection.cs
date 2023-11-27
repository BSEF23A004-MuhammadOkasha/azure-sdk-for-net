// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> Collection of participants belong to a particular thread. </summary>
    internal partial class ChatParticipantsCollection
    {
        /// <summary> Initializes a new instance of <see cref="ChatParticipantsCollection"/>. </summary>
        /// <param name="value"> Chat participants. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ChatParticipantsCollection(IEnumerable<ChatParticipantInternal> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ChatParticipantsCollection"/>. </summary>
        /// <param name="value"> Chat participants. </param>
        /// <param name="nextLink"> If there are more chat participants that can be retrieved, the next link will be populated. </param>
        internal ChatParticipantsCollection(IReadOnlyList<ChatParticipantInternal> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Chat participants. </summary>
        public IReadOnlyList<ChatParticipantInternal> Value { get; }
        /// <summary> If there are more chat participants that can be retrieved, the next link will be populated. </summary>
        public string NextLink { get; }
    }
}
