// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> NetworkDeviceRole is the device role: Example: CE | ToR. </summary>
    public readonly partial struct NetworkDeviceRole : IEquatable<NetworkDeviceRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkDeviceRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkDeviceRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CEValue = "CE";
        private const string ToRValue = "ToR";
        private const string NpbValue = "NPB";
        private const string TSValue = "TS";
        private const string ManagementValue = "Management";

        /// <summary> CE. </summary>
        public static NetworkDeviceRole CE { get; } = new NetworkDeviceRole(CEValue);
        /// <summary> ToR. </summary>
        public static NetworkDeviceRole ToR { get; } = new NetworkDeviceRole(ToRValue);
        /// <summary> NPB. </summary>
        public static NetworkDeviceRole Npb { get; } = new NetworkDeviceRole(NpbValue);
        /// <summary> TS. </summary>
        public static NetworkDeviceRole TS { get; } = new NetworkDeviceRole(TSValue);
        /// <summary> Management. </summary>
        public static NetworkDeviceRole Management { get; } = new NetworkDeviceRole(ManagementValue);
        /// <summary> Determines if two <see cref="NetworkDeviceRole"/> values are the same. </summary>
        public static bool operator ==(NetworkDeviceRole left, NetworkDeviceRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkDeviceRole"/> values are not the same. </summary>
        public static bool operator !=(NetworkDeviceRole left, NetworkDeviceRole right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetworkDeviceRole"/>. </summary>
        public static implicit operator NetworkDeviceRole(string value) => new NetworkDeviceRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkDeviceRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkDeviceRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
