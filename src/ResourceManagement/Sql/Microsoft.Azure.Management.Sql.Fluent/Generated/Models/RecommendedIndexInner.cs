// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL Database recommended index.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class RecommendedIndexInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the RecommendedIndexInner class.
        /// </summary>
        public RecommendedIndexInner() { }

        /// <summary>
        /// Initializes a new instance of the RecommendedIndexInner class.
        /// </summary>
        /// <param name="action">The proposed index action. You can create a
        /// missing index, drop an unused index, or rebuild an existing index
        /// to improve its performance. Possible values are 'Create', 'Drop',
        /// 'Rebuild'. Possible values include: 'Create', 'Drop',
        /// 'Rebuild'</param>
        /// <param name="state">The current recommendation state. Current
        /// options are: 'Active', 'Pending', 'Executing', 'Verifying',
        /// 'Pending Revert', 'Reverting', 'Reverted', 'Ignored', 'Expired',
        /// 'Blocked', 'Success'. Possible values include: 'Active',
        /// 'Pending', 'Executing', 'Verifying', 'Pending Revert',
        /// 'Reverting', 'Reverted', 'Ignored', 'Expired', 'Blocked',
        /// 'Success'</param>
        /// <param name="created">The UTC datetime showing when this resource
        /// was created (ISO8601 format).</param>
        /// <param name="lastModified">The UTC datetime of when was this
        /// resource last changed (ISO8601 format).</param>
        /// <param name="indexType">The type of index (CLUSTERED,
        /// NONCLUSTERED, COLUMNSTORE, CLUSTERED COLUMNSTORE). Possible
        /// values include: 'CLUSTERED', 'NONCLUSTERED', 'COLUMNSTORE',
        /// 'CLUSTERED COLUMNSTORE'</param>
        /// <param name="schema">The schema where table to build index over
        /// resides</param>
        /// <param name="table">The table on which to build index.</param>
        /// <param name="columns">Columns over which to build index</param>
        /// <param name="includedColumns">The list of column names to be
        /// included in the index</param>
        /// <param name="indexScript">The full build index script</param>
        /// <param name="estimatedImpact">The estimated impact of doing
        /// recommended index action.</param>
        /// <param name="reportedImpact">The values reported after index
        /// action is complete.</param>
        public RecommendedIndexInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), RecommendedIndexActions? action = default(RecommendedIndexActions?), RecommendedIndexStates? state = default(RecommendedIndexStates?), System.DateTime? created = default(System.DateTime?), System.DateTime? lastModified = default(System.DateTime?), RecommendedIndexTypes? indexType = default(RecommendedIndexTypes?), string schema = default(string), string table = default(string), System.Collections.Generic.IList<string> columns = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> includedColumns = default(System.Collections.Generic.IList<string>), string indexScript = default(string), System.Collections.Generic.IList<OperationImpact> estimatedImpact = default(System.Collections.Generic.IList<OperationImpact>), System.Collections.Generic.IList<OperationImpact> reportedImpact = default(System.Collections.Generic.IList<OperationImpact>))
            : base(location, id, name, type, tags)
        {
            Action = action;
            State = state;
            Created = created;
            LastModified = lastModified;
            IndexType = indexType;
            Schema = schema;
            Table = table;
            Columns = columns;
            IncludedColumns = includedColumns;
            IndexScript = indexScript;
            EstimatedImpact = estimatedImpact;
            ReportedImpact = reportedImpact;
        }

        /// <summary>
        /// Gets the proposed index action. You can create a missing index,
        /// drop an unused index, or rebuild an existing index to improve its
        /// performance. Possible values are 'Create', 'Drop', 'Rebuild'.
        /// Possible values include: 'Create', 'Drop', 'Rebuild'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.action")]
        public RecommendedIndexActions? Action { get; private set; }

        /// <summary>
        /// Gets the current recommendation state. Current options are:
        /// 'Active', 'Pending', 'Executing', 'Verifying', 'Pending Revert',
        /// 'Reverting', 'Reverted', 'Ignored', 'Expired', 'Blocked',
        /// 'Success'. Possible values include: 'Active', 'Pending',
        /// 'Executing', 'Verifying', 'Pending Revert', 'Reverting',
        /// 'Reverted', 'Ignored', 'Expired', 'Blocked', 'Success'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.state")]
        public RecommendedIndexStates? State { get; private set; }

        /// <summary>
        /// Gets the UTC datetime showing when this resource was created
        /// (ISO8601 format).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; private set; }

        /// <summary>
        /// Gets the UTC datetime of when was this resource last changed
        /// (ISO8601 format).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lastModified")]
        public System.DateTime? LastModified { get; private set; }

        /// <summary>
        /// Gets the type of index (CLUSTERED, NONCLUSTERED, COLUMNSTORE,
        /// CLUSTERED COLUMNSTORE). Possible values include: 'CLUSTERED',
        /// 'NONCLUSTERED', 'COLUMNSTORE', 'CLUSTERED COLUMNSTORE'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.indexType")]
        public RecommendedIndexTypes? IndexType { get; private set; }

        /// <summary>
        /// Gets the schema where table to build index over resides
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.schema")]
        public string Schema { get; private set; }

        /// <summary>
        /// Gets the table on which to build index.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.table")]
        public string Table { get; private set; }

        /// <summary>
        /// Gets columns over which to build index
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.columns")]
        public System.Collections.Generic.IList<string> Columns { get; private set; }

        /// <summary>
        /// Gets the list of column names to be included in the index
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.includedColumns")]
        public System.Collections.Generic.IList<string> IncludedColumns { get; private set; }

        /// <summary>
        /// Gets the full build index script
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.indexScript")]
        public string IndexScript { get; private set; }

        /// <summary>
        /// Gets the estimated impact of doing recommended index action.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.estimatedImpact")]
        public System.Collections.Generic.IList<OperationImpact> EstimatedImpact { get; private set; }

        /// <summary>
        /// Gets the values reported after index action is complete.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.reportedImpact")]
        public System.Collections.Generic.IList<OperationImpact> ReportedImpact { get; private set; }

    }
}
