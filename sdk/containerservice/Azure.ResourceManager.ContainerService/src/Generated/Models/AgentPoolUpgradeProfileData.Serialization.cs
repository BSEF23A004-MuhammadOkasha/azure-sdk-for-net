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
    public partial class AgentPoolUpgradeProfileData : IUtf8JsonSerializable, IJsonModel<AgentPoolUpgradeProfileData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentPoolUpgradeProfileData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AgentPoolUpgradeProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentPoolUpgradeProfileData)} does not support '{format}' format.");
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
            writer.WritePropertyName("kubernetesVersion"u8);
            writer.WriteStringValue(KubernetesVersion);
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToString());
            if (Optional.IsCollectionDefined(Upgrades))
            {
                writer.WritePropertyName("upgrades"u8);
                writer.WriteStartArray();
                foreach (var item in Upgrades)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LatestNodeImageVersion))
            {
                writer.WritePropertyName("latestNodeImageVersion"u8);
                writer.WriteStringValue(LatestNodeImageVersion);
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

        AgentPoolUpgradeProfileData IJsonModel<AgentPoolUpgradeProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentPoolUpgradeProfileData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentPoolUpgradeProfileData(document.RootElement, options);
        }

        internal static AgentPoolUpgradeProfileData DeserializeAgentPoolUpgradeProfileData(JsonElement element, ModelReaderWriterOptions options = null)
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
            string kubernetesVersion = default;
            ContainerServiceOSType osType = default;
            Optional<IReadOnlyList<AgentPoolUpgradeProfilePropertiesUpgradesItem>> upgrades = default;
            Optional<string> latestNodeImageVersion = default;
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
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            osType = new ContainerServiceOSType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("upgrades"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AgentPoolUpgradeProfilePropertiesUpgradesItem> array = new List<AgentPoolUpgradeProfilePropertiesUpgradesItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AgentPoolUpgradeProfilePropertiesUpgradesItem.DeserializeAgentPoolUpgradeProfilePropertiesUpgradesItem(item));
                            }
                            upgrades = array;
                            continue;
                        }
                        if (property0.NameEquals("latestNodeImageVersion"u8))
                        {
                            latestNodeImageVersion = property0.Value.GetString();
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
            return new AgentPoolUpgradeProfileData(id, name, type, systemData.Value, kubernetesVersion, osType, Optional.ToList(upgrades), latestNodeImageVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AgentPoolUpgradeProfileData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AgentPoolUpgradeProfileData)} does not support '{options.Format}' format.");
            }
        }

        AgentPoolUpgradeProfileData IPersistableModel<AgentPoolUpgradeProfileData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgentPoolUpgradeProfileData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentPoolUpgradeProfileData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentPoolUpgradeProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
