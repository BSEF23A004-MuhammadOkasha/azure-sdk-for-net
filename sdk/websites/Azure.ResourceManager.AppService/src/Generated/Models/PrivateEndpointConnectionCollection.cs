// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The PrivateEndpointConnectionCollection.
    /// Serialized Name: PrivateEndpointConnectionCollection
    /// </summary>
    internal partial class PrivateEndpointConnectionCollection
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: PrivateEndpointConnectionCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PrivateEndpointConnectionCollection(IEnumerable<RemotePrivateEndpointConnectionARMResourceData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: PrivateEndpointConnectionCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: PrivateEndpointConnectionCollection.nextLink
        /// </param>
        internal PrivateEndpointConnectionCollection(IReadOnlyList<RemotePrivateEndpointConnectionARMResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: PrivateEndpointConnectionCollection.value
        /// </summary>
        public IReadOnlyList<RemotePrivateEndpointConnectionARMResourceData> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: PrivateEndpointConnectionCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
