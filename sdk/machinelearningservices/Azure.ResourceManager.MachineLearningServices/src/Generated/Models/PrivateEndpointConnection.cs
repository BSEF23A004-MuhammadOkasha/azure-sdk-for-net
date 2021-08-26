// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The Private Endpoint Connection resource. </summary>
    public partial class PrivateEndpointConnection : Resource
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnection. </summary>
        public PrivateEndpointConnection()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnection. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="tags"> Contains resource tags defined as key/value pairs. </param>
        /// <param name="sku"> The sku of the workspace. </param>
        /// <param name="systemData"> System data. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="privateLinkServiceConnectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        internal PrivateEndpointConnection(string id, string name, string type, Identity identity, string location, IDictionary<string, string> tags, Sku sku, SystemData systemData, PrivateEndpoint privateEndpoint, PrivateLinkServiceConnectionState privateLinkServiceConnectionState, PrivateEndpointConnectionProvisioningState? provisioningState) : base(id, name, type)
        {
            Identity = identity;
            Location = location;
            Tags = tags;
            Sku = sku;
            SystemData = systemData;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The identity of the resource. </summary>
        public Identity Identity { get; set; }
        /// <summary> Specifies the location of the resource. </summary>
        public string Location { get; set; }
        /// <summary> Contains resource tags defined as key/value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The sku of the workspace. </summary>
        public Sku Sku { get; set; }
        /// <summary> System data. </summary>
        public SystemData SystemData { get; }
        /// <summary> The resource of private end point. </summary>
        public PrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public PrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
    }
}
