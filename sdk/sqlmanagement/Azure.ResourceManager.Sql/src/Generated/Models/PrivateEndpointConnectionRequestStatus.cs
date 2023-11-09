// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains the private endpoint connection requests status. </summary>
    public partial class PrivateEndpointConnectionRequestStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnectionRequestStatus"/>. </summary>
        internal PrivateEndpointConnectionRequestStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnectionRequestStatus"/>. </summary>
        /// <param name="privateLinkServiceId"> Resource id for which the private endpoint is created. </param>
        /// <param name="privateEndpointConnectionName"> The connection name for the private endpoint. </param>
        /// <param name="status"> Status of this private endpoint connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateEndpointConnectionRequestStatus(ResourceIdentifier privateLinkServiceId, string privateEndpointConnectionName, string status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrivateLinkServiceId = privateLinkServiceId;
            PrivateEndpointConnectionName = privateEndpointConnectionName;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource id for which the private endpoint is created. </summary>
        public ResourceIdentifier PrivateLinkServiceId { get; }
        /// <summary> The connection name for the private endpoint. </summary>
        public string PrivateEndpointConnectionName { get; }
        /// <summary> Status of this private endpoint connection. </summary>
        public string Status { get; }
    }
}
