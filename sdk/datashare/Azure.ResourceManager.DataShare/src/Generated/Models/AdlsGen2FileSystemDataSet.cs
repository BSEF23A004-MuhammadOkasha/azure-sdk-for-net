// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> An ADLS Gen 2 file system data set. </summary>
    public partial class AdlsGen2FileSystemDataSet : ShareDataSetData
    {
        /// <summary> Initializes a new instance of <see cref="AdlsGen2FileSystemDataSet"/>. </summary>
        /// <param name="fileSystem"> The file system name. </param>
        /// <param name="resourceGroup"> Resource group of storage account. </param>
        /// <param name="storageAccountName"> Storage account name of the source data set. </param>
        /// <param name="subscriptionId"> Subscription id of storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystem"/>, <paramref name="resourceGroup"/>, <paramref name="storageAccountName"/> or <paramref name="subscriptionId"/> is null. </exception>
        public AdlsGen2FileSystemDataSet(string fileSystem, string resourceGroup, string storageAccountName, string subscriptionId)
        {
            Argument.AssertNotNull(fileSystem, nameof(fileSystem));
            Argument.AssertNotNull(resourceGroup, nameof(resourceGroup));
            Argument.AssertNotNull(storageAccountName, nameof(storageAccountName));
            Argument.AssertNotNull(subscriptionId, nameof(subscriptionId));

            FileSystem = fileSystem;
            ResourceGroup = resourceGroup;
            StorageAccountName = storageAccountName;
            SubscriptionId = subscriptionId;
            Kind = DataSetKind.AdlsGen2FileSystem;
        }

        /// <summary> Initializes a new instance of <see cref="AdlsGen2FileSystemDataSet"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set. </param>
        /// <param name="dataSetId"> Unique id for identifying a data set resource. </param>
        /// <param name="fileSystem"> The file system name. </param>
        /// <param name="resourceGroup"> Resource group of storage account. </param>
        /// <param name="storageAccountName"> Storage account name of the source data set. </param>
        /// <param name="subscriptionId"> Subscription id of storage account. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AdlsGen2FileSystemDataSet(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetKind kind, Guid? dataSetId, string fileSystem, string resourceGroup, string storageAccountName, string subscriptionId, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, kind, rawData)
        {
            DataSetId = dataSetId;
            FileSystem = fileSystem;
            ResourceGroup = resourceGroup;
            StorageAccountName = storageAccountName;
            SubscriptionId = subscriptionId;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="AdlsGen2FileSystemDataSet"/> for deserialization. </summary>
        internal AdlsGen2FileSystemDataSet()
        {
        }

        /// <summary> Unique id for identifying a data set resource. </summary>
        public Guid? DataSetId { get; }
        /// <summary> The file system name. </summary>
        public string FileSystem { get; set; }
        /// <summary> Resource group of storage account. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> Storage account name of the source data set. </summary>
        public string StorageAccountName { get; set; }
        /// <summary> Subscription id of storage account. </summary>
        public string SubscriptionId { get; set; }
    }
}
