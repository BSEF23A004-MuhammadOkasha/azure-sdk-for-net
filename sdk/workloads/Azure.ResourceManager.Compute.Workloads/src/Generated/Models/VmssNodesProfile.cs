// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    /// <summary> VMSS profile. </summary>
    public partial class VmssNodesProfile : NodeProfile
    {
        /// <summary> Initializes a new instance of VmssNodesProfile. </summary>
        /// <param name="nodeSku"> VM SKU for node(s). </param>
        /// <param name="osImage"> OS image used for creating the nodes. </param>
        /// <param name="osDisk"> OS disk details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeSku"/>, <paramref name="osImage"/> or <paramref name="osDisk"/> is null. </exception>
        public VmssNodesProfile(string nodeSku, OSImageProfile osImage, DiskInfo osDisk) : base(nodeSku, osImage, osDisk)
        {
            if (nodeSku == null)
            {
                throw new ArgumentNullException(nameof(nodeSku));
            }
            if (osImage == null)
            {
                throw new ArgumentNullException(nameof(osImage));
            }
            if (osDisk == null)
            {
                throw new ArgumentNullException(nameof(osDisk));
            }
        }

        /// <summary> Initializes a new instance of VmssNodesProfile. </summary>
        /// <param name="name"> VM or VMSS name. </param>
        /// <param name="nodeSku"> VM SKU for node(s). </param>
        /// <param name="osImage"> OS image used for creating the nodes. </param>
        /// <param name="osDisk"> OS disk details. </param>
        /// <param name="dataDisks"> Data disks details. This property is not in use right now. </param>
        /// <param name="nodeResourceIds"> VM/VMSS resource ARM Ids. </param>
        /// <param name="autoScaleMinCount"> Minimum number of nodes for autoscale. </param>
        /// <param name="autoScaleMaxCount"> Maximum number of nodes for autoscale. </param>
        internal VmssNodesProfile(string name, string nodeSku, OSImageProfile osImage, DiskInfo osDisk, IList<DiskInfo> dataDisks, IReadOnlyList<ResourceIdentifier> nodeResourceIds, int? autoScaleMinCount, int? autoScaleMaxCount) : base(name, nodeSku, osImage, osDisk, dataDisks, nodeResourceIds)
        {
            AutoScaleMinCount = autoScaleMinCount;
            AutoScaleMaxCount = autoScaleMaxCount;
        }

        /// <summary> Minimum number of nodes for autoscale. </summary>
        public int? AutoScaleMinCount { get; set; }
        /// <summary> Maximum number of nodes for autoscale. </summary>
        public int? AutoScaleMaxCount { get; set; }
    }
}
