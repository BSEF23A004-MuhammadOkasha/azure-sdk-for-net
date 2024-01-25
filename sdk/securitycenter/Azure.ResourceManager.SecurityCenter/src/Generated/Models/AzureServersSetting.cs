// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> A vulnerability assessments setting on Azure servers in the defined scope. </summary>
    public partial class AzureServersSetting : ServerVulnerabilityAssessmentsSettingData
    {
        /// <summary> Initializes a new instance of <see cref="AzureServersSetting"/>. </summary>
        public AzureServersSetting()
        {
            Kind = ServerVulnerabilityAssessmentsSettingKind.AzureServersSetting;
        }

        /// <summary> Initializes a new instance of <see cref="AzureServersSetting"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the server vulnerability assessments setting. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="selectedProvider"> The selected vulnerability assessments provider on Azure servers in the defined scope. </param>
        internal AzureServersSetting(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ServerVulnerabilityAssessmentsSettingKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, ServerVulnerabilityAssessmentsAzureSettingSelectedProvider? selectedProvider) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            SelectedProvider = selectedProvider;
            Kind = kind;
        }

        /// <summary> The selected vulnerability assessments provider on Azure servers in the defined scope. </summary>
        public ServerVulnerabilityAssessmentsAzureSettingSelectedProvider? SelectedProvider { get; set; }
    }
}
