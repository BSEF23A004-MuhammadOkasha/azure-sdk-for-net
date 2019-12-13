// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Cosmos DB MongoDB collection.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MongoDBCollectionGetResults : ARMResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the MongoDBCollectionGetResults
        /// class.
        /// </summary>
        public MongoDBCollectionGetResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDBCollectionGetResults
        /// class.
        /// </summary>
        /// <param name="mongoDBCollectionGetResultsId">Name of the Cosmos DB
        /// MongoDB collection</param>
        /// <param name="id">The unique resource identifier of the ARM
        /// resource.</param>
        /// <param name="name">The name of the ARM resource.</param>
        /// <param name="type">The type of Azure resource.</param>
        /// <param name="location">The location of the resource group to which
        /// the resource belongs.</param>
        /// <param name="shardKey">A key-value pair of shard keys to be applied
        /// for the request.</param>
        /// <param name="indexes">List of index keys</param>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="_ts">A system generated property that denotes the last
        /// updated timestamp of the resource.</param>
        /// <param name="_etag">A system generated property representing the
        /// resource etag required for optimistic concurrency control.</param>
        public MongoDBCollectionGetResults(string mongoDBCollectionGetResultsId, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IDictionary<string, string> shardKey = default(IDictionary<string, string>), IList<MongoIndex> indexes = default(IList<MongoIndex>), string _rid = default(string), object _ts = default(object), string _etag = default(string))
            : base(id, name, type, location, tags)
        {
            MongoDBCollectionGetResultsId = mongoDBCollectionGetResultsId;
            ShardKey = shardKey;
            Indexes = indexes;
            this._rid = _rid;
            this._ts = _ts;
            this._etag = _etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB MongoDB collection
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public string MongoDBCollectionGetResultsId { get; set; }

        /// <summary>
        /// Gets or sets a key-value pair of shard keys to be applied for the
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.shardKey")]
        public IDictionary<string, string> ShardKey { get; set; }

        /// <summary>
        /// Gets or sets list of index keys
        /// </summary>
        [JsonProperty(PropertyName = "properties.indexes")]
        public IList<MongoIndex> Indexes { get; set; }

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties._rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated
        /// timestamp of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties._ts")]
        public object _ts { get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag
        /// required for optimistic concurrency control.
        /// </summary>
        [JsonProperty(PropertyName = "properties._etag")]
        public string _etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MongoDBCollectionGetResultsId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MongoDBCollectionGetResultsId");
            }
        }
    }
}
