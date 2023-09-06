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

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ForecastFilter : IUtf8JsonSerializable, IModelJsonSerializable<ForecastFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ForecastFilter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ForecastFilter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ForecastFilter>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(And))
            {
                writer.WritePropertyName("and"u8);
                writer.WriteStartArray();
                foreach (var item in And)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ForecastFilter>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Or))
            {
                writer.WritePropertyName("or"u8);
                writer.WriteStartArray();
                foreach (var item in Or)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ForecastFilter>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                if (Dimensions is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ForecastComparisonExpression>)Dimensions).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                if (Tags is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ForecastComparisonExpression>)Tags).Serialize(writer, options);
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

        internal static ForecastFilter DeserializeForecastFilter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ForecastFilter>> and = default;
            Optional<IList<ForecastFilter>> or = default;
            Optional<ForecastComparisonExpression> dimensions = default;
            Optional<ForecastComparisonExpression> tags = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("and"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ForecastFilter> array = new List<ForecastFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeForecastFilter(item));
                    }
                    and = array;
                    continue;
                }
                if (property.NameEquals("or"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ForecastFilter> array = new List<ForecastFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeForecastFilter(item));
                    }
                    or = array;
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dimensions = ForecastComparisonExpression.DeserializeForecastComparisonExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tags = ForecastComparisonExpression.DeserializeForecastComparisonExpression(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ForecastFilter(Optional.ToList(and), Optional.ToList(or), dimensions.Value, tags.Value, rawData);
        }

        ForecastFilter IModelJsonSerializable<ForecastFilter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ForecastFilter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeForecastFilter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ForecastFilter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ForecastFilter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ForecastFilter IModelSerializable<ForecastFilter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ForecastFilter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeForecastFilter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ForecastFilter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ForecastFilter"/> to convert. </param>
        public static implicit operator RequestContent(ForecastFilter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ForecastFilter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ForecastFilter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeForecastFilter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
