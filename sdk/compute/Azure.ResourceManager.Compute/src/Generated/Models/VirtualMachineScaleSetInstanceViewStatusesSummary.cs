// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Instance view statuses summary for virtual machines of a virtual machine scale set. </summary>
    internal partial class VirtualMachineScaleSetInstanceViewStatusesSummary
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetInstanceViewStatusesSummary"/>. </summary>
        internal VirtualMachineScaleSetInstanceViewStatusesSummary()
        {
            StatusesSummary = new ChangeTrackingList<VirtualMachineStatusCodeCount>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetInstanceViewStatusesSummary"/>. </summary>
        /// <param name="statusesSummary"> The extensions information. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetInstanceViewStatusesSummary(IReadOnlyList<VirtualMachineStatusCodeCount> statusesSummary, Dictionary<string, BinaryData> rawData)
        {
            StatusesSummary = statusesSummary;
            _rawData = rawData;
        }

        /// <summary> The extensions information. </summary>
        public IReadOnlyList<VirtualMachineStatusCodeCount> StatusesSummary { get; }
    }
}
