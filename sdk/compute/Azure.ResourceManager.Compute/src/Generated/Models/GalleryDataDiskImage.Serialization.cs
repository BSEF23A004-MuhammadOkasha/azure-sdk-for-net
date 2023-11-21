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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryDataDiskImage : IUtf8JsonSerializable, IJsonModel<GalleryDataDiskImage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryDataDiskImage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GalleryDataDiskImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryDataDiskImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(GalleryDataDiskImage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("lun"u8);
            writer.WriteNumberValue(Lun);
            if (options.Format != "W" && Optional.IsDefined(SizeInGB))
            {
                writer.WritePropertyName("sizeInGB"u8);
                writer.WriteNumberValue(SizeInGB.Value);
            }
            if (Optional.IsDefined(HostCaching))
            {
                writer.WritePropertyName("hostCaching"u8);
                writer.WriteStringValue(HostCaching.Value.ToSerialString());
            }
            if (Optional.IsDefined(GallerySource))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(GallerySource);
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

        GalleryDataDiskImage IJsonModel<GalleryDataDiskImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryDataDiskImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(GalleryDataDiskImage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryDataDiskImage(document.RootElement, options);
        }

        internal static GalleryDataDiskImage DeserializeGalleryDataDiskImage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int lun = default;
            Optional<int> sizeInGB = default;
            Optional<HostCaching> hostCaching = default;
            Optional<GalleryDiskImageSource> source = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"u8))
                {
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sizeInGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeInGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostCaching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostCaching = property.Value.GetString().ToHostCaching();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = GalleryDiskImageSource.DeserializeGalleryDiskImageSource(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GalleryDataDiskImage(Optional.ToNullable(sizeInGB), Optional.ToNullable(hostCaching), source.Value, serializedAdditionalRawData, lun);
        }

        BinaryData IPersistableModel<GalleryDataDiskImage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryDataDiskImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(GalleryDataDiskImage)} does not support '{options.Format}' format.");
            }
        }

        GalleryDataDiskImage IPersistableModel<GalleryDataDiskImage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryDataDiskImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryDataDiskImage(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(GalleryDataDiskImage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryDataDiskImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
