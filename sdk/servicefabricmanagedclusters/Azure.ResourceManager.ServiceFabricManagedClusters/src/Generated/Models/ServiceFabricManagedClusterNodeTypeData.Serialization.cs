// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    public partial class ServiceFabricManagedClusterNodeTypeData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(IsPrimary))
            {
                writer.WritePropertyName("isPrimary");
                writer.WriteBooleanValue(IsPrimary.Value);
            }
            if (Optional.IsDefined(VmInstanceCount))
            {
                writer.WritePropertyName("vmInstanceCount");
                writer.WriteNumberValue(VmInstanceCount.Value);
            }
            if (Optional.IsDefined(DataDiskSizeInGB))
            {
                writer.WritePropertyName("dataDiskSizeGB");
                writer.WriteNumberValue(DataDiskSizeInGB.Value);
            }
            if (Optional.IsDefined(DataDiskType))
            {
                writer.WritePropertyName("dataDiskType");
                writer.WriteStringValue(DataDiskType.Value.ToString());
            }
            if (Optional.IsDefined(DataDiskLetter))
            {
                writer.WritePropertyName("dataDiskLetter");
                writer.WriteStringValue(DataDiskLetter);
            }
            if (Optional.IsCollectionDefined(PlacementProperties))
            {
                writer.WritePropertyName("placementProperties");
                writer.WriteStartObject();
                foreach (var item in PlacementProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Capacities))
            {
                writer.WritePropertyName("capacities");
                writer.WriteStartObject();
                foreach (var item in Capacities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ApplicationPorts))
            {
                writer.WritePropertyName("applicationPorts");
                writer.WriteObjectValue(ApplicationPorts);
            }
            if (Optional.IsDefined(EphemeralPorts))
            {
                writer.WritePropertyName("ephemeralPorts");
                writer.WriteObjectValue(EphemeralPorts);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize");
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(VmImagePublisher))
            {
                writer.WritePropertyName("vmImagePublisher");
                writer.WriteStringValue(VmImagePublisher);
            }
            if (Optional.IsDefined(VmImageOffer))
            {
                writer.WritePropertyName("vmImageOffer");
                writer.WriteStringValue(VmImageOffer);
            }
            if (Optional.IsDefined(VmImageSku))
            {
                writer.WritePropertyName("vmImageSku");
                writer.WriteStringValue(VmImageSku);
            }
            if (Optional.IsDefined(VmImageVersion))
            {
                writer.WritePropertyName("vmImageVersion");
                writer.WriteStringValue(VmImageVersion);
            }
            if (Optional.IsCollectionDefined(VmSecrets))
            {
                writer.WritePropertyName("vmSecrets");
                writer.WriteStartArray();
                foreach (var item in VmSecrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmExtensions))
            {
                writer.WritePropertyName("vmExtensions");
                writer.WriteStartArray();
                foreach (var item in VmExtensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VmManagedIdentity))
            {
                writer.WritePropertyName("vmManagedIdentity");
                writer.WriteObjectValue(VmManagedIdentity);
            }
            if (Optional.IsDefined(IsStateless))
            {
                writer.WritePropertyName("isStateless");
                writer.WriteBooleanValue(IsStateless.Value);
            }
            if (Optional.IsDefined(HasMultiplePlacementGroups))
            {
                writer.WritePropertyName("multiplePlacementGroups");
                writer.WriteBooleanValue(HasMultiplePlacementGroups.Value);
            }
            if (Optional.IsCollectionDefined(FrontendConfigurations))
            {
                writer.WritePropertyName("frontendConfigurations");
                writer.WriteStartArray();
                foreach (var item in FrontendConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NetworkSecurityRules))
            {
                writer.WritePropertyName("networkSecurityRules");
                writer.WriteStartArray();
                foreach (var item in NetworkSecurityRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdditionalDataDisks))
            {
                writer.WritePropertyName("additionalDataDisks");
                writer.WriteStartArray();
                foreach (var item in AdditionalDataDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsEncryptionAtHostEnabled))
            {
                writer.WritePropertyName("enableEncryptionAtHost");
                writer.WriteBooleanValue(IsEncryptionAtHostEnabled.Value);
            }
            if (Optional.IsDefined(IsAcceleratedNetworkingEnabled))
            {
                writer.WritePropertyName("enableAcceleratedNetworking");
                writer.WriteBooleanValue(IsAcceleratedNetworkingEnabled.Value);
            }
            if (Optional.IsDefined(UseDefaultPublicLoadBalancer))
            {
                writer.WritePropertyName("useDefaultPublicLoadBalancer");
                writer.WriteBooleanValue(UseDefaultPublicLoadBalancer.Value);
            }
            if (Optional.IsDefined(UseTempDataDisk))
            {
                writer.WritePropertyName("useTempDataDisk");
                writer.WriteBooleanValue(UseTempDataDisk.Value);
            }
            if (Optional.IsDefined(IsOverProvisioningEnabled))
            {
                writer.WritePropertyName("enableOverProvisioning");
                writer.WriteBooleanValue(IsOverProvisioningEnabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServiceFabricManagedClusterNodeTypeData DeserializeServiceFabricManagedClusterNodeTypeData(JsonElement element)
        {
            Optional<NodeTypeSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> isPrimary = default;
            Optional<int> vmInstanceCount = default;
            Optional<int> dataDiskSizeGB = default;
            Optional<ServiceFabricManagedDataDiskType> dataDiskType = default;
            Optional<string> dataDiskLetter = default;
            Optional<IDictionary<string, string>> placementProperties = default;
            Optional<IDictionary<string, string>> capacities = default;
            Optional<EndpointRangeDescription> applicationPorts = default;
            Optional<EndpointRangeDescription> ephemeralPorts = default;
            Optional<string> vmSize = default;
            Optional<string> vmImagePublisher = default;
            Optional<string> vmImageOffer = default;
            Optional<string> vmImageSku = default;
            Optional<string> vmImageVersion = default;
            Optional<IList<NodeTypeVaultSecretGroup>> vmSecrets = default;
            Optional<IList<NodeTypeVmssExtension>> vmExtensions = default;
            Optional<VmManagedIdentity> vmManagedIdentity = default;
            Optional<bool> isStateless = default;
            Optional<bool> multiplePlacementGroups = default;
            Optional<IList<NodeTypeFrontendConfiguration>> frontendConfigurations = default;
            Optional<IList<ServiceFabricManagedClustersNetworkSecurityRule>> networkSecurityRules = default;
            Optional<IList<NodeTypeVmssDataDisk>> additionalDataDisks = default;
            Optional<bool> enableEncryptionAtHost = default;
            Optional<ServiceFabricManagedResourceProvisioningState> provisioningState = default;
            Optional<bool> enableAcceleratedNetworking = default;
            Optional<bool> useDefaultPublicLoadBalancer = default;
            Optional<bool> useTempDataDisk = default;
            Optional<bool> enableOverProvisioning = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = NodeTypeSku.DeserializeNodeTypeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("isPrimary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isPrimary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("vmInstanceCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vmInstanceCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dataDiskSizeGB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataDiskSizeGB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dataDiskType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataDiskType = new ServiceFabricManagedDataDiskType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataDiskLetter"))
                        {
                            dataDiskLetter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("placementProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            placementProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("capacities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            capacities = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("applicationPorts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            applicationPorts = EndpointRangeDescription.DeserializeEndpointRangeDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ephemeralPorts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ephemeralPorts = EndpointRangeDescription.DeserializeEndpointRangeDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vmSize"))
                        {
                            vmSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmImagePublisher"))
                        {
                            vmImagePublisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmImageOffer"))
                        {
                            vmImageOffer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmImageSku"))
                        {
                            vmImageSku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmImageVersion"))
                        {
                            vmImageVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmSecrets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NodeTypeVaultSecretGroup> array = new List<NodeTypeVaultSecretGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NodeTypeVaultSecretGroup.DeserializeNodeTypeVaultSecretGroup(item));
                            }
                            vmSecrets = array;
                            continue;
                        }
                        if (property0.NameEquals("vmExtensions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NodeTypeVmssExtension> array = new List<NodeTypeVmssExtension>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NodeTypeVmssExtension.DeserializeNodeTypeVmssExtension(item));
                            }
                            vmExtensions = array;
                            continue;
                        }
                        if (property0.NameEquals("vmManagedIdentity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vmManagedIdentity = VmManagedIdentity.DeserializeVmManagedIdentity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isStateless"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isStateless = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("multiplePlacementGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            multiplePlacementGroups = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("frontendConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NodeTypeFrontendConfiguration> array = new List<NodeTypeFrontendConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NodeTypeFrontendConfiguration.DeserializeNodeTypeFrontendConfiguration(item));
                            }
                            frontendConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ServiceFabricManagedClustersNetworkSecurityRule> array = new List<ServiceFabricManagedClustersNetworkSecurityRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceFabricManagedClustersNetworkSecurityRule.DeserializeServiceFabricManagedClustersNetworkSecurityRule(item));
                            }
                            networkSecurityRules = array;
                            continue;
                        }
                        if (property0.NameEquals("additionalDataDisks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NodeTypeVmssDataDisk> array = new List<NodeTypeVmssDataDisk>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NodeTypeVmssDataDisk.DeserializeNodeTypeVmssDataDisk(item));
                            }
                            additionalDataDisks = array;
                            continue;
                        }
                        if (property0.NameEquals("enableEncryptionAtHost"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableEncryptionAtHost = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ServiceFabricManagedResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableAcceleratedNetworking"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableAcceleratedNetworking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useDefaultPublicLoadBalancer"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useDefaultPublicLoadBalancer = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useTempDataDisk"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useTempDataDisk = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableOverProvisioning"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableOverProvisioning = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServiceFabricManagedClusterNodeTypeData(id, name, type, systemData.Value, sku.Value, Optional.ToNullable(isPrimary), Optional.ToNullable(vmInstanceCount), Optional.ToNullable(dataDiskSizeGB), Optional.ToNullable(dataDiskType), dataDiskLetter.Value, Optional.ToDictionary(placementProperties), Optional.ToDictionary(capacities), applicationPorts.Value, ephemeralPorts.Value, vmSize.Value, vmImagePublisher.Value, vmImageOffer.Value, vmImageSku.Value, vmImageVersion.Value, Optional.ToList(vmSecrets), Optional.ToList(vmExtensions), vmManagedIdentity.Value, Optional.ToNullable(isStateless), Optional.ToNullable(multiplePlacementGroups), Optional.ToList(frontendConfigurations), Optional.ToList(networkSecurityRules), Optional.ToList(additionalDataDisks), Optional.ToNullable(enableEncryptionAtHost), Optional.ToNullable(provisioningState), Optional.ToNullable(enableAcceleratedNetworking), Optional.ToNullable(useDefaultPublicLoadBalancer), Optional.ToNullable(useTempDataDisk), Optional.ToNullable(enableOverProvisioning), Optional.ToDictionary(tags));
        }
    }
}
