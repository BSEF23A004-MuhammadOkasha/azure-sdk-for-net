// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class DerivedMetricInfo
    {
        internal static DerivedMetricInfo DeserializeDerivedMetricInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> telemetryType = default;
            IReadOnlyList<FilterConjunctionGroupInfo> filterGroups = default;
            Optional<string> projection = default;
            Optional<DerivedMetricInfoAggregation> aggregation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("TelemetryType"u8))
                {
                    telemetryType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("FilterGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FilterConjunctionGroupInfo> array = new List<FilterConjunctionGroupInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FilterConjunctionGroupInfo.DeserializeFilterConjunctionGroupInfo(item));
                    }
                    filterGroups = array;
                    continue;
                }
                if (property.NameEquals("Projection"u8))
                {
                    projection = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Aggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aggregation = new DerivedMetricInfoAggregation(property.Value.GetString());
                    continue;
                }
            }
            return new DerivedMetricInfo(id.Value, telemetryType.Value, filterGroups ?? new ChangeTrackingList<FilterConjunctionGroupInfo>(), projection.Value, Optional.ToNullable(aggregation));
        }
    }
}
