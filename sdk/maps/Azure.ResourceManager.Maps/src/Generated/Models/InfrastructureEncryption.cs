// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> Values are enabled and disabled. </summary>
    public readonly partial struct InfrastructureEncryption : IEquatable<InfrastructureEncryption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InfrastructureEncryption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InfrastructureEncryption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "enabled";
        private const string DisabledValue = "disabled";

        /// <summary> enabled. </summary>
        public static InfrastructureEncryption Enabled { get; } = new InfrastructureEncryption(EnabledValue);
        /// <summary> disabled. </summary>
        public static InfrastructureEncryption Disabled { get; } = new InfrastructureEncryption(DisabledValue);
        /// <summary> Determines if two <see cref="InfrastructureEncryption"/> values are the same. </summary>
        public static bool operator ==(InfrastructureEncryption left, InfrastructureEncryption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InfrastructureEncryption"/> values are not the same. </summary>
        public static bool operator !=(InfrastructureEncryption left, InfrastructureEncryption right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="InfrastructureEncryption"/>. </summary>
        public static implicit operator InfrastructureEncryption(string value) => new InfrastructureEncryption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InfrastructureEncryption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InfrastructureEncryption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
