// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Search.Models
{
    /// <summary>
    /// One of:
    /// * POI
    /// * Street
    /// * Geography
    /// * Point Address
    /// * Address Range
    /// * Cross Street
    /// </summary>
    public readonly partial struct SearchAddressResultType : IEquatable<SearchAddressResultType>
    {

        private const string PointOfInterestValue = "POI";
        private const string StreetValue = "Street";
        private const string GeographyValue = "Geography";
        private const string PointAddressValue = "Point Address";
        private const string AddressRangeValue = "Address Range";
        private const string CrossStreetValue = "Cross Street";
        /// <summary> Street. </summary>
        public static SearchAddressResultType Street { get; } = new SearchAddressResultType(StreetValue);
        /// <summary> Geography. </summary>
        public static SearchAddressResultType Geography { get; } = new SearchAddressResultType(GeographyValue);
        /// <summary> Point Address. </summary>
        public static SearchAddressResultType PointAddress { get; } = new SearchAddressResultType(PointAddressValue);
        /// <summary> Address Range. </summary>
        public static SearchAddressResultType AddressRange { get; } = new SearchAddressResultType(AddressRangeValue);
        /// <summary> Cross Street. </summary>
        public static SearchAddressResultType CrossStreet { get; } = new SearchAddressResultType(CrossStreetValue);
        /// <summary> Determines if two <see cref="SearchAddressResultType"/> values are the same. </summary>
        public static bool operator ==(SearchAddressResultType left, SearchAddressResultType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SearchAddressResultType"/> values are not the same. </summary>
        public static bool operator !=(SearchAddressResultType left, SearchAddressResultType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SearchAddressResultType"/>. </summary>
        public static implicit operator SearchAddressResultType(string value) => new SearchAddressResultType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SearchAddressResultType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SearchAddressResultType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
