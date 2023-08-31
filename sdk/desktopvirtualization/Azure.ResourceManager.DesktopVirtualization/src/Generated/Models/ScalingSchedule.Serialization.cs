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

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ScalingSchedule : IUtf8JsonSerializable, IModelJsonSerializable<ScalingSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScalingSchedule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScalingSchedule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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
            if (Optional.IsDefined(RampUpStartTime))
            {
                writer.WritePropertyName("rampUpStartTime"u8);
                if (RampUpStartTime is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ScalingActionTime>)RampUpStartTime).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RampUpLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("rampUpLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(RampUpLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampUpMinimumHostsPct))
            {
                writer.WritePropertyName("rampUpMinimumHostsPct"u8);
                writer.WriteNumberValue(RampUpMinimumHostsPct.Value);
            }
            if (Optional.IsDefined(RampUpCapacityThresholdPct))
            {
                writer.WritePropertyName("rampUpCapacityThresholdPct"u8);
                writer.WriteNumberValue(RampUpCapacityThresholdPct.Value);
            }
            if (Optional.IsDefined(PeakStartTime))
            {
                writer.WritePropertyName("peakStartTime"u8);
                if (PeakStartTime is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ScalingActionTime>)PeakStartTime).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PeakLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("peakLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(PeakLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampDownStartTime))
            {
                writer.WritePropertyName("rampDownStartTime"u8);
                if (RampDownStartTime is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ScalingActionTime>)RampDownStartTime).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RampDownLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("rampDownLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(RampDownLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampDownMinimumHostsPct))
            {
                writer.WritePropertyName("rampDownMinimumHostsPct"u8);
                writer.WriteNumberValue(RampDownMinimumHostsPct.Value);
            }
            if (Optional.IsDefined(RampDownCapacityThresholdPct))
            {
                writer.WritePropertyName("rampDownCapacityThresholdPct"u8);
                writer.WriteNumberValue(RampDownCapacityThresholdPct.Value);
            }
            if (Optional.IsDefined(RampDownForceLogoffUsers))
            {
                writer.WritePropertyName("rampDownForceLogoffUsers"u8);
                writer.WriteBooleanValue(RampDownForceLogoffUsers.Value);
            }
            if (Optional.IsDefined(RampDownStopHostsWhen))
            {
                writer.WritePropertyName("rampDownStopHostsWhen"u8);
                writer.WriteStringValue(RampDownStopHostsWhen.Value.ToString());
            }
            if (Optional.IsDefined(RampDownWaitTimeMinutes))
            {
                writer.WritePropertyName("rampDownWaitTimeMinutes"u8);
                writer.WriteNumberValue(RampDownWaitTimeMinutes.Value);
            }
            if (Optional.IsDefined(RampDownNotificationMessage))
            {
                writer.WritePropertyName("rampDownNotificationMessage"u8);
                writer.WriteStringValue(RampDownNotificationMessage);
            }
            if (Optional.IsDefined(OffPeakStartTime))
            {
                writer.WritePropertyName("offPeakStartTime"u8);
                if (OffPeakStartTime is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ScalingActionTime>)OffPeakStartTime).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OffPeakLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("offPeakLoadBalancingAlgorithm"u8);
                writer.WriteStringValue(OffPeakLoadBalancingAlgorithm.Value.ToString());
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

        internal static ScalingSchedule DeserializeScalingSchedule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IList<ScalingScheduleDaysOfWeekItem>> daysOfWeek = default;
            Optional<ScalingActionTime> rampUpStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> rampUpLoadBalancingAlgorithm = default;
            Optional<int> rampUpMinimumHostsPct = default;
            Optional<int> rampUpCapacityThresholdPct = default;
            Optional<ScalingActionTime> peakStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> peakLoadBalancingAlgorithm = default;
            Optional<ScalingActionTime> rampDownStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> rampDownLoadBalancingAlgorithm = default;
            Optional<int> rampDownMinimumHostsPct = default;
            Optional<int> rampDownCapacityThresholdPct = default;
            Optional<bool> rampDownForceLogoffUsers = default;
            Optional<DesktopVirtualizationStopHostsWhen> rampDownStopHostsWhen = default;
            Optional<int> rampDownWaitTimeMinutes = default;
            Optional<string> rampDownNotificationMessage = default;
            Optional<ScalingActionTime> offPeakStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> offPeakLoadBalancingAlgorithm = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("daysOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScalingScheduleDaysOfWeekItem> array = new List<ScalingScheduleDaysOfWeekItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ScalingScheduleDaysOfWeekItem(item.GetString()));
                    }
                    daysOfWeek = array;
                    continue;
                }
                if (property.NameEquals("rampUpStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampUpStartTime = ScalingActionTime.DeserializeScalingActionTime(property.Value);
                    continue;
                }
                if (property.NameEquals("rampUpLoadBalancingAlgorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampUpLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rampUpMinimumHostsPct"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampUpMinimumHostsPct = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rampUpCapacityThresholdPct"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampUpCapacityThresholdPct = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("peakStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peakStartTime = ScalingActionTime.DeserializeScalingActionTime(property.Value);
                    continue;
                }
                if (property.NameEquals("peakLoadBalancingAlgorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peakLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rampDownStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampDownStartTime = ScalingActionTime.DeserializeScalingActionTime(property.Value);
                    continue;
                }
                if (property.NameEquals("rampDownLoadBalancingAlgorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampDownLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rampDownMinimumHostsPct"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampDownMinimumHostsPct = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rampDownCapacityThresholdPct"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampDownCapacityThresholdPct = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rampDownForceLogoffUsers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampDownForceLogoffUsers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rampDownStopHostsWhen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampDownStopHostsWhen = new DesktopVirtualizationStopHostsWhen(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rampDownWaitTimeMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampDownWaitTimeMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rampDownNotificationMessage"u8))
                {
                    rampDownNotificationMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offPeakStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offPeakStartTime = ScalingActionTime.DeserializeScalingActionTime(property.Value);
                    continue;
                }
                if (property.NameEquals("offPeakLoadBalancingAlgorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offPeakLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ScalingSchedule(name.Value, Optional.ToList(daysOfWeek), rampUpStartTime.Value, Optional.ToNullable(rampUpLoadBalancingAlgorithm), Optional.ToNullable(rampUpMinimumHostsPct), Optional.ToNullable(rampUpCapacityThresholdPct), peakStartTime.Value, Optional.ToNullable(peakLoadBalancingAlgorithm), rampDownStartTime.Value, Optional.ToNullable(rampDownLoadBalancingAlgorithm), Optional.ToNullable(rampDownMinimumHostsPct), Optional.ToNullable(rampDownCapacityThresholdPct), Optional.ToNullable(rampDownForceLogoffUsers), Optional.ToNullable(rampDownStopHostsWhen), Optional.ToNullable(rampDownWaitTimeMinutes), rampDownNotificationMessage.Value, offPeakStartTime.Value, Optional.ToNullable(offPeakLoadBalancingAlgorithm), rawData);
        }

        ScalingSchedule IModelJsonSerializable<ScalingSchedule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScalingSchedule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScalingSchedule>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScalingSchedule IModelSerializable<ScalingSchedule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScalingSchedule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScalingSchedule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScalingSchedule"/> to convert. </param>
        public static implicit operator RequestContent(ScalingSchedule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScalingSchedule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScalingSchedule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScalingSchedule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
