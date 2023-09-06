// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Enables or disables a capability on the dedicated host group. Minimum api-version: 2022-03-01. </summary>
    internal partial class DedicatedHostGroupPropertiesAdditionalCapabilities
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DedicatedHostGroupPropertiesAdditionalCapabilities"/>. </summary>
        public DedicatedHostGroupPropertiesAdditionalCapabilities()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DedicatedHostGroupPropertiesAdditionalCapabilities"/>. </summary>
        /// <param name="ultraSsdEnabled"> The flag that enables or disables a capability to have UltraSSD Enabled Virtual Machines on Dedicated Hosts of the Dedicated Host Group. For the Virtual Machines to be UltraSSD Enabled, UltraSSDEnabled flag for the resource needs to be set true as well. The value is defaulted to 'false' when not provided. Please refer to https://docs.microsoft.com/en-us/azure/virtual-machines/disks-enable-ultra-ssd for more details on Ultra SSD feature. **Note:** The ultraSSDEnabled setting can only be enabled for Host Groups that are created as zonal. Minimum api-version: 2022-03-01. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DedicatedHostGroupPropertiesAdditionalCapabilities(bool? ultraSsdEnabled, Dictionary<string, BinaryData> rawData)
        {
            UltraSsdEnabled = ultraSsdEnabled;
            _rawData = rawData;
        }

        /// <summary> The flag that enables or disables a capability to have UltraSSD Enabled Virtual Machines on Dedicated Hosts of the Dedicated Host Group. For the Virtual Machines to be UltraSSD Enabled, UltraSSDEnabled flag for the resource needs to be set true as well. The value is defaulted to 'false' when not provided. Please refer to https://docs.microsoft.com/en-us/azure/virtual-machines/disks-enable-ultra-ssd for more details on Ultra SSD feature. **Note:** The ultraSSDEnabled setting can only be enabled for Host Groups that are created as zonal. Minimum api-version: 2022-03-01. </summary>
        public bool? UltraSsdEnabled { get; set; }
    }
}
