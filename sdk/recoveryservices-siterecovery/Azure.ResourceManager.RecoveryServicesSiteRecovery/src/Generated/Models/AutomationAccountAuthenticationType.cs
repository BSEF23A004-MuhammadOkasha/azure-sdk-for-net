// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A value indicating the type authentication to use for automation Account. </summary>
    public readonly partial struct AutomationAccountAuthenticationType : IEquatable<AutomationAccountAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationAccountAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationAccountAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunAsAccountValue = "RunAsAccount";
        private const string SystemAssignedIdentityValue = "SystemAssignedIdentity";

        /// <summary> RunAsAccount. </summary>
        public static AutomationAccountAuthenticationType RunAsAccount { get; } = new AutomationAccountAuthenticationType(RunAsAccountValue);
        /// <summary> SystemAssignedIdentity. </summary>
        public static AutomationAccountAuthenticationType SystemAssignedIdentity { get; } = new AutomationAccountAuthenticationType(SystemAssignedIdentityValue);
        /// <summary> Determines if two <see cref="AutomationAccountAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(AutomationAccountAuthenticationType left, AutomationAccountAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationAccountAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(AutomationAccountAuthenticationType left, AutomationAccountAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AutomationAccountAuthenticationType"/>. </summary>
        public static implicit operator AutomationAccountAuthenticationType(string value) => new AutomationAccountAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationAccountAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationAccountAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
