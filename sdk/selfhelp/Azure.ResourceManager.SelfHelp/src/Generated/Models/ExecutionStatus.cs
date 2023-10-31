// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Status of Troubleshooter Step execution. </summary>
    public readonly partial struct ExecutionStatus : IEquatable<ExecutionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExecutionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExecutionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SuccessValue = "Success";
        private const string RunningValue = "Running";
        private const string FailedValue = "Failed";
        private const string WarningValue = "Warning";

        /// <summary> Success. </summary>
        public static ExecutionStatus Success { get; } = new ExecutionStatus(SuccessValue);
        /// <summary> Running. </summary>
        public static ExecutionStatus Running { get; } = new ExecutionStatus(RunningValue);
        /// <summary> Failed. </summary>
        public static ExecutionStatus Failed { get; } = new ExecutionStatus(FailedValue);
        /// <summary> Warning. </summary>
        public static ExecutionStatus Warning { get; } = new ExecutionStatus(WarningValue);
        /// <summary> Determines if two <see cref="ExecutionStatus"/> values are the same. </summary>
        public static bool operator ==(ExecutionStatus left, ExecutionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExecutionStatus"/> values are not the same. </summary>
        public static bool operator !=(ExecutionStatus left, ExecutionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExecutionStatus"/>. </summary>
        public static implicit operator ExecutionStatus(string value) => new ExecutionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExecutionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExecutionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
