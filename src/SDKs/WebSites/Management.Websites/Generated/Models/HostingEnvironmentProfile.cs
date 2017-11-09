// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specification for an App Service Environment to use for this resource.
    /// </summary>
    public partial class HostingEnvironmentProfile
    {
        /// <summary>
        /// Initializes a new instance of the HostingEnvironmentProfile class.
        /// </summary>
        public HostingEnvironmentProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HostingEnvironmentProfile class.
        /// </summary>
        /// <param name="id">Resource ID of the App Service
        /// Environment.</param>
        /// <param name="name">Name of the App Service Environment.</param>
        /// <param name="type">Resource type of the App Service
        /// Environment.</param>
        public HostingEnvironmentProfile(string id = default(string), string name = default(string), string type = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource ID of the App Service Environment.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets name of the App Service Environment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type of the App Service Environment.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
