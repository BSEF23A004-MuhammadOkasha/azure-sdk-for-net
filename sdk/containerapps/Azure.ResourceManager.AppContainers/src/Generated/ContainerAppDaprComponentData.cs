// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing the ContainerAppDaprComponent data model.
    /// Dapr Component.
    /// </summary>
    public partial class ContainerAppDaprComponentData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppDaprComponentData"/>. </summary>
        public ContainerAppDaprComponentData()
        {
            Secrets = new ChangeTrackingList<ContainerAppWritableSecret>();
            Metadata = new ChangeTrackingList<ContainerAppDaprMetadata>();
            Scopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppDaprComponentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="componentType"> Component type. </param>
        /// <param name="version"> Component version. </param>
        /// <param name="ignoreErrors"> Boolean describing if the component errors are ignores. </param>
        /// <param name="initTimeout"> Initialization timeout. </param>
        /// <param name="secrets"> Collection of secrets used by a Dapr component. </param>
        /// <param name="secretStoreComponent"> Name of a Dapr component to retrieve component secrets from. </param>
        /// <param name="metadata"> Component metadata. </param>
        /// <param name="scopes"> Names of container apps that can use this Dapr component. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppDaprComponentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string componentType, string version, bool? ignoreErrors, string initTimeout, IList<ContainerAppWritableSecret> secrets, string secretStoreComponent, IList<ContainerAppDaprMetadata> metadata, IList<string> scopes, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ComponentType = componentType;
            Version = version;
            IgnoreErrors = ignoreErrors;
            InitTimeout = initTimeout;
            Secrets = secrets;
            SecretStoreComponent = secretStoreComponent;
            Metadata = metadata;
            Scopes = scopes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Component type. </summary>
        public string ComponentType { get; set; }
        /// <summary> Component version. </summary>
        public string Version { get; set; }
        /// <summary> Boolean describing if the component errors are ignores. </summary>
        public bool? IgnoreErrors { get; set; }
        /// <summary> Initialization timeout. </summary>
        public string InitTimeout { get; set; }
        /// <summary> Collection of secrets used by a Dapr component. </summary>
        public IList<ContainerAppWritableSecret> Secrets { get; }
        /// <summary> Name of a Dapr component to retrieve component secrets from. </summary>
        public string SecretStoreComponent { get; set; }
        /// <summary> Component metadata. </summary>
        public IList<ContainerAppDaprMetadata> Metadata { get; }
        /// <summary> Names of container apps that can use this Dapr component. </summary>
        public IList<string> Scopes { get; }
    }
}
