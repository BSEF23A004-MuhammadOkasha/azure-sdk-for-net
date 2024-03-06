// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The CreateCluster request parameters. </summary>
    public partial class HDInsightClusterCreateOrUpdateContent
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterCreateOrUpdateContent"/>. </summary>
        public HDInsightClusterCreateOrUpdateContent()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The location of the cluster. </param>
        /// <param name="tags"> The resource tags. </param>
        /// <param name="zones"> The availability zones. </param>
        /// <param name="properties"> The cluster create parameters. </param>
        /// <param name="identity"> The identity of the cluster, if configured. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterCreateOrUpdateContent(AzureLocation? location, IDictionary<string, string> tags, IList<string> zones, HDInsightClusterCreateOrUpdateProperties properties, ManagedServiceIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Tags = tags;
            Zones = zones;
            Properties = properties;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The location of the cluster. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The availability zones. </summary>
        public IList<string> Zones { get; }
        /// <summary> The cluster create parameters. </summary>
        public HDInsightClusterCreateOrUpdateProperties Properties { get; set; }
        /// <summary> The identity of the cluster, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
