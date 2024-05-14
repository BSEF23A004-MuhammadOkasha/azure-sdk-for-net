// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseSqlPoolColumn data model.
    /// A Sql pool column resource.
    /// </summary>
    public partial class SynapseSqlPoolColumnData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SynapseSqlPoolColumnData"/>. </summary>
        public SynapseSqlPoolColumnData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSqlPoolColumnData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="columnType"> The column data type. </param>
        /// <param name="isComputed"> Indicates whether column value is computed or not. </param>
        internal SynapseSqlPoolColumnData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SqlPoolColumnDataType? columnType, bool? isComputed) : base(id, name, resourceType, systemData)
        {
            ColumnType = columnType;
            IsComputed = isComputed;
        }

        /// <summary> The column data type. </summary>
        public SqlPoolColumnDataType? ColumnType { get; set; }
        /// <summary> Indicates whether column value is computed or not. </summary>
        public bool? IsComputed { get; }
    }
}
