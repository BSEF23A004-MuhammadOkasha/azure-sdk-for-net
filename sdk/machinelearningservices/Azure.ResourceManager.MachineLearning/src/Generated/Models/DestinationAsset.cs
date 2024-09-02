// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
<<<<<<< HEAD
<<<<<<<< HEAD:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/DestinationAsset.cs
    /// <summary> Publishing destination registry asset information. </summary>
    public partial class DestinationAsset
========
    /// <summary> The ServerlessEndpointModelSettings. </summary>
    internal partial class ServerlessEndpointModelSettings
>>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/ServerlessEndpointModelSettings.cs
=======
    /// <summary> Publishing destination registry asset information. </summary>
    public partial class DestinationAsset
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
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

<<<<<<< HEAD
<<<<<<<< HEAD:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/DestinationAsset.cs
        /// <summary> Initializes a new instance of <see cref="DestinationAsset"/>. </summary>
        public DestinationAsset()
========
        /// <summary> Initializes a new instance of <see cref="ServerlessEndpointModelSettings"/>. </summary>
        /// <param name="modelId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public ServerlessEndpointModelSettings(string modelId)
>>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/ServerlessEndpointModelSettings.cs
        {
            Argument.AssertNotNull(modelId, nameof(modelId));

            ModelId = modelId;
        }

<<<<<<<< HEAD:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/DestinationAsset.cs
        /// <summary> Initializes a new instance of <see cref="DestinationAsset"/>. </summary>
        /// <param name="registryName"> Destination registry name. </param>
        /// <param name="destinationName"> Destination asset name. </param>
        /// <param name="destinationVersion"> Destination asset version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DestinationAsset(string registryName, string destinationName, string destinationVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RegistryName = registryName;
            DestinationName = destinationName;
            DestinationVersion = destinationVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Destination registry name. </summary>
        public string RegistryName { get; set; }
=======
        /// <summary> Initializes a new instance of <see cref="DestinationAsset"/>. </summary>
        public DestinationAsset()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DestinationAsset"/>. </summary>
        /// <param name="destinationName"> Destination asset name. </param>
        /// <param name="destinationVersion"> Destination asset version. </param>
        /// <param name="registryName"> Destination registry name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DestinationAsset(string destinationName, string destinationVersion, string registryName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DestinationName = destinationName;
            DestinationVersion = destinationVersion;
            RegistryName = registryName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// <summary> Destination asset name. </summary>
        public string DestinationName { get; set; }
        /// <summary> Destination asset version. </summary>
        public string DestinationVersion { get; set; }
<<<<<<< HEAD
========
        /// <summary> Initializes a new instance of <see cref="ServerlessEndpointModelSettings"/>. </summary>
        /// <param name="modelId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServerlessEndpointModelSettings(string modelId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ModelId = modelId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServerlessEndpointModelSettings"/> for deserialization. </summary>
        internal ServerlessEndpointModelSettings()
        {
        }

        /// <summary> Gets or sets the model id. </summary>
        public string ModelId { get; set; }
>>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/ServerlessEndpointModelSettings.cs
=======
        /// <summary> Destination registry name. </summary>
        public string RegistryName { get; set; }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
    }
}
