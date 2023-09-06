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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ExposureControlBatchResult : IUtf8JsonSerializable, IModelJsonSerializable<ExposureControlBatchResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExposureControlBatchResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExposureControlBatchResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExposureControlBatchResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("exposureControlResponses"u8);
            writer.WriteStartArray();
            foreach (var item in ExposureControlResults)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ExposureControlResult>)item).Serialize(writer, options);
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

        internal static ExposureControlBatchResult DeserializeExposureControlBatchResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ExposureControlResult> exposureControlResponses = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exposureControlResponses"u8))
                {
                    List<ExposureControlResult> array = new List<ExposureControlResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExposureControlResult.DeserializeExposureControlResult(item));
                    }
                    exposureControlResponses = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExposureControlBatchResult(exposureControlResponses, rawData);
        }

        ExposureControlBatchResult IModelJsonSerializable<ExposureControlBatchResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExposureControlBatchResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExposureControlBatchResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExposureControlBatchResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExposureControlBatchResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExposureControlBatchResult IModelSerializable<ExposureControlBatchResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExposureControlBatchResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExposureControlBatchResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExposureControlBatchResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExposureControlBatchResult"/> to convert. </param>
        public static implicit operator RequestContent(ExposureControlBatchResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExposureControlBatchResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExposureControlBatchResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExposureControlBatchResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
