// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing the ServiceBusAuthorizationRule data model.
    /// Description of a namespace authorization rule.
    /// </summary>
    public partial class ServiceBusAuthorizationRuleData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceBusAuthorizationRuleData"/>. </summary>
        public ServiceBusAuthorizationRuleData()
        {
            Rights = new ChangeTrackingList<ServiceBusAccessRight>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBusAuthorizationRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="rights"> The rights associated with the rule. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceBusAuthorizationRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<ServiceBusAccessRight> rights, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Rights = rights;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The rights associated with the rule. </summary>
        public IList<ServiceBusAccessRight> Rights { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
