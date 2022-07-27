// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The RecordingStatus. </summary>
    public readonly partial struct RecordingStatus : IEquatable<RecordingStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecordingStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecordingStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "active";
        private const string InactiveValue = "inactive";

        /// <summary> active. </summary>
        public static RecordingStatus Active { get; } = new RecordingStatus(ActiveValue);
        /// <summary> inactive. </summary>
        public static RecordingStatus Inactive { get; } = new RecordingStatus(InactiveValue);
        /// <summary> Determines if two <see cref="RecordingStatus"/> values are the same. </summary>
        public static bool operator ==(RecordingStatus left, RecordingStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecordingStatus"/> values are not the same. </summary>
        public static bool operator !=(RecordingStatus left, RecordingStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecordingStatus"/>. </summary>
        public static implicit operator RecordingStatus(string value) => new RecordingStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecordingStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecordingStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
