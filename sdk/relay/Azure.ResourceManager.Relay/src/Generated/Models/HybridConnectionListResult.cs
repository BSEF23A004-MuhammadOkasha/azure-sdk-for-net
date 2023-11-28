// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Relay;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> The response of the list hybrid connection operation. </summary>
    internal partial class HybridConnectionListResult
    {
        /// <summary> Initializes a new instance of <see cref="HybridConnectionListResult"/>. </summary>
        internal HybridConnectionListResult()
        {
            Value = new ChangeTrackingList<RelayHybridConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="HybridConnectionListResult"/>. </summary>
        /// <param name="value"> Result of the list hybrid connections. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if value contains incomplete list hybrid connection operation. </param>
        internal HybridConnectionListResult(IReadOnlyList<RelayHybridConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of the list hybrid connections. </summary>
        public IReadOnlyList<RelayHybridConnectionData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if value contains incomplete list hybrid connection operation. </summary>
        public string NextLink { get; }
    }
}
