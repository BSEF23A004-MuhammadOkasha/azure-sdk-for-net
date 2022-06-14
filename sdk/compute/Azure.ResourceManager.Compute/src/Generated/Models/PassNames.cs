// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The pass name. Currently, the only allowable value is OobeSystem. </summary>
    public readonly partial struct PassNames : IEquatable<PassNames>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PassNames"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PassNames(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OobeSystemValue = "OobeSystem";

        /// <summary> OobeSystem. </summary>
        public static PassNames OobeSystem { get; } = new PassNames(OobeSystemValue);
        /// <summary> Determines if two <see cref="PassNames"/> values are the same. </summary>
        public static bool operator ==(PassNames left, PassNames right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PassNames"/> values are not the same. </summary>
        public static bool operator !=(PassNames left, PassNames right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PassNames"/>. </summary>
        public static implicit operator PassNames(string value) => new PassNames(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PassNames other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PassNames other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
