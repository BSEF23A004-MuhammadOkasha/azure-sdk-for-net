// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    /// <summary> The provisioning state of the UpdateStrategy resource. </summary>
    public readonly partial struct FleetUpdateStrategyProvisioningState : IEquatable<FleetUpdateStrategyProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FleetUpdateStrategyProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FleetUpdateStrategyProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Resource has been created. </summary>
        public static FleetUpdateStrategyProvisioningState Succeeded { get; } = new FleetUpdateStrategyProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static FleetUpdateStrategyProvisioningState Failed { get; } = new FleetUpdateStrategyProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static FleetUpdateStrategyProvisioningState Canceled { get; } = new FleetUpdateStrategyProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="FleetUpdateStrategyProvisioningState"/> values are the same. </summary>
        public static bool operator ==(FleetUpdateStrategyProvisioningState left, FleetUpdateStrategyProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FleetUpdateStrategyProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(FleetUpdateStrategyProvisioningState left, FleetUpdateStrategyProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FleetUpdateStrategyProvisioningState"/>. </summary>
        public static implicit operator FleetUpdateStrategyProvisioningState(string value) => new FleetUpdateStrategyProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FleetUpdateStrategyProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FleetUpdateStrategyProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
