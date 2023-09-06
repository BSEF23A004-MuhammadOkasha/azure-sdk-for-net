// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlDBTaskOutputError. </summary>
    public partial class MigrateSqlServerSqlDBTaskOutputError : MigrateSqlServerSqlDBTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBTaskOutputError"/>. </summary>
        internal MigrateSqlServerSqlDBTaskOutputError()
        {
            ResultType = "ErrorOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBTaskOutputError"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="error"> Migration error. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateSqlServerSqlDBTaskOutputError(string id, string resultType, ReportableException error, Dictionary<string, BinaryData> rawData) : base(id, resultType, rawData)
        {
            Error = error;
            ResultType = resultType ?? "ErrorOutput";
        }

        /// <summary> Migration error. </summary>
        public ReportableException Error { get; }
    }
}
