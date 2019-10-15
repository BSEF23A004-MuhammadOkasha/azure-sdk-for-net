// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The network endpoint.
    /// </summary>
    public partial class IntegrationServiceEnvironmentNetworkEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationServiceEnvironmentNetworkEndpoint class.
        /// </summary>
        public IntegrationServiceEnvironmentNetworkEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationServiceEnvironmentNetworkEndpoint class.
        /// </summary>
        /// <param name="accessibility">The accessibility state. Possible
        /// values include: 'NotSpecified', 'Unknown', 'Available',
        /// 'NotAvailable'</param>
        /// <param name="domainName">The domain name.</param>
        /// <param name="ports">The ports.</param>
        public IntegrationServiceEnvironmentNetworkEndpoint(string accessibility = default(string), string domainName = default(string), IList<string> ports = default(IList<string>))
        {
            Accessibility = accessibility;
            DomainName = domainName;
            Ports = ports;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the accessibility state. Possible values include:
        /// 'NotSpecified', 'Unknown', 'Available', 'NotAvailable'
        /// </summary>
        [JsonProperty(PropertyName = "accessibility")]
        public string Accessibility { get; set; }

        /// <summary>
        /// Gets or sets the domain name.
        /// </summary>
        [JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets the ports.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public IList<string> Ports { get; set; }

    }
}
