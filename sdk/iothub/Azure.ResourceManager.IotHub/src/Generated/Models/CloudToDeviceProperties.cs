// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary>
    /// The IoT hub cloud-to-device messaging properties.
    /// Serialized Name: CloudToDeviceProperties
    /// </summary>
    public partial class CloudToDeviceProperties
    {
        /// <summary> Initializes a new instance of CloudToDeviceProperties. </summary>
        public CloudToDeviceProperties()
        {
        }

        /// <summary> Initializes a new instance of CloudToDeviceProperties. </summary>
        /// <param name="maxDeliveryCount">
        /// The max delivery count for cloud-to-device messages in the device queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
        /// Serialized Name: CloudToDeviceProperties.maxDeliveryCount
        /// </param>
        /// <param name="defaultTtlAsIso8601">
        /// The default time to live for cloud-to-device messages in the device queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
        /// Serialized Name: CloudToDeviceProperties.defaultTtlAsIso8601
        /// </param>
        /// <param name="feedback">
        /// The properties of the feedback queue for cloud-to-device messages.
        /// Serialized Name: CloudToDeviceProperties.feedback
        /// </param>
        internal CloudToDeviceProperties(int? maxDeliveryCount, TimeSpan? defaultTtlAsIso8601, CloudToDeviceFeedbackQueueProperties feedback)
        {
            MaxDeliveryCount = maxDeliveryCount;
            DefaultTtlAsIso8601 = defaultTtlAsIso8601;
            Feedback = feedback;
        }

        /// <summary>
        /// The max delivery count for cloud-to-device messages in the device queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
        /// Serialized Name: CloudToDeviceProperties.maxDeliveryCount
        /// </summary>
        public int? MaxDeliveryCount { get; set; }
        /// <summary>
        /// The default time to live for cloud-to-device messages in the device queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages.
        /// Serialized Name: CloudToDeviceProperties.defaultTtlAsIso8601
        /// </summary>
        public TimeSpan? DefaultTtlAsIso8601 { get; set; }
        /// <summary>
        /// The properties of the feedback queue for cloud-to-device messages.
        /// Serialized Name: CloudToDeviceProperties.feedback
        /// </summary>
        public CloudToDeviceFeedbackQueueProperties Feedback { get; set; }
    }
}
