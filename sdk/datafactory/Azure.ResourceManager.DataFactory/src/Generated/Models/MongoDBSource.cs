// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity source for a MongoDB database. </summary>
    public partial class MongoDBSource : CopyActivitySource
    {
        /// <summary> Initializes a new instance of <see cref="MongoDBSource"/>. </summary>
        public MongoDBSource()
        {
            CopySourceType = "MongoDbSource";
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBSource"/>. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="query"> Database query. Should be a SQL-92 query expression. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal MongoDBSource(string copySourceType, DataFactoryElement<int> sourceRetryCount, DataFactoryElement<string> sourceRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> query, BinaryData additionalColumns) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            Query = query;
            AdditionalColumns = additionalColumns;
            CopySourceType = copySourceType ?? "MongoDbSource";
        }

        /// <summary> Database query. Should be a SQL-92 query expression. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Query { get; set; }
        /// <summary>
        /// Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData AdditionalColumns { get; set; }
    }
}
