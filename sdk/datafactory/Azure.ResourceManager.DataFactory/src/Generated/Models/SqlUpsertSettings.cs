// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Sql upsert option settings. </summary>
    public partial class SqlUpsertSettings
    {
        /// <summary> Initializes a new instance of SqlUpsertSettings. </summary>
        public SqlUpsertSettings()
        {
        }

        /// <summary> Initializes a new instance of SqlUpsertSettings. </summary>
        /// <param name="useTempDB"> Specifies whether to use temp db for upsert interim table. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="interimSchemaName"> Schema name for interim table. Type: string (or Expression with resultType string). </param>
        /// <param name="keys"> Key column names for unique row identification. Type: array of strings (or Expression with resultType array of strings). </param>
        internal SqlUpsertSettings(BinaryData useTempDB, BinaryData interimSchemaName, BinaryData keys)
        {
            UseTempDB = useTempDB;
            InterimSchemaName = interimSchemaName;
            Keys = keys;
        }

        /// <summary> Specifies whether to use temp db for upsert interim table. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData UseTempDB { get; set; }
        /// <summary> Schema name for interim table. Type: string (or Expression with resultType string). </summary>
        public BinaryData InterimSchemaName { get; set; }
        /// <summary> Key column names for unique row identification. Type: array of strings (or Expression with resultType array of strings). </summary>
        public BinaryData Keys { get; set; }
    }
}
