// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct ApiManagementPrivateEndpointConnectionProvisioningState : IEquatable<ApiManagementPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApiManagementPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApiManagementPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static ApiManagementPrivateEndpointConnectionProvisioningState Succeeded { get; } = new ApiManagementPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static ApiManagementPrivateEndpointConnectionProvisioningState Creating { get; } = new ApiManagementPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static ApiManagementPrivateEndpointConnectionProvisioningState Deleting { get; } = new ApiManagementPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static ApiManagementPrivateEndpointConnectionProvisioningState Failed { get; } = new ApiManagementPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="ApiManagementPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ApiManagementPrivateEndpointConnectionProvisioningState left, ApiManagementPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApiManagementPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ApiManagementPrivateEndpointConnectionProvisioningState left, ApiManagementPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApiManagementPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator ApiManagementPrivateEndpointConnectionProvisioningState(string value) => new ApiManagementPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApiManagementPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApiManagementPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
