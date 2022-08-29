// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The quota usage for a container registry. </summary>
    public partial class ContainerRegistryUsage
    {
        /// <summary> Initializes a new instance of ContainerRegistryUsage. </summary>
        internal ContainerRegistryUsage()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryUsage. </summary>
        /// <param name="name"> The name of the usage. </param>
        /// <param name="limit"> The limit of the usage. </param>
        /// <param name="currentValue"> The current value of the usage. </param>
        /// <param name="unit"> The unit of measurement. </param>
        internal ContainerRegistryUsage(string name, long? limit, long? currentValue, ContainerRegistryUsageUnit? unit)
        {
            Name = name;
            Limit = limit;
            CurrentValue = currentValue;
            Unit = unit;
        }

        /// <summary> The name of the usage. </summary>
        public string Name { get; }
        /// <summary> The limit of the usage. </summary>
        public long? Limit { get; }
        /// <summary> The current value of the usage. </summary>
        public long? CurrentValue { get; }
        /// <summary> The unit of measurement. </summary>
        public ContainerRegistryUsageUnit? Unit { get; }
    }
}
