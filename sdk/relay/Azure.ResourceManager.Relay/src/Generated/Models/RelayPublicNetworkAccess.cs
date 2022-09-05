// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> This determines if traffic is allowed over public network. By default it is enabled. </summary>
    public readonly partial struct RelayPublicNetworkAccess : IEquatable<RelayPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RelayPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RelayPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";
        private const string SecuredByPerimeterValue = "SecuredByPerimeter";

        /// <summary> Enabled. </summary>
        public static RelayPublicNetworkAccess Enabled { get; } = new RelayPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static RelayPublicNetworkAccess Disabled { get; } = new RelayPublicNetworkAccess(DisabledValue);
        /// <summary> SecuredByPerimeter. </summary>
        public static RelayPublicNetworkAccess SecuredByPerimeter { get; } = new RelayPublicNetworkAccess(SecuredByPerimeterValue);
        /// <summary> Determines if two <see cref="RelayPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(RelayPublicNetworkAccess left, RelayPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RelayPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(RelayPublicNetworkAccess left, RelayPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RelayPublicNetworkAccess"/>. </summary>
        public static implicit operator RelayPublicNetworkAccess(string value) => new RelayPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RelayPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RelayPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
