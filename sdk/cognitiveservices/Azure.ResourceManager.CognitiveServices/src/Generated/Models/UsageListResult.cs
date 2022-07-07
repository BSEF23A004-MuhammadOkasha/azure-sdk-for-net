// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The response to a list usage request. </summary>
    internal partial class UsageListResult
    {
        /// <summary> Initializes a new instance of UsageListResult. </summary>
        internal UsageListResult()
        {
            Value = new ChangeTrackingList<CognitiveServicesUsage>();
        }

        /// <summary> Initializes a new instance of UsageListResult. </summary>
        /// <param name="value"> The list of usages for Cognitive Service account. </param>
        internal UsageListResult(IReadOnlyList<CognitiveServicesUsage> value)
        {
            Value = value;
        }

        /// <summary> The list of usages for Cognitive Service account. </summary>
        public IReadOnlyList<CognitiveServicesUsage> Value { get; }
    }
}
