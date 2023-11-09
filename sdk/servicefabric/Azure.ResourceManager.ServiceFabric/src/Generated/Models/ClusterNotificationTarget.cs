// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the notification target properties. </summary>
    public partial class ClusterNotificationTarget
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClusterNotificationTarget"/>. </summary>
        /// <param name="notificationChannel"> The notification channel indicates the type of receivers subscribed to the notification, either user or subscription. </param>
        /// <param name="receivers"> List of targets that subscribe to the notification. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivers"/> is null. </exception>
        public ClusterNotificationTarget(ClusterNotificationChannel notificationChannel, IEnumerable<string> receivers)
        {
            Argument.AssertNotNull(receivers, nameof(receivers));

            NotificationChannel = notificationChannel;
            Receivers = receivers.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterNotificationTarget"/>. </summary>
        /// <param name="notificationChannel"> The notification channel indicates the type of receivers subscribed to the notification, either user or subscription. </param>
        /// <param name="receivers"> List of targets that subscribe to the notification. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterNotificationTarget(ClusterNotificationChannel notificationChannel, IList<string> receivers, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NotificationChannel = notificationChannel;
            Receivers = receivers;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterNotificationTarget"/> for deserialization. </summary>
        internal ClusterNotificationTarget()
        {
        }

        /// <summary> The notification channel indicates the type of receivers subscribed to the notification, either user or subscription. </summary>
        public ClusterNotificationChannel NotificationChannel { get; set; }
        /// <summary> List of targets that subscribe to the notification. </summary>
        public IList<string> Receivers { get; }
    }
}
