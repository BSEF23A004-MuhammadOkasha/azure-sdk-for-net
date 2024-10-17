// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class SwaggerCustomDynamicTree : IUtf8JsonSerializable, IJsonModel<SwaggerCustomDynamicTree>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SwaggerCustomDynamicTree>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SwaggerCustomDynamicTree>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTree>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwaggerCustomDynamicTree)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
                writer.WriteObjectValue(Settings, options);
            }
            if (Optional.IsDefined(Open))
            {
                writer.WritePropertyName("open"u8);
                writer.WriteObjectValue(Open, options);
            }
            if (Optional.IsDefined(Browse))
            {
                writer.WritePropertyName("browse"u8);
                writer.WriteObjectValue(Browse, options);
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
        }

        SwaggerCustomDynamicTree IJsonModel<SwaggerCustomDynamicTree>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTree>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwaggerCustomDynamicTree)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSwaggerCustomDynamicTree(document.RootElement, options);
        }

        internal static SwaggerCustomDynamicTree DeserializeSwaggerCustomDynamicTree(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SwaggerCustomDynamicTreeSettings settings = default;
            SwaggerCustomDynamicTreeCommand open = default;
            SwaggerCustomDynamicTreeCommand browse = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    settings = SwaggerCustomDynamicTreeSettings.DeserializeSwaggerCustomDynamicTreeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("open"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    open = SwaggerCustomDynamicTreeCommand.DeserializeSwaggerCustomDynamicTreeCommand(property.Value, options);
                    continue;
                }
                if (property.NameEquals("browse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    browse = SwaggerCustomDynamicTreeCommand.DeserializeSwaggerCustomDynamicTreeCommand(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SwaggerCustomDynamicTree(settings, open, browse, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SwaggerCustomDynamicTree>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTree>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SwaggerCustomDynamicTree)} does not support writing '{options.Format}' format.");
            }
        }

        SwaggerCustomDynamicTree IPersistableModel<SwaggerCustomDynamicTree>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicTree>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSwaggerCustomDynamicTree(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SwaggerCustomDynamicTree)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SwaggerCustomDynamicTree>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
