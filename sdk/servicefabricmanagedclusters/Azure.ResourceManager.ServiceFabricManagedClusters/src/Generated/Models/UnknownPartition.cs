// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The UnknownPartition. </summary>
    internal partial class UnknownPartition : Partition
    {
        /// <summary> Initializes a new instance of UnknownPartition. </summary>
        /// <param name="partitionScheme"> Specifies how the service is partitioned. </param>
        internal UnknownPartition(PartitionScheme partitionScheme) : base(partitionScheme)
        {
            PartitionScheme = partitionScheme;
        }
    }
}
