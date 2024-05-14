// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Configured state of the client. The value could be Enabled or Disabled. </summary>
    public readonly partial struct EventGridMqttClientState : IEquatable<EventGridMqttClientState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridMqttClientState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridMqttClientState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static EventGridMqttClientState Enabled { get; } = new EventGridMqttClientState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static EventGridMqttClientState Disabled { get; } = new EventGridMqttClientState(DisabledValue);
        /// <summary> Determines if two <see cref="EventGridMqttClientState"/> values are the same. </summary>
        public static bool operator ==(EventGridMqttClientState left, EventGridMqttClientState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridMqttClientState"/> values are not the same. </summary>
        public static bool operator !=(EventGridMqttClientState left, EventGridMqttClientState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventGridMqttClientState"/>. </summary>
        public static implicit operator EventGridMqttClientState(string value) => new EventGridMqttClientState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridMqttClientState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridMqttClientState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
