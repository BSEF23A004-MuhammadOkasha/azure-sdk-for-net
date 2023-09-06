// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> An Azure Cosmos DB Gremlin database event. </summary>
    public partial class RestorableGremlinDatabase : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RestorableGremlinDatabase"/>. </summary>
        internal RestorableGremlinDatabase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestorableGremlinDatabase"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="resource"> The resource of an Azure Cosmos DB Gremlin database event. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RestorableGremlinDatabase(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ExtendedRestorableGremlinDatabaseResourceInfo resource, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Resource = resource;
            _rawData = rawData;
        }

        /// <summary> The resource of an Azure Cosmos DB Gremlin database event. </summary>
        public ExtendedRestorableGremlinDatabaseResourceInfo Resource { get; }
    }
}
