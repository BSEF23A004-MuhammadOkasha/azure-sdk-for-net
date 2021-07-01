// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Route.Models
{
    /// <summary> The RouteDirectionsResult. </summary>
    public partial class RouteDirectionsResult
    {
        /// <summary> Initializes a new instance of RouteDirectionsResult. </summary>
        internal RouteDirectionsResult()
        {
            Legs = new ChangeTrackingList<RouteResultLeg>();
            Sections = new ChangeTrackingList<RouteResultSection>();
        }

        /// <summary> Initializes a new instance of RouteDirectionsResult. </summary>
        /// <param name="summary"> Summary object. </param>
        /// <param name="legs"> Legs array. </param>
        /// <param name="sections"> Sections array. </param>
        /// <param name="guidance"> Contains guidance related elements. This field is present only when guidance was requested and is available. </param>
        internal RouteDirectionsResult(RouteDirectionsSummary summary, IReadOnlyList<RouteResultLeg> legs, IReadOnlyList<RouteResultSection> sections, RouteResultGuidance guidance)
        {
            Summary = summary;
            Legs = legs;
            Sections = sections;
            Guidance = guidance;
        }

        /// <summary> Summary object. </summary>
        public RouteDirectionsSummary Summary { get; }
        /// <summary> Legs array. </summary>
        public IReadOnlyList<RouteResultLeg> Legs { get; }
        /// <summary> Sections array. </summary>
        public IReadOnlyList<RouteResultSection> Sections { get; }
        /// <summary> Contains guidance related elements. This field is present only when guidance was requested and is available. </summary>
        public RouteResultGuidance Guidance { get; }
    }
}
