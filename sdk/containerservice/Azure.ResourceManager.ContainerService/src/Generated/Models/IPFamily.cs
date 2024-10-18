// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The IP version to use for cluster networking and IP assignment. </summary>
    public readonly partial struct IPFamily : IEquatable<IPFamily>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IPFamily"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IPFamily(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPv4Value = "IPv4";
        private const string IPv6Value = "IPv6";

        /// <summary> IPv4. </summary>
        public static IPFamily IPv4 { get; } = new IPFamily(IPv4Value);
        /// <summary> IPv6. </summary>
        public static IPFamily IPv6 { get; } = new IPFamily(IPv6Value);
        /// <summary> Determines if two <see cref="IPFamily"/> values are the same. </summary>
        public static bool operator ==(IPFamily left, IPFamily right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IPFamily"/> values are not the same. </summary>
        public static bool operator !=(IPFamily left, IPFamily right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IPFamily"/>. </summary>
        public static implicit operator IPFamily(string value) => new IPFamily(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IPFamily other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IPFamily other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
