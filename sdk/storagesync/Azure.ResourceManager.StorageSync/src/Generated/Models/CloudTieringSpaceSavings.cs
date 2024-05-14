// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Server endpoint cloud tiering status object. </summary>
    public partial class CloudTieringSpaceSavings
    {
        /// <summary> Initializes a new instance of <see cref="CloudTieringSpaceSavings"/>. </summary>
        internal CloudTieringSpaceSavings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudTieringSpaceSavings"/>. </summary>
        /// <param name="lastUpdatedOn"> Last updated timestamp. </param>
        /// <param name="volumeSizeInBytes"> Volume size. </param>
        /// <param name="cloudTotalSizeInBytes"> Total size of content in the azure file share. </param>
        /// <param name="cachedSizeInBytes"> Cached content size on the server. </param>
        /// <param name="spaceSavingsPercent"> Percentage of cached size over total size. </param>
        /// <param name="spaceSavingsInBytes"> Count of bytes saved on the server. </param>
        internal CloudTieringSpaceSavings(DateTimeOffset? lastUpdatedOn, long? volumeSizeInBytes, long? cloudTotalSizeInBytes, long? cachedSizeInBytes, int? spaceSavingsPercent, long? spaceSavingsInBytes)
        {
            LastUpdatedOn = lastUpdatedOn;
            VolumeSizeInBytes = volumeSizeInBytes;
            CloudTotalSizeInBytes = cloudTotalSizeInBytes;
            CachedSizeInBytes = cachedSizeInBytes;
            SpaceSavingsPercent = spaceSavingsPercent;
            SpaceSavingsInBytes = spaceSavingsInBytes;
        }

        /// <summary> Last updated timestamp. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> Volume size. </summary>
        public long? VolumeSizeInBytes { get; }
        /// <summary> Total size of content in the azure file share. </summary>
        public long? CloudTotalSizeInBytes { get; }
        /// <summary> Cached content size on the server. </summary>
        public long? CachedSizeInBytes { get; }
        /// <summary> Percentage of cached size over total size. </summary>
        public int? SpaceSavingsPercent { get; }
        /// <summary> Count of bytes saved on the server. </summary>
        public long? SpaceSavingsInBytes { get; }
    }
}
