// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity source for SAP HANA source. </summary>
    public partial class SapHanaSource : TabularSource
    {
        /// <summary> Initializes a new instance of <see cref="SapHanaSource"/>. </summary>
        public SapHanaSource()
        {
            CopySourceType = "SapHanaSource";
        }

        /// <summary> Initializes a new instance of <see cref="SapHanaSource"/>. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        /// <param name="query"> SAP HANA Sql query. Type: string (or Expression with resultType string). </param>
        /// <param name="packetSize"> The packet size of data read from SAP HANA. Type: integer(or Expression with resultType integer). </param>
        /// <param name="partitionOption"> The partition mechanism that will be used for SAP HANA read in parallel. Possible values include: "None", "PhysicalPartitionsOfTable", "SapHanaDynamicRange". </param>
        /// <param name="partitionSettings"> The settings that will be leveraged for SAP HANA source partitioning. </param>
        internal SapHanaSource(string copySourceType, DataFactoryElement<int> sourceRetryCount, DataFactoryElement<string> sourceRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> queryTimeout, BinaryData additionalColumns, DataFactoryElement<string> query, DataFactoryElement<int> packetSize, BinaryData partitionOption, SapHanaPartitionSettings partitionSettings) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties, queryTimeout, additionalColumns)
        {
            Query = query;
            PacketSize = packetSize;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            CopySourceType = copySourceType ?? "SapHanaSource";
        }

        /// <summary> SAP HANA Sql query. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Query { get; set; }
        /// <summary> The packet size of data read from SAP HANA. Type: integer(or Expression with resultType integer). </summary>
        public DataFactoryElement<int> PacketSize { get; set; }
        /// <summary>
        /// The partition mechanism that will be used for SAP HANA read in parallel. Possible values include: "None", "PhysicalPartitionsOfTable", "SapHanaDynamicRange".
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
        public BinaryData PartitionOption { get; set; }
        /// <summary> The settings that will be leveraged for SAP HANA source partitioning. </summary>
        internal SapHanaPartitionSettings PartitionSettings { get; set; }
        /// <summary> The name of the column that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PartitionColumnName
        {
            get => PartitionSettings is null ? default : PartitionSettings.PartitionColumnName;
            set
            {
                if (PartitionSettings is null)
                    PartitionSettings = new SapHanaPartitionSettings();
                PartitionSettings.PartitionColumnName = value;
            }
        }
    }
}
