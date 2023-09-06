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
    internal partial class BenefitRecommendationsListResult : IUtf8JsonSerializable, IModelJsonSerializable<BenefitRecommendationsListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BenefitRecommendationsListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BenefitRecommendationsListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BenefitRecommendationsListResult>(this, options.Format);

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

        internal static BenefitRecommendationsListResult DeserializeBenefitRecommendationsListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<BenefitRecommendationModel>> value = default;
            Optional<Uri> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BenefitRecommendationModel> array = new List<BenefitRecommendationModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BenefitRecommendationModel.DeserializeBenefitRecommendationModel(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BenefitRecommendationsListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        BenefitRecommendationsListResult IModelJsonSerializable<BenefitRecommendationsListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BenefitRecommendationsListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBenefitRecommendationsListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BenefitRecommendationsListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BenefitRecommendationsListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BenefitRecommendationsListResult IModelSerializable<BenefitRecommendationsListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BenefitRecommendationsListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBenefitRecommendationsListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BenefitRecommendationsListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BenefitRecommendationsListResult"/> to convert. </param>
        public static implicit operator RequestContent(BenefitRecommendationsListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BenefitRecommendationsListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BenefitRecommendationsListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBenefitRecommendationsListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
