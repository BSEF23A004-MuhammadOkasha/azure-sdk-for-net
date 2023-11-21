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
    public partial class ImageDiskReference : IUtf8JsonSerializable, IJsonModel<ImageDiskReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageDiskReference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageDiskReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageDiskReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ImageDiskReference)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(SharedGalleryImageId))
            {
                writer.WritePropertyName("sharedGalleryImageId"u8);
                writer.WriteStringValue(SharedGalleryImageId);
            }
            if (Optional.IsDefined(CommunityGalleryImageId))
            {
                writer.WritePropertyName("communityGalleryImageId"u8);
                writer.WriteStringValue(CommunityGalleryImageId);
            }
            if (Optional.IsDefined(Lun))
            {
                writer.WritePropertyName("lun"u8);
                writer.WriteNumberValue(Lun.Value);
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

        ImageDiskReference IJsonModel<ImageDiskReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageDiskReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ImageDiskReference)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageDiskReference(document.RootElement, options);
        }

        internal static ImageDiskReference DeserializeImageDiskReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> sharedGalleryImageId = default;
            Optional<string> communityGalleryImageId = default;
            Optional<int> lun = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sharedGalleryImageId"u8))
                {
                    sharedGalleryImageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityGalleryImageId"u8))
                {
                    communityGalleryImageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lun"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageDiskReference(id.Value, sharedGalleryImageId.Value, communityGalleryImageId.Value, Optional.ToNullable(lun), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageDiskReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageDiskReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ImageDiskReference)} does not support '{options.Format}' format.");
            }
        }

        ImageDiskReference IPersistableModel<ImageDiskReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageDiskReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageDiskReference(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ImageDiskReference)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageDiskReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
