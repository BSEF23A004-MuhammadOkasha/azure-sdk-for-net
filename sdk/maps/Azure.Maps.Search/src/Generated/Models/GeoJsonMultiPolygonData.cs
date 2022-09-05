// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Search.Models
{
    /// <summary> The GeoJsonMultiPolygonData. </summary>
    public partial class GeoJsonMultiPolygonData
    {
        /// <summary> Initializes a new instance of GeoJsonMultiPolygonData. </summary>
        /// <param name="coordinates"> Contains a list of valid `GeoJSON Polygon` objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonMultiPolygonData(IEnumerable<IList<IList<IList<double>>>> coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException(nameof(coordinates));
            }

            Coordinates = coordinates.ToList();
        }

        /// <summary> Initializes a new instance of GeoJsonMultiPolygonData. </summary>
        /// <param name="coordinates"> Contains a list of valid `GeoJSON Polygon` objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude). </param>
        internal GeoJsonMultiPolygonData(IList<IList<IList<IList<double>>>> coordinates)
        {
            Coordinates = coordinates;
        }

        /// <summary> Contains a list of valid `GeoJSON Polygon` objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude). </summary>
        public IList<IList<IList<IList<double>>>> Coordinates { get; }
    }
}
