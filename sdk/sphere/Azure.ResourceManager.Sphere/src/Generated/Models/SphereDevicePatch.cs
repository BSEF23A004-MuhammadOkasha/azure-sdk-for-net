// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// The type used for update operations of the Device.
    /// Serialized Name: DeviceUpdate
    /// </summary>
    public partial class SphereDevicePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SphereDevicePatch"/>. </summary>
        public SphereDevicePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SphereDevicePatch"/>. </summary>
        /// <param name="deviceGroupId">
        /// Device group id
        /// Serialized Name: DeviceUpdate.properties.deviceGroupId
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SphereDevicePatch(string deviceGroupId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeviceGroupId = deviceGroupId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Device group id
        /// Serialized Name: DeviceUpdate.properties.deviceGroupId
        /// </summary>
        public string DeviceGroupId { get; set; }
    }
}
