// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class SbomComponent : IUtf8JsonSerializable, IJsonModel<SbomComponent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SbomComponent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SbomComponent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SbomComponent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SbomComponent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ComponentId != null)
            {
                if (ComponentId != null)
                {
                    writer.WritePropertyName("componentId"u8);
                    writer.WriteStringValue(ComponentId);
                }
                else
                {
                    writer.WriteNull("componentId");
                }
            }
            if (ComponentName != null)
            {
                if (ComponentName != null)
                {
                    writer.WritePropertyName("componentName"u8);
                    writer.WriteStringValue(ComponentName);
                }
                else
                {
                    writer.WriteNull("componentName");
                }
            }
            if (Version != null)
            {
                if (Version != null)
                {
                    writer.WritePropertyName("version"u8);
                    writer.WriteStringValue(Version);
                }
                else
                {
                    writer.WriteNull("version");
                }
            }
            if (License != null)
            {
                if (License != null)
                {
                    writer.WritePropertyName("license"u8);
                    writer.WriteStringValue(License);
                }
                else
                {
                    writer.WriteNull("license");
                }
            }
            if (ReleaseOn.HasValue)
            {
                writer.WritePropertyName("releaseDate"u8);
                writer.WriteStringValue(ReleaseOn.Value, "O");
            }
            if (!(Paths is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("paths"u8);
                writer.WriteStartArray();
                foreach (var item in Paths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsUpdateAvailable.HasValue)
            {
                writer.WritePropertyName("isUpdateAvailable"u8);
                writer.WriteStringValue(IsUpdateAvailable.Value.ToString());
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

        SbomComponent IJsonModel<SbomComponent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SbomComponent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SbomComponent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSbomComponent(document.RootElement, options);
        }

        internal static SbomComponent DeserializeSbomComponent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string componentId = default;
            string componentName = default;
            string version = default;
            string license = default;
            DateTimeOffset? releaseDate = default;
            IReadOnlyList<string> paths = default;
            IsUpdateAvailable? isUpdateAvailable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("componentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        componentId = null;
                        continue;
                    }
                    componentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        componentName = null;
                        continue;
                    }
                    componentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        version = null;
                        continue;
                    }
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("license"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        license = null;
                        continue;
                    }
                    license = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("releaseDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    releaseDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("paths"u8))
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
                    paths = array;
                    continue;
                }
                if (property.NameEquals("isUpdateAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isUpdateAvailable = new IsUpdateAvailable(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SbomComponent(
                componentId,
                componentName,
                version,
                license,
                releaseDate,
                paths ?? new ChangeTrackingList<string>(),
                isUpdateAvailable,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SbomComponent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SbomComponent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SbomComponent)} does not support '{options.Format}' format.");
            }
        }

        SbomComponent IPersistableModel<SbomComponent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SbomComponent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSbomComponent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SbomComponent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SbomComponent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
