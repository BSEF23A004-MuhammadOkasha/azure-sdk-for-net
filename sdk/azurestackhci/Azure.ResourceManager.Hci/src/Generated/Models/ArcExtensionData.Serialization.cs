// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class ArcExtensionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("extensionParameters"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ForceUpdateTag))
            {
                writer.WritePropertyName("forceUpdateTag"u8);
                writer.WriteStringValue(ForceUpdateTag);
            }
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(ArcExtensionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ArcExtensionType);
            }
            if (Optional.IsDefined(TypeHandlerVersion))
            {
                writer.WritePropertyName("typeHandlerVersion"u8);
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (Optional.IsDefined(ShouldAutoUpgradeMinorVersion))
            {
                writer.WritePropertyName("autoUpgradeMinorVersion"u8);
                writer.WriteBooleanValue(ShouldAutoUpgradeMinorVersion.Value);
            }
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Settings);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Settings.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ProtectedSettings))
            {
                writer.WritePropertyName("protectedSettings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ProtectedSettings);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ProtectedSettings.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EnableAutomaticUpgrade))
            {
                writer.WritePropertyName("enableAutomaticUpgrade"u8);
                writer.WriteBooleanValue(EnableAutomaticUpgrade.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ArcExtensionData DeserializeArcExtensionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<HciProvisioningState> provisioningState = default;
            Optional<ArcExtensionAggregateState> aggregateState = default;
            Optional<IReadOnlyList<PerNodeExtensionState>> perNodeExtensionDetails = default;
            Optional<ExtensionManagedBy> managedBy = default;
            Optional<string> forceUpdateTag = default;
            Optional<string> publisher = default;
            Optional<string> type0 = default;
            Optional<string> typeHandlerVersion = default;
            Optional<bool> autoUpgradeMinorVersion = default;
            Optional<BinaryData> settings = default;
            Optional<BinaryData> protectedSettings = default;
            Optional<bool> enableAutomaticUpgrade = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HciProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("aggregateState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aggregateState = new ArcExtensionAggregateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("perNodeExtensionDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PerNodeExtensionState> array = new List<PerNodeExtensionState>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PerNodeExtensionState.DeserializePerNodeExtensionState(item));
                            }
                            perNodeExtensionDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("managedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedBy = new ExtensionManagedBy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("extensionParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("forceUpdateTag"u8))
                                {
                                    forceUpdateTag = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("publisher"u8))
                                {
                                    publisher = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("type"u8))
                                {
                                    type0 = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("typeHandlerVersion"u8))
                                {
                                    typeHandlerVersion = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("autoUpgradeMinorVersion"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    autoUpgradeMinorVersion = property1.Value.GetBoolean();
                                    continue;
                                }
                                if (property1.NameEquals("settings"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    settings = BinaryData.FromString(property1.Value.GetRawText());
                                    continue;
                                }
                                if (property1.NameEquals("protectedSettings"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    protectedSettings = BinaryData.FromString(property1.Value.GetRawText());
                                    continue;
                                }
                                if (property1.NameEquals("enableAutomaticUpgrade"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    enableAutomaticUpgrade = property1.Value.GetBoolean();
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ArcExtensionData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(aggregateState), Optional.ToList(perNodeExtensionDetails), Optional.ToNullable(managedBy), forceUpdateTag.Value, publisher.Value, type0.Value, typeHandlerVersion.Value, Optional.ToNullable(autoUpgradeMinorVersion), settings.Value, protectedSettings.Value, Optional.ToNullable(enableAutomaticUpgrade));
        }
    }
}
