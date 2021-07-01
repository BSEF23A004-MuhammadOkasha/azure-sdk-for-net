// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Weather.Models
{
    /// <summary> This object is returned from a successful Weather Along Route. </summary>
    public partial class WeatherAlongRouteResponse
    {
        /// <summary> Initializes a new instance of WeatherAlongRouteResponse. </summary>
        internal WeatherAlongRouteResponse()
        {
            Waypoints = new ChangeTrackingList<WeatherWaypoint>();
        }

        /// <summary> Initializes a new instance of WeatherAlongRouteResponse. </summary>
        /// <param name="summary"> Short summary of the weather along the route. </param>
        /// <param name="waypoints"> Data for each waypoint returned in the same order as specified in the request. </param>
        internal WeatherAlongRouteResponse(WeatherAlongRouteSummary summary, IReadOnlyList<WeatherWaypoint> waypoints)
        {
            Summary = summary;
            Waypoints = waypoints;
        }

        /// <summary> Short summary of the weather along the route. </summary>
        public WeatherAlongRouteSummary Summary { get; }
        /// <summary> Data for each waypoint returned in the same order as specified in the request. </summary>
        public IReadOnlyList<WeatherWaypoint> Waypoints { get; }
    }
}
