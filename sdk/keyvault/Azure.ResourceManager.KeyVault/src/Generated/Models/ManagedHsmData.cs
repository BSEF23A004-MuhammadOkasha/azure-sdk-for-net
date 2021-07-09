// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing the ManagedHsm data model. </summary>
    public partial class ManagedHsmData : ManagedHsmResource
    {
        /// <summary> Initializes a new instance of ManagedHsmData. </summary>
        /// <param name="location"> The location. </param>
        public ManagedHsmData(LocationData location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ManagedHsmData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the key vault resource. </param>
        /// <param name="properties"> Properties of the managed HSM. </param>
        internal ManagedHsmData(ResourceGroupResourceIdentifier id, string name, ResourceType type, LocationData location, IDictionary<string, string> tags, ManagedHsmSku sku, SystemData systemData, ManagedHsmProperties properties) : base(id, name, type, location, tags, sku, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the managed HSM. </summary>
        public ManagedHsmProperties Properties { get; set; }
    }
}
