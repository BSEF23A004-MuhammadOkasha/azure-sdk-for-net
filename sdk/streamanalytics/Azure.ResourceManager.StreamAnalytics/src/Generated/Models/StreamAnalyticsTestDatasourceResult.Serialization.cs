// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsTestDatasourceResult : IUtf8JsonSerializable, IJsonModel<StreamAnalyticsTestDatasourceResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamAnalyticsTestDatasourceResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamAnalyticsTestDatasourceResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsTestDatasourceResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsTestDatasourceResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WritePropertyName("error"u8);
            writer.WriteStartObject();
            if (Code != null)
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Target != null)
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (!(Details is ChangeTrackingList<StreamAnalyticsErrorDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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
            writer.WriteEndObject();
        }

        StreamAnalyticsTestDatasourceResult IJsonModel<StreamAnalyticsTestDatasourceResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsTestDatasourceResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsTestDatasourceResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsTestDatasourceResult(document.RootElement, options);
        }

        internal static StreamAnalyticsTestDatasourceResult DeserializeStreamAnalyticsTestDatasourceResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamAnalyticsTestDatasourceResultStatus? status = default;
            string code = default;
            string message = default;
            string target = default;
            IReadOnlyList<StreamAnalyticsErrorDetails> details = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new StreamAnalyticsTestDatasourceResultStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("code"u8))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("message"u8))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("target"u8))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamAnalyticsErrorDetails> array = new List<StreamAnalyticsErrorDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamAnalyticsErrorDetails.DeserializeStreamAnalyticsErrorDetails(item, options));
                            }
                            details = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamAnalyticsTestDatasourceResult(
                code,
                message,
                target,
                details ?? new ChangeTrackingList<StreamAnalyticsErrorDetails>(),
                serializedAdditionalRawData,
                status);
        }

        BinaryData IPersistableModel<StreamAnalyticsTestDatasourceResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsTestDatasourceResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsTestDatasourceResult)} does not support '{options.Format}' format.");
            }
        }

        StreamAnalyticsTestDatasourceResult IPersistableModel<StreamAnalyticsTestDatasourceResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsTestDatasourceResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamAnalyticsTestDatasourceResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsTestDatasourceResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamAnalyticsTestDatasourceResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
