// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureArcData.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Display metadata associated with the operation.
    /// </summary>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        /// <param name="provider">The localized friendly form of the resource
        /// provider name.</param>
        /// <param name="resource">The localized friendly form of the resource
        /// type related to this action/operation.</param>
        /// <param name="operation">The localized friendly name for the
        /// operation.</param>
        /// <param name="description">The localized friendly description for
        /// the operation.</param>
        public OperationDisplay(string provider, string resource, string operation, string description)
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
        /// Gets or sets the localized friendly form of the resource provider
        /// name.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the localized friendly form of the resource type
        /// related to this action/operation.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets the localized friendly name for the operation.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets the localized friendly description for the operation.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
