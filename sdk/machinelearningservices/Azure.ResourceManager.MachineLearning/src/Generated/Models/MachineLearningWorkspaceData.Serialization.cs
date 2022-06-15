// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningWorkspaceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(KeyVault))
            {
                writer.WritePropertyName("keyVault");
                writer.WriteStringValue(KeyVault);
            }
            if (Optional.IsDefined(ApplicationInsights))
            {
                writer.WritePropertyName("applicationInsights");
                writer.WriteStringValue(ApplicationInsights);
            }
            if (Optional.IsDefined(ContainerRegistry))
            {
                if (ContainerRegistry != null)
                {
                    writer.WritePropertyName("containerRegistry");
                    writer.WriteStringValue(ContainerRegistry);
                }
                else
                {
                    writer.WriteNull("containerRegistry");
                }
            }
            if (Optional.IsDefined(StorageAccount))
            {
                writer.WritePropertyName("storageAccount");
                writer.WriteStringValue(StorageAccount);
            }
            if (Optional.IsDefined(DiscoveryUri))
            {
                writer.WritePropertyName("discoveryUrl");
                writer.WriteStringValue(DiscoveryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(HbiWorkspace))
            {
                writer.WritePropertyName("hbiWorkspace");
                writer.WriteBooleanValue(HbiWorkspace.Value);
            }
            if (Optional.IsDefined(ImageBuildCompute))
            {
                writer.WritePropertyName("imageBuildCompute");
                writer.WriteStringValue(ImageBuildCompute);
            }
            if (Optional.IsDefined(AllowPublicAccessWhenBehindVnet))
            {
                writer.WritePropertyName("allowPublicAccessWhenBehindVnet");
                writer.WriteBooleanValue(AllowPublicAccessWhenBehindVnet.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SharedPrivateLinkResources))
            {
                writer.WritePropertyName("sharedPrivateLinkResources");
                writer.WriteStartArray();
                foreach (var item in SharedPrivateLinkResources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ServiceManagedResourcesSettings))
            {
                writer.WritePropertyName("serviceManagedResourcesSettings");
                writer.WriteObjectValue(ServiceManagedResourcesSettings);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentity))
            {
                writer.WritePropertyName("primaryUserAssignedIdentity");
                writer.WriteStringValue(PrimaryUserAssignedIdentity);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MachineLearningWorkspaceData DeserializeMachineLearningWorkspaceData(JsonElement element)
        {
            Optional<ManagedServiceIdentity> identity = default;
            Optional<MachineLearningSku> sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> workspaceId = default;
            Optional<string> description = default;
            Optional<string> friendlyName = default;
            Optional<string> keyVault = default;
            Optional<string> applicationInsights = default;
            Optional<string> containerRegistry = default;
            Optional<string> storageAccount = default;
            Optional<Uri> discoveryUrl = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<EncryptionProperty> encryption = default;
            Optional<bool> hbiWorkspace = default;
            Optional<string> serviceProvisionedResourceGroup = default;
            Optional<int> privateLinkCount = default;
            Optional<string> imageBuildCompute = default;
            Optional<bool> allowPublicAccessWhenBehindVnet = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            Optional<IReadOnlyList<MachineLearningPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<IList<SharedPrivateLinkResource>> sharedPrivateLinkResources = default;
            Optional<NotebookResourceInfo> notebookInfo = default;
            Optional<ServiceManagedResourcesSettings> serviceManagedResourcesSettings = default;
            Optional<string> primaryUserAssignedIdentity = default;
            Optional<Guid> tenantId = default;
            Optional<bool> storageHnsEnabled = default;
            Optional<Uri> mlFlowTrackingUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = MachineLearningSku.DeserializeMachineLearningSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("workspaceId"))
                        {
                            workspaceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyVault"))
                        {
                            keyVault = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationInsights"))
                        {
                            applicationInsights = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerRegistry"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                containerRegistry = null;
                                continue;
                            }
                            containerRegistry = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccount"))
                        {
                            storageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("discoveryUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                discoveryUrl = null;
                                continue;
                            }
                            discoveryUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryption = EncryptionProperty.DeserializeEncryptionProperty(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hbiWorkspace"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hbiWorkspace = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("serviceProvisionedResourceGroup"))
                        {
                            serviceProvisionedResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateLinkCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("imageBuildCompute"))
                        {
                            imageBuildCompute = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowPublicAccessWhenBehindVnet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowPublicAccessWhenBehindVnet = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<MachineLearningPrivateEndpointConnectionData> array = new List<MachineLearningPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineLearningPrivateEndpointConnectionData.DeserializeMachineLearningPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SharedPrivateLinkResource> array = new List<SharedPrivateLinkResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SharedPrivateLinkResource.DeserializeSharedPrivateLinkResource(item));
                            }
                            sharedPrivateLinkResources = array;
                            continue;
                        }
                        if (property0.NameEquals("notebookInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            notebookInfo = NotebookResourceInfo.DeserializeNotebookResourceInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serviceManagedResourcesSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serviceManagedResourcesSettings = ServiceManagedResourcesSettings.DeserializeServiceManagedResourcesSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("primaryUserAssignedIdentity"))
                        {
                            primaryUserAssignedIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("storageHnsEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageHnsEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("mlFlowTrackingUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                mlFlowTrackingUri = null;
                                continue;
                            }
                            mlFlowTrackingUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MachineLearningWorkspaceData(id, name, type, systemData, tags, location, identity, sku.Value, workspaceId.Value, description.Value, friendlyName.Value, keyVault.Value, applicationInsights.Value, containerRegistry.Value, storageAccount.Value, discoveryUrl.Value, Optional.ToNullable(provisioningState), encryption.Value, Optional.ToNullable(hbiWorkspace), serviceProvisionedResourceGroup.Value, Optional.ToNullable(privateLinkCount), imageBuildCompute.Value, Optional.ToNullable(allowPublicAccessWhenBehindVnet), Optional.ToNullable(publicNetworkAccess), Optional.ToList(privateEndpointConnections), Optional.ToList(sharedPrivateLinkResources), notebookInfo.Value, serviceManagedResourcesSettings.Value, primaryUserAssignedIdentity.Value, Optional.ToNullable(tenantId), Optional.ToNullable(storageHnsEnabled), mlFlowTrackingUri.Value);
        }
    }
}
