// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class ChangeThresholdCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("changePercentage");
            writer.WriteNumberValue(ChangePercentage);
            writer.WritePropertyName("shiftPoint");
            writer.WriteNumberValue(ShiftPoint);
            writer.WritePropertyName("withinRange");
            writer.WriteBooleanValue(IsWithinRange);
            writer.WritePropertyName("anomalyDetectorDirection");
            writer.WriteStringValue(AnomalyDetectorDirection.ToString());
            writer.WritePropertyName("suppressCondition");
            writer.WriteObjectValue(SuppressCondition);
            writer.WriteEndObject();
        }

        internal static ChangeThresholdCondition DeserializeChangeThresholdCondition(JsonElement element)
        {
            double changePercentage = default;
            int shiftPoint = default;
            bool withinRange = default;
            AnomalyDetectorDirection anomalyDetectorDirection = default;
            SuppressCondition suppressCondition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("changePercentage"))
                {
                    changePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("shiftPoint"))
                {
                    shiftPoint = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("withinRange"))
                {
                    withinRange = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("anomalyDetectorDirection"))
                {
                    anomalyDetectorDirection = new AnomalyDetectorDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("suppressCondition"))
                {
                    suppressCondition = Models.SuppressCondition.DeserializeSuppressCondition(property.Value);
                    continue;
                }
            }
            return new ChangeThresholdCondition(changePercentage, shiftPoint, withinRange, anomalyDetectorDirection, suppressCondition);
        }
    }
}
