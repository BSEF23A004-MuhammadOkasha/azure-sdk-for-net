// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </summary>
    public readonly partial struct PrivateLinkServiceConnectionStatus : IEquatable<PrivateLinkServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrivateLinkServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static PrivateLinkServiceConnectionStatus Pending { get; } = new PrivateLinkServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static PrivateLinkServiceConnectionStatus Approved { get; } = new PrivateLinkServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static PrivateLinkServiceConnectionStatus Rejected { get; } = new PrivateLinkServiceConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static PrivateLinkServiceConnectionStatus Disconnected { get; } = new PrivateLinkServiceConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="PrivateLinkServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(PrivateLinkServiceConnectionStatus left, PrivateLinkServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrivateLinkServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(PrivateLinkServiceConnectionStatus left, PrivateLinkServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PrivateLinkServiceConnectionStatus"/>. </summary>
        public static implicit operator PrivateLinkServiceConnectionStatus(string value) => new PrivateLinkServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrivateLinkServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrivateLinkServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
