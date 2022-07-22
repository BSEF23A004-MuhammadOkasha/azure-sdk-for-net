// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Orbital.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Customer End point to store/retrieve data during a contact.
    /// </summary>
    public partial class EndPoint
    {
        /// <summary>
        /// Initializes a new instance of the EndPoint class.
        /// </summary>
        public EndPoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EndPoint class.
        /// </summary>
        /// <param name="ipAddress">IP Address.</param>
        /// <param name="endPointName">Name of an end point.</param>
        /// <param name="port">TCP port to listen on to receive data.</param>
        /// <param name="protocol">Protocol either UDP or TCP. Possible values
        /// include: 'TCP', 'UDP'</param>
        public EndPoint(string ipAddress, string endPointName, string port, string protocol)
        {
            IpAddress = ipAddress;
            EndPointName = endPointName;
            Port = port;
            Protocol = protocol;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets IP Address.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets name of an end point.
        /// </summary>
        [JsonProperty(PropertyName = "endPointName")]
        public string EndPointName { get; set; }

        /// <summary>
        /// Gets or sets TCP port to listen on to receive data.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }

        /// <summary>
        /// Gets or sets protocol either UDP or TCP. Possible values include:
        /// 'TCP', 'UDP'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

    }
}
