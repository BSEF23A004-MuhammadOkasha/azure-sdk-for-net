// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ApplicationGatewayPrivateEndpointConnection data model. </summary>
    public partial class ApplicationGatewayPrivateEndpointConnectionData : SubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayPrivateEndpointConnectionData. </summary>
        public ApplicationGatewayPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayPrivateEndpointConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the private endpoint connection on an application gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceType"> Type of the resource. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the application gateway private endpoint connection resource. </param>
        /// <param name="linkIdentifier"> The consumer link id. </param>
        internal ApplicationGatewayPrivateEndpointConnectionData(string id, string name, string etag, string resourceType, PrivateEndpointData privateEndpoint, NetworkPrivateLinkServiceConnectionState connectionState, ProvisioningState? provisioningState, string linkIdentifier) : base(id)
        {
            Name = name;
            Etag = etag;
            ResourceType = resourceType;
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
            LinkIdentifier = linkIdentifier;
        }

        /// <summary> Name of the private endpoint connection on an application gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string ResourceType { get; }
        /// <summary> The resource of private end point. </summary>
        public PrivateEndpointData PrivateEndpoint { get; }
        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public NetworkPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of the application gateway private endpoint connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The consumer link id. </summary>
        public string LinkIdentifier { get; }
    }
}
