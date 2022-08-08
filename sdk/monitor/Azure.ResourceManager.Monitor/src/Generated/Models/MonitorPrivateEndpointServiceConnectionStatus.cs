// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct MonitorPrivateEndpointServiceConnectionStatus : IEquatable<MonitorPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static MonitorPrivateEndpointServiceConnectionStatus Pending { get; } = new MonitorPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static MonitorPrivateEndpointServiceConnectionStatus Approved { get; } = new MonitorPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static MonitorPrivateEndpointServiceConnectionStatus Rejected { get; } = new MonitorPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="MonitorPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(MonitorPrivateEndpointServiceConnectionStatus left, MonitorPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(MonitorPrivateEndpointServiceConnectionStatus left, MonitorPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitorPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator MonitorPrivateEndpointServiceConnectionStatus(string value) => new MonitorPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
