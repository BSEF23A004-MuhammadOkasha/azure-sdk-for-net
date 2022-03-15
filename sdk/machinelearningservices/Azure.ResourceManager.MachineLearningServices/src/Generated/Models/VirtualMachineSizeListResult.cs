// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The List Virtual Machine size operation response. </summary>
    internal partial class VirtualMachineSizeListResult
    {
        /// <summary> Initializes a new instance of VirtualMachineSizeListResult. </summary>
        internal VirtualMachineSizeListResult()
        {
            Value = new ChangeTrackingList<VirtualMachineSize>();
        }

        /// <summary> Initializes a new instance of VirtualMachineSizeListResult. </summary>
        /// <param name="value"> The list of virtual machine sizes supported by AmlCompute. </param>
        internal VirtualMachineSizeListResult(IReadOnlyList<VirtualMachineSize> value)
        {
            Value = value;
        }

        /// <summary> The list of virtual machine sizes supported by AmlCompute. </summary>
        public IReadOnlyList<VirtualMachineSize> Value { get; }
    }
}
