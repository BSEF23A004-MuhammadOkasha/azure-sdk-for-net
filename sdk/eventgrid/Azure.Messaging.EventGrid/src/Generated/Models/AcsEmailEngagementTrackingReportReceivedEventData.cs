// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.EmailEngagementTrackingReportReceived event. </summary>
    public partial class AcsEmailEngagementTrackingReportReceivedEventData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AcsEmailEngagementTrackingReportReceivedEventData"/>. </summary>
        internal AcsEmailEngagementTrackingReportReceivedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsEmailEngagementTrackingReportReceivedEventData"/>. </summary>
        /// <param name="sender"> The Sender Email Address. </param>
        /// <param name="messageId"> The Id of the email that has been sent. </param>
        /// <param name="userActionTimestamp"> The time at which the user interacted with the email. </param>
        /// <param name="engagementContext"> The context of the type of engagement user had with email. </param>
        /// <param name="userAgent"> The user agent interacting with the email. </param>
        /// <param name="engagement"> The type of engagement user have with email. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsEmailEngagementTrackingReportReceivedEventData(string sender, string messageId, DateTimeOffset? userActionTimestamp, string engagementContext, string userAgent, AcsUserEngagement? engagement, Dictionary<string, BinaryData> rawData)
        {
            Sender = sender;
            MessageId = messageId;
            UserActionTimestamp = userActionTimestamp;
            EngagementContext = engagementContext;
            UserAgent = userAgent;
            Engagement = engagement;
            _rawData = rawData;
        }

        /// <summary> The Sender Email Address. </summary>
        public string Sender { get; }
        /// <summary> The Id of the email that has been sent. </summary>
        public string MessageId { get; }
        /// <summary> The time at which the user interacted with the email. </summary>
        public DateTimeOffset? UserActionTimestamp { get; }
        /// <summary> The context of the type of engagement user had with email. </summary>
        public string EngagementContext { get; }
        /// <summary> The user agent interacting with the email. </summary>
        public string UserAgent { get; }
        /// <summary> The type of engagement user have with email. </summary>
        public AcsUserEngagement? Engagement { get; }
    }
}
