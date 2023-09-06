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
    public partial class PredictionDistributionDefinitionDistributionsItem : IUtf8JsonSerializable, IModelJsonSerializable<PredictionDistributionDefinitionDistributionsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PredictionDistributionDefinitionDistributionsItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PredictionDistributionDefinitionDistributionsItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PredictionDistributionDefinitionDistributionsItem>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ScoreThreshold))
            {
                writer.WritePropertyName("scoreThreshold"u8);
                writer.WriteNumberValue(ScoreThreshold.Value);
            }
            if (Optional.IsDefined(Positives))
            {
                writer.WritePropertyName("positives"u8);
                writer.WriteNumberValue(Positives.Value);
            }
            if (Optional.IsDefined(Negatives))
            {
                writer.WritePropertyName("negatives"u8);
                writer.WriteNumberValue(Negatives.Value);
            }
            if (Optional.IsDefined(PositivesAboveThreshold))
            {
                writer.WritePropertyName("positivesAboveThreshold"u8);
                writer.WriteNumberValue(PositivesAboveThreshold.Value);
            }
            if (Optional.IsDefined(NegativesAboveThreshold))
            {
                writer.WritePropertyName("negativesAboveThreshold"u8);
                writer.WriteNumberValue(NegativesAboveThreshold.Value);
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

        internal static PredictionDistributionDefinitionDistributionsItem DeserializePredictionDistributionDefinitionDistributionsItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> scoreThreshold = default;
            Optional<long> positives = default;
            Optional<long> negatives = default;
            Optional<long> positivesAboveThreshold = default;
            Optional<long> negativesAboveThreshold = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scoreThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scoreThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("positives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    positives = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("negatives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negatives = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("positivesAboveThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    positivesAboveThreshold = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("negativesAboveThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negativesAboveThreshold = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PredictionDistributionDefinitionDistributionsItem(Optional.ToNullable(scoreThreshold), Optional.ToNullable(positives), Optional.ToNullable(negatives), Optional.ToNullable(positivesAboveThreshold), Optional.ToNullable(negativesAboveThreshold), rawData);
        }

        PredictionDistributionDefinitionDistributionsItem IModelJsonSerializable<PredictionDistributionDefinitionDistributionsItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PredictionDistributionDefinitionDistributionsItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePredictionDistributionDefinitionDistributionsItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PredictionDistributionDefinitionDistributionsItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PredictionDistributionDefinitionDistributionsItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PredictionDistributionDefinitionDistributionsItem IModelSerializable<PredictionDistributionDefinitionDistributionsItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PredictionDistributionDefinitionDistributionsItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePredictionDistributionDefinitionDistributionsItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PredictionDistributionDefinitionDistributionsItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PredictionDistributionDefinitionDistributionsItem"/> to convert. </param>
        public static implicit operator RequestContent(PredictionDistributionDefinitionDistributionsItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PredictionDistributionDefinitionDistributionsItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PredictionDistributionDefinitionDistributionsItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePredictionDistributionDefinitionDistributionsItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
