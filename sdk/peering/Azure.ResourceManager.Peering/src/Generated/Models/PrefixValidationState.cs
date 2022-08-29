// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The prefix validation state. </summary>
    public readonly partial struct PrefixValidationState : IEquatable<PrefixValidationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrefixValidationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrefixValidationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string InvalidValue = "Invalid";
        private const string VerifiedValue = "Verified";
        private const string FailedValue = "Failed";
        private const string PendingValue = "Pending";
        private const string WarningValue = "Warning";
        private const string UnknownValue = "Unknown";

        /// <summary> None. </summary>
        public static PrefixValidationState None { get; } = new PrefixValidationState(NoneValue);
        /// <summary> Invalid. </summary>
        public static PrefixValidationState Invalid { get; } = new PrefixValidationState(InvalidValue);
        /// <summary> Verified. </summary>
        public static PrefixValidationState Verified { get; } = new PrefixValidationState(VerifiedValue);
        /// <summary> Failed. </summary>
        public static PrefixValidationState Failed { get; } = new PrefixValidationState(FailedValue);
        /// <summary> Pending. </summary>
        public static PrefixValidationState Pending { get; } = new PrefixValidationState(PendingValue);
        /// <summary> Warning. </summary>
        public static PrefixValidationState Warning { get; } = new PrefixValidationState(WarningValue);
        /// <summary> Unknown. </summary>
        public static PrefixValidationState Unknown { get; } = new PrefixValidationState(UnknownValue);
        /// <summary> Determines if two <see cref="PrefixValidationState"/> values are the same. </summary>
        public static bool operator ==(PrefixValidationState left, PrefixValidationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrefixValidationState"/> values are not the same. </summary>
        public static bool operator !=(PrefixValidationState left, PrefixValidationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrefixValidationState"/>. </summary>
        public static implicit operator PrefixValidationState(string value) => new PrefixValidationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrefixValidationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrefixValidationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
