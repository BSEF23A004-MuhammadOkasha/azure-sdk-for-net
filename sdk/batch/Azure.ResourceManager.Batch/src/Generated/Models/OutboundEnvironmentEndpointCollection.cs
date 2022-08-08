// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Values returned by the List operation. </summary>
    internal partial class OutboundEnvironmentEndpointCollection
    {
        /// <summary> Initializes a new instance of OutboundEnvironmentEndpointCollection. </summary>
        internal OutboundEnvironmentEndpointCollection()
        {
            Value = new ChangeTrackingList<BatchAccountOutboundEnvironmentEndpoint>();
        }

        /// <summary> Initializes a new instance of OutboundEnvironmentEndpointCollection. </summary>
        /// <param name="value"> The collection of outbound network dependency endpoints returned by the listing operation. </param>
        /// <param name="nextLink"> The continuation token. </param>
        internal OutboundEnvironmentEndpointCollection(IReadOnlyList<BatchAccountOutboundEnvironmentEndpoint> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of outbound network dependency endpoints returned by the listing operation. </summary>
        public IReadOnlyList<BatchAccountOutboundEnvironmentEndpoint> Value { get; }
        /// <summary> The continuation token. </summary>
        public string NextLink { get; }
    }
}
