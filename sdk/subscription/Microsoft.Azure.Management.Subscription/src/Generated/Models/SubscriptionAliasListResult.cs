// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace SubscriptionClient.Models
{
    /// <summary> The list of aliases. </summary>
    public partial class SubscriptionAliasListResult
    {
        /// <summary> Initializes a new instance of SubscriptionAliasListResult. </summary>
        internal SubscriptionAliasListResult()
        {
            Value = new ChangeTrackingList<SubscriptionAliasResponse>();
        }

        /// <summary> Initializes a new instance of SubscriptionAliasListResult. </summary>
        /// <param name="value"> The list of alias. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal SubscriptionAliasListResult(IReadOnlyList<SubscriptionAliasResponse> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of alias. </summary>
        public IReadOnlyList<SubscriptionAliasResponse> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
