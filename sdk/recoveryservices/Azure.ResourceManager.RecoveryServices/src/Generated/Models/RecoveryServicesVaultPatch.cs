// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Patch Resource information, as returned by the resource provider. </summary>
    public partial class RecoveryServicesVaultPatch : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesVaultPatch"/>. </summary>
        /// <param name="location"> The location. </param>
        public RecoveryServicesVaultPatch(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesVaultPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <param name="sku"> Identifies the unique system identifier for each Azure resource. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="etag"> Optional ETag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryServicesVaultPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, RecoveryServicesVaultProperties properties, RecoveryServicesSku sku, ManagedServiceIdentity identity, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            Sku = sku;
            Identity = identity;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesVaultPatch"/> for deserialization. </summary>
        internal RecoveryServicesVaultPatch()
        {
        }

        /// <summary> Properties of the vault. </summary>
        public RecoveryServicesVaultProperties Properties { get; set; }
        /// <summary> Identifies the unique system identifier for each Azure resource. </summary>
        public RecoveryServicesSku Sku { get; set; }
        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
