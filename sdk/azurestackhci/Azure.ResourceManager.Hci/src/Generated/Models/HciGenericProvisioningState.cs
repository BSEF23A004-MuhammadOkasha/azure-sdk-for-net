// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Provisioning state of the gallery image. </summary>
    public readonly partial struct HciGenericProvisioningState : IEquatable<HciGenericProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HciGenericProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HciGenericProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string InProgressValue = "InProgress";
        private const string AcceptedValue = "Accepted";
        private const string DeletingValue = "Deleting";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static HciGenericProvisioningState Succeeded { get; } = new HciGenericProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static HciGenericProvisioningState Failed { get; } = new HciGenericProvisioningState(FailedValue);
        /// <summary> InProgress. </summary>
        public static HciGenericProvisioningState InProgress { get; } = new HciGenericProvisioningState(InProgressValue);
        /// <summary> Accepted. </summary>
        public static HciGenericProvisioningState Accepted { get; } = new HciGenericProvisioningState(AcceptedValue);
        /// <summary> Deleting. </summary>
        public static HciGenericProvisioningState Deleting { get; } = new HciGenericProvisioningState(DeletingValue);
        /// <summary> Canceled. </summary>
        public static HciGenericProvisioningState Canceled { get; } = new HciGenericProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="HciGenericProvisioningState"/> values are the same. </summary>
        public static bool operator ==(HciGenericProvisioningState left, HciGenericProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HciGenericProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(HciGenericProvisioningState left, HciGenericProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HciGenericProvisioningState"/>. </summary>
        public static implicit operator HciGenericProvisioningState(string value) => new HciGenericProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HciGenericProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HciGenericProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
