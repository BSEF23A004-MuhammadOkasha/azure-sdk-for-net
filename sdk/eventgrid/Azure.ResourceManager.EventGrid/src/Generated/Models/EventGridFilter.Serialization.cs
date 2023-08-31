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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridFilter : IUtf8JsonSerializable, IModelJsonSerializable<EventGridFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventGridFilter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventGridFilter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("operatorType"u8);
            writer.WriteStringValue(OperatorType.ToString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        internal static EventGridFilter DeserializeEventGridFilter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("operatorType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "BoolEquals": return BoolEqualsFilter.DeserializeBoolEqualsFilter(element);
                    case "IsNotNull": return IsNotNullFilter.DeserializeIsNotNullFilter(element);
                    case "IsNullOrUndefined": return IsNullOrUndefinedFilter.DeserializeIsNullOrUndefinedFilter(element);
                    case "NumberGreaterThan": return NumberGreaterThanFilter.DeserializeNumberGreaterThanFilter(element);
                    case "NumberGreaterThanOrEquals": return NumberGreaterThanOrEqualsFilter.DeserializeNumberGreaterThanOrEqualsFilter(element);
                    case "NumberIn": return NumberInFilter.DeserializeNumberInFilter(element);
                    case "NumberInRange": return NumberInRangeFilter.DeserializeNumberInRangeFilter(element);
                    case "NumberLessThan": return NumberLessThanFilter.DeserializeNumberLessThanFilter(element);
                    case "NumberLessThanOrEquals": return NumberLessThanOrEqualsFilter.DeserializeNumberLessThanOrEqualsFilter(element);
                    case "NumberNotIn": return NumberNotInFilter.DeserializeNumberNotInFilter(element);
                    case "NumberNotInRange": return NumberNotInRangeFilter.DeserializeNumberNotInRangeFilter(element);
                    case "StringBeginsWith": return StringBeginsWithFilter.DeserializeStringBeginsWithFilter(element);
                    case "StringContains": return StringContainsFilter.DeserializeStringContainsFilter(element);
                    case "StringEndsWith": return StringEndsWithFilter.DeserializeStringEndsWithFilter(element);
                    case "StringIn": return StringInFilter.DeserializeStringInFilter(element);
                    case "StringNotBeginsWith": return StringNotBeginsWithFilter.DeserializeStringNotBeginsWithFilter(element);
                    case "StringNotContains": return StringNotContainsFilter.DeserializeStringNotContainsFilter(element);
                    case "StringNotEndsWith": return StringNotEndsWithFilter.DeserializeStringNotEndsWithFilter(element);
                    case "StringNotIn": return StringNotInFilter.DeserializeStringNotInFilter(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            FilterOperatorType operatorType = default;
            Optional<string> key = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operatorType"u8))
                {
                    operatorType = new FilterOperatorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownFilter(operatorType, key.Value, rawData);
        }

        EventGridFilter IModelJsonSerializable<EventGridFilter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridFilter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventGridFilter>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventGridFilter IModelSerializable<EventGridFilter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventGridFilter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventGridFilter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventGridFilter"/> to convert. </param>
        public static implicit operator RequestContent(EventGridFilter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventGridFilter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventGridFilter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventGridFilter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
