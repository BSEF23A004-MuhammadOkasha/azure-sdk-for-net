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
    internal partial class V1Manifest : IUtf8JsonSerializable, IModelJsonSerializable<V1Manifest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<V1Manifest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<V1Manifest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V1Manifest>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Architecture))
            {
                writer.WritePropertyName("architecture"u8);
                writer.WriteStringValue(Architecture);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Tag))
            {
                writer.WritePropertyName("tag"u8);
                writer.WriteStringValue(Tag);
            }
            if (Optional.IsCollectionDefined(FsLayers))
            {
                writer.WritePropertyName("fsLayers"u8);
                writer.WriteStartArray();
                foreach (var item in FsLayers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<FsLayer>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(History))
            {
                writer.WritePropertyName("history"u8);
                writer.WriteStartArray();
                foreach (var item in History)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<History>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Signatures))
            {
                writer.WritePropertyName("signatures"u8);
                writer.WriteStartArray();
                foreach (var item in Signatures)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ImageSignature>)item).Serialize(writer, options);
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

        internal static V1Manifest DeserializeV1Manifest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> architecture = default;
            Optional<string> name = default;
            Optional<string> tag = default;
            Optional<IReadOnlyList<FsLayer>> fsLayers = default;
            Optional<IReadOnlyList<History>> history = default;
            Optional<IReadOnlyList<ImageSignature>> signatures = default;
            Optional<int> schemaVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("architecture"u8))
                {
                    architecture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fsLayers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FsLayer> array = new List<FsLayer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FsLayer.DeserializeFsLayer(item));
                    }
                    fsLayers = array;
                    continue;
                }
                if (property.NameEquals("history"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<History> array = new List<History>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistry.History.DeserializeHistory(item));
                    }
                    history = array;
                    continue;
                }
                if (property.NameEquals("signatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ImageSignature> array = new List<ImageSignature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageSignature.DeserializeImageSignature(item));
                    }
                    signatures = array;
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
            return new V1Manifest(Optional.ToNullable(schemaVersion), architecture.Value, name.Value, tag.Value, Optional.ToList(fsLayers), Optional.ToList(history), Optional.ToList(signatures), rawData);
        }

        V1Manifest IModelJsonSerializable<V1Manifest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V1Manifest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeV1Manifest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<V1Manifest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V1Manifest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        V1Manifest IModelSerializable<V1Manifest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<V1Manifest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeV1Manifest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="V1Manifest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="V1Manifest"/> to convert. </param>
        public static implicit operator RequestContent(V1Manifest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="V1Manifest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator V1Manifest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeV1Manifest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
