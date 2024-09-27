// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The status of a private endpoint connection. </summary>
    public readonly partial struct DeviceProvisioningServicesPrivateLinkServiceConnectionStatus : IEquatable<DeviceProvisioningServicesPrivateLinkServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesPrivateLinkServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeviceProvisioningServicesPrivateLinkServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static DeviceProvisioningServicesPrivateLinkServiceConnectionStatus Pending { get; } = new DeviceProvisioningServicesPrivateLinkServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static DeviceProvisioningServicesPrivateLinkServiceConnectionStatus Approved { get; } = new DeviceProvisioningServicesPrivateLinkServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static DeviceProvisioningServicesPrivateLinkServiceConnectionStatus Rejected { get; } = new DeviceProvisioningServicesPrivateLinkServiceConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static DeviceProvisioningServicesPrivateLinkServiceConnectionStatus Disconnected { get; } = new DeviceProvisioningServicesPrivateLinkServiceConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="DeviceProvisioningServicesPrivateLinkServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(DeviceProvisioningServicesPrivateLinkServiceConnectionStatus left, DeviceProvisioningServicesPrivateLinkServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeviceProvisioningServicesPrivateLinkServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(DeviceProvisioningServicesPrivateLinkServiceConnectionStatus left, DeviceProvisioningServicesPrivateLinkServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DeviceProvisioningServicesPrivateLinkServiceConnectionStatus"/>. </summary>
        public static implicit operator DeviceProvisioningServicesPrivateLinkServiceConnectionStatus(string value) => new DeviceProvisioningServicesPrivateLinkServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeviceProvisioningServicesPrivateLinkServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeviceProvisioningServicesPrivateLinkServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
