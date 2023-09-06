// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Azure Data Factory nested object which contains a flow with data movements and transformations.
    /// Please note <see cref="DataFactoryDataFlowProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataFactoryFlowletProperties"/>, <see cref="DataFactoryMappingDataFlowProperties"/> and <see cref="DataFactoryWranglingDataFlowProperties"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownDataFlow))]
    public abstract partial class DataFactoryDataFlowProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFactoryDataFlowProperties"/>. </summary>
        protected DataFactoryDataFlowProperties()
        {
            Annotations = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryDataFlowProperties"/>. </summary>
        /// <param name="dataFlowType"> Type of data flow. </param>
        /// <param name="description"> The description of the data flow. </param>
        /// <param name="annotations"> List of tags that can be used for describing the data flow. </param>
        /// <param name="folder"> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryDataFlowProperties(string dataFlowType, string description, IList<BinaryData> annotations, DataFlowFolder folder, Dictionary<string, BinaryData> rawData)
        {
            DataFlowType = dataFlowType;
            Description = description;
            Annotations = annotations;
            Folder = folder;
            _rawData = rawData;
        }

        /// <summary> Type of data flow. </summary>
        internal string DataFlowType { get; set; }
        /// <summary> The description of the data flow. </summary>
        public string Description { get; set; }
        /// <summary>
        /// List of tags that can be used for describing the data flow.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> Annotations { get; }
        /// <summary> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </summary>
        internal DataFlowFolder Folder { get; set; }
        /// <summary> The name of the folder that this data flow is in. </summary>
        public string FolderName
        {
            get => Folder is null ? default : Folder.Name;
            set
            {
                if (Folder is null)
                    Folder = new DataFlowFolder();
                Folder.Name = value;
            }
        }
    }
}
