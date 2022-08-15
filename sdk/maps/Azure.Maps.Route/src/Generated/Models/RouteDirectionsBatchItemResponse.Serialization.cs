// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Route.Models
{
    public partial class RouteDirectionsBatchItemResponse
    {
        internal static RouteDirectionsBatchItemResponse DeserializeRouteDirectionsBatchItemResponse(JsonElement element)
        {
            Optional<ErrorDetail> error = default;
            Optional<string> formatVersion = default;
            Optional<IReadOnlyList<RouteData>> routes = default;
            Optional<IReadOnlyList<RouteOptimizedWaypoint>> optimizedWaypoints = default;
            Optional<RouteReport> report = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = Models.ErrorDetail.DeserializeErrorDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("formatVersion"))
                {
                    formatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RouteData> array = new List<RouteData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteData.DeserializeRouteData(item));
                    }
                    routes = array;
                    continue;
                }
                if (property.NameEquals("optimizedWaypoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RouteOptimizedWaypoint> array = new List<RouteOptimizedWaypoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteOptimizedWaypoint.DeserializeRouteOptimizedWaypoint(item));
                    }
                    optimizedWaypoints = array;
                    continue;
                }
                if (property.NameEquals("report"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    report = RouteReport.DeserializeRouteReport(property.Value);
                    continue;
                }
            }
            return new RouteDirectionsBatchItemResponse(formatVersion.Value, Optional.ToList(routes), Optional.ToList(optimizedWaypoints), report.Value, error.Value);
        }
    }
}
