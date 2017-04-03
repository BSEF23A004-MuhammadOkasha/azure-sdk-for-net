// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Geographical region.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GeoRegionInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the GeoRegionInner class.
        /// </summary>
        public GeoRegionInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoRegionInner class.
        /// </summary>
        /// <param name="geoRegionName">Region name.</param>
        /// <param name="description">Region description.</param>
        /// <param name="displayName">Display name for region.</param>
        public GeoRegionInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string geoRegionName = default(string), string description = default(string), string displayName = default(string))
            : base(location, id, name, type, tags)
        {
            GeoRegionName = geoRegionName;
            Description = description;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets region name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string GeoRegionName { get; private set; }

        /// <summary>
        /// Gets region description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets display name for region.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

    }
}
