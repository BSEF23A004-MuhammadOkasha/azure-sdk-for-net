// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class StatisticsListResult
    {
        internal static StatisticsListResult DeserializeStatisticsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Statistics>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Statistics> array = new List<Statistics>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Statistics.DeserializeStatistics(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new StatisticsListResult(Optional.ToList(value));
        }
    }
}
