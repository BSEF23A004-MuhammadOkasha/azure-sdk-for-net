// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Usage metric of a database. </summary>
    public partial class DatabaseUsage : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseUsage"/>. </summary>
        public DatabaseUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseUsage"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> User-readable name of the metric. </param>
        /// <param name="currentValue"> Current value of the metric. </param>
        /// <param name="limit"> Boundary value of the metric. </param>
        /// <param name="unit"> Unit of the metric. </param>
        internal DatabaseUsage(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, double? currentValue, double? limit, string unit) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            CurrentValue = currentValue;
            Limit = limit;
            Unit = unit;
        }

        /// <summary> User-readable name of the metric. </summary>
        public string DisplayName { get; }
        /// <summary> Current value of the metric. </summary>
        public double? CurrentValue { get; }
        /// <summary> Boundary value of the metric. </summary>
        public double? Limit { get; }
        /// <summary> Unit of the metric. </summary>
        public string Unit { get; }
    }
}
