// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A class representing the ConfigurationStore data model. </summary>
    public partial class ConfigurationStoreData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ConfigurationStoreData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The sku of the configuration store. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public ConfigurationStoreData(AzureLocation location, AppConfigurationSku sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionReference>();
        }

        /// <summary> Initializes a new instance of ConfigurationStoreData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed identity information, if configured. </param>
        /// <param name="sku"> The sku of the configuration store. </param>
        /// <param name="provisioningState"> The provisioning state of the configuration store. </param>
        /// <param name="creationDate"> The creation date of configuration store. </param>
        /// <param name="endpoint"> The DNS endpoint where the configuration store API will be available. </param>
        /// <param name="encryption"> The encryption settings of the configuration store. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        internal ConfigurationStoreData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, AppConfigurationSku sku, ProvisioningState? provisioningState, DateTimeOffset? creationDate, string endpoint, Models.EncryptionProperties encryption, IReadOnlyList<PrivateEndpointConnectionReference> privateEndpointConnections, PublicNetworkAccess? publicNetworkAccess) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Sku = sku;
            ProvisioningState = provisioningState;
            CreationDate = creationDate;
            Endpoint = endpoint;
            Encryption = encryption;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
        }

        /// <summary> The managed identity information, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The sku of the configuration store. </summary>
        internal AppConfigurationSku Sku { get; set; }
        /// <summary> The SKU name of the configuration store. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set => Sku = new AppConfigurationSku(value);
        }

        /// <summary> The provisioning state of the configuration store. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The creation date of configuration store. </summary>
        public DateTimeOffset? CreationDate { get; }
        /// <summary> The DNS endpoint where the configuration store API will be available. </summary>
        public string Endpoint { get; }
        /// <summary> The encryption settings of the configuration store. </summary>
        internal Models.EncryptionProperties Encryption { get; set; }
        /// <summary> Key vault properties. </summary>
        public Models.KeyVaultProperties EncryptionKeyVaultProperties
        {
            get => Encryption is null ? default : Encryption.KeyVaultProperties;
            set
            {
                if (Encryption is null)
                    Encryption = new Models.EncryptionProperties();
                Encryption.KeyVaultProperties = value;
            }
        }

        /// <summary> The list of private endpoint connections that are set up for this resource. </summary>
        public IReadOnlyList<PrivateEndpointConnectionReference> PrivateEndpointConnections { get; }
        /// <summary> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
