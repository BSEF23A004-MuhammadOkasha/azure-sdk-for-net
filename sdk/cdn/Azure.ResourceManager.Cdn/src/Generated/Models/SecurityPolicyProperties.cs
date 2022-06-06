// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// The json object containing security policy parameters
    /// Please note <see cref="SecurityPolicyProperties"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
    /// The available derived classes include <see cref="SecurityPolicyWebApplicationFirewall"/>.
    /// </summary>
    public partial class SecurityPolicyProperties
    {
        /// <summary> Initializes a new instance of SecurityPolicyProperties. </summary>
        public SecurityPolicyProperties()
        {
        }

        /// <summary> Initializes a new instance of SecurityPolicyProperties. </summary>
        /// <param name="policyType"> The type of the Security policy to create. </param>
        internal SecurityPolicyProperties(SecurityPolicyType policyType)
        {
            PolicyType = policyType;
        }

        /// <summary> The type of the Security policy to create. </summary>
        internal SecurityPolicyType PolicyType { get; set; }
    }
}
