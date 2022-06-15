// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> A single usage result. </summary>
    public partial class ContainerInstanceUsage
    {
        /// <summary> Initializes a new instance of ContainerInstanceUsage. </summary>
        internal ContainerInstanceUsage()
        {
        }

        /// <summary> Initializes a new instance of ContainerInstanceUsage. </summary>
        /// <param name="unit"> Unit of the usage result. </param>
        /// <param name="currentValue"> The current usage of the resource. </param>
        /// <param name="limit"> The maximum permitted usage of the resource. </param>
        /// <param name="name"> The name object of the resource. </param>
        internal ContainerInstanceUsage(string unit, int? currentValue, int? limit, UsageName name)
        {
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> Unit of the usage result. </summary>
        public string Unit { get; }
        /// <summary> The current usage of the resource. </summary>
        public int? CurrentValue { get; }
        /// <summary> The maximum permitted usage of the resource. </summary>
        public int? Limit { get; }
        /// <summary> The name object of the resource. </summary>
        public UsageName Name { get; }
    }
}
