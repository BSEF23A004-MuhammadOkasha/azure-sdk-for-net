// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing the ShareDataSetMapping data model.
    /// A data set mapping data transfer object.
    /// Please note <see cref="ShareDataSetMappingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AdlsGen2FileDataSetMapping"/>, <see cref="AdlsGen2FileSystemDataSetMapping"/>, <see cref="AdlsGen2FolderDataSetMapping"/>, <see cref="BlobDataSetMapping"/>, <see cref="BlobFolderDataSetMapping"/>, <see cref="BlobContainerDataSetMapping"/>, <see cref="KustoClusterDataSetMapping"/>, <see cref="KustoDatabaseDataSetMapping"/>, <see cref="KustoTableDataSetMapping"/>, <see cref="SqlDBTableDataSetMapping"/>, <see cref="SqlDWTableDataSetMapping"/> and <see cref="SynapseWorkspaceSqlPoolTableDataSetMapping"/>.
    /// </summary>
    public partial class ShareDataSetMappingData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ShareDataSetMappingData"/>. </summary>
        public ShareDataSetMappingData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ShareDataSetMappingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set mapping. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ShareDataSetMappingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetMappingKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Kind of data set mapping. </summary>
        internal DataSetMappingKind Kind { get; set; }
    }
}
