// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The connector Availability Status. </summary>
    public readonly partial struct AvailabilityStatus : IEquatable<AvailabilityStatus>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="AvailabilityStatus"/>. </summary>
        public AvailabilityStatus(int value)
        {
            _value = value;
        }

        private const int _1Value = 1;

        /// <summary> 1. </summary>
        public static AvailabilityStatus _1 { get; } = new AvailabilityStatus(_1Value);
        /// <summary> Determines if two <see cref="AvailabilityStatus"/> values are the same. </summary>
        public static bool operator ==(AvailabilityStatus left, AvailabilityStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvailabilityStatus"/> values are not the same. </summary>
        public static bool operator !=(AvailabilityStatus left, AvailabilityStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvailabilityStatus"/>. </summary>
        public static implicit operator AvailabilityStatus(int value) => new AvailabilityStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvailabilityStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvailabilityStatus other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
