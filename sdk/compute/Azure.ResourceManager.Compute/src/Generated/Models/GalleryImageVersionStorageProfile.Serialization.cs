// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageVersionStorageProfile : IUtf8JsonSerializable, IJsonModel<GalleryImageVersionStorageProfile>, IPersistableModel<GalleryImageVersionStorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryImageVersionStorageProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GalleryImageVersionStorageProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionStorageProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(GallerySource))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(GallerySource);
            }
            if (Optional.IsDefined(OSDiskImage))
            {
                writer.WritePropertyName("osDiskImage"u8);
                writer.WriteObjectValue(OSDiskImage);
            }
            if (Optional.IsCollectionDefined(DataDiskImages))
            {
                writer.WritePropertyName("dataDiskImages"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskImages)
                {
                    writer.WriteObjectValue(item);
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

        GalleryImageVersionStorageProfile IJsonModel<GalleryImageVersionStorageProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionStorageProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryImageVersionStorageProfile(document.RootElement, options);
        }

        internal static GalleryImageVersionStorageProfile DeserializeGalleryImageVersionStorageProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GalleryArtifactVersionFullSource> source = default;
            Optional<GalleryOSDiskImage> osDiskImage = default;
            Optional<IList<GalleryDataDiskImage>> dataDiskImages = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = GalleryArtifactVersionFullSource.DeserializeGalleryArtifactVersionFullSource(property.Value);
                    continue;
                }
                if (property.NameEquals("osDiskImage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDiskImage = GalleryOSDiskImage.DeserializeGalleryOSDiskImage(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDiskImages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GalleryDataDiskImage> array = new List<GalleryDataDiskImage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryDataDiskImage.DeserializeGalleryDataDiskImage(item));
                    }
                    dataDiskImages = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GalleryImageVersionStorageProfile(source.Value, osDiskImage.Value, Optional.ToList(dataDiskImages), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(GallerySource))
            {
                builder.Append("  source:");
                AppendChildObject(builder, GallerySource, options, 2);
            }

            if (Optional.IsDefined(OSDiskImage))
            {
                builder.Append("  osDiskImage:");
                AppendChildObject(builder, OSDiskImage, options, 2);
            }

            if (Optional.IsCollectionDefined(DataDiskImages))
            {
                builder.Append("  dataDiskImages:");
                builder.AppendLine(" [");
                foreach (var item in DataDiskImages)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<GalleryImageVersionStorageProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        GalleryImageVersionStorageProfile IPersistableModel<GalleryImageVersionStorageProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryImageVersionStorageProfile(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryImageVersionStorageProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
