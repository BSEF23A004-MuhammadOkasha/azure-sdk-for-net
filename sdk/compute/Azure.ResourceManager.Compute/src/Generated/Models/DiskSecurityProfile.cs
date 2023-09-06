// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Contains the security related information for the resource. </summary>
    public partial class DiskSecurityProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DiskSecurityProfile"/>. </summary>
        public DiskSecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiskSecurityProfile"/>. </summary>
        /// <param name="securityType"> Specifies the SecurityType of the VM. Applicable for OS disks only. </param>
        /// <param name="secureVmDiskEncryptionSetId"> ResourceId of the disk encryption set associated to Confidential VM supported disk encrypted with customer managed key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskSecurityProfile(DiskSecurityType? securityType, ResourceIdentifier secureVmDiskEncryptionSetId, Dictionary<string, BinaryData> rawData)
        {
            SecurityType = securityType;
            SecureVmDiskEncryptionSetId = secureVmDiskEncryptionSetId;
            _rawData = rawData;
        }

        /// <summary> Specifies the SecurityType of the VM. Applicable for OS disks only. </summary>
        public DiskSecurityType? SecurityType { get; set; }
        /// <summary> ResourceId of the disk encryption set associated to Confidential VM supported disk encrypted with customer managed key. </summary>
        public ResourceIdentifier SecureVmDiskEncryptionSetId { get; set; }
    }
}
