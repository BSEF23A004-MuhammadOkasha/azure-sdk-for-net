// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes automatic OS upgrade properties on the image. </summary>
    internal partial class AutomaticOSUpgradeProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomaticOSUpgradeProperties"/>. </summary>
        /// <param name="automaticOSUpgradeSupported"> Specifies whether automatic OS upgrade is supported on the image. </param>
        public AutomaticOSUpgradeProperties(bool automaticOSUpgradeSupported)
        {
            AutomaticOSUpgradeSupported = automaticOSUpgradeSupported;
        }

        /// <summary> Initializes a new instance of <see cref="AutomaticOSUpgradeProperties"/>. </summary>
        /// <param name="automaticOSUpgradeSupported"> Specifies whether automatic OS upgrade is supported on the image. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomaticOSUpgradeProperties(bool automaticOSUpgradeSupported, Dictionary<string, BinaryData> rawData)
        {
            AutomaticOSUpgradeSupported = automaticOSUpgradeSupported;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomaticOSUpgradeProperties"/> for deserialization. </summary>
        internal AutomaticOSUpgradeProperties()
        {
        }

        /// <summary> Specifies whether automatic OS upgrade is supported on the image. </summary>
        public bool AutomaticOSUpgradeSupported { get; set; }
    }
}
