// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> The role type. </summary>
    public readonly partial struct RoleType : IEquatable<RoleType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="RoleType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BuiltInRoleValue = "AKVBuiltInRole";
        private const string CustomRoleValue = "CustomRole";

        /// <summary> Built in role. </summary>
        public static RoleType BuiltInRole { get; } = new RoleType(BuiltInRoleValue);
        /// <summary> Custom role. </summary>
        public static RoleType CustomRole { get; } = new RoleType(CustomRoleValue);
        /// <summary> Determines if two <see cref="RoleType"/> values are the same. </summary>
        public static bool operator ==(RoleType left, RoleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoleType"/> values are not the same. </summary>
        public static bool operator !=(RoleType left, RoleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoleType"/>. </summary>
        public static implicit operator RoleType(string value) => new RoleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
