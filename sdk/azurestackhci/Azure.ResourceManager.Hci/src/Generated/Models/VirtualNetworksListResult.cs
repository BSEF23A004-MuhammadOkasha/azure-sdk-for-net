// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The VirtualNetworksListResult. </summary>
    internal partial class VirtualNetworksListResult
    {
        /// <summary> Initializes a new instance of VirtualNetworksListResult. </summary>
        internal VirtualNetworksListResult()
        {
            Value = new ChangeTrackingList<HciVirtualNetworkData>();
        }

        /// <summary> Initializes a new instance of VirtualNetworksListResult. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal VirtualNetworksListResult(IReadOnlyList<HciVirtualNetworkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<HciVirtualNetworkData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
