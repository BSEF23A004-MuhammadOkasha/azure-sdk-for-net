// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Message envelope that contains the common Azure resource manager properties and the resource provider specific content.
    /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection
    /// </summary>
    public partial class ResponseMessageEnvelopeRemotePrivateEndpointConnection : ResourceData
    {
        /// <summary> Initializes a new instance of ResponseMessageEnvelopeRemotePrivateEndpointConnection. </summary>
        internal ResponseMessageEnvelopeRemotePrivateEndpointConnection()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ResponseMessageEnvelopeRemotePrivateEndpointConnection. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location">
        /// Geographical region resource belongs to e.g. SouthCentralUS, SouthEastAsia.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.location
        /// </param>
        /// <param name="tags">
        /// Tags associated with resource.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.tags
        /// </param>
        /// <param name="plan">
        /// Azure resource manager plan.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.plan
        /// </param>
        /// <param name="properties">
        /// Resource specific properties.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.properties
        /// </param>
        /// <param name="sku">
        /// SKU description of the resource.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.sku
        /// </param>
        /// <param name="status">
        /// Azure-AsyncOperation Status info.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.status
        /// </param>
        /// <param name="error">
        /// Azure-AsyncOperation Error info.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.error
        /// </param>
        /// <param name="identity">
        /// MSI resource
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.identity
        /// </param>
        /// <param name="zones">
        /// Logical Availability Zones the service is hosted in
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.zones
        /// </param>
        internal ResponseMessageEnvelopeRemotePrivateEndpointConnection(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, IReadOnlyDictionary<string, string> tags, ArmPlan plan, RemotePrivateEndpointConnection properties, AppServiceSkuDescription sku, string status, ResponseError error, ManagedServiceIdentity identity, IReadOnlyList<string> zones) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Tags = tags;
            Plan = plan;
            Properties = properties;
            Sku = sku;
            Status = status;
            Error = error;
            Identity = identity;
            Zones = zones;
        }

        /// <summary>
        /// Geographical region resource belongs to e.g. SouthCentralUS, SouthEastAsia.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.location
        /// </summary>
        public AzureLocation? Location { get; }
        /// <summary>
        /// Tags associated with resource.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.tags
        /// </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary>
        /// Azure resource manager plan.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.plan
        /// </summary>
        public ArmPlan Plan { get; }
        /// <summary>
        /// Resource specific properties.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.properties
        /// </summary>
        public RemotePrivateEndpointConnection Properties { get; }
        /// <summary>
        /// SKU description of the resource.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.sku
        /// </summary>
        public AppServiceSkuDescription Sku { get; }
        /// <summary>
        /// Azure-AsyncOperation Status info.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.status
        /// </summary>
        public string Status { get; }
        /// <summary>
        /// Azure-AsyncOperation Error info.
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.error
        /// </summary>
        public ResponseError Error { get; }
        /// <summary>
        /// MSI resource
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.identity
        /// </summary>
        public ManagedServiceIdentity Identity { get; }
        /// <summary>
        /// Logical Availability Zones the service is hosted in
        /// Serialized Name: ResponseMessageEnvelopeRemotePrivateEndpointConnection.zones
        /// </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
