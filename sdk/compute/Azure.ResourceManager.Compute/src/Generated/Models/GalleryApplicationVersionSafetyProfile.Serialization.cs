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
    internal partial class GalleryApplicationVersionSafetyProfile : IUtf8JsonSerializable, IModelJsonSerializable<GalleryApplicationVersionSafetyProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GalleryApplicationVersionSafetyProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GalleryApplicationVersionSafetyProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryApplicationVersionSafetyProfile>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AllowDeletionOfReplicatedLocations))
            {
                writer.WritePropertyName("allowDeletionOfReplicatedLocations"u8);
                writer.WriteBooleanValue(AllowDeletionOfReplicatedLocations.Value);
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

        internal static GalleryApplicationVersionSafetyProfile DeserializeGalleryApplicationVersionSafetyProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> allowDeletionOfReplicatedLocations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowDeletionOfReplicatedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowDeletionOfReplicatedLocations = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GalleryApplicationVersionSafetyProfile(Optional.ToNullable(allowDeletionOfReplicatedLocations), rawData);
        }

        GalleryApplicationVersionSafetyProfile IModelJsonSerializable<GalleryApplicationVersionSafetyProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryApplicationVersionSafetyProfile>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryApplicationVersionSafetyProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GalleryApplicationVersionSafetyProfile>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryApplicationVersionSafetyProfile>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GalleryApplicationVersionSafetyProfile IModelSerializable<GalleryApplicationVersionSafetyProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryApplicationVersionSafetyProfile>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGalleryApplicationVersionSafetyProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GalleryApplicationVersionSafetyProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GalleryApplicationVersionSafetyProfile"/> to convert. </param>
        public static implicit operator RequestContent(GalleryApplicationVersionSafetyProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GalleryApplicationVersionSafetyProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GalleryApplicationVersionSafetyProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGalleryApplicationVersionSafetyProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
