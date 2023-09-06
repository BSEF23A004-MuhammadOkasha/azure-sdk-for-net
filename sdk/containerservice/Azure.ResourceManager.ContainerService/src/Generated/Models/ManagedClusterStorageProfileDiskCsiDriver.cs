// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> AzureDisk CSI Driver settings for the storage profile. </summary>
    public partial class ManagedClusterStorageProfileDiskCsiDriver
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterStorageProfileDiskCsiDriver"/>. </summary>
        public ManagedClusterStorageProfileDiskCsiDriver()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterStorageProfileDiskCsiDriver"/>. </summary>
        /// <param name="isEnabled"> Whether to enable AzureDisk CSI Driver. The default value is true. </param>
        /// <param name="version"> The version of AzureDisk CSI Driver. The default value is v1. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterStorageProfileDiskCsiDriver(bool? isEnabled, string version, Dictionary<string, BinaryData> rawData)
        {
            IsEnabled = isEnabled;
            Version = version;
            _rawData = rawData;
        }

        /// <summary> Whether to enable AzureDisk CSI Driver. The default value is true. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The version of AzureDisk CSI Driver. The default value is v1. </summary>
        public string Version { get; set; }
    }
}
