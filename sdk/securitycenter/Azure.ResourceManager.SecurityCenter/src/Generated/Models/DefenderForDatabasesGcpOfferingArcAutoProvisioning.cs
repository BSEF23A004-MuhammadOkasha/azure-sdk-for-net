// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The ARC autoprovisioning configuration. </summary>
    internal partial class DefenderForDatabasesGcpOfferingArcAutoProvisioning
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DefenderForDatabasesGcpOfferingArcAutoProvisioning"/>. </summary>
        public DefenderForDatabasesGcpOfferingArcAutoProvisioning()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderForDatabasesGcpOfferingArcAutoProvisioning"/>. </summary>
        /// <param name="isEnabled"> Is arc auto provisioning enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DefenderForDatabasesGcpOfferingArcAutoProvisioning(bool? isEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Is arc auto provisioning enabled. </summary>
        public bool? IsEnabled { get; set; }
    }
}
