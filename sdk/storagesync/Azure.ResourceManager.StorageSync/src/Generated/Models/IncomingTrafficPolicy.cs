// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Type of the Incoming Traffic Policy. </summary>
    public readonly partial struct IncomingTrafficPolicy : IEquatable<IncomingTrafficPolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IncomingTrafficPolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IncomingTrafficPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowAllTrafficValue = "AllowAllTraffic";
        private const string AllowVirtualNetworksOnlyValue = "AllowVirtualNetworksOnly";

        /// <summary> AllowAllTraffic. </summary>
        public static IncomingTrafficPolicy AllowAllTraffic { get; } = new IncomingTrafficPolicy(AllowAllTrafficValue);
        /// <summary> AllowVirtualNetworksOnly. </summary>
        public static IncomingTrafficPolicy AllowVirtualNetworksOnly { get; } = new IncomingTrafficPolicy(AllowVirtualNetworksOnlyValue);
        /// <summary> Determines if two <see cref="IncomingTrafficPolicy"/> values are the same. </summary>
        public static bool operator ==(IncomingTrafficPolicy left, IncomingTrafficPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IncomingTrafficPolicy"/> values are not the same. </summary>
        public static bool operator !=(IncomingTrafficPolicy left, IncomingTrafficPolicy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IncomingTrafficPolicy"/>. </summary>
        public static implicit operator IncomingTrafficPolicy(string value) => new IncomingTrafficPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IncomingTrafficPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IncomingTrafficPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
