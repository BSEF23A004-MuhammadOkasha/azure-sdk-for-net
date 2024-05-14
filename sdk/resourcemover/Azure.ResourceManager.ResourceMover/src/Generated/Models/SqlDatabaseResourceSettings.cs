// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the Sql Database resource settings. </summary>
    public partial class SqlDatabaseResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of <see cref="SqlDatabaseResourceSettings"/>. </summary>
        public SqlDatabaseResourceSettings()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            ResourceType = "Microsoft.Sql/servers/databases";
        }

        /// <summary> Initializes a new instance of <see cref="SqlDatabaseResourceSettings"/>. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <param name="targetResourceGroupName"> Gets or sets the target resource group name. </param>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="zoneRedundant"> Defines the zone redundant resource setting. </param>
        internal SqlDatabaseResourceSettings(string resourceType, string targetResourceName, string targetResourceGroupName, IDictionary<string, string> tags, ResourceZoneRedundantSetting? zoneRedundant) : base(resourceType, targetResourceName, targetResourceGroupName)
        {
            Tags = tags;
            ZoneRedundant = zoneRedundant;
            ResourceType = resourceType ?? "Microsoft.Sql/servers/databases";
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Defines the zone redundant resource setting. </summary>
        public ResourceZoneRedundantSetting? ZoneRedundant { get; set; }
    }
}
