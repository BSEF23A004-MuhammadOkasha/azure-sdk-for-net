// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The more detailed status of the L2 network. </summary>
    public readonly partial struct L2NetworkDetailedStatus : IEquatable<L2NetworkDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="L2NetworkDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public L2NetworkDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string AvailableValue = "Available";
        private const string ProvisioningValue = "Provisioning";

        /// <summary> Error. </summary>
        public static L2NetworkDetailedStatus Error { get; } = new L2NetworkDetailedStatus(ErrorValue);
        /// <summary> Available. </summary>
        public static L2NetworkDetailedStatus Available { get; } = new L2NetworkDetailedStatus(AvailableValue);
        /// <summary> Provisioning. </summary>
        public static L2NetworkDetailedStatus Provisioning { get; } = new L2NetworkDetailedStatus(ProvisioningValue);
        /// <summary> Determines if two <see cref="L2NetworkDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(L2NetworkDetailedStatus left, L2NetworkDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="L2NetworkDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(L2NetworkDetailedStatus left, L2NetworkDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="L2NetworkDetailedStatus"/>. </summary>
        public static implicit operator L2NetworkDetailedStatus(string value) => new L2NetworkDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is L2NetworkDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(L2NetworkDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
