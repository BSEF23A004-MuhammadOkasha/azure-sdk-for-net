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
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MongoDBDatabaseGetPropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MongoDBDatabaseGetPropertiesResource class.
        /// </summary>
        public MongoDBDatabaseGetPropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MongoDBDatabaseGetPropertiesResource class.
        /// </summary>
        /// <param name="id">Name of the Cosmos DB MongoDB database</param>
        /// <param name="restoreParameters">The standard JSON format of a
        /// container</param>
        /// <param name="createMode">The standard JSON format of a container.
        /// Possible values include: 'Default', 'Restore'</param>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="_ts">A system generated property that denotes the last
        /// updated timestamp of the resource.</param>
        /// <param name="_etag">A system generated property representing the
        /// resource etag required for optimistic concurrency control.</param>
        public MongoDBDatabaseGetPropertiesResource(string id, RestoreParameters restoreParameters = default(RestoreParameters), string createMode = default(string), string _rid = default(string), double? _ts = default(double?), string _etag = default(string))
        {
            Id = id;
            RestoreParameters = restoreParameters;
            CreateMode = createMode;
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
        /// Gets or sets name of the Cosmos DB MongoDB database
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the standard JSON format of a container
        /// </summary>
        [JsonProperty(PropertyName = "restoreParameters")]
        public RestoreParameters RestoreParameters { get; set; }

        /// <summary>
        /// Gets or sets the standard JSON format of a container. Possible
        /// values include: 'Default', 'Restore'
        /// </summary>
        [JsonProperty(PropertyName = "createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "_rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated
        /// timestamp of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "_ts")]
        public double? _ts { get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag
        /// required for optimistic concurrency control.
        /// </summary>
        [JsonProperty(PropertyName = "_etag")]
        public string _etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
