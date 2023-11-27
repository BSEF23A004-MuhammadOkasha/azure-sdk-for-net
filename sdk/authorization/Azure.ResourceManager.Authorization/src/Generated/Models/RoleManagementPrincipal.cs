// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The name of the entity last modified it. </summary>
    public partial class RoleManagementPrincipal
    {
        /// <summary> Initializes a new instance of <see cref="RoleManagementPrincipal"/>. </summary>
        internal RoleManagementPrincipal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RoleManagementPrincipal"/>. </summary>
        /// <param name="id"> The id of the principal made changes. </param>
        /// <param name="displayName"> The name of the principal made changes. </param>
        /// <param name="principalType"> Type of the principal. </param>
        /// <param name="email"> Email of principal. </param>
        internal RoleManagementPrincipal(string id, string displayName, RoleManagementPrincipalType? principalType, string email)
        {
            Id = id;
            DisplayName = displayName;
            PrincipalType = principalType;
            Email = email;
        }

        /// <summary> The id of the principal made changes. </summary>
        public string Id { get; }
        /// <summary> The name of the principal made changes. </summary>
        public string DisplayName { get; }
        /// <summary> Type of the principal. </summary>
        public RoleManagementPrincipalType? PrincipalType { get; }
        /// <summary> Email of principal. </summary>
        public string Email { get; }
    }
}
