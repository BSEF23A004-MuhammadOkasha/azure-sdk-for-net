// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListExpressRouteLinks API service call. </summary>
    internal partial class ExpressRouteLinkListResult
    {
        /// <summary> Initializes a new instance of ExpressRouteLinkListResult. </summary>
        internal ExpressRouteLinkListResult()
        {
            Value = new ChangeTrackingList<ExpressRouteLinkData>();
        }

        /// <summary> Initializes a new instance of ExpressRouteLinkListResult. </summary>
        /// <param name="value"> The list of ExpressRouteLink sub-resources. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRouteLinkListResult(IReadOnlyList<ExpressRouteLinkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of ExpressRouteLink sub-resources. </summary>
        public IReadOnlyList<ExpressRouteLinkData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
