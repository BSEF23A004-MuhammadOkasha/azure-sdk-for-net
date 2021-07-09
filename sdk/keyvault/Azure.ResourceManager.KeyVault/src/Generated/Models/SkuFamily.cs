// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> SKU family name. </summary>
    public readonly partial struct SkuFamily : IEquatable<SkuFamily>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SkuFamily"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SkuFamily(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AValue = "A";

        /// <summary> A. </summary>
        public static SkuFamily A { get; } = new SkuFamily(AValue);
        /// <summary> Determines if two <see cref="SkuFamily"/> values are the same. </summary>
        public static bool operator ==(SkuFamily left, SkuFamily right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SkuFamily"/> values are not the same. </summary>
        public static bool operator !=(SkuFamily left, SkuFamily right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SkuFamily"/>. </summary>
        public static implicit operator SkuFamily(string value) => new SkuFamily(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SkuFamily other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SkuFamily other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
