// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Cdn;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CIDR Ip address
    /// </summary>
    public partial class CidrIpAddress
    {
        /// <summary>
        /// Initializes a new instance of the CidrIpAddress class.
        /// </summary>
        public CidrIpAddress()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CidrIpAddress class.
        /// </summary>
        /// <param name="baseIpAddress">Ip adress itself.</param>
        /// <param name="prefixLength">The length of the prefix of the ip
        /// address.</param>
        public CidrIpAddress(string baseIpAddress = default(string), int? prefixLength = default(int?))
        {
            BaseIpAddress = baseIpAddress;
            PrefixLength = prefixLength;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ip adress itself.
        /// </summary>
        [JsonProperty(PropertyName = "baseIpAddress")]
        public string BaseIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the length of the prefix of the ip address.
        /// </summary>
        [JsonProperty(PropertyName = "prefixLength")]
        public int? PrefixLength { get; set; }

    }
}
