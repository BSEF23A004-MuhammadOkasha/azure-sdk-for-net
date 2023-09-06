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
    public partial class CosmosDBMetricAvailability : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBMetricAvailability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBMetricAvailability>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBMetricAvailability>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBMetricAvailability>(this, options.Format);

            writer.WriteStartObject();
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

        internal static CosmosDBMetricAvailability DeserializeCosmosDBMetricAvailability(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> timeGrain = default;
            Optional<string> retention = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeGrain"u8))
                {
                    timeGrain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retention"u8))
                {
                    retention = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBMetricAvailability(timeGrain.Value, retention.Value, rawData);
        }

        CosmosDBMetricAvailability IModelJsonSerializable<CosmosDBMetricAvailability>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBMetricAvailability>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBMetricAvailability(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBMetricAvailability>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBMetricAvailability>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBMetricAvailability IModelSerializable<CosmosDBMetricAvailability>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBMetricAvailability>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBMetricAvailability(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CosmosDBMetricAvailability"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CosmosDBMetricAvailability"/> to convert. </param>
        public static implicit operator RequestContent(CosmosDBMetricAvailability model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CosmosDBMetricAvailability"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CosmosDBMetricAvailability(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBMetricAvailability(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
