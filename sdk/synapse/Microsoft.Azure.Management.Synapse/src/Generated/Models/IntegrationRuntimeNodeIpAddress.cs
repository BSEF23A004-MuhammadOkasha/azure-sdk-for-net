// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The IP address of self-hosted integration runtime node.
    /// </summary>
    public partial class IntegrationRuntimeNodeIpAddress
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeNodeIpAddress
        /// class.
        /// </summary>
        public IntegrationRuntimeNodeIpAddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeNodeIpAddress
        /// class.
        /// </summary>
        /// <param name="ipAddress">The IP address of self-hosted integration
        /// runtime node.</param>
        public IntegrationRuntimeNodeIpAddress(string ipAddress = default(string))
        {
            IpAddress = ipAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the IP address of self-hosted integration runtime node.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; private set; }

    }
}
