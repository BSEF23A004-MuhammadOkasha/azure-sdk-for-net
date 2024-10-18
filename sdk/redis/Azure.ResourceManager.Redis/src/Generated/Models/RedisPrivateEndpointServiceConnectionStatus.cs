// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct RedisPrivateEndpointServiceConnectionStatus : IEquatable<RedisPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static RedisPrivateEndpointServiceConnectionStatus Pending { get; } = new RedisPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static RedisPrivateEndpointServiceConnectionStatus Approved { get; } = new RedisPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static RedisPrivateEndpointServiceConnectionStatus Rejected { get; } = new RedisPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="RedisPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(RedisPrivateEndpointServiceConnectionStatus left, RedisPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(RedisPrivateEndpointServiceConnectionStatus left, RedisPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RedisPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator RedisPrivateEndpointServiceConnectionStatus(string value) => new RedisPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
