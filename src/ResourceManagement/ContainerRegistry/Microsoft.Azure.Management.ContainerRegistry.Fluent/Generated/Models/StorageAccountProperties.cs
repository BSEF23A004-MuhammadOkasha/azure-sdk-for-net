// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerRegistry.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ContainerRegistry;
    using Microsoft.Azure.Management.ContainerRegistry.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of a storage account for a container registry.
    /// </summary>
    public partial class StorageAccountProperties
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountProperties class.
        /// </summary>
        public StorageAccountProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountProperties class.
        /// </summary>
        /// <param name="name">The name of the storage account.</param>
        public StorageAccountProperties(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
