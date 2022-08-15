// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.Core;

namespace Azure.Maps.Route.Models
{
    /// <summary> A valid `GeoJSON` geometry object. The type must be one of the seven valid GeoJSON geometry types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon and GeometryCollection. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1) for details. </summary>
    [CodeGenModel("GeoJsonGeometry")]
    internal partial class GeoJsonGeometry : GeoJsonObject
    {
        /// <summary> Initializes a new instance of GeoJsonGeometry. </summary>
        public GeoJsonGeometry()
        {
            Type = GeoJsonObjectType.GeoJsonGeometryCollection;
        }
    }
}
