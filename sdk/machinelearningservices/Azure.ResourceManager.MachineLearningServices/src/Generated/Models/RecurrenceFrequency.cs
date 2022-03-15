// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Enum to describe the frequency of a recurrence schedule. </summary>
    public readonly partial struct RecurrenceFrequency : IEquatable<RecurrenceFrequency>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecurrenceFrequency"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecurrenceFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MinuteValue = "Minute";
        private const string HourValue = "Hour";
        private const string DayValue = "Day";
        private const string WeekValue = "Week";
        private const string MonthValue = "Month";

        /// <summary> Minute frequency. </summary>
        public static RecurrenceFrequency Minute { get; } = new RecurrenceFrequency(MinuteValue);
        /// <summary> Hour frequency. </summary>
        public static RecurrenceFrequency Hour { get; } = new RecurrenceFrequency(HourValue);
        /// <summary> Day frequency. </summary>
        public static RecurrenceFrequency Day { get; } = new RecurrenceFrequency(DayValue);
        /// <summary> Week frequency. </summary>
        public static RecurrenceFrequency Week { get; } = new RecurrenceFrequency(WeekValue);
        /// <summary> Month frequency. </summary>
        public static RecurrenceFrequency Month { get; } = new RecurrenceFrequency(MonthValue);
        /// <summary> Determines if two <see cref="RecurrenceFrequency"/> values are the same. </summary>
        public static bool operator ==(RecurrenceFrequency left, RecurrenceFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecurrenceFrequency"/> values are not the same. </summary>
        public static bool operator !=(RecurrenceFrequency left, RecurrenceFrequency right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecurrenceFrequency"/>. </summary>
        public static implicit operator RecurrenceFrequency(string value) => new RecurrenceFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecurrenceFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecurrenceFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
