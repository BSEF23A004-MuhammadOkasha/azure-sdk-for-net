// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List EventSubscriptions operation. </summary>
    internal partial class EventSubscriptionsListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventSubscriptionsListResult"/>. </summary>
        internal EventSubscriptionsListResult()
        {
            Value = new ChangeTrackingList<EventGridSubscriptionData>();
        }

        /// <summary> Initializes a new instance of <see cref="EventSubscriptionsListResult"/>. </summary>
        /// <param name="value"> A collection of EventSubscriptions. </param>
        /// <param name="nextLink"> A link for the next page of event subscriptions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventSubscriptionsListResult(IReadOnlyList<EventGridSubscriptionData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A collection of EventSubscriptions. </summary>
        public IReadOnlyList<EventGridSubscriptionData> Value { get; }
        /// <summary> A link for the next page of event subscriptions. </summary>
        public string NextLink { get; }
    }
}
