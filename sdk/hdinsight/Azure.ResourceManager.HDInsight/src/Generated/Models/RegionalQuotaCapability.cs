// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The regional quota capacity. </summary>
    public partial class RegionalQuotaCapability
    {
        /// <summary> Initializes a new instance of RegionalQuotaCapability. </summary>
        internal RegionalQuotaCapability()
        {
        }

        /// <summary> Initializes a new instance of RegionalQuotaCapability. </summary>
        /// <param name="region"> The region name. </param>
        /// <param name="coresUsed"> The number of cores used in the region. </param>
        /// <param name="coresAvailable"> The number of cores available in the region. </param>
        internal RegionalQuotaCapability(AzureLocation? region, long? coresUsed, long? coresAvailable)
        {
            Region = region;
            CoresUsed = coresUsed;
            CoresAvailable = coresAvailable;
        }

        /// <summary> The region name. </summary>
        public AzureLocation? Region { get; }
        /// <summary> The number of cores used in the region. </summary>
        public long? CoresUsed { get; }
        /// <summary> The number of cores available in the region. </summary>
        public long? CoresAvailable { get; }
    }
}
