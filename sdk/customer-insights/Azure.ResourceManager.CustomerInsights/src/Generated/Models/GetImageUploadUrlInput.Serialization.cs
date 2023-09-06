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

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class GetImageUploadUrlInput : IUtf8JsonSerializable, IModelJsonSerializable<GetImageUploadUrlInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GetImageUploadUrlInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GetImageUploadUrlInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetImageUploadUrlInput>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EntityType))
            {
                writer.WritePropertyName("entityType"u8);
                writer.WriteStringValue(EntityType);
            }
            if (Optional.IsDefined(EntityTypeName))
            {
                writer.WritePropertyName("entityTypeName"u8);
                writer.WriteStringValue(EntityTypeName);
            }
            if (Optional.IsDefined(RelativePath))
            {
                writer.WritePropertyName("relativePath"u8);
                writer.WriteStringValue(RelativePath);
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

        internal static GetImageUploadUrlInput DeserializeGetImageUploadUrlInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> entityType = default;
            Optional<string> entityTypeName = default;
            Optional<string> relativePath = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entityType"u8))
                {
                    entityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityTypeName"u8))
                {
                    entityTypeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GetImageUploadUrlInput(entityType.Value, entityTypeName.Value, relativePath.Value, rawData);
        }

        GetImageUploadUrlInput IModelJsonSerializable<GetImageUploadUrlInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetImageUploadUrlInput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGetImageUploadUrlInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GetImageUploadUrlInput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetImageUploadUrlInput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GetImageUploadUrlInput IModelSerializable<GetImageUploadUrlInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetImageUploadUrlInput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGetImageUploadUrlInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GetImageUploadUrlInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GetImageUploadUrlInput"/> to convert. </param>
        public static implicit operator RequestContent(GetImageUploadUrlInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GetImageUploadUrlInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GetImageUploadUrlInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGetImageUploadUrlInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
