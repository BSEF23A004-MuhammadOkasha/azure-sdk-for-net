// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ContainerRegistry.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ContainerRegistry;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters for updating a container registry.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RegistryUpdateParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the RegistryUpdateParametersInner
        /// class.
        /// </summary>
        public RegistryUpdateParametersInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegistryUpdateParametersInner
        /// class.
        /// </summary>
        /// <param name="tags">The tags for the container registry.</param>
        /// <param name="adminUserEnabled">The value that indicates whether the
        /// admin user is enabled. This value is false by default.</param>
        /// <param name="storageAccount">The parameters of a storage account
        /// for the container registry. If specified, the storage account must
        /// be in the same physical location as the container registry.</param>
        public RegistryUpdateParametersInner(IDictionary<string, string> tags = default(IDictionary<string, string>), bool? adminUserEnabled = default(bool?), StorageAccountParameters storageAccount = default(StorageAccountParameters))
        {
            Tags = tags;
            AdminUserEnabled = adminUserEnabled;
            StorageAccount = storageAccount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tags for the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the value that indicates whether the admin user is
        /// enabled. This value is false by default.
        /// </summary>
        [JsonProperty(PropertyName = "properties.adminUserEnabled")]
        public bool? AdminUserEnabled { get; set; }

        /// <summary>
        /// Gets or sets the parameters of a storage account for the container
        /// registry. If specified, the storage account must be in the same
        /// physical location as the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccount")]
        public StorageAccountParameters StorageAccount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccount != null)
            {
                StorageAccount.Validate();
            }
        }
    }
}
