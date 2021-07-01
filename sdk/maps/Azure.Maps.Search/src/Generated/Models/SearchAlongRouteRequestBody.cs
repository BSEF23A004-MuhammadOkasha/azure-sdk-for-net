// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Search.Models
{
    /// <summary> This type represents the request body for the Search Along Route service. </summary>
    public partial class SearchAlongRouteRequestBody
    {
        /// <summary> Initializes a new instance of SearchAlongRouteRequestBody. </summary>
        public SearchAlongRouteRequestBody()
        {
        }

        /// <summary> A valid `GeoJSON LineString` geometry type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.4) for details. </summary>
        public GeoJsonLineString Route { get; set; }
    }
}
