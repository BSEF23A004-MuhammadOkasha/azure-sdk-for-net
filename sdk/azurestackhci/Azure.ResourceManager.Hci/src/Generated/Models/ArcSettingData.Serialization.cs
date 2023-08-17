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
    public partial class ArcSettingData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ArcInstanceResourceGroup))
            {
                writer.WritePropertyName("arcInstanceResourceGroup"u8);
                writer.WriteStringValue(ArcInstanceResourceGroup);
            }
            if (Optional.IsDefined(ArcApplicationClientId))
            {
                writer.WritePropertyName("arcApplicationClientId"u8);
                writer.WriteStringValue(ArcApplicationClientId.Value);
            }
            if (Optional.IsDefined(ArcApplicationTenantId))
            {
                writer.WritePropertyName("arcApplicationTenantId"u8);
                writer.WriteStringValue(ArcApplicationTenantId.Value);
            }
            if (Optional.IsDefined(ArcServicePrincipalObjectId))
            {
                writer.WritePropertyName("arcServicePrincipalObjectId"u8);
                writer.WriteStringValue(ArcServicePrincipalObjectId.Value);
            }
            if (Optional.IsDefined(ArcApplicationObjectId))
            {
                writer.WritePropertyName("arcApplicationObjectId"u8);
                writer.WriteStringValue(ArcApplicationObjectId.Value);
            }
            if (Optional.IsDefined(ConnectivityProperties))
            {
                writer.WritePropertyName("connectivityProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ConnectivityProperties);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ConnectivityProperties.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ArcSettingData DeserializeArcSettingData(JsonElement element)
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
            Optional<string> arcInstanceResourceGroup = default;
            Optional<Guid> arcApplicationClientId = default;
            Optional<Guid> arcApplicationTenantId = default;
            Optional<Guid> arcServicePrincipalObjectId = default;
            Optional<Guid> arcApplicationObjectId = default;
            Optional<ArcSettingAggregateState> aggregateState = default;
            Optional<IReadOnlyList<PerNodeArcState>> perNodeDetails = default;
            Optional<BinaryData> connectivityProperties = default;
            Optional<IReadOnlyList<DefaultExtensionDetails>> defaultExtensions = default;
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
                        if (property0.NameEquals("arcInstanceResourceGroup"u8))
                        {
                            arcInstanceResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("arcApplicationClientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            arcApplicationClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("arcApplicationTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            arcApplicationTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("arcServicePrincipalObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            arcServicePrincipalObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("arcApplicationObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            arcApplicationObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aggregateState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aggregateState = new ArcSettingAggregateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("perNodeDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PerNodeArcState> array = new List<PerNodeArcState>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PerNodeArcState.DeserializePerNodeArcState(item));
                            }
                            perNodeDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("connectivityProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectivityProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("defaultExtensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DefaultExtensionDetails> array = new List<DefaultExtensionDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DefaultExtensionDetails.DeserializeDefaultExtensionDetails(item));
                            }
                            defaultExtensions = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ArcSettingData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), arcInstanceResourceGroup.Value, Optional.ToNullable(arcApplicationClientId), Optional.ToNullable(arcApplicationTenantId), Optional.ToNullable(arcServicePrincipalObjectId), Optional.ToNullable(arcApplicationObjectId), Optional.ToNullable(aggregateState), Optional.ToList(perNodeDetails), connectivityProperties.Value, Optional.ToList(defaultExtensions));
        }
    }
}
