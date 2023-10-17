// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing the MachineLearningFeaturestoreEntityVersion data model.
    /// Azure Resource Manager resource envelope.
    /// </summary>
    public partial class MachineLearningFeaturestoreEntityVersionData : ResourceData
    {
        /// <summary> Initializes a new instance of MachineLearningFeaturestoreEntityVersionData. </summary>
        /// <param name="properties"> [Required] Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public MachineLearningFeaturestoreEntityVersionData(MachineLearningFeatureStoreEntityVersionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of MachineLearningFeaturestoreEntityVersionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> [Required] Additional attributes of the entity. </param>
        internal MachineLearningFeaturestoreEntityVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MachineLearningFeatureStoreEntityVersionProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> [Required] Additional attributes of the entity. </summary>
        public MachineLearningFeatureStoreEntityVersionProperties Properties { get; set; }
    }
}
