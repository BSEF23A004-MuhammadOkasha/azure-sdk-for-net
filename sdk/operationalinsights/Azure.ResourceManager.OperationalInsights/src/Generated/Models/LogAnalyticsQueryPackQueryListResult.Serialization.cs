// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal partial class LogAnalyticsQueryPackQueryListResult
    {
        internal static LogAnalyticsQueryPackQueryListResult DeserializeLogAnalyticsQueryPackQueryListResult(JsonElement element)
        {
            IReadOnlyList<LogAnalyticsQueryPackQueryData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<LogAnalyticsQueryPackQueryData> array = new List<LogAnalyticsQueryPackQueryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogAnalyticsQueryPackQueryData.DeserializeLogAnalyticsQueryPackQueryData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LogAnalyticsQueryPackQueryListResult(value, nextLink.Value);
        }
    }
}
