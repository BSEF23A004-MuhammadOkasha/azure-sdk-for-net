// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    /// <summary> The type used for update operations of the FleetMember. </summary>
    public partial class DatabaseFleetMemberPatch
    {
        /// <summary> Initializes a new instance of DatabaseFleetMemberPatch. </summary>
        public DatabaseFleetMemberPatch()
        {
        }

        /// <summary> The group this member belongs to for multi-cluster update management. </summary>
        public string Group { get; set; }
    }
}
