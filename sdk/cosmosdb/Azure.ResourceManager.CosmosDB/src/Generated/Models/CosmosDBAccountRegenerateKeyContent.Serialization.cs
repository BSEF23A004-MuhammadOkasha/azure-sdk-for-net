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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountRegenerateKeyContent : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBAccountRegenerateKeyContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBAccountRegenerateKeyContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBAccountRegenerateKeyContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBAccountRegenerateKeyContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("keyKind"u8);
            writer.WriteStringValue(KeyKind.ToString());
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

        internal static CosmosDBAccountRegenerateKeyContent DeserializeCosmosDBAccountRegenerateKeyContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CosmosDBAccountKeyKind keyKind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyKind"u8))
                {
                    keyKind = new CosmosDBAccountKeyKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBAccountRegenerateKeyContent(keyKind, rawData);
        }

        CosmosDBAccountRegenerateKeyContent IModelJsonSerializable<CosmosDBAccountRegenerateKeyContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBAccountRegenerateKeyContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBAccountRegenerateKeyContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBAccountRegenerateKeyContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBAccountRegenerateKeyContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBAccountRegenerateKeyContent IModelSerializable<CosmosDBAccountRegenerateKeyContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBAccountRegenerateKeyContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBAccountRegenerateKeyContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CosmosDBAccountRegenerateKeyContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CosmosDBAccountRegenerateKeyContent"/> to convert. </param>
        public static implicit operator RequestContent(CosmosDBAccountRegenerateKeyContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CosmosDBAccountRegenerateKeyContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CosmosDBAccountRegenerateKeyContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBAccountRegenerateKeyContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
