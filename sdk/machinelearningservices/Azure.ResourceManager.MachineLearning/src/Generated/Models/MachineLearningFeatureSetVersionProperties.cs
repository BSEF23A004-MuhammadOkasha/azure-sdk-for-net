// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Dto object representing feature set version. </summary>
    public partial class MachineLearningFeatureSetVersionProperties : MachineLearningAssetBase
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningFeatureSetVersionProperties"/>. </summary>
        public MachineLearningFeatureSetVersionProperties()
        {
            Entities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningFeatureSetVersionProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="autoDeleteSetting"> Specifies the lifecycle setting of managed data asset. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). For types where Stage is defined, when Stage is provided it will be used to populate IsAnonymous. </param>
        /// <param name="isArchived"> Is the asset archived? For types where Stage is defined, when Stage is provided it will be used to populate IsArchived. </param>
        /// <param name="entities"> Specifies list of entities. </param>
        /// <param name="materializationSettings"> Specifies the materialization settings. </param>
        /// <param name="provisioningState"> Provisioning state for the featureset version container. </param>
        /// <param name="specification"> Specifies the feature spec details. </param>
        /// <param name="stage"> Specifies the asset stage. </param>
        internal MachineLearningFeatureSetVersionProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, AutoDeleteSetting autoDeleteSetting, bool? isAnonymous, bool? isArchived, IList<string> entities, MaterializationSettings materializationSettings, RegistryAssetProvisioningState? provisioningState, FeaturesetSpecification specification, string stage) : base(description, properties, tags, serializedAdditionalRawData, autoDeleteSetting, isAnonymous, isArchived)
        {
            Entities = entities;
            MaterializationSettings = materializationSettings;
            ProvisioningState = provisioningState;
            Specification = specification;
            Stage = stage;
        }

        /// <summary> Specifies list of entities. </summary>
        public IList<string> Entities { get; set; }
        /// <summary> Specifies the materialization settings. </summary>
        public MaterializationSettings MaterializationSettings { get; set; }
        /// <summary> Provisioning state for the featureset version container. </summary>
        public RegistryAssetProvisioningState? ProvisioningState { get; }
        /// <summary> Specifies the feature spec details. </summary>
        internal FeaturesetSpecification Specification { get; set; }
        /// <summary> Specifies the spec path. </summary>
        public string SpecificationPath
        {
            get => Specification is null ? default : Specification.Path;
            set
            {
                if (Specification is null)
                    Specification = new FeaturesetSpecification();
                Specification.Path = value;
            }
        }

        /// <summary> Specifies the asset stage. </summary>
        public string Stage { get; set; }
    }
}
