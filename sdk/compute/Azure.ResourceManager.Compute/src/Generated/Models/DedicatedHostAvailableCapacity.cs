// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Dedicated host unutilized capacity. </summary>
    internal partial class DedicatedHostAvailableCapacity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DedicatedHostAvailableCapacity"/>. </summary>
        internal DedicatedHostAvailableCapacity()
        {
            AllocatableVms = new ChangeTrackingList<DedicatedHostAllocatableVm>();
        }

        /// <summary> Initializes a new instance of <see cref="DedicatedHostAvailableCapacity"/>. </summary>
        /// <param name="allocatableVms"> The unutilized capacity of the dedicated host represented in terms of each VM size that is allowed to be deployed to the dedicated host. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DedicatedHostAvailableCapacity(IReadOnlyList<DedicatedHostAllocatableVm> allocatableVms, Dictionary<string, BinaryData> rawData)
        {
            AllocatableVms = allocatableVms;
            _rawData = rawData;
        }

        /// <summary> The unutilized capacity of the dedicated host represented in terms of each VM size that is allowed to be deployed to the dedicated host. </summary>
        public IReadOnlyList<DedicatedHostAllocatableVm> AllocatableVms { get; }
    }
}
