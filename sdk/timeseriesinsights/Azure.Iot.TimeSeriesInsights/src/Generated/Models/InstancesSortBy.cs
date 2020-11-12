// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    /// <summary> Value to use for sorting of the time series instances before being returned by search instances call. When it is set to &apos;Rank&apos;, the returned instances are sorted based on the relevance. When it is set to &apos;DisplayName&apos;, the returned results are sorted based on the display name. Display name is the name of the instance if it exists, otherwise, display name is the time series ID. Default is &apos;Rank&apos;. </summary>
    public readonly partial struct InstancesSortBy : IEquatable<InstancesSortBy>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="InstancesSortBy"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InstancesSortBy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RankValue = "Rank";
        private const string DisplayNameValue = "DisplayName";

        /// <summary> Rank. </summary>
        public static InstancesSortBy Rank { get; } = new InstancesSortBy(RankValue);
        /// <summary> DisplayName. </summary>
        public static InstancesSortBy DisplayName { get; } = new InstancesSortBy(DisplayNameValue);
        /// <summary> Determines if two <see cref="InstancesSortBy"/> values are the same. </summary>
        public static bool operator ==(InstancesSortBy left, InstancesSortBy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InstancesSortBy"/> values are not the same. </summary>
        public static bool operator !=(InstancesSortBy left, InstancesSortBy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InstancesSortBy"/>. </summary>
        public static implicit operator InstancesSortBy(string value) => new InstancesSortBy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InstancesSortBy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InstancesSortBy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
