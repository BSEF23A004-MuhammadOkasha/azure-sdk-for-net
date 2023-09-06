// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Azure Blob Details. </summary>
    public partial class AzureBlob
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureBlob"/>. </summary>
        public AzureBlob()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlob"/>. </summary>
        /// <param name="storageAccountResourceId"> Resource Id of the storage account where backups are stored. </param>
        /// <param name="accountKey"> Storage Account Key. </param>
        /// <param name="blobContainerName"> Blob container name where backups are stored. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureBlob(string storageAccountResourceId, string accountKey, string blobContainerName, Dictionary<string, BinaryData> rawData)
        {
            StorageAccountResourceId = storageAccountResourceId;
            AccountKey = accountKey;
            BlobContainerName = blobContainerName;
            _rawData = rawData;
        }

        /// <summary> Resource Id of the storage account where backups are stored. </summary>
        public string StorageAccountResourceId { get; set; }
        /// <summary> Storage Account Key. </summary>
        public string AccountKey { get; set; }
        /// <summary> Blob container name where backups are stored. </summary>
        public string BlobContainerName { get; set; }
    }
}
