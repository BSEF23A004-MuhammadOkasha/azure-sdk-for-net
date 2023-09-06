// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The Network Adapter configuration of a DataBox. </summary>
    public partial class ApplianceNetworkConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplianceNetworkConfiguration"/>. </summary>
        internal ApplianceNetworkConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplianceNetworkConfiguration"/>. </summary>
        /// <param name="name"> Name of the network. </param>
        /// <param name="macAddress"> Mac Address. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplianceNetworkConfiguration(string name, string macAddress, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            MacAddress = macAddress;
            _rawData = rawData;
        }

        /// <summary> Name of the network. </summary>
        public string Name { get; }
        /// <summary> Mac Address. </summary>
        public string MacAddress { get; }
    }
}
