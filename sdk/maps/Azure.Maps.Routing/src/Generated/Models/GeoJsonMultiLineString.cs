// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    /// <summary> A valid `GeoJSON MultiLineString` geometry type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.5) for details. </summary>
    internal partial class GeoJsonMultiLineString : GeoJsonGeometry
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiLineString"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiLineString` geometry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonMultiLineString(IEnumerable<IList<IList<double>>> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Coordinates = coordinates.ToList();
            Type = GeoJsonObjectType.GeoJsonMultiLineString;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonMultiLineString"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiLineString` geometry. </param>
        internal GeoJsonMultiLineString(GeoJsonObjectType type, IList<IList<IList<double>>> coordinates) : base(type)
        {
            Coordinates = coordinates;
            Type = type;
        }

        /// <summary> Coordinates for the `GeoJson MultiLineString` geometry. </summary>
        public IList<IList<IList<double>>> Coordinates { get; }
    }
}
