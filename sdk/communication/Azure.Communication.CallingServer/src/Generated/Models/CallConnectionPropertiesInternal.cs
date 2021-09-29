// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The CallConnectionProperties. </summary>
    internal partial class CallConnectionPropertiesInternal
    {
        /// <summary> Initializes a new instance of CallConnectionPropertiesInternal. </summary>
        internal CallConnectionPropertiesInternal()
        {
            Targets = new ChangeTrackingList<CommunicationIdentifierModel>();
            RequestedMediaTypes = new ChangeTrackingList<MediaType>();
            RequestedCallEvents = new ChangeTrackingList<EventSubscriptionType>();
        }

        /// <summary> Initializes a new instance of CallConnectionPropertiesInternal. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="source"> The source of the call. </param>
        /// <param name="alternateCallerId"> The alternate identity of the source of the call if dialing out to a pstn number. </param>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="callConnectionState"> The state of the call connection. </param>
        /// <param name="subject"> The subject. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="requestedMediaTypes"> The requested modalities. </param>
        /// <param name="requestedCallEvents"> The requested call events to subscribe to. </param>
        /// <param name="callLocator"> The call locator. </param>
        internal CallConnectionPropertiesInternal(string callConnectionId, CommunicationIdentifierModel source, PhoneNumberIdentifierModel alternateCallerId, IReadOnlyList<CommunicationIdentifierModel> targets, CallConnectionState? callConnectionState, string subject, string callbackUri, IReadOnlyList<MediaType> requestedMediaTypes, IReadOnlyList<EventSubscriptionType> requestedCallEvents, CallLocatorModel callLocator)
        {
            CallConnectionId = callConnectionId;
            Source = source;
            AlternateCallerId = alternateCallerId;
            Targets = targets;
            CallConnectionState = callConnectionState;
            Subject = subject;
            CallbackUri = callbackUri;
            RequestedMediaTypes = requestedMediaTypes;
            RequestedCallEvents = requestedCallEvents;
            CallLocator = callLocator;
        }

        /// <summary> The call connection id. </summary>
        public string CallConnectionId { get; }
        /// <summary> The source of the call. </summary>
        public CommunicationIdentifierModel Source { get; }
        /// <summary> The alternate identity of the source of the call if dialing out to a pstn number. </summary>
        public PhoneNumberIdentifierModel AlternateCallerId { get; }
        /// <summary> The targets of the call. </summary>
        public IReadOnlyList<CommunicationIdentifierModel> Targets { get; }
        /// <summary> The state of the call connection. </summary>
        public CallConnectionState? CallConnectionState { get; }
        /// <summary> The subject. </summary>
        public string Subject { get; }
        /// <summary> The callback URI. </summary>
        public string CallbackUri { get; }
        /// <summary> The requested modalities. </summary>
        public IReadOnlyList<MediaType> RequestedMediaTypes { get; }
        /// <summary> The requested call events to subscribe to. </summary>
        public IReadOnlyList<EventSubscriptionType> RequestedCallEvents { get; }
        /// <summary> The call locator. </summary>
        public CallLocatorModel CallLocator { get; }
    }
}
