// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing the DeletedAccount data model. </summary>
    public partial class DeletedAccountData : ResourceData
    {
        /// <summary> Initializes a new instance of DeletedAccountData. </summary>
        public DeletedAccountData()
        {
        }

        /// <summary> Initializes a new instance of DeletedAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="storageAccountResourceId"> Full resource id of the original storage account. </param>
        /// <param name="location"> Location of the deleted account. </param>
        /// <param name="restoreReference"> Can be used to attempt recovering this deleted account via PutStorageAccount API. </param>
        /// <param name="createOn"> Creation time of the deleted account. </param>
        /// <param name="deleteOn"> Deletion time of the deleted account. </param>
        internal DeletedAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier storageAccountResourceId, AzureLocation? location, string restoreReference, DateTimeOffset? createOn, DateTimeOffset? deleteOn) : base(id, name, resourceType, systemData)
        {
            StorageAccountResourceId = storageAccountResourceId;
            Location = location;
            RestoreReference = restoreReference;
            CreateOn = createOn;
            DeleteOn = deleteOn;
        }

        /// <summary> Full resource id of the original storage account. </summary>
        public ResourceIdentifier StorageAccountResourceId { get; }
        /// <summary> Location of the deleted account. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Can be used to attempt recovering this deleted account via PutStorageAccount API. </summary>
        public string RestoreReference { get; }
        /// <summary> Creation time of the deleted account. </summary>
        public DateTimeOffset? CreateOn { get; }
        /// <summary> Deletion time of the deleted account. </summary>
        public DateTimeOffset? DeleteOn { get; }
    }
}
