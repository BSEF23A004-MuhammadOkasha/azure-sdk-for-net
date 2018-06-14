// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.4.36.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Azure Data Factory nested object which contains the information and
    /// credential which can be used to connect with related store or compute
    /// resource.
    /// </summary>
    public partial class LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the LinkedService class.
        /// </summary>
        public LinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinkedService class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        public LinkedService(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>))
        {
            AdditionalProperties = additionalProperties;
            ConnectVia = connectVia;
            Description = description;
            Parameters = parameters;
            Annotations = annotations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets the integration runtime reference.
        /// </summary>
        [JsonProperty(PropertyName = "connectVia")]
        public IntegrationRuntimeReference ConnectVia { get; set; }

        /// <summary>
        /// Gets or sets linked service description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets parameters for linked service.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, ParameterSpecification> Parameters { get; set; }

        /// <summary>
        /// Gets or sets list of tags that can be used for describing the
        /// Dataset.
        /// </summary>
        [JsonProperty(PropertyName = "annotations")]
        public IList<object> Annotations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConnectVia != null)
            {
                ConnectVia.Validate();
            }
            if (Parameters != null)
            {
                foreach (var valueElement in Parameters.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}
