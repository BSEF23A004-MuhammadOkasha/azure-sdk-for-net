// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Polling type. </summary>
    public readonly partial struct NetworkTapPollingType : IEquatable<NetworkTapPollingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkTapPollingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkTapPollingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PullValue = "Pull";
        private const string PushValue = "Push";

        /// <summary> Pull. </summary>
        public static NetworkTapPollingType Pull { get; } = new NetworkTapPollingType(PullValue);
        /// <summary> Push. </summary>
        public static NetworkTapPollingType Push { get; } = new NetworkTapPollingType(PushValue);
        /// <summary> Determines if two <see cref="NetworkTapPollingType"/> values are the same. </summary>
        public static bool operator ==(NetworkTapPollingType left, NetworkTapPollingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkTapPollingType"/> values are not the same. </summary>
        public static bool operator !=(NetworkTapPollingType left, NetworkTapPollingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkTapPollingType"/>. </summary>
        public static implicit operator NetworkTapPollingType(string value) => new NetworkTapPollingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkTapPollingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkTapPollingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
