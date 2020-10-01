// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines reference to a proxy resource.
    /// </summary>
    public partial class ProxyResourceReference : AzureResourceReference
    {
        /// <summary>
        /// Initializes a new instance of the ProxyResourceReference class.
        /// </summary>
        public ProxyResourceReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProxyResourceReference class.
        /// </summary>
        /// <param name="sourceArmResourceId">Gets the ARM resource ID of the
        /// tracked resource being referenced.</param>
        /// <param name="name">Gets the name of the proxy resource on the
        /// target side.</param>
        public ProxyResourceReference(string sourceArmResourceId, string name = default(string))
            : base(sourceArmResourceId)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the proxy resource on the target side.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
