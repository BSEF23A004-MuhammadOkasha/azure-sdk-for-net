// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Gets the application SSH endpoint. </summary>
    public partial class HDInsightApplicationEndpoint
    {
        /// <summary> Initializes a new instance of HDInsightApplicationEndpoint. </summary>
        public HDInsightApplicationEndpoint()
        {
        }

        /// <summary> Initializes a new instance of HDInsightApplicationEndpoint. </summary>
        /// <param name="endpointLocation"> The location of the endpoint. </param>
        /// <param name="destinationPort"> The destination port to connect to. </param>
        /// <param name="publicPort"> The public port to connect to. </param>
        /// <param name="privateIPAddress"> The private ip address of the endpoint. </param>
        internal HDInsightApplicationEndpoint(string endpointLocation, int? destinationPort, int? publicPort, IPAddress privateIPAddress)
        {
            EndpointLocation = endpointLocation;
            DestinationPort = destinationPort;
            PublicPort = publicPort;
            PrivateIPAddress = privateIPAddress;
        }

        /// <summary> The location of the endpoint. </summary>
        public string EndpointLocation { get; set; }
        /// <summary> The destination port to connect to. </summary>
        public int? DestinationPort { get; set; }
        /// <summary> The public port to connect to. </summary>
        public int? PublicPort { get; set; }
        /// <summary> The private ip address of the endpoint. </summary>
        public IPAddress PrivateIPAddress { get; set; }
    }
}
