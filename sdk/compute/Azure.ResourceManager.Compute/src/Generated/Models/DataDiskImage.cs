// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Contains the data disk images information. </summary>
    public partial class DataDiskImage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataDiskImage"/>. </summary>
        public DataDiskImage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataDiskImage"/>. </summary>
        /// <param name="lun"> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataDiskImage(int? lun, Dictionary<string, BinaryData> rawData)
        {
            Lun = lun;
            _rawData = rawData;
        }

        /// <summary> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </summary>
        public int? Lun { get; }
    }
}
