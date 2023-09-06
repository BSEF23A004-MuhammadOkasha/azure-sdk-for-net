// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The DataLakeAnalyticsHiveMetastore.
    /// Serialized Name: HiveMetastore
    /// </summary>
    public partial class DataLakeAnalyticsHiveMetastore : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsHiveMetastore"/>. </summary>
        internal DataLakeAnalyticsHiveMetastore()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsHiveMetastore"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serverUri">
        /// The serverUri for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.serverUri
        /// </param>
        /// <param name="databaseName">
        /// The databaseName for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.databaseName
        /// </param>
        /// <param name="runtimeVersion">
        /// The runtimeVersion for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.runtimeVersion
        /// </param>
        /// <param name="userName">
        /// The userName for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.userName
        /// </param>
        /// <param name="password">
        /// The password for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.password
        /// </param>
        /// <param name="nestedResourceProvisioningState">
        /// The current state of the NestedResource
        /// Serialized Name: HiveMetastore.properties.nestedResourceProvisioningState
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeAnalyticsHiveMetastore(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri serverUri, string databaseName, string runtimeVersion, string userName, string password, NestedResourceProvisioningState? nestedResourceProvisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ServerUri = serverUri;
            DatabaseName = databaseName;
            RuntimeVersion = runtimeVersion;
            UserName = userName;
            Password = password;
            NestedResourceProvisioningState = nestedResourceProvisioningState;
            _rawData = rawData;
        }

        /// <summary>
        /// The serverUri for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.serverUri
        /// </summary>
        public Uri ServerUri { get; }
        /// <summary>
        /// The databaseName for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.databaseName
        /// </summary>
        public string DatabaseName { get; }
        /// <summary>
        /// The runtimeVersion for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.runtimeVersion
        /// </summary>
        public string RuntimeVersion { get; }
        /// <summary>
        /// The userName for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.userName
        /// </summary>
        public string UserName { get; }
        /// <summary>
        /// The password for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.password
        /// </summary>
        public string Password { get; }
        /// <summary>
        /// The current state of the NestedResource
        /// Serialized Name: HiveMetastore.properties.nestedResourceProvisioningState
        /// </summary>
        public NestedResourceProvisioningState? NestedResourceProvisioningState { get; }
    }
}
