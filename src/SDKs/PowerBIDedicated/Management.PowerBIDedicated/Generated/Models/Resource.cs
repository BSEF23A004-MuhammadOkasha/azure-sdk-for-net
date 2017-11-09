// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PowerBIDedicated.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an instance of an PowerBI Dedicated resource.
    /// </summary>
    public partial class Resource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        public Resource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        /// <param name="location">Location of the PowerBI Dedicated
        /// resource.</param>
        /// <param name="sku">The SKU of the PowerBI Dedicated
        /// resource.</param>
        /// <param name="id">An identifier that represents the PowerBI
        /// Dedicated resource.</param>
        /// <param name="name">The name of the PowerBI Dedicated
        /// resource.</param>
        /// <param name="type">The type of the PowerBI Dedicated
        /// resource.</param>
        /// <param name="tags">Key-value pairs of additional resource
        /// provisioning properties.</param>
        public Resource(string location, ResourceSku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Sku = sku;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets an identifier that represents the PowerBI Dedicated resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the PowerBI Dedicated resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of the PowerBI Dedicated resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets location of the PowerBI Dedicated resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the SKU of the PowerBI Dedicated resource.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ResourceSku Sku { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of additional resource provisioning
        /// properties.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
