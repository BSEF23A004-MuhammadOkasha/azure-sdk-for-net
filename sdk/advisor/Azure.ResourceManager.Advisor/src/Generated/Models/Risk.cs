// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> The potential risk of not implementing the recommendation. </summary>
    public readonly partial struct Risk : IEquatable<Risk>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Risk"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Risk(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string WarningValue = "Warning";
        private const string NoneValue = "None";

        /// <summary> Error. </summary>
        public static Risk Error { get; } = new Risk(ErrorValue);
        /// <summary> Warning. </summary>
        public static Risk Warning { get; } = new Risk(WarningValue);
        /// <summary> None. </summary>
        public static Risk None { get; } = new Risk(NoneValue);
        /// <summary> Determines if two <see cref="Risk"/> values are the same. </summary>
        public static bool operator ==(Risk left, Risk right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Risk"/> values are not the same. </summary>
        public static bool operator !=(Risk left, Risk right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Risk"/>. </summary>
        public static implicit operator Risk(string value) => new Risk(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Risk other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Risk other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
