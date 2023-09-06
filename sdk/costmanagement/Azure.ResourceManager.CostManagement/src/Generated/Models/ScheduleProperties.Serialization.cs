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

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ScheduleProperties : IUtf8JsonSerializable, IModelJsonSerializable<ScheduleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScheduleProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScheduleProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScheduleProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("frequency"u8);
            writer.WriteStringValue(Frequency.ToString());
            if (Optional.IsDefined(HourOfDay))
            {
                writer.WritePropertyName("hourOfDay"u8);
                writer.WriteNumberValue(HourOfDay.Value);
            }
            if (Optional.IsCollectionDefined(DaysOfWeek))
            {
                writer.WritePropertyName("daysOfWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfWeek)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WeeksOfMonth))
            {
                writer.WritePropertyName("weeksOfMonth"u8);
                writer.WriteStartArray();
                foreach (var item in WeeksOfMonth)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DayOfMonth))
            {
                writer.WritePropertyName("dayOfMonth"u8);
                writer.WriteNumberValue(DayOfMonth.Value);
            }
            writer.WritePropertyName("startDate"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("endDate"u8);
            writer.WriteStringValue(EndOn, "O");
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

        internal static ScheduleProperties DeserializeScheduleProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScheduleFrequency frequency = default;
            Optional<int> hourOfDay = default;
            Optional<IList<ScheduledActionDaysOfWeek>> daysOfWeek = default;
            Optional<IList<ScheduledActionWeeksOfMonth>> weeksOfMonth = default;
            Optional<int> dayOfMonth = default;
            DateTimeOffset startDate = default;
            DateTimeOffset endDate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ScheduleProperties(frequency, Optional.ToNullable(hourOfDay), Optional.ToList(daysOfWeek), Optional.ToList(weeksOfMonth), Optional.ToNullable(dayOfMonth), startDate, endDate, rawData);
        }

        ScheduleProperties IModelJsonSerializable<ScheduleProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScheduleProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduleProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScheduleProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScheduleProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScheduleProperties IModelSerializable<ScheduleProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScheduleProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScheduleProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScheduleProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScheduleProperties"/> to convert. </param>
        public static implicit operator RequestContent(ScheduleProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScheduleProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScheduleProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScheduleProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
