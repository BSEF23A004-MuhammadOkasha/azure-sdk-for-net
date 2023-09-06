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
    /// A class representing the CassandraCluster data model.
    /// Representation of a managed Cassandra cluster.
    /// </summary>
    public partial class CassandraClusterData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CassandraClusterData"/>. </summary>
        /// <param name="location"> The location. </param>
        public CassandraClusterData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="CassandraClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of a managed Cassandra cluster. </param>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned, None. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, CassandraClusterProperties properties, ManagedServiceIdentity identity, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            Identity = identity;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CassandraClusterData"/> for deserialization. </summary>
        internal CassandraClusterData()
        {
        }

        /// <summary> Properties of a managed Cassandra cluster. </summary>
        public CassandraClusterProperties Properties { get; set; }
        /// <summary> Identity for the resource. Current supported identity types: SystemAssigned, None. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
