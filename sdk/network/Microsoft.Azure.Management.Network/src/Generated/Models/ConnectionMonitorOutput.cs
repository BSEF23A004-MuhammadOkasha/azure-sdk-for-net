// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a connection monitor output destination.
    /// </summary>
    public partial class ConnectionMonitorOutput
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionMonitorOutput class.
        /// </summary>
        public ConnectionMonitorOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionMonitorOutput class.
        /// </summary>
        /// <param name="type">Connection monitor output destination type.
        /// Currently, only "Workspace" is supported. Possible values include:
        /// 'Workspace'</param>
        /// <param name="workspaceSettings">Describes the settings for
        /// producing output into a log analytics workspace.</param>
        public ConnectionMonitorOutput(string type = default(string), ConnectionMonitorWorkspaceSettings workspaceSettings = default(ConnectionMonitorWorkspaceSettings))
        {
            Type = type;
            WorkspaceSettings = workspaceSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets connection monitor output destination type. Currently,
        /// only "Workspace" is supported. Possible values include: 'Workspace'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets describes the settings for producing output into a log
        /// analytics workspace.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceSettings")]
        public ConnectionMonitorWorkspaceSettings WorkspaceSettings { get; set; }

    }
}
