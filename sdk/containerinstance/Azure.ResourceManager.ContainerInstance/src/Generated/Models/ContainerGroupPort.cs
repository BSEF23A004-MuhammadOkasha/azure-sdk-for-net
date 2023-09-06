// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The port exposed on the container group. </summary>
    public partial class ContainerGroupPort
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerGroupPort"/>. </summary>
        /// <param name="port"> The port number. </param>
        public ContainerGroupPort(int port)
        {
            Port = port;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupPort"/>. </summary>
        /// <param name="protocol"> The protocol associated with the port. </param>
        /// <param name="port"> The port number. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerGroupPort(ContainerGroupNetworkProtocol? protocol, int port, Dictionary<string, BinaryData> rawData)
        {
            Protocol = protocol;
            Port = port;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupPort"/> for deserialization. </summary>
        internal ContainerGroupPort()
        {
        }

        /// <summary> The protocol associated with the port. </summary>
        public ContainerGroupNetworkProtocol? Protocol { get; set; }
        /// <summary> The port number. </summary>
        public int Port { get; set; }
    }
}
