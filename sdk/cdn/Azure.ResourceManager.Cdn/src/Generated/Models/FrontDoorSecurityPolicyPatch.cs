// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object containing security policy update parameters. </summary>
    public partial class FrontDoorSecurityPolicyPatch
    {
        /// <summary> Initializes a new instance of <see cref="FrontDoorSecurityPolicyPatch"/>. </summary>
        public FrontDoorSecurityPolicyPatch()
        {
        }

        /// <summary>
        /// object which contains security policy parameters
        /// Please note <see cref="SecurityPolicyProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityPolicyWebApplicationFirewall"/>.
        /// </summary>
        public SecurityPolicyProperties Properties { get; set; }
    }
}
