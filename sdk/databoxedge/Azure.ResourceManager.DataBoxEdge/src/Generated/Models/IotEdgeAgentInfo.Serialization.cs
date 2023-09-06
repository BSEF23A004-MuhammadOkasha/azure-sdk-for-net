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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class IotEdgeAgentInfo : IUtf8JsonSerializable, IModelJsonSerializable<IotEdgeAgentInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotEdgeAgentInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotEdgeAgentInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotEdgeAgentInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("imageName"u8);
            writer.WriteStringValue(ImageName);
            writer.WritePropertyName("tag"u8);
            writer.WriteStringValue(Tag);
            if (Optional.IsDefined(ImageRepository))
            {
                writer.WritePropertyName("imageRepository"u8);
                if (ImageRepository is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ImageRepositoryCredential>)ImageRepository).Serialize(writer, options);
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

        internal static IotEdgeAgentInfo DeserializeIotEdgeAgentInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string imageName = default;
            string tag = default;
            Optional<ImageRepositoryCredential> imageRepository = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageName"u8))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageRepository"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageRepository = ImageRepositoryCredential.DeserializeImageRepositoryCredential(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotEdgeAgentInfo(imageName, tag, imageRepository.Value, rawData);
        }

        IotEdgeAgentInfo IModelJsonSerializable<IotEdgeAgentInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotEdgeAgentInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotEdgeAgentInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotEdgeAgentInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotEdgeAgentInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotEdgeAgentInfo IModelSerializable<IotEdgeAgentInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotEdgeAgentInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotEdgeAgentInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotEdgeAgentInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotEdgeAgentInfo"/> to convert. </param>
        public static implicit operator RequestContent(IotEdgeAgentInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotEdgeAgentInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotEdgeAgentInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotEdgeAgentInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
