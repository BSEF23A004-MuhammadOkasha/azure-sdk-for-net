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
    public partial class ScheduleProperties : IUtf8JsonSerializable, IJsonModel<ScheduleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduleProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduleProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("frequency"u8);
            writer.WriteStringValue(Frequency.ToString());
            if (HourOfDay.HasValue)
            {
                writer.WritePropertyName("hourOfDay"u8);
                writer.WriteNumberValue(HourOfDay.Value);
            }
            if (!(DaysOfWeek is ChangeTrackingList<ScheduledActionDaysOfWeek> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("daysOfWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfWeek)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(WeeksOfMonth is ChangeTrackingList<ScheduledActionWeeksOfMonth> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("weeksOfMonth"u8);
                writer.WriteStartArray();
                foreach (var item in WeeksOfMonth)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (DayOfMonth.HasValue)
            {
                writer.WritePropertyName("dayOfMonth"u8);
                writer.WriteNumberValue(DayOfMonth.Value);
            }
            writer.WritePropertyName("startDate"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("endDate"u8);
            writer.WriteStringValue(EndOn, "O");
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

        ScheduleProperties IJsonModel<ScheduleProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduleProperties(document.RootElement, options);
        }

        internal static ScheduleProperties DeserializeScheduleProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScheduleFrequency frequency = default;
            Optional<int> hourOfDay = default;
            IList<ScheduledActionDaysOfWeek> daysOfWeek = default;
            IList<ScheduledActionWeeksOfMonth> weeksOfMonth = default;
            Optional<int> dayOfMonth = default;
            DateTimeOffset startDate = default;
            DateTimeOffset endDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frequency"u8))
                {
                    frequency = new ScheduleFrequency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hourOfDay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hourOfDay = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("daysOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScheduledActionDaysOfWeek> array = new List<ScheduledActionDaysOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ScheduledActionDaysOfWeek(item.GetString()));
                    }
                    daysOfWeek = array;
                    continue;
                }
                if (property.NameEquals("weeksOfMonth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScheduledActionWeeksOfMonth> array = new List<ScheduledActionWeeksOfMonth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ScheduledActionWeeksOfMonth(item.GetString()));
                    }
                    weeksOfMonth = array;
                    continue;
                }
                if (property.NameEquals("dayOfMonth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfMonth = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDate"u8))
                {
                    endDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScheduleProperties(frequency, Optional.ToNullable(hourOfDay), daysOfWeek ?? new ChangeTrackingList<ScheduledActionDaysOfWeek>(), weeksOfMonth ?? new ChangeTrackingList<ScheduledActionWeeksOfMonth>(), Optional.ToNullable(dayOfMonth), startDate, endDate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScheduleProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduleProperties)} does not support '{options.Format}' format.");
            }
        }

        ScheduleProperties IPersistableModel<ScheduleProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduleProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduleProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduleProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
