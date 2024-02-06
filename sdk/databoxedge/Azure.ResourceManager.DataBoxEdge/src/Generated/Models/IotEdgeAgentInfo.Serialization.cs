// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class IotEdgeAgentInfo : IUtf8JsonSerializable, IJsonModel<IotEdgeAgentInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotEdgeAgentInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotEdgeAgentInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotEdgeAgentInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotEdgeAgentInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("imageName"u8);
            writer.WriteStringValue(ImageName);
            writer.WritePropertyName("tag"u8);
            writer.WriteStringValue(Tag);
            if (Optional.IsDefined(ImageRepository))
            {
                writer.WritePropertyName("imageRepository"u8);
                BinaryData data = ModelReaderWriter.Write(ImageRepository, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        IotEdgeAgentInfo IJsonModel<IotEdgeAgentInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotEdgeAgentInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotEdgeAgentInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotEdgeAgentInfo(document.RootElement, options);
        }

        internal static IotEdgeAgentInfo DeserializeIotEdgeAgentInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string imageName = default;
            string tag = default;
            Optional<ImageRepositoryCredential> imageRepository = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageName"u8))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageRepository"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageRepository = ImageRepositoryCredential.DeserializeImageRepositoryCredential(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotEdgeAgentInfo(imageName, tag, imageRepository.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotEdgeAgentInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotEdgeAgentInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotEdgeAgentInfo)} does not support '{options.Format}' format.");
            }
        }

        IotEdgeAgentInfo IPersistableModel<IotEdgeAgentInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotEdgeAgentInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotEdgeAgentInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotEdgeAgentInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotEdgeAgentInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
