// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Provisioning state of a network security perimeter configuration that is being created or updated. </summary>
    public readonly partial struct NetworkSecurityPerimeterConfigurationProvisioningState : IEquatable<NetworkSecurityPerimeterConfigurationProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterConfigurationProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkSecurityPerimeterConfigurationProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string AcceptedValue = "Accepted";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static NetworkSecurityPerimeterConfigurationProvisioningState Succeeded { get; } = new NetworkSecurityPerimeterConfigurationProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static NetworkSecurityPerimeterConfigurationProvisioningState Creating { get; } = new NetworkSecurityPerimeterConfigurationProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static NetworkSecurityPerimeterConfigurationProvisioningState Updating { get; } = new NetworkSecurityPerimeterConfigurationProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static NetworkSecurityPerimeterConfigurationProvisioningState Deleting { get; } = new NetworkSecurityPerimeterConfigurationProvisioningState(DeletingValue);
        /// <summary> Accepted. </summary>
        public static NetworkSecurityPerimeterConfigurationProvisioningState Accepted { get; } = new NetworkSecurityPerimeterConfigurationProvisioningState(AcceptedValue);
        /// <summary> Failed. </summary>
        public static NetworkSecurityPerimeterConfigurationProvisioningState Failed { get; } = new NetworkSecurityPerimeterConfigurationProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static NetworkSecurityPerimeterConfigurationProvisioningState Canceled { get; } = new NetworkSecurityPerimeterConfigurationProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="NetworkSecurityPerimeterConfigurationProvisioningState"/> values are the same. </summary>
        public static bool operator ==(NetworkSecurityPerimeterConfigurationProvisioningState left, NetworkSecurityPerimeterConfigurationProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkSecurityPerimeterConfigurationProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(NetworkSecurityPerimeterConfigurationProvisioningState left, NetworkSecurityPerimeterConfigurationProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetworkSecurityPerimeterConfigurationProvisioningState"/>. </summary>
        public static implicit operator NetworkSecurityPerimeterConfigurationProvisioningState(string value) => new NetworkSecurityPerimeterConfigurationProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkSecurityPerimeterConfigurationProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkSecurityPerimeterConfigurationProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
