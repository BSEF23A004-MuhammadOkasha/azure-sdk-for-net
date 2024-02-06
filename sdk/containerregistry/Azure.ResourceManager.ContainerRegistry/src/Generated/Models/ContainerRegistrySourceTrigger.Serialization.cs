// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistrySourceTrigger : IUtf8JsonSerializable, IJsonModel<ContainerRegistrySourceTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistrySourceTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistrySourceTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistrySourceTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourceRepository"u8);
            BinaryData data = ModelReaderWriter.Write(SourceRepository, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
            using (JsonDocument document = JsonDocument.Parse(data))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("sourceTriggerEvents"u8);
            writer.WriteStartArray();
            foreach (var item in SourceTriggerEvents)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        ContainerRegistrySourceTrigger IJsonModel<ContainerRegistrySourceTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistrySourceTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistrySourceTrigger(document.RootElement, options);
        }

        internal static ContainerRegistrySourceTrigger DeserializeContainerRegistrySourceTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceCodeRepoProperties sourceRepository = default;
            IList<ContainerRegistrySourceTriggerEvent> sourceTriggerEvents = default;
            Optional<ContainerRegistryTriggerStatus> status = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceRepository"u8))
                {
                    sourceRepository = SourceCodeRepoProperties.DeserializeSourceCodeRepoProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceTriggerEvents"u8))
                {
                    List<ContainerRegistrySourceTriggerEvent> array = new List<ContainerRegistrySourceTriggerEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ContainerRegistrySourceTriggerEvent(item.GetString()));
                    }
                    sourceTriggerEvents = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ContainerRegistryTriggerStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistrySourceTrigger(sourceRepository, sourceTriggerEvents, Optional.ToNullable(status), name, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistrySourceTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistrySourceTrigger)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistrySourceTrigger IPersistableModel<ContainerRegistrySourceTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistrySourceTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistrySourceTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistrySourceTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
