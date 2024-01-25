// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Result of query. It contains all columns listed under groupings and aggregation. </summary>
    public partial class QueryResult : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="QueryResult"/>. </summary>
        internal QueryResult()
        {
            Columns = new ChangeTrackingList<QueryColumn>();
            Rows = new ChangeTrackingList<IList<BinaryData>>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="columns"> Array of columns. </param>
        /// <param name="rows"> Array of rows. </param>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="sku"> SKU of the resource. </param>
        /// <param name="eTag"> ETag of the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string nextLink, IReadOnlyList<QueryColumn> columns, IReadOnlyList<IList<BinaryData>> rows, AzureLocation? location, string sku, ETag? eTag, IReadOnlyDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            NextLink = nextLink;
            Columns = columns;
            Rows = rows;
            Location = location;
            Sku = sku;
            ETag = eTag;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> Array of columns. </summary>
        public IReadOnlyList<QueryColumn> Columns { get; }
        /// <summary> Array of rows. </summary>
        public IReadOnlyList<IList<BinaryData>> Rows { get; }
        /// <summary> Location of the resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> SKU of the resource. </summary>
        public string Sku { get; }
        /// <summary> ETag of the resource. </summary>
        public ETag? ETag { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
