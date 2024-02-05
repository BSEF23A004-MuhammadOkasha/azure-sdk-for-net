// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceMaintenanceWindow : IUtf8JsonSerializable, IJsonModel<ContainerServiceMaintenanceWindow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceMaintenanceWindow>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceMaintenanceWindow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("schedule"u8);
            writer.WriteObjectValue(Schedule);
            writer.WritePropertyName("durationHours"u8);
            writer.WriteNumberValue(DurationHours);
            if (Optional.IsDefined(UtcOffset))
            {
                writer.WritePropertyName("utcOffset"u8);
                writer.WriteStringValue(UtcOffset);
            }
            if (Optional.IsDefined(StartDate))
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartDate);
            }
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime);
            if (Optional.IsCollectionDefined(NotAllowedDates))
            {
                writer.WritePropertyName("notAllowedDates"u8);
                writer.WriteStartArray();
                foreach (var item in NotAllowedDates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ContainerServiceMaintenanceWindow IJsonModel<ContainerServiceMaintenanceWindow>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceMaintenanceWindow(document.RootElement, options);
        }

        internal static ContainerServiceMaintenanceWindow DeserializeContainerServiceMaintenanceWindow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerServiceMaintenanceSchedule schedule = default;
            int durationHours = default;
            Optional<string> utcOffset = default;
            Optional<string> startDate = default;
            string startTime = default;
            Optional<IList<ContainerServiceDateSpan>> notAllowedDates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schedule"u8))
                {
                    schedule = ContainerServiceMaintenanceSchedule.DeserializeContainerServiceMaintenanceSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("durationHours"u8))
                {
                    durationHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("utcOffset"u8))
                {
                    utcOffset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    startDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notAllowedDates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceDateSpan> array = new List<ContainerServiceDateSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceDateSpan.DeserializeContainerServiceDateSpan(item));
                    }
                    notAllowedDates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceMaintenanceWindow(schedule, durationHours, utcOffset.Value, startDate.Value, startTime, Optional.ToList(notAllowedDates), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Schedule))
            {
                builder.Append("  schedule:");
                AppendChildObject(builder, Schedule, options, 2, false);
            }

            if (Optional.IsDefined(DurationHours))
            {
                builder.Append("  durationHours:");
                builder.AppendLine($" {DurationHours}");
            }

            if (Optional.IsDefined(UtcOffset))
            {
                builder.Append("  utcOffset:");
                builder.AppendLine($" '{UtcOffset}'");
            }

            if (Optional.IsDefined(StartDate))
            {
                builder.Append("  startDate:");
                builder.AppendLine($" '{StartDate}'");
            }

            if (Optional.IsDefined(StartTime))
            {
                builder.Append("  startTime:");
                builder.AppendLine($" '{StartTime}'");
            }

            if (Optional.IsCollectionDefined(NotAllowedDates))
            {
                if (NotAllowedDates.Any())
                {
                    builder.Append("  notAllowedDates:");
                    builder.AppendLine(" [");
                    foreach (var item in NotAllowedDates)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ContainerServiceMaintenanceWindow>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceMaintenanceWindow IPersistableModel<ContainerServiceMaintenanceWindow>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceMaintenanceWindow(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceWindow)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceMaintenanceWindow>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
