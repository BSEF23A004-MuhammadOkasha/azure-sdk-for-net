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
    internal partial class Manifest : IUtf8JsonSerializable, IModelJsonSerializable<Manifest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<Manifest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<Manifest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Manifest>(this, options.Format);

            writer.WriteStartObject();
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

        internal static Manifest DeserializeManifest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> schemaVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new Manifest(Optional.ToNullable(schemaVersion), rawData);
        }

        Manifest IModelJsonSerializable<Manifest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Manifest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManifest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<Manifest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Manifest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        Manifest IModelSerializable<Manifest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<Manifest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManifest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="Manifest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="Manifest"/> to convert. </param>
        public static implicit operator RequestContent(Manifest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="Manifest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator Manifest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManifest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
