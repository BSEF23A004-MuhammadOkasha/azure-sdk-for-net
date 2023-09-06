// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The secrets related to a DataBox. </summary>
    public partial class DataBoxSecret
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxSecret"/>. </summary>
        internal DataBoxSecret()
        {
            NetworkConfigurations = new ChangeTrackingList<ApplianceNetworkConfiguration>();
            AccountCredentialDetails = new ChangeTrackingList<DataBoxAccountCredentialDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxSecret"/>. </summary>
        /// <param name="deviceSerialNumber"> Serial number of the assigned device. </param>
        /// <param name="devicePassword"> Password for out of the box experience on device. </param>
        /// <param name="networkConfigurations"> Network configuration of the appliance. </param>
        /// <param name="encodedValidationCertPubKey"> The base 64 encoded public key to authenticate with the device. </param>
        /// <param name="accountCredentialDetails"> Per account level access credentials. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxSecret(string deviceSerialNumber, string devicePassword, IReadOnlyList<ApplianceNetworkConfiguration> networkConfigurations, string encodedValidationCertPubKey, IReadOnlyList<DataBoxAccountCredentialDetails> accountCredentialDetails, Dictionary<string, BinaryData> rawData)
        {
            DeviceSerialNumber = deviceSerialNumber;
            DevicePassword = devicePassword;
            NetworkConfigurations = networkConfigurations;
            EncodedValidationCertPubKey = encodedValidationCertPubKey;
            AccountCredentialDetails = accountCredentialDetails;
            _rawData = rawData;
        }

        /// <summary> Serial number of the assigned device. </summary>
        public string DeviceSerialNumber { get; }
        /// <summary> Password for out of the box experience on device. </summary>
        public string DevicePassword { get; }
        /// <summary> Network configuration of the appliance. </summary>
        public IReadOnlyList<ApplianceNetworkConfiguration> NetworkConfigurations { get; }
        /// <summary> The base 64 encoded public key to authenticate with the device. </summary>
        public string EncodedValidationCertPubKey { get; }
        /// <summary> Per account level access credentials. </summary>
        public IReadOnlyList<DataBoxAccountCredentialDetails> AccountCredentialDetails { get; }
    }
}
