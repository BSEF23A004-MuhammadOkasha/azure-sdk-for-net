// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum to determine whether PublicNetworkAccess is Enabled or Disabled. </summary>
    public readonly partial struct PublicNetworkAccessType : IEquatable<PublicNetworkAccessType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PublicNetworkAccessType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PublicNetworkAccessType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static PublicNetworkAccessType Enabled { get; } = new PublicNetworkAccessType(EnabledValue);
        /// <summary> Disabled. </summary>
        public static PublicNetworkAccessType Disabled { get; } = new PublicNetworkAccessType(DisabledValue);
        /// <summary> Determines if two <see cref="PublicNetworkAccessType"/> values are the same. </summary>
        public static bool operator ==(PublicNetworkAccessType left, PublicNetworkAccessType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PublicNetworkAccessType"/> values are not the same. </summary>
        public static bool operator !=(PublicNetworkAccessType left, PublicNetworkAccessType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PublicNetworkAccessType"/>. </summary>
        public static implicit operator PublicNetworkAccessType(string value) => new PublicNetworkAccessType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PublicNetworkAccessType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PublicNetworkAccessType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
