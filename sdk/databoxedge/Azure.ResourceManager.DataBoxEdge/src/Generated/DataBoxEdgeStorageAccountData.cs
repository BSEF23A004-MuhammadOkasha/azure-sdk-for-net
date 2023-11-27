// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the DataBoxEdgeStorageAccount data model.
    /// Represents a Storage Account on the  Data Box Edge/Gateway device.
    /// </summary>
    public partial class DataBoxEdgeStorageAccountData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeStorageAccountData"/>. </summary>
        /// <param name="dataPolicy"> Data policy of the storage Account. </param>
        public DataBoxEdgeStorageAccountData(DataBoxEdgeDataPolicy dataPolicy)
        {
            DataPolicy = dataPolicy;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeStorageAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description for the storage Account. </param>
        /// <param name="storageAccountStatus"> Current status of the storage account. </param>
        /// <param name="dataPolicy"> Data policy of the storage Account. </param>
        /// <param name="storageAccountCredentialId"> Storage Account Credential Id. </param>
        /// <param name="blobEndpoint"> BlobEndpoint of Storage Account. </param>
        /// <param name="containerCount"> The Container Count. Present only for Storage Accounts with DataPolicy set to Cloud. </param>
        internal DataBoxEdgeStorageAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, DataBoxEdgeStorageAccountStatus? storageAccountStatus, DataBoxEdgeDataPolicy dataPolicy, ResourceIdentifier storageAccountCredentialId, string blobEndpoint, int? containerCount) : base(id, name, resourceType, systemData)
        {
            Description = description;
            StorageAccountStatus = storageAccountStatus;
            DataPolicy = dataPolicy;
            StorageAccountCredentialId = storageAccountCredentialId;
            BlobEndpoint = blobEndpoint;
            ContainerCount = containerCount;
        }

        /// <summary> Description for the storage Account. </summary>
        public string Description { get; set; }
        /// <summary> Current status of the storage account. </summary>
        public DataBoxEdgeStorageAccountStatus? StorageAccountStatus { get; set; }
        /// <summary> Data policy of the storage Account. </summary>
        public DataBoxEdgeDataPolicy DataPolicy { get; set; }
        /// <summary> Storage Account Credential Id. </summary>
        public ResourceIdentifier StorageAccountCredentialId { get; set; }
        /// <summary> BlobEndpoint of Storage Account. </summary>
        public string BlobEndpoint { get; }
        /// <summary> The Container Count. Present only for Storage Accounts with DataPolicy set to Cloud. </summary>
        public int? ContainerCount { get; }
    }
}
