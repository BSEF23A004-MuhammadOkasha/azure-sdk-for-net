// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing the EventHubNamespace data model. </summary>
    public partial class EventHubNamespaceData : TrackedResource
    {
        /// <summary> Initializes a new instance of EventHubNamespaceData. </summary>
        /// <param name="location"> The location. </param>
        public EventHubNamespaceData(Location location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of EventHubNamespaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of sku resource. </param>
        /// <param name="identity"> Properties of BYOK Identity description. </param>
        /// <param name="systemData"> The system meta data relating to this resource. </param>
        /// <param name="provisioningState"> Provisioning state of the Namespace. </param>
        /// <param name="status"> Status of the Namespace. </param>
        /// <param name="createdAt"> The time the Namespace was created. </param>
        /// <param name="updatedAt"> The time the Namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="clusterArmId"> Cluster ARM ID of the Namespace. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="isAutoInflateEnabled"> Value that indicates whether AutoInflate is enabled for eventhub namespace. </param>
        /// <param name="maximumThroughputUnits"> Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( &apos;0&apos; if AutoInflateEnabled = true). </param>
        /// <param name="kafkaEnabled"> Value that indicates whether Kafka is enabled for eventhub namespace. </param>
        /// <param name="zoneRedundant"> Enabling this property creates a Standard Event Hubs Namespace in regions supported availability zones. </param>
        /// <param name="encryption"> Properties of BYOK Encryption description. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="disableLocalAuth"> This property disables SAS authentication for the Event Hubs namespace. </param>
        /// <param name="alternateName"> Alternate name specified when alias and namespace names are same. </param>
        internal EventHubNamespaceData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, Models.Sku sku, Identity identity, SystemData systemData, string provisioningState, string status, DateTimeOffset? createdAt, DateTimeOffset? updatedAt, string serviceBusEndpoint, string clusterArmId, string metricId, bool? isAutoInflateEnabled, int? maximumThroughputUnits, bool? kafkaEnabled, bool? zoneRedundant, Encryption encryption, IList<PrivateEndpointConnectionData> privateEndpointConnections, bool? disableLocalAuth, string alternateName) : base(id, name, type, tags, location)
        {
            Sku = sku;
            Identity = identity;
            SystemData = systemData;
            ProvisioningState = provisioningState;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ServiceBusEndpoint = serviceBusEndpoint;
            ClusterArmId = clusterArmId;
            MetricId = metricId;
            IsAutoInflateEnabled = isAutoInflateEnabled;
            MaximumThroughputUnits = maximumThroughputUnits;
            KafkaEnabled = kafkaEnabled;
            ZoneRedundant = zoneRedundant;
            Encryption = encryption;
            PrivateEndpointConnections = privateEndpointConnections;
            DisableLocalAuth = disableLocalAuth;
            AlternateName = alternateName;
        }

        /// <summary> Properties of sku resource. </summary>
        public Models.Sku Sku { get; set; }
        /// <summary> Properties of BYOK Identity description. </summary>
        public Identity Identity { get; set; }
        /// <summary> The system meta data relating to this resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> Provisioning state of the Namespace. </summary>
        public string ProvisioningState { get; }
        /// <summary> Status of the Namespace. </summary>
        public string Status { get; }
        /// <summary> The time the Namespace was created. </summary>
        public DateTimeOffset? CreatedAt { get; }
        /// <summary> The time the Namespace was updated. </summary>
        public DateTimeOffset? UpdatedAt { get; }
        /// <summary> Endpoint you can use to perform Service Bus operations. </summary>
        public string ServiceBusEndpoint { get; }
        /// <summary> Cluster ARM ID of the Namespace. </summary>
        public string ClusterArmId { get; set; }
        /// <summary> Identifier for Azure Insights metrics. </summary>
        public string MetricId { get; }
        /// <summary> Value that indicates whether AutoInflate is enabled for eventhub namespace. </summary>
        public bool? IsAutoInflateEnabled { get; set; }
        /// <summary> Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( &apos;0&apos; if AutoInflateEnabled = true). </summary>
        public int? MaximumThroughputUnits { get; set; }
        /// <summary> Value that indicates whether Kafka is enabled for eventhub namespace. </summary>
        public bool? KafkaEnabled { get; set; }
        /// <summary> Enabling this property creates a Standard Event Hubs Namespace in regions supported availability zones. </summary>
        public bool? ZoneRedundant { get; set; }
        /// <summary> Properties of BYOK Encryption description. </summary>
        public Encryption Encryption { get; set; }
        /// <summary> List of private endpoint connections. </summary>
        public IList<PrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> This property disables SAS authentication for the Event Hubs namespace. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> Alternate name specified when alias and namespace names are same. </summary>
        public string AlternateName { get; set; }
    }
}
