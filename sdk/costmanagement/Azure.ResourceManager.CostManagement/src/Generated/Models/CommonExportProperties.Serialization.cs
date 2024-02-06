// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class CommonExportProperties : IUtf8JsonSerializable, IJsonModel<CommonExportProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommonExportProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommonExportProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonExportProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommonExportProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format.Value.ToString());
            }
            writer.WritePropertyName("deliveryInfo"u8);
            BinaryData data = ModelReaderWriter.Write(DeliveryInfo, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
            using (JsonDocument document = JsonDocument.Parse(data))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("definition"u8);
            BinaryData data0 = ModelReaderWriter.Write(Definition, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data0);
#else
            using (JsonDocument document = JsonDocument.Parse(data0))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            if (Optional.IsDefined(RunHistory))
            {
                writer.WritePropertyName("runHistory"u8);
                BinaryData data1 = ModelReaderWriter.Write(RunHistory, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data1);
#else
                using (JsonDocument document = JsonDocument.Parse(data1))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(PartitionData))
            {
                writer.WritePropertyName("partitionData"u8);
                writer.WriteBooleanValue(PartitionData.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NextRunTimeEstimate))
            {
                writer.WritePropertyName("nextRunTimeEstimate"u8);
                writer.WriteStringValue(NextRunTimeEstimate.Value, "O");
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
            writer.WriteEndObject();
        }

        CommonExportProperties IJsonModel<CommonExportProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonExportProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommonExportProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommonExportProperties(document.RootElement, options);
        }

        internal static CommonExportProperties DeserializeCommonExportProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExportFormatType> format = default;
            ExportDeliveryInfo deliveryInfo = default;
            ExportDefinition definition = default;
            Optional<ExportExecutionListResult> runHistory = default;
            Optional<bool> partitionData = default;
            Optional<DateTimeOffset> nextRunTimeEstimate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    format = new ExportFormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deliveryInfo"u8))
                {
                    deliveryInfo = ExportDeliveryInfo.DeserializeExportDeliveryInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("definition"u8))
                {
                    definition = ExportDefinition.DeserializeExportDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("runHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runHistory = ExportExecutionListResult.DeserializeExportExecutionListResult(property.Value);
                    continue;
                }
                if (property.NameEquals("partitionData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionData = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nextRunTimeEstimate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextRunTimeEstimate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CommonExportProperties(Optional.ToNullable(format), deliveryInfo, definition, runHistory.Value, Optional.ToNullable(partitionData), Optional.ToNullable(nextRunTimeEstimate), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CommonExportProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonExportProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommonExportProperties)} does not support '{options.Format}' format.");
            }
        }

        CommonExportProperties IPersistableModel<CommonExportProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonExportProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommonExportProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommonExportProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommonExportProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
