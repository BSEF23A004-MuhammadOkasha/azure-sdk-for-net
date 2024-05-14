// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The Azure Active Directory principal identifier, Azure built-in role, and just-in-time access policy that describes the just-in-time access the principal will receive on the delegated resource in the managed tenant. </summary>
    public partial class ManagedServicesEligibleAuthorization
    {
        /// <summary> Initializes a new instance of <see cref="ManagedServicesEligibleAuthorization"/>. </summary>
        /// <param name="principalId"> The identifier of the Azure Active Directory principal. </param>
        /// <param name="roleDefinitionId"> The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will have on the projected scope. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public ManagedServicesEligibleAuthorization(Guid principalId, string roleDefinitionId)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesEligibleAuthorization"/>. </summary>
        /// <param name="principalId"> The identifier of the Azure Active Directory principal. </param>
        /// <param name="principalIdDisplayName"> The display name of the Azure Active Directory principal. </param>
        /// <param name="roleDefinitionId"> The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will have on the projected scope. </param>
        /// <param name="justInTimeAccessPolicy"> The just-in-time access policy setting. </param>
        internal ManagedServicesEligibleAuthorization(Guid principalId, string principalIdDisplayName, string roleDefinitionId, ManagedServicesJustInTimeAccessPolicy justInTimeAccessPolicy)
        {
            PrincipalId = principalId;
            PrincipalIdDisplayName = principalIdDisplayName;
            RoleDefinitionId = roleDefinitionId;
            JustInTimeAccessPolicy = justInTimeAccessPolicy;
        }

        /// <summary> The identifier of the Azure Active Directory principal. </summary>
        public Guid PrincipalId { get; set; }
        /// <summary> The display name of the Azure Active Directory principal. </summary>
        public string PrincipalIdDisplayName { get; set; }
        /// <summary> The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will have on the projected scope. </summary>
        public string RoleDefinitionId { get; set; }
        /// <summary> The just-in-time access policy setting. </summary>
        public ManagedServicesJustInTimeAccessPolicy JustInTimeAccessPolicy { get; set; }
    }
}
