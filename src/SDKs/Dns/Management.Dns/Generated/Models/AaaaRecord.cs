// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Dns.Models
{
    using Azure;
    using Management;
    using Dns;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An AAAA record.
    /// </summary>
    public partial class AaaaRecord
    {
        /// <summary>
        /// Initializes a new instance of the AaaaRecord class.
        /// </summary>
        public AaaaRecord() { }

        /// <summary>
        /// Initializes a new instance of the AaaaRecord class.
        /// </summary>
        /// <param name="ipv6Address">The IPv6 address of this AAAA
        /// record.</param>
        public AaaaRecord(string ipv6Address = default(string))
        {
            Ipv6Address = ipv6Address;
        }

        /// <summary>
        /// Gets or sets the IPv6 address of this AAAA record.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6Address")]
        public string Ipv6Address { get; set; }

    }
}

