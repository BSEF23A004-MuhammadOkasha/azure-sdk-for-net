// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The maintenance configuration capability. </summary>
    public partial class MaintenanceConfigurationCapability
    {
        /// <summary> Initializes a new instance of MaintenanceConfigurationCapability. </summary>
        internal MaintenanceConfigurationCapability()
        {
        }

        /// <summary> Initializes a new instance of MaintenanceConfigurationCapability. </summary>
        /// <param name="name"> Maintenance configuration name. </param>
        /// <param name="isZoneRedundant"> Whether or not zone redundancy is supported for the maintenance configuration. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal MaintenanceConfigurationCapability(string name, bool? isZoneRedundant, SqlCapabilityStatus? status, string reason)
        {
            Name = name;
            IsZoneRedundant = isZoneRedundant;
            Status = status;
            Reason = reason;
        }

        /// <summary> Maintenance configuration name. </summary>
        public string Name { get; }
        /// <summary> Whether or not zone redundancy is supported for the maintenance configuration. </summary>
        public bool? IsZoneRedundant { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
