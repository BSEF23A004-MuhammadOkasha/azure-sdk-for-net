// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The ChangePointValue. </summary>
    public readonly partial struct ChangePointValue : IEquatable<ChangePointValue>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ChangePointValue"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChangePointValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoDetectValue = "AutoDetect";
        private const string ChangePointValue1 = "ChangePoint";
        private const string NotChangePointValue = "NotChangePoint";

        /// <summary> AutoDetect. </summary>
        public static ChangePointValue AutoDetect { get; } = new ChangePointValue(AutoDetectValue);
        /// <summary> ChangePoint. </summary>
        public static ChangePointValue ChangePoint { get; } = new ChangePointValue(ChangePointValue1);
        /// <summary> NotChangePoint. </summary>
        public static ChangePointValue NotChangePoint { get; } = new ChangePointValue(NotChangePointValue);
        /// <summary> Determines if two <see cref="ChangePointValue"/> values are the same. </summary>
        public static bool operator ==(ChangePointValue left, ChangePointValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ChangePointValue"/> values are not the same. </summary>
        public static bool operator !=(ChangePointValue left, ChangePointValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ChangePointValue"/>. </summary>
        public static implicit operator ChangePointValue(string value) => new ChangePointValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChangePointValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ChangePointValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
