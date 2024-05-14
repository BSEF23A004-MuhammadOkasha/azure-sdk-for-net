// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of restorable dropped databases. </summary>
    internal partial class RestorableDroppedDatabaseListResult
    {
        /// <summary> Initializes a new instance of <see cref="RestorableDroppedDatabaseListResult"/>. </summary>
        internal RestorableDroppedDatabaseListResult()
        {
            Value = new ChangeTrackingList<RestorableDroppedDatabaseData>();
        }

        /// <summary> Initializes a new instance of <see cref="RestorableDroppedDatabaseListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal RestorableDroppedDatabaseListResult(IReadOnlyList<RestorableDroppedDatabaseData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<RestorableDroppedDatabaseData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
