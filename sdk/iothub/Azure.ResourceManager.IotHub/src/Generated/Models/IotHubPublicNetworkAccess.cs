// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary>
    /// Whether requests from Public Network are allowed
    /// Serialized Name: PublicNetworkAccess
    /// </summary>
    public readonly partial struct IotHubPublicNetworkAccess : IEquatable<IotHubPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IotHubPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IotHubPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary>
        /// Enabled
        /// Serialized Name: PublicNetworkAccess.Enabled
        /// </summary>
        public static IotHubPublicNetworkAccess Enabled { get; } = new IotHubPublicNetworkAccess(EnabledValue);
        /// <summary>
        /// Disabled
        /// Serialized Name: PublicNetworkAccess.Disabled
        /// </summary>
        public static IotHubPublicNetworkAccess Disabled { get; } = new IotHubPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="IotHubPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(IotHubPublicNetworkAccess left, IotHubPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IotHubPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(IotHubPublicNetworkAccess left, IotHubPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IotHubPublicNetworkAccess"/>. </summary>
        public static implicit operator IotHubPublicNetworkAccess(string value) => new IotHubPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IotHubPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IotHubPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
