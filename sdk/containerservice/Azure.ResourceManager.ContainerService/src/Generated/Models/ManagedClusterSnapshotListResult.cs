// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The response from the List Managed Cluster Snapshots operation. </summary>
    internal partial class ManagedClusterSnapshotListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterSnapshotListResult"/>. </summary>
        internal ManagedClusterSnapshotListResult()
        {
            Value = new ChangeTrackingList<ManagedClusterSnapshotData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterSnapshotListResult"/>. </summary>
        /// <param name="value"> The list of managed cluster snapshots. </param>
        /// <param name="nextLink"> The URL to get the next set of managed cluster snapshot results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterSnapshotListResult(IReadOnlyList<ManagedClusterSnapshotData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of managed cluster snapshots. </summary>
        public IReadOnlyList<ManagedClusterSnapshotData> Value { get; }
        /// <summary> The URL to get the next set of managed cluster snapshot results. </summary>
        public string NextLink { get; }
    }
}
