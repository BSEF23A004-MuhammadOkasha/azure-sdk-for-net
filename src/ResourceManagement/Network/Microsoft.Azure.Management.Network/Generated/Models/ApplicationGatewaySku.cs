// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// SKU of application gateway
    /// </summary>
    public partial class ApplicationGatewaySku
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewaySku class.
        /// </summary>
        public ApplicationGatewaySku() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewaySku class.
        /// </summary>
        public ApplicationGatewaySku(string name = default(string), string tier = default(string), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
        }

        /// <summary>
        /// Gets or sets name of application gateway SKU. Possible values
        /// include: 'Standard_Small', 'Standard_Medium', 'Standard_Large'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets tier of application gateway. Possible values include:
        /// 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets capacity (instance count) of application gateway
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

    }
}
