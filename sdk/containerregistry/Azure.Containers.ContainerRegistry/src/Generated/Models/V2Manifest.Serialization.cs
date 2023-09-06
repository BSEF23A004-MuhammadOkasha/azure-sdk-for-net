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
    internal partial class V2Manifest : IUtf8JsonSerializable, IModelJsonSerializable<V2Manifest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<V2Manifest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<V2Manifest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V2Manifest>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MediaType))
            {
                writer.WritePropertyName("mediaType"u8);
                writer.WriteStringValue(MediaType);
            }
            if (Optional.IsDefined(Config))
            {
                writer.WritePropertyName("config"u8);
                if (Config is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OciDescriptor>)Config).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers"u8);
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<OciDescriptor>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion"u8);
                writer.WriteNumberValue(SchemaVersion.Value);
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

        internal static V2Manifest DeserializeV2Manifest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> mediaType = default;
            Optional<OciDescriptor> config = default;
            Optional<IReadOnlyList<OciDescriptor>> layers = default;
            Optional<int> schemaVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"u8))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("config"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    config = OciDescriptor.DeserializeOciDescriptor(property.Value);
                    continue;
                }
                if (property.NameEquals("layers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OciDescriptor> array = new List<OciDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OciDescriptor.DeserializeOciDescriptor(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new V2Manifest(Optional.ToNullable(schemaVersion), mediaType.Value, config.Value, Optional.ToList(layers), rawData);
        }

        V2Manifest IModelJsonSerializable<V2Manifest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V2Manifest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeV2Manifest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<V2Manifest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V2Manifest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        V2Manifest IModelSerializable<V2Manifest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V2Manifest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeV2Manifest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="V2Manifest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="V2Manifest"/> to convert. </param>
        public static implicit operator RequestContent(V2Manifest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="V2Manifest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator V2Manifest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeV2Manifest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
