// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The PremiumPageBlobAccessTier. </summary>
    internal readonly partial struct PremiumPageBlobAccessTier : IEquatable<PremiumPageBlobAccessTier>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PremiumPageBlobAccessTier"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PremiumPageBlobAccessTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string P4Value = "P4";
        private const string P6Value = "P6";
        private const string P10Value = "P10";
        private const string P15Value = "P15";
        private const string P20Value = "P20";
        private const string P30Value = "P30";
        private const string P40Value = "P40";
        private const string P50Value = "P50";
        private const string P60Value = "P60";
        private const string P70Value = "P70";
        private const string P80Value = "P80";

        /// <summary> P4. </summary>
        public static PremiumPageBlobAccessTier P4 { get; } = new PremiumPageBlobAccessTier(P4Value);
        /// <summary> P6. </summary>
        public static PremiumPageBlobAccessTier P6 { get; } = new PremiumPageBlobAccessTier(P6Value);
        /// <summary> P10. </summary>
        public static PremiumPageBlobAccessTier P10 { get; } = new PremiumPageBlobAccessTier(P10Value);
        /// <summary> P15. </summary>
        public static PremiumPageBlobAccessTier P15 { get; } = new PremiumPageBlobAccessTier(P15Value);
        /// <summary> P20. </summary>
        public static PremiumPageBlobAccessTier P20 { get; } = new PremiumPageBlobAccessTier(P20Value);
        /// <summary> P30. </summary>
        public static PremiumPageBlobAccessTier P30 { get; } = new PremiumPageBlobAccessTier(P30Value);
        /// <summary> P40. </summary>
        public static PremiumPageBlobAccessTier P40 { get; } = new PremiumPageBlobAccessTier(P40Value);
        /// <summary> P50. </summary>
        public static PremiumPageBlobAccessTier P50 { get; } = new PremiumPageBlobAccessTier(P50Value);
        /// <summary> P60. </summary>
        public static PremiumPageBlobAccessTier P60 { get; } = new PremiumPageBlobAccessTier(P60Value);
        /// <summary> P70. </summary>
        public static PremiumPageBlobAccessTier P70 { get; } = new PremiumPageBlobAccessTier(P70Value);
        /// <summary> P80. </summary>
        public static PremiumPageBlobAccessTier P80 { get; } = new PremiumPageBlobAccessTier(P80Value);
        /// <summary> Determines if two <see cref="PremiumPageBlobAccessTier"/> values are the same. </summary>
        public static bool operator ==(PremiumPageBlobAccessTier left, PremiumPageBlobAccessTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PremiumPageBlobAccessTier"/> values are not the same. </summary>
        public static bool operator !=(PremiumPageBlobAccessTier left, PremiumPageBlobAccessTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PremiumPageBlobAccessTier"/>. </summary>
        public static implicit operator PremiumPageBlobAccessTier(string value) => new PremiumPageBlobAccessTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PremiumPageBlobAccessTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PremiumPageBlobAccessTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
