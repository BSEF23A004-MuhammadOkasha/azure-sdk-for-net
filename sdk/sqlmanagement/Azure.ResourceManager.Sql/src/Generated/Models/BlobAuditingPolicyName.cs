// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The BlobAuditingPolicyName. </summary>
    public readonly partial struct BlobAuditingPolicyName : IEquatable<BlobAuditingPolicyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BlobAuditingPolicyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BlobAuditingPolicyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static BlobAuditingPolicyName Default { get; } = new BlobAuditingPolicyName(DefaultValue);
        /// <summary> Determines if two <see cref="BlobAuditingPolicyName"/> values are the same. </summary>
        public static bool operator ==(BlobAuditingPolicyName left, BlobAuditingPolicyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BlobAuditingPolicyName"/> values are not the same. </summary>
        public static bool operator !=(BlobAuditingPolicyName left, BlobAuditingPolicyName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BlobAuditingPolicyName"/>. </summary>
        public static implicit operator BlobAuditingPolicyName(string value) => new BlobAuditingPolicyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BlobAuditingPolicyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BlobAuditingPolicyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
