// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the list of all private endpoint connections operation. </summary>
    internal partial class EventGridPrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of EventGridPrivateEndpointConnectionListResult. </summary>
        internal EventGridPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<EventGridPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of EventGridPrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> A collection of private endpoint connection resources. </param>
        /// <param name="nextLink"> A link for the next page of private endpoint connection resources. </param>
        internal EventGridPrivateEndpointConnectionListResult(IReadOnlyList<EventGridPrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of private endpoint connection resources. </summary>
        public IReadOnlyList<EventGridPrivateEndpointConnectionData> Value { get; }
        /// <summary> A link for the next page of private endpoint connection resources. </summary>
        public string NextLink { get; }
    }
}
