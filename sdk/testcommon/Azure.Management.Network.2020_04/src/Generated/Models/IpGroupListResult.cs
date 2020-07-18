// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for the ListIpGroups API service call. </summary>
    public partial class IpGroupListResult
    {
        /// <summary> Initializes a new instance of IpGroupListResult. </summary>
        internal IpGroupListResult()
        {
        }

        /// <summary> Initializes a new instance of IpGroupListResult. </summary>
        /// <param name="value"> The list of IpGroups information resources. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal IpGroupListResult(IReadOnlyList<IpGroup> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of IpGroups information resources. </summary>
        public IReadOnlyList<IpGroup> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
