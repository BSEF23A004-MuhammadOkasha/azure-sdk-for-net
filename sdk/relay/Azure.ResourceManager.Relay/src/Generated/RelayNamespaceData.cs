// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary>
    /// A class representing the RelayNamespace data model.
    /// Description of a namespace resource.
    /// </summary>
    public partial class RelayNamespaceData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RelayNamespaceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public RelayNamespaceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<RelayPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="RelayNamespaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU of the namespace. </param>
        /// <param name="provisioningState"> Provisioning state of the Namespace. </param>
        /// <param name="status"> Status of the Namespace. </param>
        /// <param name="createdOn"> The time the namespace was created. </param>
        /// <param name="updatedOn"> The time the namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="publicNetworkAccess"> This determines if traffic is allowed over public network. By default it is enabled. DO NOT USE PublicNetworkAccess on Namespace API. Please use the NetworkRuleSet API to enable or disable PublicNetworkAccess. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RelayNamespaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, RelaySku sku, string provisioningState, string status, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string serviceBusEndpoint, string metricId, IList<RelayPrivateEndpointConnectionData> privateEndpointConnections, RelayPublicNetworkAccess? publicNetworkAccess, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            ProvisioningState = provisioningState;
            Status = status;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ServiceBusEndpoint = serviceBusEndpoint;
            MetricId = metricId;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RelayNamespaceData"/> for deserialization. </summary>
        internal RelayNamespaceData()
        {
        }

        /// <summary> SKU of the namespace. </summary>
        public RelaySku Sku { get; set; }
        /// <summary> Provisioning state of the Namespace. </summary>
        public string ProvisioningState { get; }
        /// <summary> Status of the Namespace. </summary>
        public string Status { get; }
        /// <summary> The time the namespace was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time the namespace was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Endpoint you can use to perform Service Bus operations. </summary>
        public string ServiceBusEndpoint { get; }
        /// <summary> Identifier for Azure Insights metrics. </summary>
        public string MetricId { get; }
        /// <summary> List of private endpoint connections. </summary>
        public IList<RelayPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
