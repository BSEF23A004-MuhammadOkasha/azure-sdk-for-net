// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The json object containing security policy parameters. </summary>
    public partial class SecurityPolicyParameters
    {
        /// <summary> Initializes a new instance of SecurityPolicyParameters. </summary>
        public SecurityPolicyParameters()
        {
        }

        /// <summary> Initializes a new instance of SecurityPolicyParameters. </summary>
        /// <param name="securityPolicyType"> The type of the Security policy to create. </param>
        internal SecurityPolicyParameters(SecurityPolicyType securityPolicyType)
        {
            SecurityPolicyType = securityPolicyType;
        }

        /// <summary> The type of the Security policy to create. </summary>
        internal SecurityPolicyType SecurityPolicyType { get; set; }
    }
}
