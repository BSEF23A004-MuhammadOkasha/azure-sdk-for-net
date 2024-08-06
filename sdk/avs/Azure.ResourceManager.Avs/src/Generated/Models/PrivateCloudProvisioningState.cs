// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> private cloud provisioning state. </summary>
    public readonly partial struct PrivateCloudProvisioningState : IEquatable<PrivateCloudProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrivateCloudProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrivateCloudProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string CancelledValue = "Cancelled";
        private const string PendingValue = "Pending";
        private const string BuildingValue = "Building";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";

        /// <summary> Resource has been created. </summary>
        public static PrivateCloudProvisioningState Succeeded { get; } = new PrivateCloudProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static PrivateCloudProvisioningState Failed { get; } = new PrivateCloudProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static PrivateCloudProvisioningState Canceled { get; } = new PrivateCloudProvisioningState(CanceledValue);
        /// <summary> is cancelled. </summary>
        public static PrivateCloudProvisioningState Cancelled { get; } = new PrivateCloudProvisioningState(CancelledValue);
        /// <summary> is pending. </summary>
        public static PrivateCloudProvisioningState Pending { get; } = new PrivateCloudProvisioningState(PendingValue);
        /// <summary> is building. </summary>
        public static PrivateCloudProvisioningState Building { get; } = new PrivateCloudProvisioningState(BuildingValue);
        /// <summary> is deleting. </summary>
        public static PrivateCloudProvisioningState Deleting { get; } = new PrivateCloudProvisioningState(DeletingValue);
        /// <summary> is updating. </summary>
        public static PrivateCloudProvisioningState Updating { get; } = new PrivateCloudProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="PrivateCloudProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PrivateCloudProvisioningState left, PrivateCloudProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrivateCloudProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PrivateCloudProvisioningState left, PrivateCloudProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrivateCloudProvisioningState"/>. </summary>
        public static implicit operator PrivateCloudProvisioningState(string value) => new PrivateCloudProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrivateCloudProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrivateCloudProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
