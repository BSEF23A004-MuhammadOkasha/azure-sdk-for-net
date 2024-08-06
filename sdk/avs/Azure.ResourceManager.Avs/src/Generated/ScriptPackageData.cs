// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the ScriptPackage data model.
    /// Script Package resources available for execution
    /// </summary>
    public partial class ScriptPackageData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ScriptPackageData"/>. </summary>
        internal ScriptPackageData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScriptPackageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="description"> User friendly description of the package. </param>
        /// <param name="version"> Module version. </param>
        /// <param name="company"> Company that created and supports the package. </param>
        /// <param name="uri"> Link to support by the package vendor. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptPackageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ScriptPackageProvisioningState? provisioningState, string description, string version, string company, string uri, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            Description = description;
            Version = version;
            Company = company;
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioning state of the resource. </summary>
        public ScriptPackageProvisioningState? ProvisioningState { get; }
        /// <summary> User friendly description of the package. </summary>
        public string Description { get; }
        /// <summary> Module version. </summary>
        public string Version { get; }
        /// <summary> Company that created and supports the package. </summary>
        public string Company { get; }
        /// <summary> Link to support by the package vendor. </summary>
        public string Uri { get; }
    }
}
