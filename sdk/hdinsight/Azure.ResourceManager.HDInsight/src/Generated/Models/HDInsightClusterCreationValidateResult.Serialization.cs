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

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterCreationValidateResult : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightClusterCreationValidateResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightClusterCreationValidateResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightClusterCreationValidateResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ValidationErrors))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationErrors)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HDInsightClusterValidationErrorInfo>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ValidationWarnings))
            {
                writer.WritePropertyName("validationWarnings"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationWarnings)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HDInsightClusterValidationErrorInfo>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EstimatedCreationDuration))
            {
                writer.WritePropertyName("estimatedCreationDuration"u8);
                writer.WriteStringValue(EstimatedCreationDuration.Value, "P");
            }
            if (Optional.IsCollectionDefined(AaddsResourcesDetails))
            {
                writer.WritePropertyName("aaddsResourcesDetails"u8);
                writer.WriteStartArray();
                foreach (var item in AaddsResourcesDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HDInsightClusterAaddsDetail>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static HDInsightClusterCreationValidateResult DeserializeHDInsightClusterCreationValidateResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<HDInsightClusterValidationErrorInfo>> validationErrors = default;
            Optional<IReadOnlyList<HDInsightClusterValidationErrorInfo>> validationWarnings = default;
            Optional<TimeSpan> estimatedCreationDuration = default;
            Optional<IReadOnlyList<HDInsightClusterAaddsDetail>> aaddsResourcesDetails = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightClusterValidationErrorInfo> array = new List<HDInsightClusterValidationErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightClusterValidationErrorInfo.DeserializeHDInsightClusterValidationErrorInfo(item));
                    }
                    validationErrors = array;
                    continue;
                }
                if (property.NameEquals("validationWarnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightClusterValidationErrorInfo> array = new List<HDInsightClusterValidationErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightClusterValidationErrorInfo.DeserializeHDInsightClusterValidationErrorInfo(item));
                    }
                    validationWarnings = array;
                    continue;
                }
                if (property.NameEquals("estimatedCreationDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    estimatedCreationDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("aaddsResourcesDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightClusterAaddsDetail> array = new List<HDInsightClusterAaddsDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightClusterAaddsDetail.DeserializeHDInsightClusterAaddsDetail(item));
                    }
                    aaddsResourcesDetails = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightClusterCreationValidateResult(Optional.ToList(validationErrors), Optional.ToList(validationWarnings), Optional.ToNullable(estimatedCreationDuration), Optional.ToList(aaddsResourcesDetails), rawData);
        }

        HDInsightClusterCreationValidateResult IModelJsonSerializable<HDInsightClusterCreationValidateResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterCreationValidateResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightClusterCreationValidateResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightClusterCreationValidateResult IModelSerializable<HDInsightClusterCreationValidateResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightClusterCreationValidateResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightClusterCreationValidateResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightClusterCreationValidateResult"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightClusterCreationValidateResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightClusterCreationValidateResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightClusterCreationValidateResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightClusterCreationValidateResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
