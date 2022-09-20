// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Specifies the assignment type and execution of the configuration. Possible values are Audit, DeployAndAutoCorrect, ApplyAndAutoCorrect and ApplyAndMonitor. </summary>
    public readonly partial struct GuestConfigurationAssignmentType : IEquatable<GuestConfigurationAssignmentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationAssignmentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GuestConfigurationAssignmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AuditValue = "Audit";
        private const string DeployAndAutoCorrectValue = "DeployAndAutoCorrect";
        private const string ApplyAndAutoCorrectValue = "ApplyAndAutoCorrect";
        private const string ApplyAndMonitorValue = "ApplyAndMonitor";

        /// <summary> Audit. </summary>
        public static GuestConfigurationAssignmentType Audit { get; } = new GuestConfigurationAssignmentType(AuditValue);
        /// <summary> DeployAndAutoCorrect. </summary>
        public static GuestConfigurationAssignmentType DeployAndAutoCorrect { get; } = new GuestConfigurationAssignmentType(DeployAndAutoCorrectValue);
        /// <summary> ApplyAndAutoCorrect. </summary>
        public static GuestConfigurationAssignmentType ApplyAndAutoCorrect { get; } = new GuestConfigurationAssignmentType(ApplyAndAutoCorrectValue);
        /// <summary> ApplyAndMonitor. </summary>
        public static GuestConfigurationAssignmentType ApplyAndMonitor { get; } = new GuestConfigurationAssignmentType(ApplyAndMonitorValue);
        /// <summary> Determines if two <see cref="GuestConfigurationAssignmentType"/> values are the same. </summary>
        public static bool operator ==(GuestConfigurationAssignmentType left, GuestConfigurationAssignmentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GuestConfigurationAssignmentType"/> values are not the same. </summary>
        public static bool operator !=(GuestConfigurationAssignmentType left, GuestConfigurationAssignmentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GuestConfigurationAssignmentType"/>. </summary>
        public static implicit operator GuestConfigurationAssignmentType(string value) => new GuestConfigurationAssignmentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GuestConfigurationAssignmentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GuestConfigurationAssignmentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
