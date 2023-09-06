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
    public partial class ConsumptionMeterDetails : IUtf8JsonSerializable, IModelJsonSerializable<ConsumptionMeterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConsumptionMeterDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConsumptionMeterDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionMeterDetails>(this, options.Format);

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

        internal static ConsumptionMeterDetails DeserializeConsumptionMeterDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> meterName = default;
            Optional<string> meterCategory = default;
            Optional<string> meterSubCategory = default;
            Optional<string> unit = default;
            Optional<string> meterLocation = default;
            Optional<decimal> totalIncludedQuantity = default;
            Optional<decimal> pretaxStandardRate = default;
            Optional<string> serviceName = default;
            Optional<string> serviceTier = default;
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
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterLocation"u8))
                {
                    meterLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalIncludedQuantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalIncludedQuantity = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("pretaxStandardRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pretaxStandardRate = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("serviceName"u8))
                {
                    serviceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceTier"u8))
                {
                    serviceTier = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConsumptionMeterDetails(meterName.Value, meterCategory.Value, meterSubCategory.Value, unit.Value, meterLocation.Value, Optional.ToNullable(totalIncludedQuantity), Optional.ToNullable(pretaxStandardRate), serviceName.Value, serviceTier.Value, rawData);
        }

        ConsumptionMeterDetails IModelJsonSerializable<ConsumptionMeterDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionMeterDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionMeterDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConsumptionMeterDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionMeterDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConsumptionMeterDetails IModelSerializable<ConsumptionMeterDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionMeterDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConsumptionMeterDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConsumptionMeterDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConsumptionMeterDetails"/> to convert. </param>
        public static implicit operator RequestContent(ConsumptionMeterDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConsumptionMeterDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConsumptionMeterDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConsumptionMeterDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
