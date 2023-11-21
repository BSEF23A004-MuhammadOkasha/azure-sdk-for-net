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
    internal partial class Platform : IUtf8JsonSerializable, IJsonModel<Platform>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Platform>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Platform>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Platform>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(Platform)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Architecture))
            {
                writer.WritePropertyName("architecture"u8);
                writer.WriteStringValue(Architecture);
            }
            if (Optional.IsDefined(Os))
            {
                writer.WritePropertyName("os"u8);
                writer.WriteStringValue(Os);
            }
            if (Optional.IsDefined(OsVersion))
            {
                writer.WritePropertyName("os.version"u8);
                writer.WriteStringValue(OsVersion);
            }
            if (Optional.IsCollectionDefined(OsFeatures))
            {
                writer.WritePropertyName("os.features"u8);
                writer.WriteStartArray();
                foreach (var item in OsFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Variant))
            {
                writer.WritePropertyName("variant"u8);
                writer.WriteStringValue(Variant);
            }
            if (Optional.IsCollectionDefined(Features))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteStartArray();
                foreach (var item in Features)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        Platform IJsonModel<Platform>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Platform>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(Platform)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlatform(document.RootElement, options);
        }

        internal static Platform DeserializePlatform(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> architecture = default;
            Optional<string> os = default;
            Optional<string> osVersion = default;
            Optional<IReadOnlyList<string>> osFeatures = default;
            Optional<string> variant = default;
            Optional<IReadOnlyList<string>> features = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("architecture"u8))
                {
                    architecture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("os"u8))
                {
                    os = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("os.version"u8))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("os.features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    osFeatures = array;
                    continue;
                }
                if (property.NameEquals("variant"u8))
                {
                    variant = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    features = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Platform(architecture.Value, os.Value, osVersion.Value, Optional.ToList(osFeatures), variant.Value, Optional.ToList(features), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Platform>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Platform>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(Platform)} does not support '{options.Format}' format.");
            }
        }

        Platform IPersistableModel<Platform>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Platform>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePlatform(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(Platform)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Platform>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
