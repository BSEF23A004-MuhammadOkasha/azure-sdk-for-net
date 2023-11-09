// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcmFailback NIC details. </summary>
    public partial class InMageRcmFailbackNicDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackNicDetails"/>. </summary>
        internal InMageRcmFailbackNicDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackNicDetails"/>. </summary>
        /// <param name="macAddress"> The mac address. </param>
        /// <param name="networkName"> The network name. </param>
        /// <param name="adapterType"> The adapter type. </param>
        /// <param name="sourceIPAddress"> The IP address. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmFailbackNicDetails(string macAddress, string networkName, string adapterType, IPAddress sourceIPAddress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MacAddress = macAddress;
            NetworkName = networkName;
            AdapterType = adapterType;
            SourceIPAddress = sourceIPAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The mac address. </summary>
        public string MacAddress { get; }
        /// <summary> The network name. </summary>
        public string NetworkName { get; }
        /// <summary> The adapter type. </summary>
        public string AdapterType { get; }
        /// <summary> The IP address. </summary>
        public IPAddress SourceIPAddress { get; }
    }
}
