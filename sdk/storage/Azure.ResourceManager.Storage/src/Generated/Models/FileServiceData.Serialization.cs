// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class FileServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Cors))
            {
                writer.WritePropertyName("cors");
                writer.WriteObjectValue(Cors);
            }
            if (Optional.IsDefined(ShareDeleteRetentionPolicy))
            {
                writer.WritePropertyName("shareDeleteRetentionPolicy");
                writer.WriteObjectValue(ShareDeleteRetentionPolicy);
            }
            if (Optional.IsDefined(ProtocolSettings))
            {
                writer.WritePropertyName("protocolSettings");
                writer.WriteObjectValue(ProtocolSettings);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FileServiceData DeserializeFileServiceData(JsonElement element)
        {
            Optional<Sku> sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<CorsRules> cors = default;
            Optional<DeleteRetentionPolicy> shareDeleteRetentionPolicy = default;
            Optional<ProtocolSettings> protocolSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = Sku.DeserializeSku(property.Value);
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
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("cors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cors = CorsRules.DeserializeCorsRules(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("shareDeleteRetentionPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            shareDeleteRetentionPolicy = DeleteRetentionPolicy.DeserializeDeleteRetentionPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("protocolSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            protocolSettings = ProtocolSettings.DeserializeProtocolSettings(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FileServiceData(id, name, type, sku.Value, cors.Value, shareDeleteRetentionPolicy.Value, protocolSettings.Value);
        }
    }
}
