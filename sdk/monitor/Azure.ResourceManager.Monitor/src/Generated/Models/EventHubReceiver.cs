// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> An Event hub receiver. </summary>
    public partial class EventHubReceiver
    {
        /// <summary> Initializes a new instance of EventHubReceiver. </summary>
        /// <param name="name"> The name of the Event hub receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="eventHubNameSpace"> The Event Hub namespace. </param>
        /// <param name="eventHubName"> The name of the specific Event Hub queue. </param>
        /// <param name="subscriptionId"> The Id for the subscription containing this event hub. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="eventHubNameSpace"/>, <paramref name="eventHubName"/> or <paramref name="subscriptionId"/> is null. </exception>
        public EventHubReceiver(string name, string eventHubNameSpace, string eventHubName, string subscriptionId)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (eventHubNameSpace == null)
            {
                throw new ArgumentNullException(nameof(eventHubNameSpace));
            }
            if (eventHubName == null)
            {
                throw new ArgumentNullException(nameof(eventHubName));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            Name = name;
            EventHubNameSpace = eventHubNameSpace;
            EventHubName = eventHubName;
            SubscriptionId = subscriptionId;
        }

        /// <summary> Initializes a new instance of EventHubReceiver. </summary>
        /// <param name="name"> The name of the Event hub receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="eventHubNameSpace"> The Event Hub namespace. </param>
        /// <param name="eventHubName"> The name of the specific Event Hub queue. </param>
        /// <param name="useCommonAlertSchema"> Indicates whether to use common alert schema. </param>
        /// <param name="tenantId"> The tenant Id for the subscription containing this event hub. </param>
        /// <param name="subscriptionId"> The Id for the subscription containing this event hub. </param>
        internal EventHubReceiver(string name, string eventHubNameSpace, string eventHubName, bool? useCommonAlertSchema, string tenantId, string subscriptionId)
        {
            Name = name;
            EventHubNameSpace = eventHubNameSpace;
            EventHubName = eventHubName;
            UseCommonAlertSchema = useCommonAlertSchema;
            TenantId = tenantId;
            SubscriptionId = subscriptionId;
        }

        /// <summary> The name of the Event hub receiver. Names must be unique across all receivers within an action group. </summary>
        public string Name { get; set; }
        /// <summary> The Event Hub namespace. </summary>
        public string EventHubNameSpace { get; set; }
        /// <summary> The name of the specific Event Hub queue. </summary>
        public string EventHubName { get; set; }
        /// <summary> Indicates whether to use common alert schema. </summary>
        public bool? UseCommonAlertSchema { get; set; }
        /// <summary> The tenant Id for the subscription containing this event hub. </summary>
        public string TenantId { get; set; }
        /// <summary> The Id for the subscription containing this event hub. </summary>
        public string SubscriptionId { get; set; }
    }
}
