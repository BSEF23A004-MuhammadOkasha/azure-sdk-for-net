// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains the ARM resources for which to create private endpoint connection. </summary>
    public partial class NetworkIsolationSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkIsolationSettings"/>. </summary>
        public NetworkIsolationSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkIsolationSettings"/>. </summary>
        /// <param name="storageAccountResourceId"> The resource id for the storage account used to store BACPAC file. If set, private endpoint connection will be created for the storage account. Must match storage account used for StorageUri parameter. </param>
        /// <param name="sqlServerResourceId"> The resource id for the SQL server which is the target of this request. If set, private endpoint connection will be created for the SQL server. Must match server which is target of the operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkIsolationSettings(ResourceIdentifier storageAccountResourceId, ResourceIdentifier sqlServerResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageAccountResourceId = storageAccountResourceId;
            SqlServerResourceId = sqlServerResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource id for the storage account used to store BACPAC file. If set, private endpoint connection will be created for the storage account. Must match storage account used for StorageUri parameter. </summary>
        public ResourceIdentifier StorageAccountResourceId { get; set; }
        /// <summary> The resource id for the SQL server which is the target of this request. If set, private endpoint connection will be created for the SQL server. Must match server which is target of the operation. </summary>
        public ResourceIdentifier SqlServerResourceId { get; set; }
    }
}
