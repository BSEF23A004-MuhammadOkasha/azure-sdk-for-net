// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Resources.Models
{
    /// <summary> The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static. </summary>
    public readonly partial struct PolicyType : IEquatable<PolicyType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PolicyType"/> values are the same. </summary>
        public PolicyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string BuiltInValue = "BuiltIn";
        private const string CustomValue = "Custom";
        private const string StaticValue = "Static";

        /// <summary> NotSpecified. </summary>
        public static PolicyType NotSpecified { get; } = new PolicyType(NotSpecifiedValue);
        /// <summary> BuiltIn. </summary>
        public static PolicyType BuiltIn { get; } = new PolicyType(BuiltInValue);
        /// <summary> Custom. </summary>
        public static PolicyType Custom { get; } = new PolicyType(CustomValue);
        /// <summary> Static. </summary>
        public static PolicyType Static { get; } = new PolicyType(StaticValue);
        /// <summary> Determines if two <see cref="PolicyType"/> values are the same. </summary>
        public static bool operator ==(PolicyType left, PolicyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyType"/> values are not the same. </summary>
        public static bool operator !=(PolicyType left, PolicyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyType"/>. </summary>
        public static implicit operator PolicyType(string value) => new PolicyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
