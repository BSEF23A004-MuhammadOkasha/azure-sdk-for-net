// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SimpleSchedulePolicyV2 : IUtf8JsonSerializable, IJsonModel<SimpleSchedulePolicyV2>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SimpleSchedulePolicyV2>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SimpleSchedulePolicyV2>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicyV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ScheduleRunFrequency))
            {
                writer.WritePropertyName("scheduleRunFrequency"u8);
                writer.WriteStringValue(ScheduleRunFrequency.Value.ToString());
            }
            if (Optional.IsDefined(HourlySchedule))
            {
                writer.WritePropertyName("hourlySchedule"u8);
                writer.WriteObjectValue(HourlySchedule, options);
            }
            if (Optional.IsDefined(DailySchedule))
            {
                writer.WritePropertyName("dailySchedule"u8);
                writer.WriteObjectValue(DailySchedule, options);
            }
            if (Optional.IsDefined(WeeklySchedule))
            {
                writer.WritePropertyName("weeklySchedule"u8);
                writer.WriteObjectValue(WeeklySchedule, options);
            }
        }

        SimpleSchedulePolicyV2 IJsonModel<SimpleSchedulePolicyV2>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicyV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSimpleSchedulePolicyV2(document.RootElement, options);
        }

        internal static SimpleSchedulePolicyV2 DeserializeSimpleSchedulePolicyV2(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScheduleRunType? scheduleRunFrequency = default;
            BackupHourlySchedule hourlySchedule = default;
            BackupDailySchedule dailySchedule = default;
            BackupWeeklySchedule weeklySchedule = default;
            string schedulePolicyType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleRunFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleRunFrequency = new ScheduleRunType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hourlySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hourlySchedule = BackupHourlySchedule.DeserializeBackupHourlySchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dailySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dailySchedule = BackupDailySchedule.DeserializeBackupDailySchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("weeklySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weeklySchedule = BackupWeeklySchedule.DeserializeBackupWeeklySchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("schedulePolicyType"u8))
                {
                    schedulePolicyType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SimpleSchedulePolicyV2(
                schedulePolicyType,
                serializedAdditionalRawData,
                scheduleRunFrequency,
                hourlySchedule,
                dailySchedule,
                weeklySchedule);
        }

        BinaryData IPersistableModel<SimpleSchedulePolicyV2>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicyV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support writing '{options.Format}' format.");
            }
        }

        SimpleSchedulePolicyV2 IPersistableModel<SimpleSchedulePolicyV2>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimpleSchedulePolicyV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSimpleSchedulePolicyV2(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SimpleSchedulePolicyV2>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
