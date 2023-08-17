// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The VirtualMachinePropertiesSecurityProfileUefiSettings. </summary>
    internal partial class VirtualMachinePropertiesSecurityProfileUefiSettings
    {
        /// <summary> Initializes a new instance of VirtualMachinePropertiesSecurityProfileUefiSettings. </summary>
        public VirtualMachinePropertiesSecurityProfileUefiSettings()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachinePropertiesSecurityProfileUefiSettings. </summary>
        /// <param name="secureBootEnabled"> Specifies whether secure boot should be enabled on the virtual machine. </param>
        internal VirtualMachinePropertiesSecurityProfileUefiSettings(bool? secureBootEnabled)
        {
            SecureBootEnabled = secureBootEnabled;
        }

        /// <summary> Specifies whether secure boot should be enabled on the virtual machine. </summary>
        public bool? SecureBootEnabled { get; set; }
    }
}
