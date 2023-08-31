// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceUpdate;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> The available private endpoint connection proxies for an Account (not to be used by anyone, here because of ARM requirements). </summary>
    internal partial class PrivateEndpointConnectionProxyListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnectionProxyListResult"/>. </summary>
        internal PrivateEndpointConnectionProxyListResult()
        {
            Value = new ChangeTrackingList<PrivateEndpointConnectionProxyData>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnectionProxyListResult"/>. </summary>
        /// <param name="value"> The list of available private endpoint connection proxies for an Account. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of private endpoint connection proxies. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateEndpointConnectionProxyListResult(IReadOnlyList<PrivateEndpointConnectionProxyData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of available private endpoint connection proxies for an Account. </summary>
        public IReadOnlyList<PrivateEndpointConnectionProxyData> Value { get; }
        /// <summary> The URI that can be used to request the next list of private endpoint connection proxies. </summary>
        public string NextLink { get; }
    }
}
