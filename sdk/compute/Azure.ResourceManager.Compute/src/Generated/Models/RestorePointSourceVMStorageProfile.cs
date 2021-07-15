// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the storage profile. </summary>
    public partial class RestorePointSourceVMStorageProfile
    {
        /// <summary> Initializes a new instance of RestorePointSourceVMStorageProfile. </summary>
        internal RestorePointSourceVMStorageProfile()
        {
            DataDisks = new ChangeTrackingList<RestorePointSourceVMDataDisk>();
        }

        /// <summary> Initializes a new instance of RestorePointSourceVMStorageProfile. </summary>
        /// <param name="osDisk"> Gets the OS disk of the VM captured at the time of the restore point creation. </param>
        /// <param name="dataDisks"> Gets the data disks of the VM captured at the time of the restore point creation. </param>
        internal RestorePointSourceVMStorageProfile(RestorePointSourceVmosDisk osDisk, IReadOnlyList<RestorePointSourceVMDataDisk> dataDisks)
        {
            OsDisk = osDisk;
            DataDisks = dataDisks;
        }

        /// <summary> Gets the OS disk of the VM captured at the time of the restore point creation. </summary>
        public RestorePointSourceVmosDisk OsDisk { get; }
        /// <summary> Gets the data disks of the VM captured at the time of the restore point creation. </summary>
        public IReadOnlyList<RestorePointSourceVMDataDisk> DataDisks { get; }
    }
}
