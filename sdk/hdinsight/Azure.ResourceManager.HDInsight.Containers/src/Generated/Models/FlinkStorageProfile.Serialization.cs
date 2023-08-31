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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class FlinkStorageProfile : IUtf8JsonSerializable, IModelJsonSerializable<FlinkStorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FlinkStorageProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FlinkStorageProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("storageUri"u8);
            writer.WriteStringValue(StorageUriString);
            if (Optional.IsDefined(Storagekey))
            {
                writer.WritePropertyName("storagekey"u8);
                writer.WriteStringValue(Storagekey);
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

        internal static FlinkStorageProfile DeserializeFlinkStorageProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageUri = default;
            Optional<string> storagekey = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageUri"u8))
                {
                    storageUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storagekey"u8))
                {
                    storagekey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FlinkStorageProfile(storageUri, storagekey.Value, rawData);
        }

        FlinkStorageProfile IModelJsonSerializable<FlinkStorageProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFlinkStorageProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FlinkStorageProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FlinkStorageProfile IModelSerializable<FlinkStorageProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFlinkStorageProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FlinkStorageProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FlinkStorageProfile"/> to convert. </param>
        public static implicit operator RequestContent(FlinkStorageProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FlinkStorageProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FlinkStorageProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFlinkStorageProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
