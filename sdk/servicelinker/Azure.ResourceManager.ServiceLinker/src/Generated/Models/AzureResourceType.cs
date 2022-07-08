// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The azure resource type. </summary>
    internal readonly partial struct AzureResourceType : IEquatable<AzureResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeyVaultValue = "KeyVault";

        /// <summary> KeyVault. </summary>
        public static AzureResourceType KeyVault { get; } = new AzureResourceType(KeyVaultValue);
        /// <summary> Determines if two <see cref="AzureResourceType"/> values are the same. </summary>
        public static bool operator ==(AzureResourceType left, AzureResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureResourceType"/> values are not the same. </summary>
        public static bool operator !=(AzureResourceType left, AzureResourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureResourceType"/>. </summary>
        public static implicit operator AzureResourceType(string value) => new AzureResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
