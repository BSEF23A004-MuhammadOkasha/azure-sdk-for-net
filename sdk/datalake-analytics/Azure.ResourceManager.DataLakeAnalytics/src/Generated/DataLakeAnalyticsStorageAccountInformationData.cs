// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary>
    /// A class representing the DataLakeAnalyticsStorageAccountInformation data model.
    /// Azure Storage account information.
    /// Serialized Name: StorageAccountInformation
    /// </summary>
    public partial class DataLakeAnalyticsStorageAccountInformationData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsStorageAccountInformationData"/>. </summary>
        internal DataLakeAnalyticsStorageAccountInformationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsStorageAccountInformationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="suffix">
        /// The optional suffix for the storage account.
        /// Serialized Name: StorageAccountInformation.properties.suffix
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeAnalyticsStorageAccountInformationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string suffix, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Suffix = suffix;
            _rawData = rawData;
        }

        /// <summary>
        /// The optional suffix for the storage account.
        /// Serialized Name: StorageAccountInformation.properties.suffix
        /// </summary>
        public string Suffix { get; }
    }
}
