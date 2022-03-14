// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The response of the List NetworkRuleSet operation. </summary>
    internal partial class NetworkRuleSetListResult
    {
        /// <summary> Initializes a new instance of NetworkRuleSetListResult. </summary>
        internal NetworkRuleSetListResult()
        {
            Value = new ChangeTrackingList<NetworkRuleSetData>();
        }

        /// <summary> Initializes a new instance of NetworkRuleSetListResult. </summary>
        /// <param name="value"> Result of the List NetworkRuleSet operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of NetworkRuleSet. </param>
        internal NetworkRuleSetListResult(IReadOnlyList<NetworkRuleSetData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of the List NetworkRuleSet operation. </summary>
        public IReadOnlyList<NetworkRuleSetData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of NetworkRuleSet. </summary>
        public string NextLink { get; }
    }
}
