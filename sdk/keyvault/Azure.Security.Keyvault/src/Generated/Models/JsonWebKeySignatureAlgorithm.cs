// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.KeyVault.Models
{
    /// <summary> The signing/verification algorithm identifier. For more information on possible algorithm types, see JsonWebKeySignatureAlgorithm. </summary>
    public readonly partial struct JsonWebKeySignatureAlgorithm : IEquatable<JsonWebKeySignatureAlgorithm>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JsonWebKeySignatureAlgorithm"/> values are the same. </summary>
        public JsonWebKeySignatureAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PS256Value = "PS256";
        private const string PS384Value = "PS384";
        private const string PS512Value = "PS512";
        private const string RS256Value = "RS256";
        private const string RS384Value = "RS384";
        private const string RS512Value = "RS512";
        private const string RsnullValue = "RSNULL";
        private const string ES256Value = "ES256";
        private const string ES384Value = "ES384";
        private const string ES512Value = "ES512";
        private const string ES256KValue = "ES256K";

        /// <summary> RSASSA-PSS using SHA-256 and MGF1 with SHA-256, as described in https://tools.ietf.org/html/rfc7518. </summary>
        public static JsonWebKeySignatureAlgorithm PS256 { get; } = new JsonWebKeySignatureAlgorithm(PS256Value);
        /// <summary> RSASSA-PSS using SHA-384 and MGF1 with SHA-384, as described in https://tools.ietf.org/html/rfc7518. </summary>
        public static JsonWebKeySignatureAlgorithm PS384 { get; } = new JsonWebKeySignatureAlgorithm(PS384Value);
        /// <summary> RSASSA-PSS using SHA-512 and MGF1 with SHA-512, as described in https://tools.ietf.org/html/rfc7518. </summary>
        public static JsonWebKeySignatureAlgorithm PS512 { get; } = new JsonWebKeySignatureAlgorithm(PS512Value);
        /// <summary> RSASSA-PKCS1-v1_5 using SHA-256, as described in https://tools.ietf.org/html/rfc7518. </summary>
        public static JsonWebKeySignatureAlgorithm RS256 { get; } = new JsonWebKeySignatureAlgorithm(RS256Value);
        /// <summary> RSASSA-PKCS1-v1_5 using SHA-384, as described in https://tools.ietf.org/html/rfc7518. </summary>
        public static JsonWebKeySignatureAlgorithm RS384 { get; } = new JsonWebKeySignatureAlgorithm(RS384Value);
        /// <summary> RSASSA-PKCS1-v1_5 using SHA-512, as described in https://tools.ietf.org/html/rfc7518. </summary>
        public static JsonWebKeySignatureAlgorithm RS512 { get; } = new JsonWebKeySignatureAlgorithm(RS512Value);
        /// <summary> Reserved. </summary>
        public static JsonWebKeySignatureAlgorithm Rsnull { get; } = new JsonWebKeySignatureAlgorithm(RsnullValue);
        /// <summary> ECDSA using P-256 and SHA-256, as described in https://tools.ietf.org/html/rfc7518. </summary>
        public static JsonWebKeySignatureAlgorithm ES256 { get; } = new JsonWebKeySignatureAlgorithm(ES256Value);
        /// <summary> ECDSA using P-384 and SHA-384, as described in https://tools.ietf.org/html/rfc7518. </summary>
        public static JsonWebKeySignatureAlgorithm ES384 { get; } = new JsonWebKeySignatureAlgorithm(ES384Value);
        /// <summary> ECDSA using P-521 and SHA-512, as described in https://tools.ietf.org/html/rfc7518. </summary>
        public static JsonWebKeySignatureAlgorithm ES512 { get; } = new JsonWebKeySignatureAlgorithm(ES512Value);
        /// <summary> ECDSA using P-256K and SHA-256, as described in https://tools.ietf.org/html/rfc7518. </summary>
        public static JsonWebKeySignatureAlgorithm ES256K { get; } = new JsonWebKeySignatureAlgorithm(ES256KValue);
        /// <summary> Determines if two <see cref="JsonWebKeySignatureAlgorithm"/> values are the same. </summary>
        public static bool operator ==(JsonWebKeySignatureAlgorithm left, JsonWebKeySignatureAlgorithm right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JsonWebKeySignatureAlgorithm"/> values are not the same. </summary>
        public static bool operator !=(JsonWebKeySignatureAlgorithm left, JsonWebKeySignatureAlgorithm right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JsonWebKeySignatureAlgorithm"/>. </summary>
        public static implicit operator JsonWebKeySignatureAlgorithm(string value) => new JsonWebKeySignatureAlgorithm(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JsonWebKeySignatureAlgorithm other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JsonWebKeySignatureAlgorithm other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
