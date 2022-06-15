// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> A list of SKUs supported by an Azure Resource Provider. </summary>
    internal partial class SkusListResult
    {
        /// <summary> Initializes a new instance of SkusListResult. </summary>
        internal SkusListResult()
        {
            Value = new ChangeTrackingList<SkuDefinition>();
        }

        /// <summary> Initializes a new instance of SkusListResult. </summary>
        /// <param name="value"> List of SKUs supported by the resource provider. </param>
        /// <param name="nextLink"> URL to get the next set of SKU list results (if there are any). </param>
        internal SkusListResult(IReadOnlyList<SkuDefinition> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of SKUs supported by the resource provider. </summary>
        public IReadOnlyList<SkuDefinition> Value { get; }
        /// <summary> URL to get the next set of SKU list results (if there are any). </summary>
        public string NextLink { get; }
    }
}
