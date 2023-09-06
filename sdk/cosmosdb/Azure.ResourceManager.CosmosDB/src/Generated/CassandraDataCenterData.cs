// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the CassandraDataCenter data model.
    /// A managed Cassandra data center.
    /// </summary>
    public partial class CassandraDataCenterData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CassandraDataCenterData"/>. </summary>
        public CassandraDataCenterData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CassandraDataCenterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of a managed Cassandra data center. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraDataCenterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CassandraDataCenterProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Properties of a managed Cassandra data center. </summary>
        public CassandraDataCenterProperties Properties { get; set; }
    }
}
