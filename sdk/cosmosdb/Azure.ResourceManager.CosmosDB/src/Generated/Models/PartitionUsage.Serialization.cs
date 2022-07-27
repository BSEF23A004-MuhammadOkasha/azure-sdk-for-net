// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class PartitionUsage
    {
        internal static PartitionUsage DeserializePartitionUsage(JsonElement element)
        {
            Optional<Guid> partitionId = default;
            Optional<string> partitionKeyRangeId = default;
            Optional<CosmosDBMetricUnitType> unit = default;
            Optional<CosmosDBMetricName> name = default;
            Optional<string> quotaPeriod = default;
            Optional<long> limit = default;
            Optional<long> currentValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("partitionKeyRangeId"))
                {
                    partitionKeyRangeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unit = new CosmosDBMetricUnitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = CosmosDBMetricName.DeserializeCosmosDBMetricName(property.Value);
                    continue;
                }
                if (property.NameEquals("quotaPeriod"))
                {
                    quotaPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentValue = property.Value.GetInt64();
                    continue;
                }
            }
            return new PartitionUsage(Optional.ToNullable(unit), name.Value, quotaPeriod.Value, Optional.ToNullable(limit), Optional.ToNullable(currentValue), Optional.ToNullable(partitionId), partitionKeyRangeId.Value);
        }
    }
}
