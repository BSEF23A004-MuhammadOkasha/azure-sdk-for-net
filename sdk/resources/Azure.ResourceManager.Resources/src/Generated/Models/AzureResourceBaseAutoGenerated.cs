// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Common properties for all Azure resources. </summary>
    public partial class AzureResourceBaseAutoGenerated : Resource
    {
        /// <summary> Initializes a new instance of AzureResourceBaseAutoGenerated. </summary>
        public AzureResourceBaseAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of AzureResourceBaseAutoGenerated. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        internal AzureResourceBaseAutoGenerated(ResourceIdentifier id, string name, ResourceType type, SystemData systemData) : base(id, name, type)
        {
            SystemData = systemData;
        }

        /// <summary> Azure Resource Manager metadata containing createdBy and modifiedBy information. </summary>
        public SystemData SystemData { get; }
    }
}
