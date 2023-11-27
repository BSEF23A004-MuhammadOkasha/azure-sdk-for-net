// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Property details. </summary>
    public partial class ContainerAppDiagnosticDataProviderMetadataPropertyBagItem
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticDataProviderMetadataPropertyBagItem"/>. </summary>
        public ContainerAppDiagnosticDataProviderMetadataPropertyBagItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticDataProviderMetadataPropertyBagItem"/>. </summary>
        /// <param name="name"> Property name. </param>
        /// <param name="value"> Property value. </param>
        internal ContainerAppDiagnosticDataProviderMetadataPropertyBagItem(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> Property name. </summary>
        public string Name { get; set; }
        /// <summary> Property value. </summary>
        public string Value { get; set; }
    }
}
