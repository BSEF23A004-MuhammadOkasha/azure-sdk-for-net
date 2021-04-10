// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Dynamic delivery attribute mapping details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Dynamic")]
    [Rest.Serialization.JsonTransformation]
    public partial class DynamicDeliveryAttributeMapping : DeliveryAttributeMapping
    {
        /// <summary>
        /// Initializes a new instance of the DynamicDeliveryAttributeMapping
        /// class.
        /// </summary>
        public DynamicDeliveryAttributeMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicDeliveryAttributeMapping
        /// class.
        /// </summary>
        /// <param name="name">Name of the delivery attribute or
        /// header.</param>
        /// <param name="sourceField">JSON path in the event which contains
        /// attribute value.</param>
        public DynamicDeliveryAttributeMapping(string name = default(string), string sourceField = default(string))
            : base(name)
        {
            SourceField = sourceField;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets JSON path in the event which contains attribute value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceField")]
        public string SourceField { get; set; }

    }
}
