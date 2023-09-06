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

namespace Azure.Containers.ContainerRegistry
{
    public partial class OciDescriptor : IUtf8JsonSerializable, IModelJsonSerializable<OciDescriptor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OciDescriptor>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OciDescriptor>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OciDescriptor>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MediaType))
            {
                writer.WritePropertyName("mediaType"u8);
                writer.WriteStringValue(MediaType);
            }
            if (Optional.IsDefined(SizeInBytes))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteNumberValue(SizeInBytes.Value);
            }
            if (Optional.IsDefined(Digest))
            {
                writer.WritePropertyName("digest"u8);
                writer.WriteStringValue(Digest);
            }
            if (Optional.IsCollectionDefined(Urls))
            {
                writer.WritePropertyName("urls"u8);
                writer.WriteStartArray();
                foreach (var item in Urls)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.AbsoluteUri);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotations))
            {
                if (Annotations != null)
                {
                    writer.WritePropertyName("annotations"u8);
                    if (Annotations is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<OciAnnotations>)Annotations).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("annotations");
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

        internal static OciDescriptor DeserializeOciDescriptor(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> mediaType = default;
            Optional<long> size = default;
            Optional<string> digest = default;
            Optional<IList<Uri>> urls = default;
            Optional<OciAnnotations> annotations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"u8))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    size = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("digest"u8))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("urls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Uri> array = new List<Uri>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new Uri(item.GetString()));
                        }
                    }
                    urls = array;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        annotations = null;
                        continue;
                    }
                    annotations = OciAnnotations.DeserializeOciAnnotations(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OciDescriptor(mediaType.Value, Optional.ToNullable(size), digest.Value, Optional.ToList(urls), annotations.Value, rawData);
        }

        OciDescriptor IModelJsonSerializable<OciDescriptor>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OciDescriptor>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOciDescriptor(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OciDescriptor>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OciDescriptor>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OciDescriptor IModelSerializable<OciDescriptor>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OciDescriptor>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOciDescriptor(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OciDescriptor"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OciDescriptor"/> to convert. </param>
        public static implicit operator RequestContent(OciDescriptor model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OciDescriptor"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OciDescriptor(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOciDescriptor(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
