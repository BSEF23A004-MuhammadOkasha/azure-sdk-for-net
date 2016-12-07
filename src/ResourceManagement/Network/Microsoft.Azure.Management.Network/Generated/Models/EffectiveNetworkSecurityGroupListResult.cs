// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Response for list effective network security groups API service call.
    /// </summary>
    public partial class EffectiveNetworkSecurityGroupListResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EffectiveNetworkSecurityGroupListResult class.
        /// </summary>
        public EffectiveNetworkSecurityGroupListResult() { }

        /// <summary>
        /// Initializes a new instance of the
        /// EffectiveNetworkSecurityGroupListResult class.
        /// </summary>
        /// <param name="value">A list of effective network security
        /// groups.</param>
        /// <param name="nextLink">The URL to get the next set of
        /// results.</param>
        public EffectiveNetworkSecurityGroupListResult(System.Collections.Generic.IList<EffectiveNetworkSecurityGroup> value = default(System.Collections.Generic.IList<EffectiveNetworkSecurityGroup>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets a list of effective network security groups.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<EffectiveNetworkSecurityGroup> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to get the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
