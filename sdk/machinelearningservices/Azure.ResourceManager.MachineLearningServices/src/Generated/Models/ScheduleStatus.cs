// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Enum to describe status of schedule. </summary>
    public readonly partial struct ScheduleStatus : IEquatable<ScheduleStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScheduleStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScheduleStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Schedule is enabled. </summary>
        public static ScheduleStatus Enabled { get; } = new ScheduleStatus(EnabledValue);
        /// <summary> Schedule is disabled. </summary>
        public static ScheduleStatus Disabled { get; } = new ScheduleStatus(DisabledValue);
        /// <summary> Determines if two <see cref="ScheduleStatus"/> values are the same. </summary>
        public static bool operator ==(ScheduleStatus left, ScheduleStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScheduleStatus"/> values are not the same. </summary>
        public static bool operator !=(ScheduleStatus left, ScheduleStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScheduleStatus"/>. </summary>
        public static implicit operator ScheduleStatus(string value) => new ScheduleStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScheduleStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScheduleStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
