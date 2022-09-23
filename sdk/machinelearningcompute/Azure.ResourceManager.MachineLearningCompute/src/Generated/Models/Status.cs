// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> SSL status. Allowed values are Enabled and Disabled. </summary>
    public readonly partial struct Status : IEquatable<Status>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Status"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Status(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static Status Enabled { get; } = new Status(EnabledValue);
        /// <summary> Disabled. </summary>
        public static Status Disabled { get; } = new Status(DisabledValue);
        /// <summary> Determines if two <see cref="Status"/> values are the same. </summary>
        public static bool operator ==(Status left, Status right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Status"/> values are not the same. </summary>
        public static bool operator !=(Status left, Status right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Status"/>. </summary>
        public static implicit operator Status(string value) => new Status(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Status other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Status other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
