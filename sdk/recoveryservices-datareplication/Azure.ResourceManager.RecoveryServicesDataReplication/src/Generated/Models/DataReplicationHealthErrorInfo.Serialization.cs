// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationHealthErrorInfo : IUtf8JsonSerializable, IJsonModel<DataReplicationHealthErrorInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataReplicationHealthErrorInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataReplicationHealthErrorInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationHealthErrorInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationHealthErrorInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AffectedResourceType))
            {
                writer.WritePropertyName("affectedResourceType"u8);
                writer.WriteStringValue(AffectedResourceType);
            }
            if (Optional.IsCollectionDefined(AffectedResourceCorrelationIds))
            {
                writer.WritePropertyName("affectedResourceCorrelationIds"u8);
                writer.WriteStartArray();
                foreach (var item in AffectedResourceCorrelationIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ChildErrors))
            {
                writer.WritePropertyName("childErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ChildErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (options.Format != "W" && Optional.IsDefined(HealthCategory))
            {
                writer.WritePropertyName("healthCategory"u8);
                writer.WriteStringValue(HealthCategory);
            }
            if (options.Format != "W" && Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (options.Format != "W" && Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity);
            }
            if (options.Format != "W" && Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(IsCustomerResolvable))
            {
                writer.WritePropertyName("isCustomerResolvable"u8);
                writer.WriteBooleanValue(IsCustomerResolvable.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsDefined(Causes))
            {
                writer.WritePropertyName("causes"u8);
                writer.WriteStringValue(Causes);
            }
            if (options.Format != "W" && Optional.IsDefined(Recommendation))
            {
                writer.WritePropertyName("recommendation"u8);
                writer.WriteStringValue(Recommendation);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        DataReplicationHealthErrorInfo IJsonModel<DataReplicationHealthErrorInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationHealthErrorInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationHealthErrorInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataReplicationHealthErrorInfo(document.RootElement, options);
        }

        internal static DataReplicationHealthErrorInfo DeserializeDataReplicationHealthErrorInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string affectedResourceType = default;
            IReadOnlyList<string> affectedResourceCorrelationIds = default;
            IReadOnlyList<DataReplicationInnerHealthErrorInfo> childErrors = default;
            string code = default;
            string healthCategory = default;
            string category = default;
            string severity = default;
            string source = default;
            DateTimeOffset? creationTime = default;
            bool? isCustomerResolvable = default;
            string summary = default;
            string message = default;
            string causes = default;
            string recommendation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("affectedResourceType"u8))
                {
                    affectedResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedResourceCorrelationIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    affectedResourceCorrelationIds = array;
                    continue;
                }
                if (property.NameEquals("childErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataReplicationInnerHealthErrorInfo> array = new List<DataReplicationInnerHealthErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataReplicationInnerHealthErrorInfo.DeserializeDataReplicationInnerHealthErrorInfo(item, options));
                    }
                    childErrors = array;
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthCategory"u8))
                {
                    healthCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isCustomerResolvable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCustomerResolvable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("causes"u8))
                {
                    causes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendation"u8))
                {
                    recommendation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataReplicationHealthErrorInfo(
                affectedResourceType,
                affectedResourceCorrelationIds ?? new ChangeTrackingList<string>(),
                childErrors ?? new ChangeTrackingList<DataReplicationInnerHealthErrorInfo>(),
                code,
                healthCategory,
                category,
                severity,
                source,
                creationTime,
                isCustomerResolvable,
                summary,
                message,
                causes,
                recommendation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataReplicationHealthErrorInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationHealthErrorInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataReplicationHealthErrorInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DataReplicationHealthErrorInfo IPersistableModel<DataReplicationHealthErrorInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationHealthErrorInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataReplicationHealthErrorInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataReplicationHealthErrorInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataReplicationHealthErrorInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
