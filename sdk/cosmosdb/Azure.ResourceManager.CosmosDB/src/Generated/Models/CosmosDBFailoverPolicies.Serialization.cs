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
    public partial class CosmosDBFailoverPolicies : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBFailoverPolicies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBFailoverPolicies>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBFailoverPolicies>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBFailoverPolicies>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("failoverPolicies"u8);
            writer.WriteStartArray();
            foreach (var item in FailoverPolicies)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CosmosDBFailoverPolicy>)item).Serialize(writer, options);
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

        internal static CosmosDBFailoverPolicies DeserializeCosmosDBFailoverPolicies(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<CosmosDBFailoverPolicy> failoverPolicies = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failoverPolicies"u8))
                {
                    List<CosmosDBFailoverPolicy> array = new List<CosmosDBFailoverPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBFailoverPolicy.DeserializeCosmosDBFailoverPolicy(item));
                    }
                    failoverPolicies = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBFailoverPolicies(failoverPolicies, rawData);
        }

        CosmosDBFailoverPolicies IModelJsonSerializable<CosmosDBFailoverPolicies>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBFailoverPolicies>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBFailoverPolicies(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBFailoverPolicies>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBFailoverPolicies>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBFailoverPolicies IModelSerializable<CosmosDBFailoverPolicies>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBFailoverPolicies>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBFailoverPolicies(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CosmosDBFailoverPolicies"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CosmosDBFailoverPolicies"/> to convert. </param>
        public static implicit operator RequestContent(CosmosDBFailoverPolicies model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CosmosDBFailoverPolicies"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CosmosDBFailoverPolicies(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBFailoverPolicies(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
