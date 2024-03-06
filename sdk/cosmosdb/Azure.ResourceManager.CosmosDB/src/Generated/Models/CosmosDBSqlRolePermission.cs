// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The set of data plane operations permitted through this Role Definition. </summary>
    public partial class CosmosDBSqlRolePermission
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlRolePermission"/>. </summary>
        public CosmosDBSqlRolePermission()
        {
            DataActions = new ChangeTrackingList<string>();
            NotDataActions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlRolePermission"/>. </summary>
        /// <param name="dataActions"> An array of data actions that are allowed. </param>
        /// <param name="notDataActions"> An array of data actions that are denied. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBSqlRolePermission(IList<string> dataActions, IList<string> notDataActions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataActions = dataActions;
            NotDataActions = notDataActions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An array of data actions that are allowed. </summary>
        public IList<string> DataActions { get; }
        /// <summary> An array of data actions that are denied. </summary>
        public IList<string> NotDataActions { get; }
    }
}
