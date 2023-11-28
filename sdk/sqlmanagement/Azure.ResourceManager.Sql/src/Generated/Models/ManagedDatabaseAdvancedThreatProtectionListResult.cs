// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of the managed database's Advanced Threat Protection settings. </summary>
    internal partial class ManagedDatabaseAdvancedThreatProtectionListResult
    {
        /// <summary> Initializes a new instance of <see cref="ManagedDatabaseAdvancedThreatProtectionListResult"/>. </summary>
        internal ManagedDatabaseAdvancedThreatProtectionListResult()
        {
            Value = new ChangeTrackingList<ManagedDatabaseAdvancedThreatProtectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedDatabaseAdvancedThreatProtectionListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedDatabaseAdvancedThreatProtectionListResult(IReadOnlyList<ManagedDatabaseAdvancedThreatProtectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedDatabaseAdvancedThreatProtectionData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
