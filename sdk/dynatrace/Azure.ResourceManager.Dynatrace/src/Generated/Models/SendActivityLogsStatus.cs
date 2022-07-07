// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Indicates whether activity logs are being sent. </summary>
    public readonly partial struct SendActivityLogsStatus : IEquatable<SendActivityLogsStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SendActivityLogsStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SendActivityLogsStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static SendActivityLogsStatus Enabled { get; } = new SendActivityLogsStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static SendActivityLogsStatus Disabled { get; } = new SendActivityLogsStatus(DisabledValue);
        /// <summary> Determines if two <see cref="SendActivityLogsStatus"/> values are the same. </summary>
        public static bool operator ==(SendActivityLogsStatus left, SendActivityLogsStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SendActivityLogsStatus"/> values are not the same. </summary>
        public static bool operator !=(SendActivityLogsStatus left, SendActivityLogsStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SendActivityLogsStatus"/>. </summary>
        public static implicit operator SendActivityLogsStatus(string value) => new SendActivityLogsStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SendActivityLogsStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SendActivityLogsStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
