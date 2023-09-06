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
    /// A class representing the CassandraKeyspace data model.
    /// An Azure Cosmos DB Cassandra keyspace.
    /// </summary>
    public partial class CassandraKeyspaceData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CassandraKeyspaceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public CassandraKeyspaceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="CassandraKeyspaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"></param>
        /// <param name="options"></param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraKeyspaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedCassandraKeyspaceResourceInfo resource, CassandraKeyspacePropertiesConfig options, ManagedServiceIdentity identity, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Resource = resource;
            Options = options;
            Identity = identity;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CassandraKeyspaceData"/> for deserialization. </summary>
        internal CassandraKeyspaceData()
        {
        }

        /// <summary> Gets or sets the resource. </summary>
        public ExtendedCassandraKeyspaceResourceInfo Resource { get; set; }
        /// <summary> Gets or sets the options. </summary>
        public CassandraKeyspacePropertiesConfig Options { get; set; }
        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
