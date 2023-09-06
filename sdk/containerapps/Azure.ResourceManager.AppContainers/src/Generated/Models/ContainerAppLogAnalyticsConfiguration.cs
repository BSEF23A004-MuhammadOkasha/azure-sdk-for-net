// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Log Analytics configuration, must only be provided when destination is configured as 'log-analytics'. </summary>
    public partial class ContainerAppLogAnalyticsConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppLogAnalyticsConfiguration"/>. </summary>
        public ContainerAppLogAnalyticsConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppLogAnalyticsConfiguration"/>. </summary>
        /// <param name="customerId"> Log analytics customer id. </param>
        /// <param name="sharedKey"> Log analytics customer key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppLogAnalyticsConfiguration(string customerId, string sharedKey, Dictionary<string, BinaryData> rawData)
        {
            CustomerId = customerId;
            SharedKey = sharedKey;
            _rawData = rawData;
        }

        /// <summary> Log analytics customer id. </summary>
        public string CustomerId { get; set; }
        /// <summary> Log analytics customer key. </summary>
        public string SharedKey { get; set; }
    }
}
