// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Maintenance;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> Response for MaintenanceConfigurations list. </summary>
    internal partial class MaintenanceConfigurationListResult
    {
        /// <summary> Initializes a new instance of <see cref="MaintenanceConfigurationListResult"/>. </summary>
        internal MaintenanceConfigurationListResult()
        {
            Value = new ChangeTrackingList<MaintenanceConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="MaintenanceConfigurationListResult"/>. </summary>
        /// <param name="value"> The list of maintenance Configurations. </param>
        internal MaintenanceConfigurationListResult(IReadOnlyList<MaintenanceConfigurationData> value)
        {
            Value = value;
        }

        /// <summary> The list of maintenance Configurations. </summary>
        public IReadOnlyList<MaintenanceConfigurationData> Value { get; }
    }
}
