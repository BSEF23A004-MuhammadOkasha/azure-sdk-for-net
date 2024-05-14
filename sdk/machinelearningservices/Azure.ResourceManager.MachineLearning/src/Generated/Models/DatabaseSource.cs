// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The DatabaseSource. </summary>
    public partial class DatabaseSource : DataImportSource
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseSource"/>. </summary>
        public DatabaseSource()
        {
            StoredProcedureParams = new ChangeTrackingList<IDictionary<string, string>>();
            SourceType = DataImportSourceType.Database;
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseSource"/>. </summary>
        /// <param name="connection"> Workspace connection for data import source storage. </param>
        /// <param name="sourceType"> [Required] Specifies the type of data. </param>
        /// <param name="query"> SQL Query statement for data import Database source. </param>
        /// <param name="storedProcedure"> SQL StoredProcedure on data import Database source. </param>
        /// <param name="storedProcedureParams"> SQL StoredProcedure parameters. </param>
        /// <param name="tableName"> Name of the table on data import Database source. </param>
        internal DatabaseSource(string connection, DataImportSourceType sourceType, string query, string storedProcedure, IList<IDictionary<string, string>> storedProcedureParams, string tableName) : base(connection, sourceType)
        {
            Query = query;
            StoredProcedure = storedProcedure;
            StoredProcedureParams = storedProcedureParams;
            TableName = tableName;
            SourceType = sourceType;
        }

        /// <summary> SQL Query statement for data import Database source. </summary>
        public string Query { get; set; }
        /// <summary> SQL StoredProcedure on data import Database source. </summary>
        public string StoredProcedure { get; set; }
        /// <summary> SQL StoredProcedure parameters. </summary>
        public IList<IDictionary<string, string>> StoredProcedureParams { get; set; }
        /// <summary> Name of the table on data import Database source. </summary>
        public string TableName { get; set; }
    }
}
