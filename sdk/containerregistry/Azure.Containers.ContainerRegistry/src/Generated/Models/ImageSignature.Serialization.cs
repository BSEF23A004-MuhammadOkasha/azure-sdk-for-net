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

namespace Azure.Containers.ContainerRegistry
{
    internal partial class ImageSignature : IUtf8JsonSerializable, IJsonModel<ImageSignature>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageSignature>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageSignature>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSignature>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ImageSignature)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Header))
            {
                writer.WritePropertyName("header"u8);
                writer.WriteObjectValue(Header);
            }
            if (Optional.IsDefined(Signature))
            {
                writer.WritePropertyName("signature"u8);
                writer.WriteStringValue(Signature);
            }
            if (Optional.IsDefined(Protected))
            {
                writer.WritePropertyName("protected"u8);
                writer.WriteStringValue(Protected);
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

        ImageSignature IJsonModel<ImageSignature>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSignature>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ImageSignature)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageSignature(document.RootElement, options);
        }

        internal static ImageSignature DeserializeImageSignature(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<JWK> header = default;
            Optional<string> signature = default;
            Optional<string> @protected = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("header"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    header = JWK.DeserializeJWK(property.Value);
                    continue;
                }
                if (property.NameEquals("signature"u8))
                {
                    signature = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protected"u8))
                {
                    @protected = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageSignature(header.Value, signature.Value, @protected.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageSignature>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSignature>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ImageSignature)} does not support '{options.Format}' format.");
            }
        }

        ImageSignature IPersistableModel<ImageSignature>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSignature>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageSignature(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ImageSignature)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageSignature>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
