// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    public partial class SpringBootAppApplicationConfigurationsItem : IUtf8JsonSerializable, IJsonModel<SpringBootAppApplicationConfigurationsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpringBootAppApplicationConfigurationsItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SpringBootAppApplicationConfigurationsItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootAppApplicationConfigurationsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootAppApplicationConfigurationsItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            writer.WriteStringValue(Key);
            if (Value != null)
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
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

        SpringBootAppApplicationConfigurationsItem IJsonModel<SpringBootAppApplicationConfigurationsItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootAppApplicationConfigurationsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootAppApplicationConfigurationsItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpringBootAppApplicationConfigurationsItem(document.RootElement, options);
        }

        internal static SpringBootAppApplicationConfigurationsItem DeserializeSpringBootAppApplicationConfigurationsItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            string value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SpringBootAppApplicationConfigurationsItem(key, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SpringBootAppApplicationConfigurationsItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootAppApplicationConfigurationsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SpringBootAppApplicationConfigurationsItem)} does not support '{options.Format}' format.");
            }
        }

        SpringBootAppApplicationConfigurationsItem IPersistableModel<SpringBootAppApplicationConfigurationsItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootAppApplicationConfigurationsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSpringBootAppApplicationConfigurationsItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SpringBootAppApplicationConfigurationsItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpringBootAppApplicationConfigurationsItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
