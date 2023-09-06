// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryDataDiskImage : IUtf8JsonSerializable, IModelJsonSerializable<GalleryDataDiskImage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GalleryDataDiskImage>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GalleryDataDiskImage>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryDataDiskImage>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("lun"u8);
            writer.WriteNumberValue(Lun);
            if (Optional.IsDefined(HostCaching))
            {
                writer.WritePropertyName("hostCaching"u8);
                writer.WriteStringValue(HostCaching.Value.ToSerialString());
            }
            if (Optional.IsDefined(GallerySource))
            {
                writer.WritePropertyName("source"u8);
                if (GallerySource is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GalleryDiskImageSource>)GallerySource).Serialize(writer, options);
                }
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static GalleryDataDiskImage DeserializeGalleryDataDiskImage(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int lun = default;
            Optional<int> sizeInGB = default;
            Optional<HostCaching> hostCaching = default;
            Optional<GalleryDiskImageSource> source = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GalleryDataDiskImage(Optional.ToNullable(sizeInGB), Optional.ToNullable(hostCaching), source.Value, lun, rawData);
        }

        GalleryDataDiskImage IModelJsonSerializable<GalleryDataDiskImage>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryDataDiskImage>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryDataDiskImage(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GalleryDataDiskImage>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryDataDiskImage>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GalleryDataDiskImage IModelSerializable<GalleryDataDiskImage>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryDataDiskImage>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGalleryDataDiskImage(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GalleryDataDiskImage"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GalleryDataDiskImage"/> to convert. </param>
        public static implicit operator RequestContent(GalleryDataDiskImage model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GalleryDataDiskImage"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GalleryDataDiskImage(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGalleryDataDiskImage(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
