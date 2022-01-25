// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Resource Manager template.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ArmTemplate : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ArmTemplate class.
        /// </summary>
        public ArmTemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArmTemplate class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="displayName">The display name of the ARM
        /// template.</param>
        /// <param name="description">The description of the ARM
        /// template.</param>
        /// <param name="publisher">The publisher of the ARM template.</param>
        /// <param name="icon">The URI to the icon of the ARM template.</param>
        /// <param name="contents">The contents of the ARM template.</param>
        /// <param name="createdDate">The creation date of the
        /// armTemplate.</param>
        /// <param name="parametersValueFilesInfo">File name and parameter
        /// values information from all azuredeploy.*.parameters.json for the
        /// ARM template.</param>
        /// <param name="enabled">Whether or not ARM template is enabled for
        /// use by lab user.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource</param>
        public ArmTemplate(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), string description = default(string), string publisher = default(string), string icon = default(string), object contents = default(object), System.DateTime? createdDate = default(System.DateTime?), IList<ParametersValueFileInfo> parametersValueFilesInfo = default(IList<ParametersValueFileInfo>), bool? enabled = default(bool?), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            DisplayName = displayName;
            Description = description;
            Publisher = publisher;
            Icon = icon;
            Contents = contents;
            CreatedDate = createdDate;
            ParametersValueFilesInfo = parametersValueFilesInfo;
            Enabled = enabled;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the display name of the ARM template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the description of the ARM template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the publisher of the ARM template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisher")]
        public string Publisher { get; private set; }

        /// <summary>
        /// Gets the URI to the icon of the ARM template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.icon")]
        public string Icon { get; private set; }

        /// <summary>
        /// Gets the contents of the ARM template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contents")]
        public object Contents { get; private set; }

        /// <summary>
        /// Gets the creation date of the armTemplate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// Gets file name and parameter values information from all
        /// azuredeploy.*.parameters.json for the ARM template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parametersValueFilesInfo")]
        public IList<ParametersValueFileInfo> ParametersValueFilesInfo { get; private set; }

        /// <summary>
        /// Gets whether or not ARM template is enabled for use by lab user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; private set; }

        /// <summary>
        /// Gets the system metadata relating to this resource
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
