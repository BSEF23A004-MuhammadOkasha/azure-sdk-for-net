// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Route.Models
{
    public partial class GetRouteRangeResponse
    {
        internal static GetRouteRangeResponse DeserializeGetRouteRangeResponse(JsonElement element)
        {
            Optional<string> formatVersion = default;
            Optional<RouteRange> reachableRange = default;
            Optional<RouteResponseReport> report = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatVersion"))
                {
                    formatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reachableRange"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reachableRange = RouteRange.DeserializeRouteRange(property.Value);
                    continue;
                }
                if (property.NameEquals("report"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    report = RouteResponseReport.DeserializeRouteResponseReport(property.Value);
                    continue;
                }
            }
            return new GetRouteRangeResponse(formatVersion.Value, reachableRange.Value, report.Value);
        }
    }
}
