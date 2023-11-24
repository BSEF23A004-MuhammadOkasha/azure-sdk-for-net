// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    internal partial class AgentPoolUpgradeSettings : IUtf8JsonSerializable, IJsonModel<AgentPoolUpgradeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentPoolUpgradeSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AgentPoolUpgradeSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AgentPoolUpgradeSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxSurge))
            {
                writer.WritePropertyName("maxSurge"u8);
                writer.WriteStringValue(MaxSurge);
            }
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

        AgentPoolUpgradeSettings IJsonModel<AgentPoolUpgradeSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AgentPoolUpgradeSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentPoolUpgradeSettings(document.RootElement, options);
        }

        internal static AgentPoolUpgradeSettings DeserializeAgentPoolUpgradeSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> maxSurge = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxSurge"u8))
                {
                    maxSurge = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AgentPoolUpgradeSettings(maxSurge.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AgentPoolUpgradeSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AgentPoolUpgradeSettings)} does not support '{options.Format}' format.");
            }
        }

        AgentPoolUpgradeSettings IPersistableModel<AgentPoolUpgradeSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgentPoolUpgradeSettings(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AgentPoolUpgradeSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentPoolUpgradeSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
