// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Creator.Models
{
    /// <summary> type of geometry returned. </summary>
    public readonly partial struct GeoJsonGeometryType : IEquatable<GeoJsonGeometryType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="GeoJsonGeometryType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GeoJsonGeometryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeoJsonPointValue = "Point";
        private const string GeoJsonMultiPointValue = "MultiPoint";
        private const string GeoJsonLineStringValue = "LineString";
        private const string GeoJsonMultiLineStringValue = "MultiLineString";
        private const string GeoJsonPolygonValue = "Polygon";
        private const string GeoJsonMultiPolygonValue = "MultiPolygon";
        private const string GeoJsonGeometryCollectionValue = "GeometryCollection";

        /// <summary> `GeoJSON Point` geometry. </summary>
        public static GeoJsonGeometryType GeoJsonPoint { get; } = new GeoJsonGeometryType(GeoJsonPointValue);
        /// <summary> `GeoJSON MultiPoint` geometry. </summary>
        public static GeoJsonGeometryType GeoJsonMultiPoint { get; } = new GeoJsonGeometryType(GeoJsonMultiPointValue);
        /// <summary> `GeoJSON LineString` geometry. </summary>
        public static GeoJsonGeometryType GeoJsonLineString { get; } = new GeoJsonGeometryType(GeoJsonLineStringValue);
        /// <summary> `GeoJSON MultiLineString` geometry. </summary>
        public static GeoJsonGeometryType GeoJsonMultiLineString { get; } = new GeoJsonGeometryType(GeoJsonMultiLineStringValue);
        /// <summary> `GeoJSON Polygon` geometry. </summary>
        public static GeoJsonGeometryType GeoJsonPolygon { get; } = new GeoJsonGeometryType(GeoJsonPolygonValue);
        /// <summary> `GeoJSON MultiPolygon` geometry. </summary>
        public static GeoJsonGeometryType GeoJsonMultiPolygon { get; } = new GeoJsonGeometryType(GeoJsonMultiPolygonValue);
        /// <summary> `GeoJSON GeometryCollection` geometry. </summary>
        public static GeoJsonGeometryType GeoJsonGeometryCollection { get; } = new GeoJsonGeometryType(GeoJsonGeometryCollectionValue);
        /// <summary> Determines if two <see cref="GeoJsonGeometryType"/> values are the same. </summary>
        public static bool operator ==(GeoJsonGeometryType left, GeoJsonGeometryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GeoJsonGeometryType"/> values are not the same. </summary>
        public static bool operator !=(GeoJsonGeometryType left, GeoJsonGeometryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GeoJsonGeometryType"/>. </summary>
        public static implicit operator GeoJsonGeometryType(string value) => new GeoJsonGeometryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GeoJsonGeometryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GeoJsonGeometryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
