// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    public partial class ManagedClusterUpgradeProfileData : IUtf8JsonSerializable, IJsonModel<ManagedClusterUpgradeProfileData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterUpgradeProfileData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterUpgradeProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterUpgradeProfileData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("controlPlaneProfile"u8);
            BinaryData data = ModelReaderWriter.Write(ControlPlaneProfile, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
            using (JsonDocument document = JsonDocument.Parse(data))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("agentPoolProfiles"u8);
            writer.WriteStartArray();
            foreach (var item in AgentPoolProfiles)
            {
                BinaryData data0 = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data0);
#else
                using (JsonDocument document = JsonDocument.Parse(data0))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndArray();
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

        ManagedClusterUpgradeProfileData IJsonModel<ManagedClusterUpgradeProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterUpgradeProfileData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterUpgradeProfileData(document.RootElement, options);
        }

        internal static ManagedClusterUpgradeProfileData DeserializeManagedClusterUpgradeProfileData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            ManagedClusterPoolUpgradeProfile controlPlaneProfile = default;
            IReadOnlyList<ManagedClusterPoolUpgradeProfile> agentPoolProfiles = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("controlPlaneProfile"u8))
                        {
                            controlPlaneProfile = ManagedClusterPoolUpgradeProfile.DeserializeManagedClusterPoolUpgradeProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("agentPoolProfiles"u8))
                        {
                            List<ManagedClusterPoolUpgradeProfile> array = new List<ManagedClusterPoolUpgradeProfile>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedClusterPoolUpgradeProfile.DeserializeManagedClusterPoolUpgradeProfile(item));
                            }
                            agentPoolProfiles = array;
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
            return new ManagedClusterUpgradeProfileData(id, name, type, systemData.Value, controlPlaneProfile, agentPoolProfiles, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterUpgradeProfileData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterUpgradeProfileData)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterUpgradeProfileData IPersistableModel<ManagedClusterUpgradeProfileData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterUpgradeProfileData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterUpgradeProfileData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterUpgradeProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
