// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The ContainerMemoryStatistics.
    /// Serialized Name: ContainerMemoryStatistics
    /// </summary>
    public partial class ContainerMemoryStatistics
    {
        /// <summary> Initializes a new instance of ContainerMemoryStatistics. </summary>
        public ContainerMemoryStatistics()
        {
        }

        /// <summary> Initializes a new instance of ContainerMemoryStatistics. </summary>
        /// <param name="usage"> Serialized Name: ContainerMemoryStatistics.usage. </param>
        /// <param name="maxUsage"> Serialized Name: ContainerMemoryStatistics.maxUsage. </param>
        /// <param name="limit"> Serialized Name: ContainerMemoryStatistics.limit. </param>
        internal ContainerMemoryStatistics(long? usage, long? maxUsage, long? limit)
        {
            Usage = usage;
            MaxUsage = maxUsage;
            Limit = limit;
        }

        /// <summary> Serialized Name: ContainerMemoryStatistics.usage. </summary>
        public long? Usage { get; set; }
        /// <summary> Serialized Name: ContainerMemoryStatistics.maxUsage. </summary>
        public long? MaxUsage { get; set; }
        /// <summary> Serialized Name: ContainerMemoryStatistics.limit. </summary>
        public long? Limit { get; set; }
    }
}
