// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Route.Models
{
    /// <summary> This object is returned from a successful Route Directions call. </summary>
    public partial class RouteDirections
    {
        /// <summary> Initializes a new instance of RouteDirections. </summary>
        internal RouteDirections()
        {
            Routes = new ChangeTrackingList<RouteData>();
            OptimizedWaypoints = new ChangeTrackingList<RouteOptimizedWaypoint>();
        }

        /// <summary> Initializes a new instance of RouteDirections. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="routes"> Routes array. </param>
        /// <param name="optimizedWaypoints">
        /// Optimized sequence of waypoints. It shows the index from the user provided waypoint sequence for the original and optimized list. For instance, a response: 
        /// 
        /// ```
        /// &lt;optimizedWaypoints&gt;
        /// &lt;waypoint providedIndex=&quot;0&quot; optimizedIndex=&quot;1&quot;/&gt;
        /// &lt;waypoint providedIndex=&quot;1&quot; optimizedIndex=&quot;2&quot;/&gt;
        /// &lt;waypoint providedIndex=&quot;2&quot; optimizedIndex=&quot;0&quot;/&gt;
        /// &lt;/optimizedWaypoints&gt;
        /// ```
        /// 
        /// means that the original sequence is [0, 1, 2] and optimized sequence is [1, 2, 0]. Since the index starts by 0 the original is &quot;first, second, third&quot; while the optimized is &quot;second, third, first&quot;.
        /// </param>
        /// <param name="report"> Reports the effective settings used in the current call. </param>
        internal RouteDirections(string formatVersion, IReadOnlyList<RouteData> routes, IReadOnlyList<RouteOptimizedWaypoint> optimizedWaypoints, RouteReport report)
        {
            FormatVersion = formatVersion;
            Routes = routes;
            OptimizedWaypoints = optimizedWaypoints;
            Report = report;
        }

        /// <summary> Format Version property. </summary>
        public string FormatVersion { get; }
        /// <summary> Routes array. </summary>
        public IReadOnlyList<RouteData> Routes { get; }
        /// <summary>
        /// Optimized sequence of waypoints. It shows the index from the user provided waypoint sequence for the original and optimized list. For instance, a response: 
        /// 
        /// ```
        /// &lt;optimizedWaypoints&gt;
        /// &lt;waypoint providedIndex=&quot;0&quot; optimizedIndex=&quot;1&quot;/&gt;
        /// &lt;waypoint providedIndex=&quot;1&quot; optimizedIndex=&quot;2&quot;/&gt;
        /// &lt;waypoint providedIndex=&quot;2&quot; optimizedIndex=&quot;0&quot;/&gt;
        /// &lt;/optimizedWaypoints&gt;
        /// ```
        /// 
        /// means that the original sequence is [0, 1, 2] and optimized sequence is [1, 2, 0]. Since the index starts by 0 the original is &quot;first, second, third&quot; while the optimized is &quot;second, third, first&quot;.
        /// </summary>
        public IReadOnlyList<RouteOptimizedWaypoint> OptimizedWaypoints { get; }
        /// <summary> Reports the effective settings used in the current call. </summary>
        public RouteReport Report { get; }
    }
}
