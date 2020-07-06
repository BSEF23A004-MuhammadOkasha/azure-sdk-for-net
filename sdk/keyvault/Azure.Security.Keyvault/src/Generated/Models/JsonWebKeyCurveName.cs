// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.KeyVault.Models
{
    /// <summary> Elliptic curve name. For valid values, see JsonWebKeyCurveName. </summary>
    public readonly partial struct JsonWebKeyCurveName : IEquatable<JsonWebKeyCurveName>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JsonWebKeyCurveName"/> values are the same. </summary>
        public JsonWebKeyCurveName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string P256Value = "P-256";
        private const string P384Value = "P-384";
        private const string P521Value = "P-521";
        private const string P256KValue = "P-256K";

        /// <summary> The NIST P-256 elliptic curve, AKA SECG curve SECP256R1. </summary>
        public static JsonWebKeyCurveName P256 { get; } = new JsonWebKeyCurveName(P256Value);
        /// <summary> The NIST P-384 elliptic curve, AKA SECG curve SECP384R1. </summary>
        public static JsonWebKeyCurveName P384 { get; } = new JsonWebKeyCurveName(P384Value);
        /// <summary> The NIST P-521 elliptic curve, AKA SECG curve SECP521R1. </summary>
        public static JsonWebKeyCurveName P521 { get; } = new JsonWebKeyCurveName(P521Value);
        /// <summary> The SECG SECP256K1 elliptic curve. </summary>
        public static JsonWebKeyCurveName P256K { get; } = new JsonWebKeyCurveName(P256KValue);
        /// <summary> Determines if two <see cref="JsonWebKeyCurveName"/> values are the same. </summary>
        public static bool operator ==(JsonWebKeyCurveName left, JsonWebKeyCurveName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JsonWebKeyCurveName"/> values are not the same. </summary>
        public static bool operator !=(JsonWebKeyCurveName left, JsonWebKeyCurveName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JsonWebKeyCurveName"/>. </summary>
        public static implicit operator JsonWebKeyCurveName(string value) => new JsonWebKeyCurveName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JsonWebKeyCurveName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JsonWebKeyCurveName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
