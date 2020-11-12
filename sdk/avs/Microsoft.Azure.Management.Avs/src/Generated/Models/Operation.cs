// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A REST API operation
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">Name of the operation being performed on this
        /// object</param>
        /// <param name="display">Contains the localized display information
        /// for this operation</param>
        /// <param name="isDataAction">Gets or sets a value indicating whether
        /// the operation is a data action or not</param>
        /// <param name="origin">Origin of the operation</param>
        /// <param name="properties">Properties of the operation</param>
        public Operation(string name = default(string), OperationDisplay display = default(OperationDisplay), bool? isDataAction = default(bool?), string origin = default(string), OperationProperties properties = default(OperationProperties))
        {
            Name = name;
            Display = display;
            IsDataAction = isDataAction;
            Origin = origin;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the operation being performed on this object
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets contains the localized display information for this operation
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether the operation is a data
        /// action or not
        /// </summary>
        [JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction { get; set; }

        /// <summary>
        /// Gets or sets origin of the operation
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets properties of the operation
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public OperationProperties Properties { get; set; }

    }
}
