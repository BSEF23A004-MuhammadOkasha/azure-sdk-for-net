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
    public partial class ForecastDefinition : IUtf8JsonSerializable, IModelJsonSerializable<ForecastDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ForecastDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ForecastDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ForecastDefinition>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ForecastType.ToString());
            writer.WritePropertyName("timeframe"u8);
            writer.WriteStringValue(Timeframe.ToString());
            if (Optional.IsDefined(TimePeriod))
            {
                writer.WritePropertyName("timePeriod"u8);
                if (TimePeriod is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ForecastTimePeriod>)TimePeriod).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("dataset"u8);
            if (Dataset is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ForecastDataset>)Dataset).Serialize(writer, options);
            }
            if (Optional.IsDefined(IncludeActualCost))
            {
                writer.WritePropertyName("includeActualCost"u8);
                writer.WriteBooleanValue(IncludeActualCost.Value);
            }
            if (Optional.IsDefined(IncludeFreshPartialCost))
            {
                writer.WritePropertyName("includeFreshPartialCost"u8);
                writer.WriteBooleanValue(IncludeFreshPartialCost.Value);
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

        internal static ForecastDefinition DeserializeForecastDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ForecastType type = default;
            ForecastTimeframe timeframe = default;
            Optional<ForecastTimePeriod> timePeriod = default;
            ForecastDataset dataset = default;
            Optional<bool> includeActualCost = default;
            Optional<bool> includeFreshPartialCost = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ForecastType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeframe"u8))
                {
                    timeframe = new ForecastTimeframe(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timePeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timePeriod = ForecastTimePeriod.DeserializeForecastTimePeriod(property.Value);
                    continue;
                }
                if (property.NameEquals("dataset"u8))
                {
                    dataset = ForecastDataset.DeserializeForecastDataset(property.Value);
                    continue;
                }
                if (property.NameEquals("includeActualCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeActualCost = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeFreshPartialCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeFreshPartialCost = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ForecastDefinition(type, timeframe, timePeriod.Value, dataset, Optional.ToNullable(includeActualCost), Optional.ToNullable(includeFreshPartialCost), rawData);
        }

        ForecastDefinition IModelJsonSerializable<ForecastDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ForecastDefinition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeForecastDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ForecastDefinition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ForecastDefinition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ForecastDefinition IModelSerializable<ForecastDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ForecastDefinition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeForecastDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ForecastDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ForecastDefinition"/> to convert. </param>
        public static implicit operator RequestContent(ForecastDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ForecastDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ForecastDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeForecastDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
