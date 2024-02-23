// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabData : IUtf8JsonSerializable, IJsonModel<DevTestLabData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && DefaultStorageAccount != null)
            {
                writer.WritePropertyName("defaultStorageAccount"u8);
                writer.WriteStringValue(DefaultStorageAccount);
            }
            if (options.Format != "W" && DefaultPremiumStorageAccount != null)
            {
                writer.WritePropertyName("defaultPremiumStorageAccount"u8);
                writer.WriteStringValue(DefaultPremiumStorageAccount);
            }
            if (options.Format != "W" && ArtifactsStorageAccount != null)
            {
                writer.WritePropertyName("artifactsStorageAccount"u8);
                writer.WriteStringValue(ArtifactsStorageAccount);
            }
            if (options.Format != "W" && PremiumDataDiskStorageAccount != null)
            {
                writer.WritePropertyName("premiumDataDiskStorageAccount"u8);
                writer.WriteStringValue(PremiumDataDiskStorageAccount);
            }
            if (options.Format != "W" && VaultName != null)
            {
                writer.WritePropertyName("vaultName"u8);
                writer.WriteStringValue(VaultName);
            }
            if (LabStorageType.HasValue)
            {
                writer.WritePropertyName("labStorageType"u8);
                writer.WriteStringValue(LabStorageType.Value.ToString());
            }
            if (!(MandatoryArtifactsResourceIdsLinux is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("mandatoryArtifactsResourceIdsLinux"u8);
                writer.WriteStartArray();
                foreach (var item in MandatoryArtifactsResourceIdsLinux)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(MandatoryArtifactsResourceIdsWindows is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("mandatoryArtifactsResourceIdsWindows"u8);
                writer.WriteStartArray();
                foreach (var item in MandatoryArtifactsResourceIdsWindows)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (PremiumDataDisks.HasValue)
            {
                writer.WritePropertyName("premiumDataDisks"u8);
                writer.WriteStringValue(PremiumDataDisks.Value.ToString());
            }
            if (EnvironmentPermission.HasValue)
            {
                writer.WritePropertyName("environmentPermission"u8);
                writer.WriteStringValue(EnvironmentPermission.Value.ToString());
            }
            if (Announcement != null)
            {
                writer.WritePropertyName("announcement"u8);
                writer.WriteObjectValue(Announcement);
            }
            if (Support != null)
            {
                writer.WritePropertyName("support"u8);
                writer.WriteObjectValue(Support);
            }
            if (options.Format != "W" && VmCreationResourceGroup != null)
            {
                writer.WritePropertyName("vmCreationResourceGroup"u8);
                writer.WriteStringValue(VmCreationResourceGroup);
            }
            if (options.Format != "W" && PublicIPId != null)
            {
                writer.WritePropertyName("publicIpId"u8);
                writer.WriteStringValue(PublicIPId);
            }
            if (options.Format != "W" && LoadBalancerId != null)
            {
                writer.WritePropertyName("loadBalancerId"u8);
                writer.WriteStringValue(LoadBalancerId);
            }
            if (options.Format != "W" && NetworkSecurityGroupId != null)
            {
                writer.WritePropertyName("networkSecurityGroupId"u8);
                writer.WriteStringValue(NetworkSecurityGroupId);
            }
            if (!(ExtendedProperties is ChangeTrackingDictionary<string, string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("extendedProperties"u8);
                writer.WriteStartObject();
                foreach (var item in ExtendedProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && UniqueIdentifier.HasValue)
            {
                writer.WritePropertyName("uniqueIdentifier"u8);
                writer.WriteStringValue(UniqueIdentifier.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DevTestLabData IJsonModel<DevTestLabData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabData(document.RootElement, options);
        }

        internal static DevTestLabData DeserializeDevTestLabData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> defaultStorageAccount = default;
            Optional<string> defaultPremiumStorageAccount = default;
            Optional<string> artifactsStorageAccount = default;
            Optional<string> premiumDataDiskStorageAccount = default;
            Optional<string> vaultName = default;
            Optional<DevTestLabStorageType> labStorageType = default;
            IList<string> mandatoryArtifactsResourceIdsLinux = default;
            IList<string> mandatoryArtifactsResourceIdsWindows = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<DevTestLabPremiumDataDisk> premiumDataDisks = default;
            Optional<DevTestLabEnvironmentPermission> environmentPermission = default;
            Optional<DevTestLabAnnouncement> announcement = default;
            Optional<DevTestLabSupport> support = default;
            Optional<string> vmCreationResourceGroup = default;
            Optional<string> publicIPId = default;
            Optional<string> loadBalancerId = default;
            Optional<string> networkSecurityGroupId = default;
            IDictionary<string, string> extendedProperties = default;
            Optional<string> provisioningState = default;
            Optional<Guid> uniqueIdentifier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("defaultStorageAccount"u8))
                        {
                            defaultStorageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultPremiumStorageAccount"u8))
                        {
                            defaultPremiumStorageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("artifactsStorageAccount"u8))
                        {
                            artifactsStorageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("premiumDataDiskStorageAccount"u8))
                        {
                            premiumDataDiskStorageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vaultName"u8))
                        {
                            vaultName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labStorageType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            labStorageType = new DevTestLabStorageType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mandatoryArtifactsResourceIdsLinux"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            mandatoryArtifactsResourceIdsLinux = array;
                            continue;
                        }
                        if (property0.NameEquals("mandatoryArtifactsResourceIdsWindows"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            mandatoryArtifactsResourceIdsWindows = array;
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("premiumDataDisks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            premiumDataDisks = new DevTestLabPremiumDataDisk(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("environmentPermission"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            environmentPermission = new DevTestLabEnvironmentPermission(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("announcement"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            announcement = DevTestLabAnnouncement.DeserializeDevTestLabAnnouncement(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("support"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            support = DevTestLabSupport.DeserializeDevTestLabSupport(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vmCreationResourceGroup"u8))
                        {
                            vmCreationResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicIpId"u8))
                        {
                            publicIPId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerId"u8))
                        {
                            loadBalancerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityGroupId"u8))
                        {
                            networkSecurityGroupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extendedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            extendedProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabData(id, name, type, systemData.Value, tags ?? new ChangeTrackingDictionary<string, string>(), location, defaultStorageAccount.Value, defaultPremiumStorageAccount.Value, artifactsStorageAccount.Value, premiumDataDiskStorageAccount.Value, vaultName.Value, Optional.ToNullable(labStorageType), mandatoryArtifactsResourceIdsLinux ?? new ChangeTrackingList<string>(), mandatoryArtifactsResourceIdsWindows ?? new ChangeTrackingList<string>(), Optional.ToNullable(createdDate), Optional.ToNullable(premiumDataDisks), Optional.ToNullable(environmentPermission), announcement.Value, support.Value, vmCreationResourceGroup.Value, publicIPId.Value, loadBalancerId.Value, networkSecurityGroupId.Value, extendedProperties ?? new ChangeTrackingDictionary<string, string>(), provisioningState.Value, Optional.ToNullable(uniqueIdentifier), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabData)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabData IPersistableModel<DevTestLabData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
