// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Ssl cipher suites enums. </summary>
    public readonly partial struct ApplicationGatewaySslCipherSuite : IEquatable<ApplicationGatewaySslCipherSuite>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ApplicationGatewaySslCipherSuite"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewaySslCipherSuite(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TLSEcdheRSAWithAES256CBCSHA384Value = "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384";
        private const string TLSEcdheRSAWithAES128CBCSHA256Value = "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256";
        private const string TLSEcdheRSAWithAES256CBCSHAValue = "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA";
        private const string TLSEcdheRSAWithAES128CBCSHAValue = "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA";
        private const string TLSDHERSAWithAES256GCMSHA384Value = "TLS_DHE_RSA_WITH_AES_256_GCM_SHA384";
        private const string TLSDHERSAWithAES128GCMSHA256Value = "TLS_DHE_RSA_WITH_AES_128_GCM_SHA256";
        private const string TLSDHERSAWithAES256CBCSHAValue = "TLS_DHE_RSA_WITH_AES_256_CBC_SHA";
        private const string TLSDHERSAWithAES128CBCSHAValue = "TLS_DHE_RSA_WITH_AES_128_CBC_SHA";
        private const string TLSRSAWithAES256GCMSHA384Value = "TLS_RSA_WITH_AES_256_GCM_SHA384";
        private const string TLSRSAWithAES128GCMSHA256Value = "TLS_RSA_WITH_AES_128_GCM_SHA256";
        private const string TLSRSAWithAES256CBCSHA256Value = "TLS_RSA_WITH_AES_256_CBC_SHA256";
        private const string TLSRSAWithAES128CBCSHA256Value = "TLS_RSA_WITH_AES_128_CBC_SHA256";
        private const string TLSRSAWithAES256CBCSHAValue = "TLS_RSA_WITH_AES_256_CBC_SHA";
        private const string TLSRSAWithAES128CBCSHAValue = "TLS_RSA_WITH_AES_128_CBC_SHA";
        private const string TLSEcdheEcdsaWithAES256GCMSHA384Value = "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384";
        private const string TLSEcdheEcdsaWithAES128GCMSHA256Value = "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256";
        private const string TLSEcdheEcdsaWithAES256CBCSHA384Value = "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384";
        private const string TLSEcdheEcdsaWithAES128CBCSHA256Value = "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256";
        private const string TLSEcdheEcdsaWithAES256CBCSHAValue = "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA";
        private const string TLSEcdheEcdsaWithAES128CBCSHAValue = "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA";
        private const string TLSDHEDSSWithAES256CBCSHA256Value = "TLS_DHE_DSS_WITH_AES_256_CBC_SHA256";
        private const string TLSDHEDSSWithAES128CBCSHA256Value = "TLS_DHE_DSS_WITH_AES_128_CBC_SHA256";
        private const string TLSDHEDSSWithAES256CBCSHAValue = "TLS_DHE_DSS_WITH_AES_256_CBC_SHA";
        private const string TLSDHEDSSWithAES128CBCSHAValue = "TLS_DHE_DSS_WITH_AES_128_CBC_SHA";
        private const string TLSRSAWith3DESEDECBCSHAValue = "TLS_RSA_WITH_3DES_EDE_CBC_SHA";
        private const string TLSDHEDSSWith3DESEDECBCSHAValue = "TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA";
        private const string TLSEcdheRSAWithAES128GCMSHA256Value = "TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256";
        private const string TLSEcdheRSAWithAES256GCMSHA384Value = "TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384";

        /// <summary> TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheRSAWithAES256CBCSHA384 { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheRSAWithAES256CBCSHA384Value);
        /// <summary> TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheRSAWithAES128CBCSHA256 { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheRSAWithAES128CBCSHA256Value);
        /// <summary> TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheRSAWithAES256CBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheRSAWithAES256CBCSHAValue);
        /// <summary> TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheRSAWithAES128CBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheRSAWithAES128CBCSHAValue);
        /// <summary> TLS_DHE_RSA_WITH_AES_256_GCM_SHA384. </summary>
        public static ApplicationGatewaySslCipherSuite TLSDHERSAWithAES256GCMSHA384 { get; } = new ApplicationGatewaySslCipherSuite(TLSDHERSAWithAES256GCMSHA384Value);
        /// <summary> TLS_DHE_RSA_WITH_AES_128_GCM_SHA256. </summary>
        public static ApplicationGatewaySslCipherSuite TLSDHERSAWithAES128GCMSHA256 { get; } = new ApplicationGatewaySslCipherSuite(TLSDHERSAWithAES128GCMSHA256Value);
        /// <summary> TLS_DHE_RSA_WITH_AES_256_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSDHERSAWithAES256CBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSDHERSAWithAES256CBCSHAValue);
        /// <summary> TLS_DHE_RSA_WITH_AES_128_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSDHERSAWithAES128CBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSDHERSAWithAES128CBCSHAValue);
        /// <summary> TLS_RSA_WITH_AES_256_GCM_SHA384. </summary>
        public static ApplicationGatewaySslCipherSuite TLSRSAWithAES256GCMSHA384 { get; } = new ApplicationGatewaySslCipherSuite(TLSRSAWithAES256GCMSHA384Value);
        /// <summary> TLS_RSA_WITH_AES_128_GCM_SHA256. </summary>
        public static ApplicationGatewaySslCipherSuite TLSRSAWithAES128GCMSHA256 { get; } = new ApplicationGatewaySslCipherSuite(TLSRSAWithAES128GCMSHA256Value);
        /// <summary> TLS_RSA_WITH_AES_256_CBC_SHA256. </summary>
        public static ApplicationGatewaySslCipherSuite TLSRSAWithAES256CBCSHA256 { get; } = new ApplicationGatewaySslCipherSuite(TLSRSAWithAES256CBCSHA256Value);
        /// <summary> TLS_RSA_WITH_AES_128_CBC_SHA256. </summary>
        public static ApplicationGatewaySslCipherSuite TLSRSAWithAES128CBCSHA256 { get; } = new ApplicationGatewaySslCipherSuite(TLSRSAWithAES128CBCSHA256Value);
        /// <summary> TLS_RSA_WITH_AES_256_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSRSAWithAES256CBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSRSAWithAES256CBCSHAValue);
        /// <summary> TLS_RSA_WITH_AES_128_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSRSAWithAES128CBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSRSAWithAES128CBCSHAValue);
        /// <summary> TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheEcdsaWithAES256GCMSHA384 { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheEcdsaWithAES256GCMSHA384Value);
        /// <summary> TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheEcdsaWithAES128GCMSHA256 { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheEcdsaWithAES128GCMSHA256Value);
        /// <summary> TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheEcdsaWithAES256CBCSHA384 { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheEcdsaWithAES256CBCSHA384Value);
        /// <summary> TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheEcdsaWithAES128CBCSHA256 { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheEcdsaWithAES128CBCSHA256Value);
        /// <summary> TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheEcdsaWithAES256CBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheEcdsaWithAES256CBCSHAValue);
        /// <summary> TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheEcdsaWithAES128CBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheEcdsaWithAES128CBCSHAValue);
        /// <summary> TLS_DHE_DSS_WITH_AES_256_CBC_SHA256. </summary>
        public static ApplicationGatewaySslCipherSuite TLSDHEDSSWithAES256CBCSHA256 { get; } = new ApplicationGatewaySslCipherSuite(TLSDHEDSSWithAES256CBCSHA256Value);
        /// <summary> TLS_DHE_DSS_WITH_AES_128_CBC_SHA256. </summary>
        public static ApplicationGatewaySslCipherSuite TLSDHEDSSWithAES128CBCSHA256 { get; } = new ApplicationGatewaySslCipherSuite(TLSDHEDSSWithAES128CBCSHA256Value);
        /// <summary> TLS_DHE_DSS_WITH_AES_256_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSDHEDSSWithAES256CBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSDHEDSSWithAES256CBCSHAValue);
        /// <summary> TLS_DHE_DSS_WITH_AES_128_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSDHEDSSWithAES128CBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSDHEDSSWithAES128CBCSHAValue);
        /// <summary> TLS_RSA_WITH_3DES_EDE_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSRSAWith3DESEDECBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSRSAWith3DESEDECBCSHAValue);
        /// <summary> TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA. </summary>
        public static ApplicationGatewaySslCipherSuite TLSDHEDSSWith3DESEDECBCSHA { get; } = new ApplicationGatewaySslCipherSuite(TLSDHEDSSWith3DESEDECBCSHAValue);
        /// <summary> TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheRSAWithAES128GCMSHA256 { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheRSAWithAES128GCMSHA256Value);
        /// <summary> TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384. </summary>
        public static ApplicationGatewaySslCipherSuite TLSEcdheRSAWithAES256GCMSHA384 { get; } = new ApplicationGatewaySslCipherSuite(TLSEcdheRSAWithAES256GCMSHA384Value);
        /// <summary> Determines if two <see cref="ApplicationGatewaySslCipherSuite"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewaySslCipherSuite left, ApplicationGatewaySslCipherSuite right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewaySslCipherSuite"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewaySslCipherSuite left, ApplicationGatewaySslCipherSuite right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewaySslCipherSuite"/>. </summary>
        public static implicit operator ApplicationGatewaySslCipherSuite(string value) => new ApplicationGatewaySslCipherSuite(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewaySslCipherSuite other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewaySslCipherSuite other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
