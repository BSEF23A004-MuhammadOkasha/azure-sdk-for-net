// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement
{
    public partial class CostManagementExportData : IUtf8JsonSerializable, IJsonModel<CostManagementExportData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CostManagementExportData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CostManagementExportData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementExportData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CostManagementExportData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format.Value.ToString());
            }
            if (Optional.IsDefined(DeliveryInfo))
            {
                writer.WritePropertyName("deliveryInfo"u8);
                writer.WriteObjectValue(DeliveryInfo);
            }
            if (Optional.IsDefined(Definition))
            {
                writer.WritePropertyName("definition"u8);
                writer.WriteObjectValue(Definition);
            }
            if (Optional.IsDefined(RunHistory))
            {
                writer.WritePropertyName("runHistory"u8);
                writer.WriteObjectValue(RunHistory);
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
            if (Optional.IsDefined(Schedule))
            {
                writer.WritePropertyName("schedule"u8);
                writer.WriteObjectValue(Schedule);
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

        CostManagementExportData IJsonModel<CostManagementExportData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementExportData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CostManagementExportData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCostManagementExportData(document.RootElement, options);
        }

        internal static CostManagementExportData DeserializeCostManagementExportData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ExportFormatType> format = default;
            Optional<ExportDeliveryInfo> deliveryInfo = default;
            Optional<ExportDefinition> definition = default;
            Optional<ExportExecutionListResult> runHistory = default;
            Optional<bool> partitionData = default;
            Optional<DateTimeOffset> nextRunTimeEstimate = default;
            Optional<ExportSchedule> schedule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("format"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            format = new ExportFormatType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deliveryInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryInfo = ExportDeliveryInfo.DeserializeExportDeliveryInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("definition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            definition = ExportDefinition.DeserializeExportDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("runHistory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runHistory = ExportExecutionListResult.DeserializeExportExecutionListResult(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("partitionData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partitionData = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("nextRunTimeEstimate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextRunTimeEstimate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("schedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            schedule = ExportSchedule.DeserializeExportSchedule(property0.Value);
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
            return new CostManagementExportData(id, name, type, systemData.Value, Optional.ToNullable(format), deliveryInfo.Value, definition.Value, runHistory.Value, Optional.ToNullable(partitionData), Optional.ToNullable(nextRunTimeEstimate), schedule.Value, Optional.ToNullable(eTag), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CostManagementExportData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementExportData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CostManagementExportData)} does not support '{options.Format}' format.");
            }
        }

        CostManagementExportData IPersistableModel<CostManagementExportData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementExportData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCostManagementExportData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CostManagementExportData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CostManagementExportData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
