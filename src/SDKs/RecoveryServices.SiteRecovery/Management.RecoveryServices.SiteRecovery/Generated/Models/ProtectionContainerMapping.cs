// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Protection container mapping object.
    /// </summary>
    public partial class ProtectionContainerMapping : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ProtectionContainerMapping class.
        /// </summary>
        public ProtectionContainerMapping()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProtectionContainerMapping class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource Name</param>
        /// <param name="type">Resource Type</param>
        /// <param name="location">Resource Location</param>
        /// <param name="properties">The custom data.</param>
        public ProtectionContainerMapping(string id = default(string), string name = default(string), string type = default(string), string location = default(string), ProtectionContainerMappingProperties properties = default(ProtectionContainerMappingProperties))
            : base(id, name, type, location)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the custom data.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ProtectionContainerMappingProperties Properties { get; set; }

    }
}
