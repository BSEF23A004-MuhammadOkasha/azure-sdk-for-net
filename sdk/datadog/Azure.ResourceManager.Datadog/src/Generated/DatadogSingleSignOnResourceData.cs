// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Datadog.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Datadog
{
    /// <summary> A class representing the DatadogSingleSignOnResource data model. </summary>
    public partial class DatadogSingleSignOnResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DatadogSingleSignOnResourceData"/>. </summary>
        public DatadogSingleSignOnResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatadogSingleSignOnResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"></param>
        internal DatadogSingleSignOnResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DatadogSingleSignOnProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Gets or sets the properties. </summary>
        public DatadogSingleSignOnProperties Properties { get; set; }
    }
}
