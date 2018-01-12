// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Localized display information of an operation.
    /// </summary>
    public partial class ClientDiscoveryDisplay
    {
        /// <summary>
        /// Initializes a new instance of the ClientDiscoveryDisplay class.
        /// </summary>
        public ClientDiscoveryDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClientDiscoveryDisplay class.
        /// </summary>
        /// <param name="provider">Name of the provider for display
        /// purposes</param>
        /// <param name="resource">ResourceType for which this Operation can be
        /// performed.</param>
        /// <param name="operation">Operations Name itself.</param>
        /// <param name="description">Description of the operation having
        /// details of what operation is about.</param>
        public ClientDiscoveryDisplay(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the provider for display purposes
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets resourceType for which this Operation can be
        /// performed.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets operations Name itself.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets description of the operation having details of what
        /// operation is about.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
