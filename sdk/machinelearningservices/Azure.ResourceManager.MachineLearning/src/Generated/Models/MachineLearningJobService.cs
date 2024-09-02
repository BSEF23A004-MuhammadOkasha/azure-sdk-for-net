// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Job endpoint definition. </summary>
    public partial class MachineLearningJobService
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobService"/>. </summary>
        public MachineLearningJobService()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobService"/>. </summary>
        /// <param name="jobServiceType"> Endpoint type. </param>
        /// <param name="port"> Port for endpoint. </param>
        /// <param name="endpoint"> Url for endpoint. </param>
        /// <param name="status"> Status of endpoint. </param>
        /// <param name="errorMessage"> Any error in the service. </param>
        /// <param name="properties"> Additional properties to set on the endpoint. </param>
        /// <param name="nodes">
        /// Nodes that user would like to start the service on.
        /// If Nodes is not set or set to null, the service will only be started on leader node.
        /// Please note <see cref="JobNodes"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobAllNodes"/>.
        /// </param>
<<<<<<< HEAD
=======
        /// <param name="port"> Port for endpoint. </param>
        /// <param name="properties"> Additional properties to set on the endpoint. </param>
        /// <param name="status"> Status of endpoint. </param>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningJobService(string jobServiceType, int? port, string endpoint, string status, string errorMessage, IDictionary<string, string> properties, JobNodes nodes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JobServiceType = jobServiceType;
            Port = port;
            Endpoint = endpoint;
            Status = status;
            ErrorMessage = errorMessage;
            Properties = properties;
            Nodes = nodes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Endpoint type. </summary>
        public string JobServiceType { get; set; }
        /// <summary> Port for endpoint. </summary>
        public int? Port { get; set; }
        /// <summary> Url for endpoint. </summary>
        public string Endpoint { get; set; }
        /// <summary> Status of endpoint. </summary>
        public string Status { get; }
        /// <summary> Any error in the service. </summary>
        public string ErrorMessage { get; }
        /// <summary> Additional properties to set on the endpoint. </summary>
        public IDictionary<string, string> Properties { get; set; }
        /// <summary>
        /// Nodes that user would like to start the service on.
        /// If Nodes is not set or set to null, the service will only be started on leader node.
        /// Please note <see cref="JobNodes"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobAllNodes"/>.
        /// </summary>
        public JobNodes Nodes { get; set; }
<<<<<<< HEAD
=======
        /// <summary> Port for endpoint. </summary>
        public int? Port { get; set; }
        /// <summary> Additional properties to set on the endpoint. </summary>
        public IDictionary<string, string> Properties { get; set; }
        /// <summary> Status of endpoint. </summary>
        public string Status { get; }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
    }
}
