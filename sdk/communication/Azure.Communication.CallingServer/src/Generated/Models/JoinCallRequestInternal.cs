// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The request payload for join call. </summary>
    internal partial class JoinCallRequestInternal
    {
        /// <summary> Initializes a new instance of JoinCallRequestInternal. </summary>
        /// <param name="callLocator"> The call locator. </param>
        /// <param name="source"> The source of the call. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callLocator"/>, <paramref name="source"/>, or <paramref name="callbackUri"/> is null. </exception>
        public JoinCallRequestInternal(CallLocatorModel callLocator, CommunicationIdentifierModel source, string callbackUri)
        {
            if (callLocator == null)
            {
                throw new ArgumentNullException(nameof(callLocator));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (callbackUri == null)
            {
                throw new ArgumentNullException(nameof(callbackUri));
            }

            CallLocator = callLocator;
            Source = source;
            CallbackUri = callbackUri;
            RequestedMediaTypes = new ChangeTrackingList<CallMediaType>();
            RequestedCallEvents = new ChangeTrackingList<CallingEventSubscriptionType>();
        }

        /// <summary> The call locator. </summary>
        public CallLocatorModel CallLocator { get; }
        /// <summary> The source of the call. </summary>
        public CommunicationIdentifierModel Source { get; }
        /// <summary> The subject. </summary>
        public string Subject { get; set; }
        /// <summary> The callback URI. </summary>
        public string CallbackUri { get; }
        /// <summary> The requested modalities. </summary>
        public IList<CallMediaType> RequestedMediaTypes { get; }
        /// <summary> The requested call events to subscribe to. </summary>
        public IList<CallingEventSubscriptionType> RequestedCallEvents { get; }
    }
}
