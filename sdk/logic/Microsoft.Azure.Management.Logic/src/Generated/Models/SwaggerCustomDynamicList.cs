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
    /// The swagger custom dynamic list.
    /// </summary>
    public partial class SwaggerCustomDynamicList
    {
        /// <summary>
        /// Initializes a new instance of the SwaggerCustomDynamicList class.
        /// </summary>
        public SwaggerCustomDynamicList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SwaggerCustomDynamicList class.
        /// </summary>
        /// <param name="operationId">The operation id to fetch dynamic
        /// schema.</param>
        /// <param name="builtInOperation">The built in operation.</param>
        /// <param name="itemsPath">The path to a response property (relative
        /// to the response object, not the response body) which contains an
        /// array of dynamic value items.</param>
        /// <param name="itemValuePath">The path to a property which defines
        /// the value which should be used.</param>
        /// <param name="itemTitlePath">The path to an item property which
        /// defines the display name of the item.</param>
        /// <param name="parameters">The parameters.</param>
        public SwaggerCustomDynamicList(string operationId = default(string), string builtInOperation = default(string), string itemsPath = default(string), string itemValuePath = default(string), string itemTitlePath = default(string), IDictionary<string, SwaggerCustomDynamicProperties> parameters = default(IDictionary<string, SwaggerCustomDynamicProperties>))
        {
            OperationId = operationId;
            BuiltInOperation = builtInOperation;
            ItemsPath = itemsPath;
            ItemValuePath = itemValuePath;
            ItemTitlePath = itemTitlePath;
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the operation id to fetch dynamic schema.
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or sets the built in operation.
        /// </summary>
        [JsonProperty(PropertyName = "builtInOperation")]
        public string BuiltInOperation { get; set; }

        /// <summary>
        /// Gets or sets the path to a response property (relative to the
        /// response object, not the response body) which contains an array of
        /// dynamic value items.
        /// </summary>
        [JsonProperty(PropertyName = "itemsPath")]
        public string ItemsPath { get; set; }

        /// <summary>
        /// Gets or sets the path to a property which defines the value which
        /// should be used.
        /// </summary>
        [JsonProperty(PropertyName = "itemValuePath")]
        public string ItemValuePath { get; set; }

        /// <summary>
        /// Gets or sets the path to an item property which defines the display
        /// name of the item.
        /// </summary>
        [JsonProperty(PropertyName = "itemTitlePath")]
        public string ItemTitlePath { get; set; }

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, SwaggerCustomDynamicProperties> Parameters { get; set; }

    }
}
