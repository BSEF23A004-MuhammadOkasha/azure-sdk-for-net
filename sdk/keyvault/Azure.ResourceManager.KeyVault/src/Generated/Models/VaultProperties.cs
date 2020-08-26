// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Properties of the vault. </summary>
    public partial class VaultProperties
    {
        /// <summary> Initializes a new instance of VaultProperties. </summary>
        /// <param name="tenantId"> The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault. </param>
        /// <param name="sku"> SKU details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public VaultProperties(Guid tenantId, Sku sku)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            TenantId = tenantId;
            Sku = sku;
            AccessPolicies = new ChangeTrackingList<AccessPolicyEntry>();
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionItem>();
        }

        /// <summary> Initializes a new instance of VaultProperties. </summary>
        /// <param name="tenantId"> The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="accessPolicies"> An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault&apos;s tenant ID. When `createMode` is set to `recover`, access policies are not required. Otherwise, access policies are required. </param>
        /// <param name="vaultUri"> The URI of the vault for performing operations on keys and secrets. </param>
        /// <param name="enabledForDeployment"> Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key vault. </param>
        /// <param name="enabledForDiskEncryption"> Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys. </param>
        /// <param name="enabledForTemplateDeployment"> Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault. </param>
        /// <param name="enableSoftDelete"> Property to specify whether the &apos;soft delete&apos; functionality is enabled for this key vault. If omitted, assume true as default value. Once set to true, cannot be reverted to false. </param>
        /// <param name="createMode"> The vault&apos;s create mode to indicate whether the vault need to be recovered or not. </param>
        /// <param name="enablePurgeProtection"> Property specifying whether protection against purge is enabled for this vault. Setting this property to true activates protection against purge for this vault and its content - only the Key Vault service may initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible - that is, the property does not accept false as its value. </param>
        /// <param name="networkAcls"> Rules governing the accessibility of the key vault from specific network locations. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the key vault. </param>
        internal VaultProperties(Guid tenantId, Sku sku, IList<AccessPolicyEntry> accessPolicies, string vaultUri, bool? enabledForDeployment, bool? enabledForDiskEncryption, bool? enabledForTemplateDeployment, bool? enableSoftDelete, CreateMode? createMode, bool? enablePurgeProtection, NetworkRuleSet networkAcls, IReadOnlyList<PrivateEndpointConnectionItem> privateEndpointConnections)
        {
            TenantId = tenantId;
            Sku = sku;
            AccessPolicies = accessPolicies;
            VaultUri = vaultUri;
            EnabledForDeployment = enabledForDeployment;
            EnabledForDiskEncryption = enabledForDiskEncryption;
            EnabledForTemplateDeployment = enabledForTemplateDeployment;
            EnableSoftDelete = enableSoftDelete;
            CreateMode = createMode;
            EnablePurgeProtection = enablePurgeProtection;
            NetworkAcls = networkAcls;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary> The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault. </summary>
        public Guid TenantId { get; set; }
        /// <summary> SKU details. </summary>
        public Sku Sku { get; set; }
        /// <summary> An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault&apos;s tenant ID. When `createMode` is set to `recover`, access policies are not required. Otherwise, access policies are required. </summary>
        public IList<AccessPolicyEntry> AccessPolicies { get; }
        /// <summary> The URI of the vault for performing operations on keys and secrets. </summary>
        public string VaultUri { get; set; }
        /// <summary> Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key vault. </summary>
        public bool? EnabledForDeployment { get; set; }
        /// <summary> Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys. </summary>
        public bool? EnabledForDiskEncryption { get; set; }
        /// <summary> Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault. </summary>
        public bool? EnabledForTemplateDeployment { get; set; }
        /// <summary> Property to specify whether the &apos;soft delete&apos; functionality is enabled for this key vault. If omitted, assume true as default value. Once set to true, cannot be reverted to false. </summary>
        public bool? EnableSoftDelete { get; set; }
        /// <summary> The vault&apos;s create mode to indicate whether the vault need to be recovered or not. </summary>
        public CreateMode? CreateMode { get; set; }
        /// <summary> Property specifying whether protection against purge is enabled for this vault. Setting this property to true activates protection against purge for this vault and its content - only the Key Vault service may initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible - that is, the property does not accept false as its value. </summary>
        public bool? EnablePurgeProtection { get; set; }
        /// <summary> Rules governing the accessibility of the key vault from specific network locations. </summary>
        public NetworkRuleSet NetworkAcls { get; set; }
        /// <summary> List of private endpoint connections associated with the key vault. </summary>
        public IReadOnlyList<PrivateEndpointConnectionItem> PrivateEndpointConnections { get; }
    }
}
