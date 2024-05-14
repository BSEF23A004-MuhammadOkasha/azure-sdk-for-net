// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeSkuListResult. </summary>
    internal partial class ResourceTypeSkuListResult
    {
        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuListResult"/>. </summary>
        internal ResourceTypeSkuListResult()
        {
            Value = new ChangeTrackingList<ResourceTypeSkuData>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuListResult"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URL to get to the next set of results, if there are any. </param>
        internal ResourceTypeSkuListResult(IReadOnlyList<ResourceTypeSkuData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ResourceTypeSkuData> Value { get; }
        /// <summary> The URL to get to the next set of results, if there are any. </summary>
        public string NextLink { get; }
    }
}
