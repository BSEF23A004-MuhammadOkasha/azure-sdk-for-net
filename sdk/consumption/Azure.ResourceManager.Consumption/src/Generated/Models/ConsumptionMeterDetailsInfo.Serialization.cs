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

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionMeterDetailsInfo : IUtf8JsonSerializable, IModelJsonSerializable<ConsumptionMeterDetailsInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConsumptionMeterDetailsInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConsumptionMeterDetailsInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionMeterDetailsInfo>(this, options.Format);

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

        internal static ConsumptionMeterDetailsInfo DeserializeConsumptionMeterDetailsInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> meterName = default;
            Optional<string> meterCategory = default;
            Optional<string> meterSubCategory = default;
            Optional<string> unitOfMeasure = default;
            Optional<string> serviceFamily = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meterName"u8))
                {
                    meterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterCategory"u8))
                {
                    meterCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterSubCategory"u8))
                {
                    meterSubCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unitOfMeasure"u8))
                {
                    unitOfMeasure = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceFamily"u8))
                {
                    serviceFamily = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConsumptionMeterDetailsInfo(meterName.Value, meterCategory.Value, meterSubCategory.Value, unitOfMeasure.Value, serviceFamily.Value, rawData);
        }

        ConsumptionMeterDetailsInfo IModelJsonSerializable<ConsumptionMeterDetailsInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionMeterDetailsInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionMeterDetailsInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConsumptionMeterDetailsInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionMeterDetailsInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConsumptionMeterDetailsInfo IModelSerializable<ConsumptionMeterDetailsInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionMeterDetailsInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConsumptionMeterDetailsInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConsumptionMeterDetailsInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConsumptionMeterDetailsInfo"/> to convert. </param>
        public static implicit operator RequestContent(ConsumptionMeterDetailsInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConsumptionMeterDetailsInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConsumptionMeterDetailsInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConsumptionMeterDetailsInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
