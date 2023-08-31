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

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial struct CurrencyValue : IUtf8JsonSerializable, IModelJsonSerializable<CurrencyValue>, IModelJsonSerializable<object>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CurrencyValue>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CurrencyValue>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CurrencyValue>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("amount"u8);
            writer.WriteNumberValue(Amount);
            if (Optional.IsDefined(Symbol))
            {
                writer.WritePropertyName("currencySymbol"u8);
                writer.WriteStringValue(Symbol);
            }
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(Code);
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

        void IModelJsonSerializable<object>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CurrencyValue>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("amount"u8);
            writer.WriteNumberValue(Amount);
            if (Optional.IsDefined(Symbol))
            {
                writer.WritePropertyName("currencySymbol"u8);
                writer.WriteStringValue(Symbol);
            }
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(Code);
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

        internal static CurrencyValue DeserializeCurrencyValue(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            double amount = default;
            Optional<string> currencySymbol = default;
            Optional<string> currencyCode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amount"u8))
                {
                    amount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("currencySymbol"u8))
                {
                    currencySymbol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CurrencyValue(amount, currencySymbol.Value, currencyCode.Value, rawData);
        }

        CurrencyValue IModelJsonSerializable<CurrencyValue>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CurrencyValue>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCurrencyValue(doc.RootElement, options);
        }

        object IModelJsonSerializable<object>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CurrencyValue>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCurrencyValue(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CurrencyValue>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CurrencyValue>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CurrencyValue IModelSerializable<CurrencyValue>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CurrencyValue>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCurrencyValue(doc.RootElement, options);
        }

        BinaryData IModelSerializable<object>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CurrencyValue>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        object IModelSerializable<object>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CurrencyValue>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCurrencyValue(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CurrencyValue"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CurrencyValue"/> to convert. </param>
        public static implicit operator RequestContent(CurrencyValue model)
        {
            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CurrencyValue"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CurrencyValue(Response response)
        {
            Argument.AssertNotNull(response, nameof(response));

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCurrencyValue(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
