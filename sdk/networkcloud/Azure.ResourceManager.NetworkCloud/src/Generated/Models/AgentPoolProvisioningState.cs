// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The provisioning state of the agent pool. </summary>
    public readonly partial struct AgentPoolProvisioningState : IEquatable<AgentPoolProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AgentPoolProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgentPoolProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string CanceledValue = "Canceled";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";
        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string UpdatingValue = "Updating";

        /// <summary> Accepted. </summary>
        public static AgentPoolProvisioningState Accepted { get; } = new AgentPoolProvisioningState(AcceptedValue);
        /// <summary> Canceled. </summary>
        public static AgentPoolProvisioningState Canceled { get; } = new AgentPoolProvisioningState(CanceledValue);
        /// <summary> Deleting. </summary>
        public static AgentPoolProvisioningState Deleting { get; } = new AgentPoolProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static AgentPoolProvisioningState Failed { get; } = new AgentPoolProvisioningState(FailedValue);
        /// <summary> InProgress. </summary>
        public static AgentPoolProvisioningState InProgress { get; } = new AgentPoolProvisioningState(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static AgentPoolProvisioningState Succeeded { get; } = new AgentPoolProvisioningState(SucceededValue);
        /// <summary> Updating. </summary>
        public static AgentPoolProvisioningState Updating { get; } = new AgentPoolProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="AgentPoolProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AgentPoolProvisioningState left, AgentPoolProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgentPoolProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AgentPoolProvisioningState left, AgentPoolProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AgentPoolProvisioningState"/>. </summary>
        public static implicit operator AgentPoolProvisioningState(string value) => new AgentPoolProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgentPoolProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgentPoolProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
