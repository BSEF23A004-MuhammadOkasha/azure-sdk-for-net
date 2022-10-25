// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Host Capacity Data. </summary>
    public partial class HostCapacity
    {
        /// <summary> Initializes a new instance of HostCapacity. </summary>
        public HostCapacity()
        {
            VmUsedMemory = new ChangeTrackingDictionary<string, DataBoxEdgeVmMemory>();
            NumaNodesData = new ChangeTrackingList<NumaNodeInfo>();
        }

        /// <summary> Initializes a new instance of HostCapacity. </summary>
        /// <param name="hostName"> The name of the host. </param>
        /// <param name="effectiveAvailableMemoryInMBOnHost"> The available memory on the host accounting for VM placement size and any host VM reservations. </param>
        /// <param name="availableGpuCount"> The available amount of GPUs on the host to use after accounting for GPUS used by reservations on the host. </param>
        /// <param name="vmUsedMemory"> The VM used memory per VmId. </param>
        /// <param name="gpuType"> The GPU type of the VM. </param>
        /// <param name="numaNodesData"> The numa nodes information for Hpn VMs. </param>
        internal HostCapacity(string hostName, long? effectiveAvailableMemoryInMBOnHost, int? availableGpuCount, IDictionary<string, DataBoxEdgeVmMemory> vmUsedMemory, string gpuType, IList<NumaNodeInfo> numaNodesData)
        {
            HostName = hostName;
            EffectiveAvailableMemoryInMBOnHost = effectiveAvailableMemoryInMBOnHost;
            AvailableGpuCount = availableGpuCount;
            VmUsedMemory = vmUsedMemory;
            GpuType = gpuType;
            NumaNodesData = numaNodesData;
        }

        /// <summary> The name of the host. </summary>
        public string HostName { get; set; }
        /// <summary> The available memory on the host accounting for VM placement size and any host VM reservations. </summary>
        public long? EffectiveAvailableMemoryInMBOnHost { get; set; }
        /// <summary> The available amount of GPUs on the host to use after accounting for GPUS used by reservations on the host. </summary>
        public int? AvailableGpuCount { get; set; }
        /// <summary> The VM used memory per VmId. </summary>
        public IDictionary<string, DataBoxEdgeVmMemory> VmUsedMemory { get; }
        /// <summary> The GPU type of the VM. </summary>
        public string GpuType { get; set; }
        /// <summary> The numa nodes information for Hpn VMs. </summary>
        public IList<NumaNodeInfo> NumaNodesData { get; }
    }
}
