// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Network Security Perimeter related configurations of a given namespace. </summary>
    public partial class EventHubsNetworkSecurityPerimeterConfiguration : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfiguration"/>. </summary>
        /// <param name="location"> The location. </param>
        public EventHubsNetworkSecurityPerimeterConfiguration(AzureLocation location) : base(location)
        {
            ProvisioningIssues = new ChangeTrackingList<EventHubsProvisioningIssue>();
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfiguration"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of NetworkSecurityPerimeter configuration propagation. </param>
        /// <param name="provisioningIssues"> List of Provisioning Issues if any. </param>
        /// <param name="networkSecurityPerimeter"> NetworkSecurityPerimeter related information. </param>
        /// <param name="resourceAssociation"> Information about resource association. </param>
        /// <param name="profile"> Information about current network profile. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsNetworkSecurityPerimeterConfiguration(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, EventHubsNetworkSecurityPerimeterConfigurationProvisioningState? provisioningState, IList<EventHubsProvisioningIssue> provisioningIssues, EventHubsNetworkSecurityPerimeter networkSecurityPerimeter, EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation resourceAssociation, EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile profile, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            ProvisioningIssues = provisioningIssues;
            NetworkSecurityPerimeter = networkSecurityPerimeter;
            ResourceAssociation = resourceAssociation;
            Profile = profile;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfiguration"/> for deserialization. </summary>
        internal EventHubsNetworkSecurityPerimeterConfiguration()
        {
        }

        /// <summary> Provisioning state of NetworkSecurityPerimeter configuration propagation. </summary>
        public EventHubsNetworkSecurityPerimeterConfigurationProvisioningState? ProvisioningState { get; set; }
        /// <summary> List of Provisioning Issues if any. </summary>
        public IList<EventHubsProvisioningIssue> ProvisioningIssues { get; }
        /// <summary> NetworkSecurityPerimeter related information. </summary>
        public EventHubsNetworkSecurityPerimeter NetworkSecurityPerimeter { get; }
        /// <summary> Information about resource association. </summary>
        public EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation ResourceAssociation { get; }
        /// <summary> Information about current network profile. </summary>
        public EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile Profile { get; }
    }
}
