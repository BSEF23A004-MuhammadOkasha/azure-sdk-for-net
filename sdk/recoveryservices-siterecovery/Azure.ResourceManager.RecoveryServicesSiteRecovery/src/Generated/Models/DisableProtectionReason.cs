// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Disable protection reason. It can have values NotSpecified/MigrationComplete. </summary>
    public readonly partial struct DisableProtectionReason : IEquatable<DisableProtectionReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DisableProtectionReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DisableProtectionReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string MigrationCompleteValue = "MigrationComplete";

        /// <summary> NotSpecified. </summary>
        public static DisableProtectionReason NotSpecified { get; } = new DisableProtectionReason(NotSpecifiedValue);
        /// <summary> MigrationComplete. </summary>
        public static DisableProtectionReason MigrationComplete { get; } = new DisableProtectionReason(MigrationCompleteValue);
        /// <summary> Determines if two <see cref="DisableProtectionReason"/> values are the same. </summary>
        public static bool operator ==(DisableProtectionReason left, DisableProtectionReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DisableProtectionReason"/> values are not the same. </summary>
        public static bool operator !=(DisableProtectionReason left, DisableProtectionReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DisableProtectionReason"/>. </summary>
        public static implicit operator DisableProtectionReason(string value) => new DisableProtectionReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DisableProtectionReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DisableProtectionReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
