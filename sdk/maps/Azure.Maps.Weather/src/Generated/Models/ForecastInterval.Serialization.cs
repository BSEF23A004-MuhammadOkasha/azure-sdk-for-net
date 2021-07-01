// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Weather.Models
{
    public partial class ForecastInterval
    {
        internal static ForecastInterval DeserializeForecastInterval(JsonElement element)
        {
            Optional<string> startTime = default;
            Optional<int> minute = default;
            Optional<double> dbz = default;
            Optional<string> shortPhrase = default;
            Optional<string> threshold = default;
            Optional<ColorValue> color = default;
            Optional<ColorValue> simplifiedColor = default;
            Optional<string> precipitationType = default;
            Optional<int> iconCode = default;
            Optional<int> cloudCover = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minute = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dbz"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dbz = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("shortPhrase"))
                {
                    shortPhrase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threshold"))
                {
                    threshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("color"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    color = ColorValue.DeserializeColorValue(property.Value);
                    continue;
                }
                if (property.NameEquals("simplifiedColor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    simplifiedColor = ColorValue.DeserializeColorValue(property.Value);
                    continue;
                }
                if (property.NameEquals("precipitationType"))
                {
                    precipitationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iconCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    iconCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cloudCover"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cloudCover = property.Value.GetInt32();
                    continue;
                }
            }
            return new ForecastInterval(startTime.Value, Optional.ToNullable(minute), Optional.ToNullable(dbz), shortPhrase.Value, threshold.Value, color.Value, simplifiedColor.Value, precipitationType.Value, Optional.ToNullable(iconCode), Optional.ToNullable(cloudCover));
        }
    }
}
