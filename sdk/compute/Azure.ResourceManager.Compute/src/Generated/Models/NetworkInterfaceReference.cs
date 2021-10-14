// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a network interface reference. </summary>
    public partial class NetworkInterfaceReference : WritableSubResource
    {
        /// <summary> Initializes a new instance of NetworkInterfaceReference. </summary>
        public NetworkInterfaceReference()
        {
        }

        /// <summary> Initializes a new instance of NetworkInterfaceReference. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="primary"> Specifies the primary network interface in case the virtual machine has more than 1 network interface. </param>
        /// <param name="deleteOption"> Specify what happens to the network interface when the VM is deleted. </param>
        internal NetworkInterfaceReference(string id, bool? primary, DeleteOptions? deleteOption) : base(id)
        {
            Primary = primary;
            DeleteOption = deleteOption;
        }

        /// <summary> Specifies the primary network interface in case the virtual machine has more than 1 network interface. </summary>
        public bool? Primary { get; set; }
        /// <summary> Specify what happens to the network interface when the VM is deleted. </summary>
        public DeleteOptions? DeleteOption { get; set; }
    }
}
