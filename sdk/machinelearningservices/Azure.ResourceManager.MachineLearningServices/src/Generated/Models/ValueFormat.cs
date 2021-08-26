// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> format for the workspace connection value. </summary>
    public readonly partial struct ValueFormat : IEquatable<ValueFormat>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ValueFormat"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ValueFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JsonValue = "JSON";

        /// <summary> JSON. </summary>
        public static ValueFormat Json { get; } = new ValueFormat(JsonValue);
        /// <summary> Determines if two <see cref="ValueFormat"/> values are the same. </summary>
        public static bool operator ==(ValueFormat left, ValueFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ValueFormat"/> values are not the same. </summary>
        public static bool operator !=(ValueFormat left, ValueFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ValueFormat"/>. </summary>
        public static implicit operator ValueFormat(string value) => new ValueFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ValueFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ValueFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
