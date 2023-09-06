// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The protection policy of a virtual machine scale set VM. </summary>
    public partial class VirtualMachineScaleSetVmProtectionPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmProtectionPolicy"/>. </summary>
        public VirtualMachineScaleSetVmProtectionPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmProtectionPolicy"/>. </summary>
        /// <param name="protectFromScaleIn"> Indicates that the virtual machine scale set VM shouldn't be considered for deletion during a scale-in operation. </param>
        /// <param name="protectFromScaleSetActions"> Indicates that model updates or actions (including scale-in) initiated on the virtual machine scale set should not be applied to the virtual machine scale set VM. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetVmProtectionPolicy(bool? protectFromScaleIn, bool? protectFromScaleSetActions, Dictionary<string, BinaryData> rawData)
        {
            ProtectFromScaleIn = protectFromScaleIn;
            ProtectFromScaleSetActions = protectFromScaleSetActions;
            _rawData = rawData;
        }

        /// <summary> Indicates that the virtual machine scale set VM shouldn't be considered for deletion during a scale-in operation. </summary>
        public bool? ProtectFromScaleIn { get; set; }
        /// <summary> Indicates that model updates or actions (including scale-in) initiated on the virtual machine scale set should not be applied to the virtual machine scale set VM. </summary>
        public bool? ProtectFromScaleSetActions { get; set; }
    }
}
