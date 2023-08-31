// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing the DevTestLabArmTemplate data model.
    /// An Azure Resource Manager template.
    /// </summary>
    public partial class DevTestLabArmTemplateData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabArmTemplateData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DevTestLabArmTemplateData(AzureLocation location) : base(location)
        {
            ParametersValueFilesInfo = new ChangeTrackingList<DevTestLabParametersValueFileInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabArmTemplateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="displayName"> The display name of the ARM template. </param>
        /// <param name="description"> The description of the ARM template. </param>
        /// <param name="publisher"> The publisher of the ARM template. </param>
        /// <param name="icon"> The URI to the icon of the ARM template. </param>
        /// <param name="contents"> The contents of the ARM template. </param>
        /// <param name="createdOn"> The creation date of the armTemplate. </param>
        /// <param name="parametersValueFilesInfo"> File name and parameter values information from all azuredeploy.*.parameters.json for the ARM template. </param>
        /// <param name="isEnabled"> Whether or not ARM template is enabled for use by lab user. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabArmTemplateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string displayName, string description, string publisher, string icon, BinaryData contents, DateTimeOffset? createdOn, IReadOnlyList<DevTestLabParametersValueFileInfo> parametersValueFilesInfo, bool? isEnabled, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            DisplayName = displayName;
            Description = description;
            Publisher = publisher;
            Icon = icon;
            Contents = contents;
            CreatedOn = createdOn;
            ParametersValueFilesInfo = parametersValueFilesInfo;
            IsEnabled = isEnabled;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabArmTemplateData"/> for deserialization. </summary>
        internal DevTestLabArmTemplateData()
        {
        }

        /// <summary> The display name of the ARM template. </summary>
        public string DisplayName { get; }
        /// <summary> The description of the ARM template. </summary>
        public string Description { get; }
        /// <summary> The publisher of the ARM template. </summary>
        public string Publisher { get; }
        /// <summary> The URI to the icon of the ARM template. </summary>
        public string Icon { get; }
        /// <summary>
        /// The contents of the ARM template.
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
        public BinaryData Contents { get; }
        /// <summary> The creation date of the armTemplate. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> File name and parameter values information from all azuredeploy.*.parameters.json for the ARM template. </summary>
        public IReadOnlyList<DevTestLabParametersValueFileInfo> ParametersValueFilesInfo { get; }
        /// <summary> Whether or not ARM template is enabled for use by lab user. </summary>
        public bool? IsEnabled { get; }
    }
}
