// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class ManagedDiskData : IUtf8JsonSerializable, IModelJsonSerializable<ManagedDiskData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedDiskData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedDiskData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedDiskData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DiskSku>)Sku).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsCollectionDefined(Tags))
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToSerialString());
            }
            if (Optional.IsDefined(HyperVGeneration))
            {
                writer.WritePropertyName("hyperVGeneration"u8);
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            if (Optional.IsDefined(PurchasePlan))
            {
                writer.WritePropertyName("purchasePlan"u8);
                if (PurchasePlan is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DiskPurchasePlan>)PurchasePlan).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SupportedCapabilities))
            {
                writer.WritePropertyName("supportedCapabilities"u8);
                if (SupportedCapabilities is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SupportedCapabilities>)SupportedCapabilities).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CreationData))
            {
                writer.WritePropertyName("creationData"u8);
                if (CreationData is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DiskCreationData>)CreationData).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(EncryptionSettingsGroup))
            {
                writer.WritePropertyName("encryptionSettingsCollection"u8);
                if (EncryptionSettingsGroup is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<EncryptionSettingsGroup>)EncryptionSettingsGroup).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DiskIopsReadWrite))
            {
                writer.WritePropertyName("diskIOPSReadWrite"u8);
                writer.WriteNumberValue(DiskIopsReadWrite.Value);
            }
            if (Optional.IsDefined(DiskMBpsReadWrite))
            {
                writer.WritePropertyName("diskMBpsReadWrite"u8);
                writer.WriteNumberValue(DiskMBpsReadWrite.Value);
            }
            if (Optional.IsDefined(DiskIopsReadOnly))
            {
                writer.WritePropertyName("diskIOPSReadOnly"u8);
                writer.WriteNumberValue(DiskIopsReadOnly.Value);
            }
            if (Optional.IsDefined(DiskMBpsReadOnly))
            {
                writer.WritePropertyName("diskMBpsReadOnly"u8);
                writer.WriteNumberValue(DiskMBpsReadOnly.Value);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                if (Encryption is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DiskEncryption>)Encryption).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MaxShares))
            {
                writer.WritePropertyName("maxShares"u8);
                writer.WriteNumberValue(MaxShares.Value);
            }
            if (Optional.IsDefined(NetworkAccessPolicy))
            {
                writer.WritePropertyName("networkAccessPolicy"u8);
                writer.WriteStringValue(NetworkAccessPolicy.Value.ToString());
            }
            if (Optional.IsDefined(DiskAccessId))
            {
                writer.WritePropertyName("diskAccessId"u8);
                writer.WriteStringValue(DiskAccessId);
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (Optional.IsDefined(BurstingEnabled))
            {
                writer.WritePropertyName("burstingEnabled"u8);
                writer.WriteBooleanValue(BurstingEnabled.Value);
            }
            if (Optional.IsDefined(SupportsHibernation))
            {
                writer.WritePropertyName("supportsHibernation"u8);
                writer.WriteBooleanValue(SupportsHibernation.Value);
            }
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile"u8);
                if (SecurityProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DiskSecurityProfile>)SecurityProfile).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CompletionPercent))
            {
                writer.WritePropertyName("completionPercent"u8);
                writer.WriteNumberValue(CompletionPercent.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(DataAccessAuthMode))
            {
                writer.WritePropertyName("dataAccessAuthMode"u8);
                writer.WriteStringValue(DataAccessAuthMode.Value.ToString());
            }
            if (Optional.IsDefined(IsOptimizedForFrequentAttach))
            {
                writer.WritePropertyName("optimizedForFrequentAttach"u8);
                writer.WriteBooleanValue(IsOptimizedForFrequentAttach.Value);
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ManagedDiskData DeserializeManagedDiskData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> managedBy = default;
            Optional<IReadOnlyList<ResourceIdentifier>> managedByExtended = default;
            Optional<DiskSku> sku = default;
            Optional<IList<string>> zones = default;
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> timeCreated = default;
            Optional<SupportedOperatingSystemType> osType = default;
            Optional<HyperVGeneration> hyperVGeneration = default;
            Optional<DiskPurchasePlan> purchasePlan = default;
            Optional<SupportedCapabilities> supportedCapabilities = default;
            Optional<DiskCreationData> creationData = default;
            Optional<int> diskSizeGB = default;
            Optional<long> diskSizeBytes = default;
            Optional<string> uniqueId = default;
            Optional<EncryptionSettingsGroup> encryptionSettingsGroup = default;
            Optional<string> provisioningState = default;
            Optional<long> diskIOPSReadWrite = default;
            Optional<long> diskMBpsReadWrite = default;
            Optional<long> diskIOPSReadOnly = default;
            Optional<long> diskMBpsReadOnly = default;
            Optional<DiskState> diskState = default;
            Optional<DiskEncryption> encryption = default;
            Optional<int> maxShares = default;
            Optional<IReadOnlyList<ShareInfoElement>> shareInfo = default;
            Optional<NetworkAccessPolicy> networkAccessPolicy = default;
            Optional<ResourceIdentifier> diskAccessId = default;
            Optional<DateTimeOffset> burstingEnabledTime = default;
            Optional<string> tier = default;
            Optional<bool> burstingEnabled = default;
            Optional<PropertyUpdatesInProgress> propertyUpdatesInProgress = default;
            Optional<bool> supportsHibernation = default;
            Optional<DiskSecurityProfile> securityProfile = default;
            Optional<float> completionPercent = default;
            Optional<DiskPublicNetworkAccess> publicNetworkAccess = default;
            Optional<DataAccessAuthMode> dataAccessAuthMode = default;
            Optional<bool> optimizedForFrequentAttach = default;
            Optional<DateTimeOffset> lastOwnershipUpdateTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedBy = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedByExtended"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    managedByExtended = array;
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = DiskSku.DeserializeDiskSku(property.Value);
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
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
                        if (property0.NameEquals("timeCreated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeCreated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osType = property0.Value.GetString().ToSupportedOperatingSystemType();
                            continue;
                        }
                        if (property0.NameEquals("hyperVGeneration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperVGeneration = new HyperVGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("purchasePlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchasePlan = DiskPurchasePlan.DeserializeDiskPurchasePlan(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportedCapabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportedCapabilities = SupportedCapabilities.DeserializeSupportedCapabilities(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creationData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationData = DiskCreationData.DeserializeDiskCreationData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("diskSizeGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskSizeGB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("diskSizeBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("uniqueId"u8))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionSettingsCollection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionSettingsGroup = EncryptionSettingsGroup.DeserializeEncryptionSettingsGroup(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("diskIOPSReadWrite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskIOPSReadWrite = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskMBpsReadWrite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskMBpsReadWrite = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskIOPSReadOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskIOPSReadOnly = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskMBpsReadOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskMBpsReadOnly = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskState = new DiskState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = DiskEncryption.DeserializeDiskEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maxShares"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxShares = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("shareInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ShareInfoElement> array = new List<ShareInfoElement>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ShareInfoElement.DeserializeShareInfoElement(item));
                            }
                            shareInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("networkAccessPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAccessPolicy = new NetworkAccessPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("diskAccessId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskAccessId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("burstingEnabledTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            burstingEnabledTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("tier"u8))
                        {
                            tier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("burstingEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            burstingEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("propertyUpdatesInProgress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            propertyUpdatesInProgress = PropertyUpdatesInProgress.DeserializePropertyUpdatesInProgress(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportsHibernation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportsHibernation = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("securityProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityProfile = DiskSecurityProfile.DeserializeDiskSecurityProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("completionPercent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            completionPercent = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new DiskPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataAccessAuthMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataAccessAuthMode = new DataAccessAuthMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("optimizedForFrequentAttach"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optimizedForFrequentAttach = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("LastOwnershipUpdateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastOwnershipUpdateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedDiskData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, managedBy.Value, Optional.ToList(managedByExtended), sku.Value, Optional.ToList(zones), extendedLocation, Optional.ToNullable(timeCreated), Optional.ToNullable(osType), Optional.ToNullable(hyperVGeneration), purchasePlan.Value, supportedCapabilities.Value, creationData.Value, Optional.ToNullable(diskSizeGB), Optional.ToNullable(diskSizeBytes), uniqueId.Value, encryptionSettingsGroup.Value, provisioningState.Value, Optional.ToNullable(diskIOPSReadWrite), Optional.ToNullable(diskMBpsReadWrite), Optional.ToNullable(diskIOPSReadOnly), Optional.ToNullable(diskMBpsReadOnly), Optional.ToNullable(diskState), encryption.Value, Optional.ToNullable(maxShares), Optional.ToList(shareInfo), Optional.ToNullable(networkAccessPolicy), diskAccessId.Value, Optional.ToNullable(burstingEnabledTime), tier.Value, Optional.ToNullable(burstingEnabled), propertyUpdatesInProgress.Value, Optional.ToNullable(supportsHibernation), securityProfile.Value, Optional.ToNullable(completionPercent), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(dataAccessAuthMode), Optional.ToNullable(optimizedForFrequentAttach), Optional.ToNullable(lastOwnershipUpdateTime), rawData);
        }

        ManagedDiskData IModelJsonSerializable<ManagedDiskData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedDiskData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedDiskData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedDiskData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedDiskData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedDiskData IModelSerializable<ManagedDiskData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedDiskData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedDiskData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedDiskData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedDiskData"/> to convert. </param>
        public static implicit operator RequestContent(ManagedDiskData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedDiskData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedDiskData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedDiskData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
