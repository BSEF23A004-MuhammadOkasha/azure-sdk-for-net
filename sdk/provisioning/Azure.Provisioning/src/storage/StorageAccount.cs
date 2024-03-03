﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text;
using Azure.Core;
using Azure.Provisioning.ResourceManager;
using Azure.ResourceManager.Storage;
using Azure.ResourceManager.Storage.Models;

namespace Azure.Provisioning.Storage
{
    /// <summary>
    /// Represents a storage account.
    /// </summary>
    public class StorageAccount : Resource<StorageAccountData>
    {
        private const string ResourceTypeName = "Microsoft.Storage/storageAccounts";

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageAccount"/>.
        /// </summary>
        /// <param name="scope">The scope.</param>
        /// <param name="kind">The kind.</param>
        /// <param name="sku">The sku.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="name">The name.</param>
        public StorageAccount(IConstruct scope, StorageKind kind, StorageSkuName sku, ResourceGroup? parent = null, string name = "sa")
            : base(scope, parent, name, ResourceTypeName, "2022-09-01", (name) => ArmStorageModelFactory.StorageAccountData(
                name: name,
                resourceType: ResourceTypeName,
                location: Environment.GetEnvironmentVariable("AZURE_LOCATION") ?? AzureLocation.WestUS,
                sku: new StorageSku(sku),
                kind: kind,
                // access tier cannot be set for premium accounts
                accessTier: kind == StorageKind.BlobStorage || kind == StorageKind.StorageV2 ? StorageAccountAccessTier.Hot : null))
        {
            AssignProperty(data => data.Name, GetAzureName(scope, name));
        }

        /// <inheritdoc/>
        protected override Resource? FindParentInScope(IConstruct scope)
        {
            var result = base.FindParentInScope(scope);
            if (result is null)
            {
                result = scope.GetOrAddResourceGroup();
            }
            return result;
        }

        /// <inheritdoc/>
        protected override string GetAzureName(IConstruct scope, string resourceName)
        {
            return $"toLower(take(concat('{resourceName}', uniqueString(resourceGroup().id)), 24))";
        }
    }
}
