// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of the Virtual Machine for which the restore point was created. The properties provided are a subset and the snapshot of the overall Virtual Machine properties captured at the time of the restore point creation. </summary>
    public partial class RestorePointSourceMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RestorePointSourceMetadata"/>. </summary>
        public RestorePointSourceMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestorePointSourceMetadata"/>. </summary>
        /// <param name="hardwareProfile"> Gets the hardware profile. </param>
        /// <param name="storageProfile"> Gets the storage profile. </param>
        /// <param name="osProfile"> Gets the OS profile. </param>
        /// <param name="diagnosticsProfile"> Gets the diagnostics profile. </param>
        /// <param name="licenseType"> Gets the license type, which is for bring your own license scenario. </param>
        /// <param name="vmId"> Gets the virtual machine unique id. </param>
        /// <param name="securityProfile"> Gets the security profile. </param>
        /// <param name="location"> Location of the VM from which the restore point was created. </param>
        /// <param name="userData"> UserData associated with the source VM for which restore point is captured, which is a base-64 encoded value. </param>
        /// <param name="hyperVGeneration"> HyperVGeneration of the source VM for which restore point is captured. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RestorePointSourceMetadata(VirtualMachineHardwareProfile hardwareProfile, RestorePointSourceVmStorageProfile storageProfile, VirtualMachineOSProfile osProfile, DiagnosticsProfile diagnosticsProfile, string licenseType, string vmId, SecurityProfile securityProfile, AzureLocation? location, string userData, HyperVGeneration? hyperVGeneration, Dictionary<string, BinaryData> rawData)
        {
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            OSProfile = osProfile;
            DiagnosticsProfile = diagnosticsProfile;
            LicenseType = licenseType;
            VmId = vmId;
            SecurityProfile = securityProfile;
            Location = location;
            UserData = userData;
            HyperVGeneration = hyperVGeneration;
            _rawData = rawData;
        }

        /// <summary> Gets the hardware profile. </summary>
        public VirtualMachineHardwareProfile HardwareProfile { get; }
        /// <summary> Gets the storage profile. </summary>
        public RestorePointSourceVmStorageProfile StorageProfile { get; set; }
        /// <summary> Gets the OS profile. </summary>
        public VirtualMachineOSProfile OSProfile { get; }
        /// <summary> Gets the diagnostics profile. </summary>
        internal DiagnosticsProfile DiagnosticsProfile { get; }
        /// <summary> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. **NOTE**: If storageUri is being specified then ensure that the storage account is in the same region and subscription as the VM. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor. </summary>
        public BootDiagnostics BootDiagnostics
        {
            get => DiagnosticsProfile?.BootDiagnostics;
        }

        /// <summary> Gets the license type, which is for bring your own license scenario. </summary>
        public string LicenseType { get; }
        /// <summary> Gets the virtual machine unique id. </summary>
        public string VmId { get; }
        /// <summary> Gets the security profile. </summary>
        public SecurityProfile SecurityProfile { get; }
        /// <summary> Location of the VM from which the restore point was created. </summary>
        public AzureLocation? Location { get; }
        /// <summary> UserData associated with the source VM for which restore point is captured, which is a base-64 encoded value. </summary>
        public string UserData { get; }
        /// <summary> HyperVGeneration of the source VM for which restore point is captured. </summary>
        public HyperVGeneration? HyperVGeneration { get; }
    }
}
