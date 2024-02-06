// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class ScheduleBasedBackupCriteria : IUtf8JsonSerializable, IJsonModel<ScheduleBasedBackupCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduleBasedBackupCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduleBasedBackupCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleBasedBackupCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleBasedBackupCriteria)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AbsoluteCriteria))
            {
                writer.WritePropertyName("absoluteCriteria"u8);
                writer.WriteStartArray();
                foreach (var item in AbsoluteCriteria)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DaysOfMonth))
            {
                writer.WritePropertyName("daysOfMonth"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfMonth)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DaysOfWeek))
            {
                writer.WritePropertyName("daysOfTheWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfWeek)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonthsOfYear))
            {
                writer.WritePropertyName("monthsOfYear"u8);
                writer.WriteStartArray();
                foreach (var item in MonthsOfYear)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ScheduleTimes))
            {
                writer.WritePropertyName("scheduleTimes"u8);
                writer.WriteStartArray();
                foreach (var item in ScheduleTimes)
                {
                    writer.WriteStringValue(item, "O");
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WeeksOfMonth))
            {
                writer.WritePropertyName("weeksOfTheMonth"u8);
                writer.WriteStartArray();
                foreach (var item in WeeksOfMonth)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        ScheduleBasedBackupCriteria IJsonModel<ScheduleBasedBackupCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleBasedBackupCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleBasedBackupCriteria)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduleBasedBackupCriteria(document.RootElement, options);
        }

        internal static ScheduleBasedBackupCriteria DeserializeScheduleBasedBackupCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<BackupAbsoluteMarker>> absoluteCriteria = default;
            Optional<IList<DataProtectionBackupDay>> daysOfMonth = default;
            Optional<IList<DataProtectionBackupDayOfWeek>> daysOfTheWeek = default;
            Optional<IList<DataProtectionBackupMonth>> monthsOfYear = default;
            Optional<IList<DateTimeOffset>> scheduleTimes = default;
            Optional<IList<DataProtectionBackupWeekNumber>> weeksOfTheMonth = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("absoluteCriteria"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupAbsoluteMarker> array = new List<BackupAbsoluteMarker>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new BackupAbsoluteMarker(item.GetString()));
                    }
                    absoluteCriteria = array;
                    continue;
                }
                if (property.NameEquals("daysOfMonth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataProtectionBackupDay> array = new List<DataProtectionBackupDay>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProtectionBackupDay.DeserializeDataProtectionBackupDay(item));
                    }
                    daysOfMonth = array;
                    continue;
                }
                if (property.NameEquals("daysOfTheWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataProtectionBackupDayOfWeek> array = new List<DataProtectionBackupDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DataProtectionBackupDayOfWeek(item.GetString()));
                    }
                    daysOfTheWeek = array;
                    continue;
                }
                if (property.NameEquals("monthsOfYear"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataProtectionBackupMonth> array = new List<DataProtectionBackupMonth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DataProtectionBackupMonth(item.GetString()));
                    }
                    monthsOfYear = array;
                    continue;
                }
                if (property.NameEquals("scheduleTimes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    scheduleTimes = array;
                    continue;
                }
                if (property.NameEquals("weeksOfTheMonth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataProtectionBackupWeekNumber> array = new List<DataProtectionBackupWeekNumber>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DataProtectionBackupWeekNumber(item.GetString()));
                    }
                    weeksOfTheMonth = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScheduleBasedBackupCriteria(objectType, serializedAdditionalRawData, Optional.ToList(absoluteCriteria), Optional.ToList(daysOfMonth), Optional.ToList(daysOfTheWeek), Optional.ToList(monthsOfYear), Optional.ToList(scheduleTimes), Optional.ToList(weeksOfTheMonth));
        }

        BinaryData IPersistableModel<ScheduleBasedBackupCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleBasedBackupCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduleBasedBackupCriteria)} does not support '{options.Format}' format.");
            }
        }

        ScheduleBasedBackupCriteria IPersistableModel<ScheduleBasedBackupCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleBasedBackupCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduleBasedBackupCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduleBasedBackupCriteria)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduleBasedBackupCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
