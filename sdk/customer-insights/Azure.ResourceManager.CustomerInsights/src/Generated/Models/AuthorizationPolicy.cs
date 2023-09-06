// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The authorization policy. </summary>
    public partial class AuthorizationPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AuthorizationPolicy"/>. </summary>
        /// <param name="permissions"> The permissions associated with the policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="permissions"/> is null. </exception>
        internal AuthorizationPolicy(IEnumerable<PermissionType> permissions)
        {
            Argument.AssertNotNull(permissions, nameof(permissions));

            Permissions = permissions.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizationPolicy"/>. </summary>
        /// <param name="policyName"> Name of the policy. </param>
        /// <param name="permissions"> The permissions associated with the policy. </param>
        /// <param name="primaryKey"> Primary key associated with the policy. </param>
        /// <param name="secondaryKey"> Secondary key associated with the policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AuthorizationPolicy(string policyName, IReadOnlyList<PermissionType> permissions, string primaryKey, string secondaryKey, Dictionary<string, BinaryData> rawData)
        {
            PolicyName = policyName;
            Permissions = permissions;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizationPolicy"/> for deserialization. </summary>
        internal AuthorizationPolicy()
        {
        }

        /// <summary> Name of the policy. </summary>
        public string PolicyName { get; }
        /// <summary> The permissions associated with the policy. </summary>
        public IReadOnlyList<PermissionType> Permissions { get; }
        /// <summary> Primary key associated with the policy. </summary>
        public string PrimaryKey { get; }
        /// <summary> Secondary key associated with the policy. </summary>
        public string SecondaryKey { get; }
    }
}
