// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Connection string for the mongo cluster. </summary>
    public partial class CosmosDBConnectionString
    {
        /// <summary> Initializes a new instance of ConnectionString. </summary>
        internal CosmosDBConnectionString()
        {
        }

        /// <summary> Initializes a new instance of ConnectionString. </summary>
        /// <param name="connectionStringValue"> Value of the connection string. </param>
        /// <param name="description"> Description of the connection string. </param>
        internal CosmosDBConnectionString(string connectionStringValue, string description)
        {
            ConnectionStringValue = connectionStringValue;
            Description = description;
        }

        /// <summary> Value of the connection string. </summary>
        public string ConnectionStringValue { get; }
        /// <summary> Description of the connection string. </summary>
        public string Description { get; }
    }
}
