// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class Dimensions
    {
        internal static Dimensions DeserializeDimensions(JsonElement element)
        {
            Optional<double> length = default;
            Optional<double> height = default;
            Optional<double> width = default;
            Optional<LengthHeightUnit> lengthHeightUnit = default;
            Optional<double> weight = default;
            Optional<double> depth = default;
            Optional<WeightMeasurementUnit> weightUnit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("length"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    length = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("height"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    height = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("width"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    width = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("lengthHeightUnit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lengthHeightUnit = new LengthHeightUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("weight"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weight = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("depth"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    depth = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("weightUnit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weightUnit = new WeightMeasurementUnit(property.Value.GetString());
                    continue;
                }
            }
            return new Dimensions(Optional.ToNullable(length), Optional.ToNullable(height), Optional.ToNullable(width), Optional.ToNullable(lengthHeightUnit), Optional.ToNullable(weight), Optional.ToNullable(depth), Optional.ToNullable(weightUnit));
        }
    }
}
