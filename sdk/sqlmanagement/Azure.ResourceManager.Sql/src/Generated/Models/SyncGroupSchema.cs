// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of sync group schema. </summary>
    public partial class SyncGroupSchema
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SyncGroupSchema"/>. </summary>
        public SyncGroupSchema()
        {
            Tables = new ChangeTrackingList<SyncGroupSchemaTable>();
        }

        /// <summary> Initializes a new instance of <see cref="SyncGroupSchema"/>. </summary>
        /// <param name="tables"> List of tables in sync group schema. </param>
        /// <param name="masterSyncMemberName"> Name of master sync member where the schema is from. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SyncGroupSchema(IList<SyncGroupSchemaTable> tables, string masterSyncMemberName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tables = tables;
            MasterSyncMemberName = masterSyncMemberName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of tables in sync group schema. </summary>
        public IList<SyncGroupSchemaTable> Tables { get; }
        /// <summary> Name of master sync member where the schema is from. </summary>
        public string MasterSyncMemberName { get; set; }
    }
}
