// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class UnknownVariable
    {
        internal static UnknownVariable DeserializeUnknownVariable(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = "Unknown";
            Optional<TimeSeriesExpression> filter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
            }
            return new UnknownVariable(kind, filter.Value);
        }
    }
}
