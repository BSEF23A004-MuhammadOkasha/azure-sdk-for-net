// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Network configuration of customer virtual network. </summary>
    internal partial class ContactProfilesPropertiesNetworkConfiguration
    {
        /// <summary> Initializes a new instance of ContactProfilesPropertiesNetworkConfiguration. </summary>
        /// <param name="subnetId"> ARM resource identifier of the subnet delegated to the Microsoft.Orbital/orbitalGateways. Needs to be at least a class C subnet, and should not have any IP created in it. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetId"/> is null. </exception>
        public ContactProfilesPropertiesNetworkConfiguration(string subnetId)
        {
            if (subnetId == null)
            {
                throw new ArgumentNullException(nameof(subnetId));
            }

            SubnetId = subnetId;
        }

        /// <summary> ARM resource identifier of the subnet delegated to the Microsoft.Orbital/orbitalGateways. Needs to be at least a class C subnet, and should not have any IP created in it. </summary>
        public string SubnetId { get; set; }
    }
}
