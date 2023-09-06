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

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class KpiExtract : IUtf8JsonSerializable, IModelJsonSerializable<KpiExtract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KpiExtract>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KpiExtract>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KpiExtract>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("extractName"u8);
            writer.WriteStringValue(ExtractName);
            writer.WritePropertyName("expression"u8);
            writer.WriteStringValue(Expression);
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

        internal static KpiExtract DeserializeKpiExtract(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string extractName = default;
            string expression = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extractName"u8))
                {
                    extractName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KpiExtract(extractName, expression, rawData);
        }

        KpiExtract IModelJsonSerializable<KpiExtract>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KpiExtract>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKpiExtract(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KpiExtract>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KpiExtract>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KpiExtract IModelSerializable<KpiExtract>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KpiExtract>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKpiExtract(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KpiExtract"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KpiExtract"/> to convert. </param>
        public static implicit operator RequestContent(KpiExtract model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KpiExtract"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KpiExtract(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKpiExtract(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
