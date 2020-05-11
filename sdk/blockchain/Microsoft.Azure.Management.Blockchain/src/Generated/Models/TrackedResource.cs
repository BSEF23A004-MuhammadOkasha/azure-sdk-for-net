// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blockchain.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The resource model definition for a top level resource.
    /// </summary>
    public partial class TrackedResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the TrackedResource class.
        /// </summary>
        public TrackedResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrackedResource class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id of the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the service - e.g.
        /// "Microsoft.Blockchain"</param>
        /// <param name="location">The GEO location of the blockchain
        /// service.</param>
        /// <param name="tags">Tags of the service which is a list of key value
        /// pairs that describes the resource.</param>
        public TrackedResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id, name, type)
        {
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the GEO location of the blockchain service.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets tags of the service which is a list of key value pairs
        /// that describes the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
