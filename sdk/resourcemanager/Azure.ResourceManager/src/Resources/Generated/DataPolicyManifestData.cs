// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the DataPolicyManifest data model.
    /// The data policy manifest.
    /// </summary>
    public partial class DataPolicyManifestData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataPolicyManifestData"/>. </summary>
        internal DataPolicyManifestData()
        {
            Namespaces = new ChangeTrackingList<string>();
            ResourceTypeAliases = new ChangeTrackingList<ResourceTypeAliases>();
            Effects = new ChangeTrackingList<DataPolicyManifestEffect>();
            FieldValues = new ChangeTrackingList<string>();
            Standard = new ChangeTrackingList<string>();
            CustomDefinitions = new ChangeTrackingList<DataManifestCustomResourceFunctionDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="DataPolicyManifestData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="namespaces"> The list of namespaces for the data policy manifest. </param>
        /// <param name="policyMode"> The policy mode of the data policy manifest. </param>
        /// <param name="isBuiltInOnly"> A value indicating whether policy mode is allowed only in built-in definitions. </param>
        /// <param name="resourceTypeAliases"> An array of resource type aliases. </param>
        /// <param name="effects"> The effect definition. </param>
        /// <param name="fieldValues"> The non-alias field accessor values that can be used in the policy rule. </param>
        /// <param name="standard"> The standard resource functions (subscription and/or resourceGroup). </param>
        /// <param name="customDefinitions"> An array of data manifest custom resource definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataPolicyManifestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<string> namespaces, string policyMode, bool? isBuiltInOnly, IReadOnlyList<ResourceTypeAliases> resourceTypeAliases, IReadOnlyList<DataPolicyManifestEffect> effects, IReadOnlyList<string> fieldValues, IReadOnlyList<string> standard, IReadOnlyList<DataManifestCustomResourceFunctionDefinition> customDefinitions, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Namespaces = namespaces;
            PolicyMode = policyMode;
            IsBuiltInOnly = isBuiltInOnly;
            ResourceTypeAliases = resourceTypeAliases;
            Effects = effects;
            FieldValues = fieldValues;
            Standard = standard;
            CustomDefinitions = customDefinitions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of namespaces for the data policy manifest. </summary>
        public IReadOnlyList<string> Namespaces { get; }
        /// <summary> The policy mode of the data policy manifest. </summary>
        public string PolicyMode { get; }
        /// <summary> A value indicating whether policy mode is allowed only in built-in definitions. </summary>
        public bool? IsBuiltInOnly { get; }
        /// <summary> An array of resource type aliases. </summary>
        public IReadOnlyList<ResourceTypeAliases> ResourceTypeAliases { get; }
        /// <summary> The effect definition. </summary>
        public IReadOnlyList<DataPolicyManifestEffect> Effects { get; }
        /// <summary> The non-alias field accessor values that can be used in the policy rule. </summary>
        public IReadOnlyList<string> FieldValues { get; }
        /// <summary> The standard resource functions (subscription and/or resourceGroup). </summary>
        public IReadOnlyList<string> Standard { get; }
        /// <summary> An array of data manifest custom resource definition. </summary>
        public IReadOnlyList<DataManifestCustomResourceFunctionDefinition> CustomDefinitions { get; }
    }
}
