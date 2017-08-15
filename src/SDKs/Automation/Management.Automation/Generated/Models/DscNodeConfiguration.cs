// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the dsc node configuration.
    /// </summary>
    public partial class DscNodeConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the DscNodeConfiguration class.
        /// </summary>
        public DscNodeConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DscNodeConfiguration class.
        /// </summary>
        /// <param name="name">Gets or sets the node configuration
        /// name.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified
        /// time.</param>
        /// <param name="creationTime">Gets or sets creation time.</param>
        /// <param name="configuration">Gets or sets the configuration of the
        /// node.</param>
        /// <param name="id">Gets or sets the id of the resource.</param>
        public DscNodeConfiguration(string name = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?), System.DateTime? creationTime = default(System.DateTime?), DscConfigurationAssociationProperty configuration = default(DscConfigurationAssociationProperty), string id = default(string))
        {
            Name = name;
            LastModifiedTime = lastModifiedTime;
            CreationTime = creationTime;
            Configuration = configuration;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the node configuration name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets creation time.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the configuration of the node.
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public DscConfigurationAssociationProperty Configuration { get; set; }

        /// <summary>
        /// Gets or sets the id of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
