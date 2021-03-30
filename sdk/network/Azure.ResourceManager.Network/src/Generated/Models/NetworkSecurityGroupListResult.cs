// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListNetworkSecurityGroups API service call. </summary>
    internal partial class NetworkSecurityGroupListResult
    {
        /// <summary> Initializes a new instance of NetworkSecurityGroupListResult. </summary>
        internal NetworkSecurityGroupListResult()
        {
            Value = new ChangeTrackingList<NetworkSecurityGroup>();
        }

        /// <summary> Initializes a new instance of NetworkSecurityGroupListResult. </summary>
        /// <param name="value"> A list of NetworkSecurityGroup resources. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal NetworkSecurityGroupListResult(IReadOnlyList<NetworkSecurityGroup> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of NetworkSecurityGroup resources. </summary>
        public IReadOnlyList<NetworkSecurityGroup> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
