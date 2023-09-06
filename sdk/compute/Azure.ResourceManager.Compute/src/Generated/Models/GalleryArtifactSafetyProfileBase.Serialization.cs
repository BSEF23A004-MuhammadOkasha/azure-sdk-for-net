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
    public partial class GalleryArtifactSafetyProfileBase : IUtf8JsonSerializable, IModelJsonSerializable<GalleryArtifactSafetyProfileBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GalleryArtifactSafetyProfileBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GalleryArtifactSafetyProfileBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryArtifactSafetyProfileBase>(this, options.Format);

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

        internal static GalleryArtifactSafetyProfileBase DeserializeGalleryArtifactSafetyProfileBase(JsonElement element, ModelSerializerOptions options = default)
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
            return new GalleryArtifactSafetyProfileBase(Optional.ToNullable(allowDeletionOfReplicatedLocations), rawData);
        }

        GalleryArtifactSafetyProfileBase IModelJsonSerializable<GalleryArtifactSafetyProfileBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryArtifactSafetyProfileBase>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryArtifactSafetyProfileBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GalleryArtifactSafetyProfileBase>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryArtifactSafetyProfileBase>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GalleryArtifactSafetyProfileBase IModelSerializable<GalleryArtifactSafetyProfileBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GalleryArtifactSafetyProfileBase>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGalleryArtifactSafetyProfileBase(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GalleryArtifactSafetyProfileBase"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GalleryArtifactSafetyProfileBase"/> to convert. </param>
        public static implicit operator RequestContent(GalleryArtifactSafetyProfileBase model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GalleryArtifactSafetyProfileBase"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GalleryArtifactSafetyProfileBase(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGalleryArtifactSafetyProfileBase(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
