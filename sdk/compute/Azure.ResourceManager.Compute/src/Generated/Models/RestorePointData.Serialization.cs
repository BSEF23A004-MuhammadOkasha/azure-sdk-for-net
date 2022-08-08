// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class RestorePointData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ExcludeDisks))
            {
                writer.WritePropertyName("excludeDisks");
                writer.WriteStartArray();
                foreach (var item in ExcludeDisks)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ConsistencyMode))
            {
                writer.WritePropertyName("consistencyMode");
                writer.WriteStringValue(ConsistencyMode.Value.ToString());
            }
            if (Optional.IsDefined(TimeCreated))
            {
                writer.WritePropertyName("timeCreated");
                writer.WriteStringValue(TimeCreated.Value, "O");
            }
            if (Optional.IsDefined(SourceRestorePoint))
            {
                writer.WritePropertyName("sourceRestorePoint");
                JsonSerializer.Serialize(writer, SourceRestorePoint);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RestorePointData DeserializeRestorePointData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<WritableSubResource>> excludeDisks = default;
            Optional<RestorePointSourceMetadata> sourceMetadata = default;
            Optional<string> provisioningState = default;
            Optional<ConsistencyModeType> consistencyMode = default;
            Optional<DateTimeOffset> timeCreated = default;
            Optional<WritableSubResource> sourceRestorePoint = default;
            Optional<RestorePointInstanceView> instanceView = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("excludeDisks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            excludeDisks = array;
                            continue;
                        }
                        if (property0.NameEquals("sourceMetadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceMetadata = RestorePointSourceMetadata.DeserializeRestorePointSourceMetadata(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consistencyMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            consistencyMode = new ConsistencyModeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timeCreated"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            timeCreated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceRestorePoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceRestorePoint = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("instanceView"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            instanceView = RestorePointInstanceView.DeserializeRestorePointInstanceView(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RestorePointData(id, name, type, systemData.Value, Optional.ToList(excludeDisks), sourceMetadata.Value, provisioningState.Value, Optional.ToNullable(consistencyMode), Optional.ToNullable(timeCreated), sourceRestorePoint, instanceView.Value);
        }
    }
}
