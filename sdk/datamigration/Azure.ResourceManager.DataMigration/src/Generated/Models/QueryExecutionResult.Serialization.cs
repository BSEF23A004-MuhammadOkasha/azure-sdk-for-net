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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class QueryExecutionResult : IUtf8JsonSerializable, IModelJsonSerializable<QueryExecutionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<QueryExecutionResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<QueryExecutionResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueryExecutionResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(QueryText))
            {
                writer.WritePropertyName("queryText"u8);
                writer.WriteStringValue(QueryText);
            }
            if (Optional.IsDefined(StatementsInBatch))
            {
                writer.WritePropertyName("statementsInBatch"u8);
                writer.WriteNumberValue(StatementsInBatch.Value);
            }
            if (Optional.IsDefined(SourceResult))
            {
                writer.WritePropertyName("sourceResult"u8);
                if (SourceResult is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ExecutionStatistics>)SourceResult).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TargetResult))
            {
                writer.WritePropertyName("targetResult"u8);
                if (TargetResult is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ExecutionStatistics>)TargetResult).Serialize(writer, options);
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

        internal static QueryExecutionResult DeserializeQueryExecutionResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> queryText = default;
            Optional<long> statementsInBatch = default;
            Optional<ExecutionStatistics> sourceResult = default;
            Optional<ExecutionStatistics> targetResult = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryText"u8))
                {
                    queryText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statementsInBatch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statementsInBatch = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sourceResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResult = ExecutionStatistics.DeserializeExecutionStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("targetResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResult = ExecutionStatistics.DeserializeExecutionStatistics(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new QueryExecutionResult(queryText.Value, Optional.ToNullable(statementsInBatch), sourceResult.Value, targetResult.Value, rawData);
        }

        QueryExecutionResult IModelJsonSerializable<QueryExecutionResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueryExecutionResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryExecutionResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<QueryExecutionResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueryExecutionResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        QueryExecutionResult IModelSerializable<QueryExecutionResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QueryExecutionResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeQueryExecutionResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="QueryExecutionResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="QueryExecutionResult"/> to convert. </param>
        public static implicit operator RequestContent(QueryExecutionResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="QueryExecutionResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator QueryExecutionResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeQueryExecutionResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
