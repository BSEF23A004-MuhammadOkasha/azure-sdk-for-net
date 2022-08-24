// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The IP Addresses and Ports that require inbound network access to and within the subnet of the App Service Environment.
    /// Serialized Name: InboundEnvironmentEndpoint
    /// </summary>
    public partial class InboundEnvironmentEndpoint
    {
        /// <summary> Initializes a new instance of InboundEnvironmentEndpoint. </summary>
        internal InboundEnvironmentEndpoint()
        {
            Endpoints = new ChangeTrackingList<string>();
            Ports = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of InboundEnvironmentEndpoint. </summary>
        /// <param name="description">
        /// Short text describing the purpose of the network traffic.
        /// Serialized Name: InboundEnvironmentEndpoint.description
        /// </param>
        /// <param name="endpoints">
        /// The IP addresses that network traffic will originate from in cidr notation.
        /// Serialized Name: InboundEnvironmentEndpoint.endpoints
        /// </param>
        /// <param name="ports">
        /// The ports that network traffic will arrive to the App Service Environment at.
        /// Serialized Name: InboundEnvironmentEndpoint.ports
        /// </param>
        internal InboundEnvironmentEndpoint(string description, IReadOnlyList<string> endpoints, IReadOnlyList<string> ports)
        {
            Description = description;
            Endpoints = endpoints;
            Ports = ports;
        }

        /// <summary>
        /// Short text describing the purpose of the network traffic.
        /// Serialized Name: InboundEnvironmentEndpoint.description
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// The IP addresses that network traffic will originate from in cidr notation.
        /// Serialized Name: InboundEnvironmentEndpoint.endpoints
        /// </summary>
        public IReadOnlyList<string> Endpoints { get; }
        /// <summary>
        /// The ports that network traffic will arrive to the App Service Environment at.
        /// Serialized Name: InboundEnvironmentEndpoint.ports
        /// </summary>
        public IReadOnlyList<string> Ports { get; }
    }
}
