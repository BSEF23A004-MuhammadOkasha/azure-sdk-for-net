// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.AccessControl.Models
{
    /// <summary> Role Assignment request details. </summary>
    public partial class RoleAssignmentOptions
    {
        /// <summary> Initializes a new instance of RoleAssignmentOptions. </summary>
        /// <param name="roleId"> Role ID of the Synapse Built-In Role. </param>
        /// <param name="principalId"> Object ID of the AAD principal or security-group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleId"/> or <paramref name="principalId"/> is null. </exception>
        public RoleAssignmentOptions(string roleId, string principalId)
        {
            if (roleId == null)
            {
                throw new ArgumentNullException(nameof(roleId));
            }
            if (principalId == null)
            {
                throw new ArgumentNullException(nameof(principalId));
            }

            RoleId = roleId;
            PrincipalId = principalId;
        }

        /// <summary> Role ID of the Synapse Built-In Role. </summary>
        public string RoleId { get; }
        /// <summary> Object ID of the AAD principal or security-group. </summary>
        public string PrincipalId { get; }
    }
}
