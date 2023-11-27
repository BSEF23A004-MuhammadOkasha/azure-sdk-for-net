// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The UnknownSecurityPolicyProperties. </summary>
    internal partial class UnknownSecurityPolicyProperties : SecurityPolicyProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSecurityPolicyProperties"/>. </summary>
        /// <param name="policyType"> The type of the Security policy to create. </param>
        internal UnknownSecurityPolicyProperties(SecurityPolicyType policyType) : base(policyType)
        {
            PolicyType = policyType;
        }
    }
}
