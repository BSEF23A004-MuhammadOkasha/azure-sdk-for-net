// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Virtual Appliance NIC properties. </summary>
    public partial class VirtualApplianceNicProperties
    {
        /// <summary> Initializes a new instance of VirtualApplianceNicProperties. </summary>
        public VirtualApplianceNicProperties()
        {
        }

        /// <summary> Initializes a new instance of VirtualApplianceNicProperties. </summary>
        /// <param name="name"> NIC name. </param>
        /// <param name="publicIpAddress"> Public IP address. </param>
        /// <param name="privateIpAddress"> Private IP address. </param>
        internal VirtualApplianceNicProperties(string name, string publicIpAddress, string privateIpAddress)
        {
            Name = name;
            PublicIpAddress = publicIpAddress;
            PrivateIpAddress = privateIpAddress;
        }

        /// <summary> NIC name. </summary>
        public string Name { get; }
        /// <summary> Public IP address. </summary>
        public string PublicIpAddress { get; }
        /// <summary> Private IP address. </summary>
        public string PrivateIpAddress { get; }
    }
}
