// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Configuration Content for Devices or Modules on Edge Devices. </summary>
    public partial class ConfigurationContent
    {
        /// <summary> Initializes a new instance of ConfigurationContent. </summary>
        public ConfigurationContent()
        {
            DeviceContent = new ChangeTrackingDictionary<string, object>();
            ModulesContent = new ChangeTrackingDictionary<string, object>();
            ModuleContent = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ConfigurationContent. </summary>
        /// <param name="deviceContent"> Gets or sets device Configurations. </param>
        /// <param name="modulesContent"> Gets or sets Modules Configurations. </param>
        /// <param name="moduleContent"> Gets or sets Module Configurations. </param>
        internal ConfigurationContent(IDictionary<string, object> deviceContent, IDictionary<string, object> modulesContent, IDictionary<string, object> moduleContent)
        {
            DeviceContent = deviceContent;
            ModulesContent = modulesContent;
            ModuleContent = moduleContent;
        }

        /// <summary> Gets or sets device Configurations. </summary>
        public IDictionary<string, object> DeviceContent { get; }
        /// <summary> Gets or sets Modules Configurations. </summary>
        public IDictionary<string, object> ModulesContent { get; }
        /// <summary> Gets or sets Module Configurations. </summary>
        public IDictionary<string, object> ModuleContent { get; }
    }
}
