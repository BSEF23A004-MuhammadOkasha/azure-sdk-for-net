// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Defines whether to send email notifications about new security alerts. </summary>
    public partial class SecurityContactPropertiesAlertNotifications
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityContactPropertiesAlertNotifications"/>. </summary>
        public SecurityContactPropertiesAlertNotifications()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityContactPropertiesAlertNotifications"/>. </summary>
        /// <param name="state"> Defines if email notifications will be sent about new security alerts. </param>
        /// <param name="minimalSeverity"> Defines the minimal alert severity which will be sent as email notifications. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityContactPropertiesAlertNotifications(SecurityAlertNotificationState? state, SecurityAlertMinimalSeverity? minimalSeverity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            MinimalSeverity = minimalSeverity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Defines if email notifications will be sent about new security alerts. </summary>
        public SecurityAlertNotificationState? State { get; set; }
        /// <summary> Defines the minimal alert severity which will be sent as email notifications. </summary>
        public SecurityAlertMinimalSeverity? MinimalSeverity { get; set; }
    }
}
