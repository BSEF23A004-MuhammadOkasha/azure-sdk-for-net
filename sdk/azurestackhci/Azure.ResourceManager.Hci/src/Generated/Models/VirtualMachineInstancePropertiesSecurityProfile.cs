// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> SecurityProfile - Specifies the security settings for the virtual machine instance. </summary>
    public partial class VirtualMachineInstancePropertiesSecurityProfile
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineInstancePropertiesSecurityProfile"/>. </summary>
        public VirtualMachineInstancePropertiesSecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineInstancePropertiesSecurityProfile"/>. </summary>
        /// <param name="enableTPM"></param>
        /// <param name="uefiSettings"></param>
        /// <param name="securityType"> Specifies the SecurityType of the virtual machine. EnableTPM and SecureBootEnabled must be set to true for SecurityType to function. </param>
        internal VirtualMachineInstancePropertiesSecurityProfile(bool? enableTPM, VirtualMachineInstancePropertiesSecurityProfileUefiSettings uefiSettings, SecurityType? securityType)
        {
            EnableTPM = enableTPM;
            UefiSettings = uefiSettings;
            SecurityType = securityType;
        }

        /// <summary> Gets or sets the enable tpm. </summary>
        public bool? EnableTPM { get; set; }
        /// <summary> Gets or sets the uefi settings. </summary>
        internal VirtualMachineInstancePropertiesSecurityProfileUefiSettings UefiSettings { get; set; }
        /// <summary> Specifies whether secure boot should be enabled on the virtual machine instance. </summary>
        public bool? SecureBootEnabled
        {
            get => UefiSettings is null ? default : UefiSettings.SecureBootEnabled;
            set
            {
                if (UefiSettings is null)
                    UefiSettings = new VirtualMachineInstancePropertiesSecurityProfileUefiSettings();
                UefiSettings.SecureBootEnabled = value;
            }
        }

        /// <summary> Specifies the SecurityType of the virtual machine. EnableTPM and SecureBootEnabled must be set to true for SecurityType to function. </summary>
        public SecurityType? SecurityType { get; set; }
    }
}
