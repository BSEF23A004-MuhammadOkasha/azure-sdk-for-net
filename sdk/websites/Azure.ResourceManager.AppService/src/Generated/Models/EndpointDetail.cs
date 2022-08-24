// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Current TCP connectivity information from the App Service Environment to a single endpoint.
    /// Serialized Name: EndpointDetail
    /// </summary>
    public partial class EndpointDetail
    {
        /// <summary> Initializes a new instance of EndpointDetail. </summary>
        internal EndpointDetail()
        {
        }

        /// <summary> Initializes a new instance of EndpointDetail. </summary>
        /// <param name="ipAddress">
        /// An IP Address that Domain Name currently resolves to.
        /// Serialized Name: EndpointDetail.ipAddress
        /// </param>
        /// <param name="port">
        /// The port an endpoint is connected to.
        /// Serialized Name: EndpointDetail.port
        /// </param>
        /// <param name="latency">
        /// The time in milliseconds it takes for a TCP connection to be created from the App Service Environment to this IpAddress at this Port.
        /// Serialized Name: EndpointDetail.latency
        /// </param>
        /// <param name="isAccessible">
        /// Whether it is possible to create a TCP connection from the App Service Environment to this IpAddress at this Port.
        /// Serialized Name: EndpointDetail.isAccessible
        /// </param>
        internal EndpointDetail(string ipAddress, int? port, double? latency, bool? isAccessible)
        {
            IPAddress = ipAddress;
            Port = port;
            Latency = latency;
            IsAccessible = isAccessible;
        }

        /// <summary>
        /// An IP Address that Domain Name currently resolves to.
        /// Serialized Name: EndpointDetail.ipAddress
        /// </summary>
        public string IPAddress { get; }
        /// <summary>
        /// The port an endpoint is connected to.
        /// Serialized Name: EndpointDetail.port
        /// </summary>
        public int? Port { get; }
        /// <summary>
        /// The time in milliseconds it takes for a TCP connection to be created from the App Service Environment to this IpAddress at this Port.
        /// Serialized Name: EndpointDetail.latency
        /// </summary>
        public double? Latency { get; }
        /// <summary>
        /// Whether it is possible to create a TCP connection from the App Service Environment to this IpAddress at this Port.
        /// Serialized Name: EndpointDetail.isAccessible
        /// </summary>
        public bool? IsAccessible { get; }
    }
}
