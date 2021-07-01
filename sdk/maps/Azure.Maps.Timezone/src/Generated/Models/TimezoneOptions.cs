// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Timezone.Models
{
    /// <summary> The TimezoneOptions. </summary>
    public readonly partial struct TimezoneOptions : IEquatable<TimezoneOptions>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TimezoneOptions"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TimezoneOptions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string ZoneInfoValue = "zoneInfo";
        private const string TransitionsValue = "transitions";
        private const string AllValue = "all";

        /// <summary> Do not include zoneinfo or transitions in the result. </summary>
        public static TimezoneOptions None { get; } = new TimezoneOptions(NoneValue);
        /// <summary> Include additional time zone info in the result. </summary>
        public static TimezoneOptions ZoneInfo { get; } = new TimezoneOptions(ZoneInfoValue);
        /// <summary> Include transition information in the result (The number of transitions is currently capped at 250). </summary>
        public static TimezoneOptions Transitions { get; } = new TimezoneOptions(TransitionsValue);
        /// <summary> Include both zoneinfo and transitions in the result. </summary>
        public static TimezoneOptions All { get; } = new TimezoneOptions(AllValue);
        /// <summary> Determines if two <see cref="TimezoneOptions"/> values are the same. </summary>
        public static bool operator ==(TimezoneOptions left, TimezoneOptions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TimezoneOptions"/> values are not the same. </summary>
        public static bool operator !=(TimezoneOptions left, TimezoneOptions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TimezoneOptions"/>. </summary>
        public static implicit operator TimezoneOptions(string value) => new TimezoneOptions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TimezoneOptions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TimezoneOptions other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
