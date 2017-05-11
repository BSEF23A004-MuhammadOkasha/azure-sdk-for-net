// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Properties of a network port.
    /// </summary>
    public partial class Port
    {
        /// <summary>
        /// Initializes a new instance of the Port class.
        /// </summary>
        public Port() { }

        /// <summary>
        /// Initializes a new instance of the Port class.
        /// </summary>
        public Port(string transportProtocol = default(string), int? backendPort = default(int?))
        {
            TransportProtocol = transportProtocol;
            BackendPort = backendPort;
        }

        /// <summary>
        /// Protocol type of the port. Possible values include: 'Tcp', 'Udp'
        /// </summary>
        [JsonProperty(PropertyName = "transportProtocol")]
        public string TransportProtocol { get; set; }

        /// <summary>
        /// Backend port of the target virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "backendPort")]
        public int? BackendPort { get; set; }

    }
}
