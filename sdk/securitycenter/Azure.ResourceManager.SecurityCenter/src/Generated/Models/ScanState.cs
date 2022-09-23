// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The scan status. </summary>
    public readonly partial struct ScanState : IEquatable<ScanState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScanState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScanState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FailedValue = "Failed";
        private const string FailedToRunValue = "FailedToRun";
        private const string InProgressValue = "InProgress";
        private const string PassedValue = "Passed";

        /// <summary> Failed. </summary>
        public static ScanState Failed { get; } = new ScanState(FailedValue);
        /// <summary> FailedToRun. </summary>
        public static ScanState FailedToRun { get; } = new ScanState(FailedToRunValue);
        /// <summary> InProgress. </summary>
        public static ScanState InProgress { get; } = new ScanState(InProgressValue);
        /// <summary> Passed. </summary>
        public static ScanState Passed { get; } = new ScanState(PassedValue);
        /// <summary> Determines if two <see cref="ScanState"/> values are the same. </summary>
        public static bool operator ==(ScanState left, ScanState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScanState"/> values are not the same. </summary>
        public static bool operator !=(ScanState left, ScanState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScanState"/>. </summary>
        public static implicit operator ScanState(string value) => new ScanState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScanState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScanState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
