// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal partial class CustomForecastHorizon : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value");
            writer.WriteNumberValue(Value);
            writer.WritePropertyName("mode");
            writer.WriteStringValue(Mode.ToString());
            writer.WriteEndObject();
        }

        internal static CustomForecastHorizon DeserializeCustomForecastHorizon(JsonElement element)
        {
            int value = default;
            ForecastHorizonMode mode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mode"))
                {
                    mode = new ForecastHorizonMode(property.Value.GetString());
                    continue;
                }
            }
            return new CustomForecastHorizon(mode, value);
        }
    }
}
