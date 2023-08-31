// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the NamespaceTopicEventSubscription data model.
    /// Event Subscription.
    /// </summary>
    public partial class NamespaceTopicEventSubscriptionData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NamespaceTopicEventSubscriptionData"/>. </summary>
        public NamespaceTopicEventSubscriptionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NamespaceTopicEventSubscriptionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the event subscription. </param>
        /// <param name="deliveryConfiguration"> Information about the delivery configuration of the event subscription. </param>
        /// <param name="eventDeliverySchema"> The event delivery schema for the event subscription. </param>
        /// <param name="filtersConfiguration"> Information about the filter for the event subscription. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NamespaceTopicEventSubscriptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SubscriptionProvisioningState? provisioningState, DeliveryConfiguration deliveryConfiguration, DeliverySchema? eventDeliverySchema, FiltersConfiguration filtersConfiguration, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            DeliveryConfiguration = deliveryConfiguration;
            EventDeliverySchema = eventDeliverySchema;
            FiltersConfiguration = filtersConfiguration;
            _rawData = rawData;
        }

        /// <summary> Provisioning state of the event subscription. </summary>
        public SubscriptionProvisioningState? ProvisioningState { get; }
        /// <summary> Information about the delivery configuration of the event subscription. </summary>
        public DeliveryConfiguration DeliveryConfiguration { get; set; }
        /// <summary> The event delivery schema for the event subscription. </summary>
        public DeliverySchema? EventDeliverySchema { get; set; }
        /// <summary> Information about the filter for the event subscription. </summary>
        public FiltersConfiguration FiltersConfiguration { get; set; }
    }
}
