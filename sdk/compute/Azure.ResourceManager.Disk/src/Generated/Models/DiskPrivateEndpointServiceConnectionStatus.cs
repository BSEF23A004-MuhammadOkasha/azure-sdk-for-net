// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Disk.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct DiskPrivateEndpointServiceConnectionStatus : IEquatable<DiskPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static DiskPrivateEndpointServiceConnectionStatus Pending { get; } = new DiskPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static DiskPrivateEndpointServiceConnectionStatus Approved { get; } = new DiskPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static DiskPrivateEndpointServiceConnectionStatus Rejected { get; } = new DiskPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="DiskPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(DiskPrivateEndpointServiceConnectionStatus left, DiskPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(DiskPrivateEndpointServiceConnectionStatus left, DiskPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DiskPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator DiskPrivateEndpointServiceConnectionStatus(string value) => new DiskPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
