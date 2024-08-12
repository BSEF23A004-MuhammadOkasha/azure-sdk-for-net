// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// The desired installation state of the packet core.
    /// Serialized Name: DesiredInstallationState
    /// </summary>
    public readonly partial struct DesiredInstallationState : IEquatable<DesiredInstallationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DesiredInstallationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DesiredInstallationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UninstalledValue = "Uninstalled";
        private const string InstalledValue = "Installed";

        /// <summary>
        /// Don't install the packet core.
        /// Serialized Name: DesiredInstallationState.Uninstalled
        /// </summary>
        public static DesiredInstallationState Uninstalled { get; } = new DesiredInstallationState(UninstalledValue);
        /// <summary>
        /// Install the packet core.
        /// Serialized Name: DesiredInstallationState.Installed
        /// </summary>
        public static DesiredInstallationState Installed { get; } = new DesiredInstallationState(InstalledValue);
        /// <summary> Determines if two <see cref="DesiredInstallationState"/> values are the same. </summary>
        public static bool operator ==(DesiredInstallationState left, DesiredInstallationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DesiredInstallationState"/> values are not the same. </summary>
        public static bool operator !=(DesiredInstallationState left, DesiredInstallationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DesiredInstallationState"/>. </summary>
        public static implicit operator DesiredInstallationState(string value) => new DesiredInstallationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DesiredInstallationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DesiredInstallationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
