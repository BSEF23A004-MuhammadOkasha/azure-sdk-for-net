// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The PatchCluster request parameters
    /// Serialized Name: ClusterPatchParameters
    /// </summary>
    public partial class HDInsightClusterPatch
    {
        /// <summary> Initializes a new instance of HDInsightClusterPatch. </summary>
        public HDInsightClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary>
        /// The resource tags.
        /// Serialized Name: ClusterPatchParameters.tags
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }
    }
}
