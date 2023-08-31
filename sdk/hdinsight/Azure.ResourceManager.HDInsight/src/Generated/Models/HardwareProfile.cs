// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The hardware profile. </summary>
    internal partial class HardwareProfile
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HardwareProfile"/>. </summary>
        public HardwareProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HardwareProfile"/>. </summary>
        /// <param name="vmSize"> The size of the VM. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HardwareProfile(string vmSize, Dictionary<string, BinaryData> rawData)
        {
            VmSize = vmSize;
            _rawData = rawData;
        }

        /// <summary> The size of the VM. </summary>
        public string VmSize { get; set; }
    }
}
