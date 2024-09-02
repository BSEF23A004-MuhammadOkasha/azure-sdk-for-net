// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> A class representing the MachineLearningRegistry data model. </summary>
    public partial class MachineLearningRegistryData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningRegistryData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MachineLearningRegistryData(AzureLocation location) : base(location)
        {
            RegistryPrivateEndpointConnections = new ChangeTrackingList<RegistryPrivateEndpointConnection>();
            RegionDetails = new ChangeTrackingList<RegistryRegionArmDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningRegistryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. </param>
        /// <param name="sku"> Sku details required for ARM contract for Autoscaling. </param>
        /// <param name="discoveryUri"> Discovery URL for the Registry. </param>
        /// <param name="intellectualPropertyPublisher"> IntellectualPropertyPublisher for the registry. </param>
        /// <param name="managedResourceGroup"> ResourceId of the managed RG if the registry has system created resources. </param>
        /// <param name="managedResourceGroupSettings"> Managed resource group specific settings. </param>
        /// <param name="mlFlowRegistryUri"> MLFlow Registry URI for the Registry. </param>
        /// <param name="registryPrivateEndpointConnections"> Private endpoint connections info used for pending connections in private link portal. </param>
        /// <param name="publicNetworkAccess">
        /// Is the Registry accessible from the internet?
        /// Possible values: "Enabled" or "Disabled"
        /// </param>
        /// <param name="regionDetails"> Details of each region the registry is in. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
<<<<<<< HEAD
        internal MachineLearningRegistryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string kind, MachineLearningSku sku, Uri discoveryUri, string intellectualPropertyPublisher, ArmResourceId managedResourceGroup, Uri mlFlowRegistryUri, IList<RegistryPrivateEndpointConnection> registryPrivateEndpointConnections, string publicNetworkAccess, IList<RegistryRegionArmDetails> regionDetails, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
=======
        internal MachineLearningRegistryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string kind, MachineLearningSku sku, Uri discoveryUri, string intellectualPropertyPublisher, ArmResourceId managedResourceGroup, ManagedResourceGroupSettings managedResourceGroupSettings, Uri mlFlowRegistryUri, IList<RegistryPrivateEndpointConnection> registryPrivateEndpointConnections, string publicNetworkAccess, IList<RegistryRegionArmDetails> regionDetails, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        {
            Identity = identity;
            Kind = kind;
            Sku = sku;
            DiscoveryUri = discoveryUri;
            IntellectualPropertyPublisher = intellectualPropertyPublisher;
            ManagedResourceGroup = managedResourceGroup;
            ManagedResourceGroupSettings = managedResourceGroupSettings;
            MlFlowRegistryUri = mlFlowRegistryUri;
            RegistryPrivateEndpointConnections = registryPrivateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            RegionDetails = regionDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningRegistryData"/> for deserialization. </summary>
        internal MachineLearningRegistryData()
        {
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. </summary>
        public string Kind { get; set; }
        /// <summary> Sku details required for ARM contract for Autoscaling. </summary>
        public MachineLearningSku Sku { get; set; }
        /// <summary> Discovery URL for the Registry. </summary>
        public Uri DiscoveryUri { get; set; }
        /// <summary> IntellectualPropertyPublisher for the registry. </summary>
        public string IntellectualPropertyPublisher { get; set; }
        /// <summary> ResourceId of the managed RG if the registry has system created resources. </summary>
        internal ArmResourceId ManagedResourceGroup { get; set; }
        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        public ResourceIdentifier ManagedResourceId
        {
            get => ManagedResourceGroup is null ? default : ManagedResourceGroup.ResourceId;
            set
            {
                if (ManagedResourceGroup is null)
                    ManagedResourceGroup = new ArmResourceId();
                ManagedResourceGroup.ResourceId = value;
            }
        }

        /// <summary> Managed resource group specific settings. </summary>
        internal ManagedResourceGroupSettings ManagedResourceGroupSettings { get; set; }
        /// <summary> List of assigned identities for the managed resource group. </summary>
        public IList<ManagedResourceGroupAssignedIdentities> ManagedResourceGroupAssignedIdentities
        {
            get => ManagedResourceGroupSettings is null ? default : ManagedResourceGroupSettings.AssignedIdentities;
            set
            {
                if (ManagedResourceGroupSettings is null)
                    ManagedResourceGroupSettings = new ManagedResourceGroupSettings();
                ManagedResourceGroupSettings.AssignedIdentities = value;
            }
        }

        /// <summary> MLFlow Registry URI for the Registry. </summary>
        public Uri MlFlowRegistryUri { get; set; }
        /// <summary> Private endpoint connections info used for pending connections in private link portal. </summary>
        public IList<RegistryPrivateEndpointConnection> RegistryPrivateEndpointConnections { get; set; }
        /// <summary>
        /// Is the Registry accessible from the internet?
        /// Possible values: "Enabled" or "Disabled"
        /// </summary>
        public string PublicNetworkAccess { get; set; }
        /// <summary> Details of each region the registry is in. </summary>
        public IList<RegistryRegionArmDetails> RegionDetails { get; set; }
    }
}
