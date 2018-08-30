// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single Event Hubs Cluster resource in List or Get operations.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Cluster : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        public Cluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Resource location</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">Properties of the cluster SKU.</param>
        /// <param name="created">The UTC time when the Event Hubs Cluster was
        /// created.</param>
        /// <param name="updated">The UTC time when the Event Hubs Cluster was
        /// last updated.</param>
        /// <param name="metricId">The metric ID of the cluster resource.
        /// Provided by the service and not modifiable by the user.</param>
        public Cluster(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ClusterSku sku = default(ClusterSku), string created = default(string), string updated = default(string), string metricId = default(string))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            Created = created;
            Updated = updated;
            MetricId = metricId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of the cluster SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ClusterSku Sku { get; set; }

        /// <summary>
        /// Gets the UTC time when the Event Hubs Cluster was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public string Created { get; private set; }

        /// <summary>
        /// Gets the UTC time when the Event Hubs Cluster was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updated")]
        public string Updated { get; private set; }

        /// <summary>
        /// Gets the metric ID of the cluster resource. Provided by the service
        /// and not modifiable by the user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricId")]
        public string MetricId { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
