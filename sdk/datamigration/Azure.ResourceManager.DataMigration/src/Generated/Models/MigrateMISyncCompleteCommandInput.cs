// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for command that completes online migration for an Azure SQL Database Managed Instance. </summary>
    internal partial class MigrateMISyncCompleteCommandInput
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MigrateMISyncCompleteCommandInput"/>. </summary>
        /// <param name="sourceDatabaseName"> Name of managed instance database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceDatabaseName"/> is null. </exception>
        public MigrateMISyncCompleteCommandInput(string sourceDatabaseName)
        {
            Argument.AssertNotNull(sourceDatabaseName, nameof(sourceDatabaseName));

            SourceDatabaseName = sourceDatabaseName;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateMISyncCompleteCommandInput"/>. </summary>
        /// <param name="sourceDatabaseName"> Name of managed instance database. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateMISyncCompleteCommandInput(string sourceDatabaseName, Dictionary<string, BinaryData> rawData)
        {
            SourceDatabaseName = sourceDatabaseName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateMISyncCompleteCommandInput"/> for deserialization. </summary>
        internal MigrateMISyncCompleteCommandInput()
        {
        }

        /// <summary> Name of managed instance database. </summary>
        public string SourceDatabaseName { get; set; }
    }
}
