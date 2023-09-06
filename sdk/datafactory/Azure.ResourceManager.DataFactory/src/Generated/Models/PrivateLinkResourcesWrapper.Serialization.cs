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

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class PrivateLinkResourcesWrapper : IUtf8JsonSerializable, IModelJsonSerializable<PrivateLinkResourcesWrapper>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrivateLinkResourcesWrapper>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrivateLinkResourcesWrapper>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkResourcesWrapper>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DataFactoryPrivateLinkResource>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static PrivateLinkResourcesWrapper DeserializePrivateLinkResourcesWrapper(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataFactoryPrivateLinkResource> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DataFactoryPrivateLinkResource> array = new List<DataFactoryPrivateLinkResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryPrivateLinkResource.DeserializeDataFactoryPrivateLinkResource(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrivateLinkResourcesWrapper(value, rawData);
        }

        PrivateLinkResourcesWrapper IModelJsonSerializable<PrivateLinkResourcesWrapper>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkResourcesWrapper>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateLinkResourcesWrapper(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrivateLinkResourcesWrapper>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkResourcesWrapper>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrivateLinkResourcesWrapper IModelSerializable<PrivateLinkResourcesWrapper>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateLinkResourcesWrapper>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrivateLinkResourcesWrapper(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PrivateLinkResourcesWrapper"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PrivateLinkResourcesWrapper"/> to convert. </param>
        public static implicit operator RequestContent(PrivateLinkResourcesWrapper model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PrivateLinkResourcesWrapper"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PrivateLinkResourcesWrapper(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrivateLinkResourcesWrapper(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
