// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMM fabric specific details. </summary>
    public partial class VmmFabricDetails : FabricSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="VmmFabricDetails"/>. </summary>
        internal VmmFabricDetails()
        {
            InstanceType = "VMM";
        }

        /// <summary> Initializes a new instance of <see cref="VmmFabricDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal VmmFabricDetails(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "VMM";
        }
    }
}
