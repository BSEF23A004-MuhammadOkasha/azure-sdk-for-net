// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of subscription usage metrics in a location. </summary>
    public partial class SubscriptionUsageListResult
    {
        /// <summary> Initializes a new instance of SubscriptionUsageListResult. </summary>
        internal SubscriptionUsageListResult()
        {
            Value = new ChangeTrackingList<SubscriptionUsage>();
        }

        /// <summary> Initializes a new instance of SubscriptionUsageListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SubscriptionUsageListResult(IReadOnlyList<SubscriptionUsage> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SubscriptionUsage> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
