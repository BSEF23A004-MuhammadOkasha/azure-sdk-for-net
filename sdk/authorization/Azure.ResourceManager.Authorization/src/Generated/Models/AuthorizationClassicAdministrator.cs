// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Classic Administrators. </summary>
    public partial class AuthorizationClassicAdministrator : ResourceData
    {
        /// <summary> Initializes a new instance of AuthorizationClassicAdministrator. </summary>
        internal AuthorizationClassicAdministrator()
        {
        }

        /// <summary> Initializes a new instance of AuthorizationClassicAdministrator. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="emailAddress"> The email address of the administrator. </param>
        /// <param name="role"> The role of the administrator. </param>
        internal AuthorizationClassicAdministrator(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string emailAddress, string role) : base(id, name, resourceType, systemData)
        {
            EmailAddress = emailAddress;
            Role = role;
        }

        /// <summary> The email address of the administrator. </summary>
        public string EmailAddress { get; }
        /// <summary> The role of the administrator. </summary>
        public string Role { get; }
    }
}
