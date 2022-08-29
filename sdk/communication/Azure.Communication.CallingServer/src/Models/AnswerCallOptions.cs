﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Communication.CallingServer
{
    /// <summary>
    /// The answer call operation options.
    /// </summary>
    public class AnswerCallOptions
    {
        /// <summary>
        /// Creates a new AnswerCallOptions object.
        /// </summary>
        /// <param name="incomingCallContext"></param>
        public AnswerCallOptions(string incomingCallContext)
        {
            IncomingCallContext = incomingCallContext;
        }

        /// <summary>
        /// The context associated with the call.
        /// </summary>
        public string IncomingCallContext { get; }

        /// <summary>
        /// The callback uri.
        /// </summary>
        public Uri CallbackEndpoint { get; set; }

        /// <summary>
        /// Media Streaming Configuration.
        /// </summary>
        public MediaStreamingConfiguration MediaStreamingConfiguration { get; set; }
    }
}
