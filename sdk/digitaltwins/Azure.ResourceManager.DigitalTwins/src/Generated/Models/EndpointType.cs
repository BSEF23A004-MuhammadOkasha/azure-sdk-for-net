// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The type of Digital Twins endpoint. </summary>
    internal readonly partial struct EndpointType : IEquatable<EndpointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EndpointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EndpointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EventHubValue = "EventHub";
        private const string EventGridValue = "EventGrid";
        private const string ServiceBusValue = "ServiceBus";

        /// <summary> EventHub. </summary>
        public static EndpointType EventHub { get; } = new EndpointType(EventHubValue);
        /// <summary> EventGrid. </summary>
        public static EndpointType EventGrid { get; } = new EndpointType(EventGridValue);
        /// <summary> ServiceBus. </summary>
        public static EndpointType ServiceBus { get; } = new EndpointType(ServiceBusValue);
        /// <summary> Determines if two <see cref="EndpointType"/> values are the same. </summary>
        public static bool operator ==(EndpointType left, EndpointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EndpointType"/> values are not the same. </summary>
        public static bool operator !=(EndpointType left, EndpointType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EndpointType"/>. </summary>
        public static implicit operator EndpointType(string value) => new EndpointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EndpointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EndpointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
