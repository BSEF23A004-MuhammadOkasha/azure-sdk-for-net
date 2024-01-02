// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Update replication protected item input. </summary>
    public partial class ReplicationProtectedItemPatch
    {
        /// <summary> Initializes a new instance of <see cref="ReplicationProtectedItemPatch"/>. </summary>
        public ReplicationProtectedItemPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReplicationProtectedItemPatch"/>. </summary>
        /// <param name="properties"> Update replication protected item properties. </param>
        internal ReplicationProtectedItemPatch(UpdateReplicationProtectedItemProperties properties)
        {
            Properties = properties;
        }

        /// <summary> Update replication protected item properties. </summary>
        public UpdateReplicationProtectedItemProperties Properties { get; set; }
    }
}
