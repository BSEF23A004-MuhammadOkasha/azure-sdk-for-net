// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace OperationalInsightsManagementClient.Models
{
    /// <summary> Result of the request to list data exports. </summary>
    internal partial class DataExportListResult
    {
        /// <summary> Initializes a new instance of DataExportListResult. </summary>
        internal DataExportListResult()
        {
            Value = new ChangeTrackingList<DataExport>();
        }

        /// <summary> Initializes a new instance of DataExportListResult. </summary>
        /// <param name="value"> List of data export instances within a workspace.. </param>
        internal DataExportListResult(IReadOnlyList<DataExport> value)
        {
            Value = value;
        }

        /// <summary> List of data export instances within a workspace.. </summary>
        public IReadOnlyList<DataExport> Value { get; }
    }
}
