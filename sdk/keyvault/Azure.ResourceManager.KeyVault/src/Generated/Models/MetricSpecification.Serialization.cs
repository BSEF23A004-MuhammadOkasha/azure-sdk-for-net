// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault
{
    public partial class MetricSpecification
    {
        internal static MetricSpecification DeserializeMetricSpecification(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<string> displayDescription = default;
            Optional<string> unit = default;
            Optional<string> aggregationType = default;
            Optional<IReadOnlyList<string>> supportedAggregationTypes = default;
            Optional<IReadOnlyList<string>> supportedTimeGrainTypes = default;
            Optional<string> lockAggregationType = default;
            Optional<IReadOnlyList<DimensionProperties>> dimensions = default;
            Optional<bool> fillGapWithZero = default;
            Optional<string> internalMetricName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayDescription"))
                {
                    displayDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregationType"))
                {
                    aggregationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedAggregationTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedAggregationTypes = array;
                    continue;
                }
                if (property.NameEquals("supportedTimeGrainTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedTimeGrainTypes = array;
                    continue;
                }
                if (property.NameEquals("lockAggregationType"))
                {
                    lockAggregationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DimensionProperties> array = new List<DimensionProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DimensionProperties.DeserializeDimensionProperties(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("fillGapWithZero"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fillGapWithZero = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("internalMetricName"))
                {
                    internalMetricName = property.Value.GetString();
                    continue;
                }
            }
            return new MetricSpecification(name.Value, displayName.Value, displayDescription.Value, unit.Value, aggregationType.Value, Optional.ToList(supportedAggregationTypes), Optional.ToList(supportedTimeGrainTypes), lockAggregationType.Value, Optional.ToList(dimensions), Optional.ToNullable(fillGapWithZero), internalMetricName.Value);
        }
    }
}
