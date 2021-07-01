// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Route.Models
{
    /// <summary> The magnitude of delay caused by the incident. These values correspond to the values of the response field ty of the [Get Traffic Incident Detail API](https://docs.microsoft.com/rest/api/maps/traffic/gettrafficincidentdetail). </summary>
    public readonly partial struct MagnitudeOfDelay : IEquatable<MagnitudeOfDelay>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="MagnitudeOfDelay"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MagnitudeOfDelay(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ZeroValue = "0";
        private const string OneValue = "1";
        private const string TwoValue = "2";
        private const string ThreeValue = "3";
        private const string FourValue = "4";

        /// <summary> Unknown. </summary>
        public static MagnitudeOfDelay Zero { get; } = new MagnitudeOfDelay(ZeroValue);
        /// <summary> Minor. </summary>
        public static MagnitudeOfDelay One { get; } = new MagnitudeOfDelay(OneValue);
        /// <summary> Moderate. </summary>
        public static MagnitudeOfDelay Two { get; } = new MagnitudeOfDelay(TwoValue);
        /// <summary> Major. </summary>
        public static MagnitudeOfDelay Three { get; } = new MagnitudeOfDelay(ThreeValue);
        /// <summary> Undefined, used for road closures and other indefinite delays. </summary>
        public static MagnitudeOfDelay Four { get; } = new MagnitudeOfDelay(FourValue);
        /// <summary> Determines if two <see cref="MagnitudeOfDelay"/> values are the same. </summary>
        public static bool operator ==(MagnitudeOfDelay left, MagnitudeOfDelay right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MagnitudeOfDelay"/> values are not the same. </summary>
        public static bool operator !=(MagnitudeOfDelay left, MagnitudeOfDelay right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MagnitudeOfDelay"/>. </summary>
        public static implicit operator MagnitudeOfDelay(string value) => new MagnitudeOfDelay(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MagnitudeOfDelay other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MagnitudeOfDelay other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
