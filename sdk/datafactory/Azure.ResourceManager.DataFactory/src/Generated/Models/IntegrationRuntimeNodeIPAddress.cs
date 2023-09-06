// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The IP address of self-hosted integration runtime node. </summary>
    public partial class IntegrationRuntimeNodeIPAddress
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeNodeIPAddress"/>. </summary>
        internal IntegrationRuntimeNodeIPAddress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeNodeIPAddress"/>. </summary>
        /// <param name="ipAddress"> The IP address of self-hosted integration runtime node. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationRuntimeNodeIPAddress(IPAddress ipAddress, Dictionary<string, BinaryData> rawData)
        {
            IPAddress = ipAddress;
            _rawData = rawData;
        }

        /// <summary> The IP address of self-hosted integration runtime node. </summary>
        public IPAddress IPAddress { get; }
    }
}
