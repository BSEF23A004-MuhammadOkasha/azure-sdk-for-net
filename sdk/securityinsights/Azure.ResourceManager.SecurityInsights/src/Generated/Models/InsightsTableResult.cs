// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Query results for table insights query. </summary>
    public partial class InsightsTableResult
    {
        /// <summary> Initializes a new instance of InsightsTableResult. </summary>
        internal InsightsTableResult()
        {
            Columns = new ChangeTrackingList<InsightsTableResultColumnsItem>();
            Rows = new ChangeTrackingList<IList<string>>();
        }

        /// <summary> Initializes a new instance of InsightsTableResult. </summary>
        /// <param name="columns"> Columns Metadata of the table. </param>
        /// <param name="rows"> Rows data of the table. </param>
        internal InsightsTableResult(IReadOnlyList<InsightsTableResultColumnsItem> columns, IReadOnlyList<IList<string>> rows)
        {
            Columns = columns;
            Rows = rows;
        }

        /// <summary> Columns Metadata of the table. </summary>
        public IReadOnlyList<InsightsTableResultColumnsItem> Columns { get; }
        /// <summary> Rows data of the table. </summary>
        public IReadOnlyList<IList<string>> Rows { get; }
    }
}
