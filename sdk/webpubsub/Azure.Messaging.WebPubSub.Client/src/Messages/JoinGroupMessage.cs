﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Messaging.WebPubSub.Clients
{
    /// <summary>
    /// The message representing joining group.
    /// </summary>
    public class JoinGroupMessage : WebPubSubMessage
    {
        /// <summary>
        /// The group name.
        /// </summary>
        public string Group { get; }

        /// <summary>
        /// The optional ack-id
        /// </summary>
        public long? AckId { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinGroupMessage"/> class.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <param name="ackId">The optional ack-id</param>
        public JoinGroupMessage(string group, long? ackId)
        {
            Group = group;
            AckId = ackId;
        }
    }
}
