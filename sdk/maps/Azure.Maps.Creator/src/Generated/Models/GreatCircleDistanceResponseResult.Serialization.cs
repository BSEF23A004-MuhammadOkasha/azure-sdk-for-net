// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    public partial class GreatCircleDistanceResponseResult
    {
        internal static GreatCircleDistanceResponseResult DeserializeGreatCircleDistanceResponseResult(JsonElement element)
        {
            Optional<float> distanceInMeters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("distanceInMeters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    distanceInMeters = property.Value.GetSingle();
                    continue;
                }
            }
            return new GreatCircleDistanceResponseResult(Optional.ToNullable(distanceInMeters));
        }
    }
}
