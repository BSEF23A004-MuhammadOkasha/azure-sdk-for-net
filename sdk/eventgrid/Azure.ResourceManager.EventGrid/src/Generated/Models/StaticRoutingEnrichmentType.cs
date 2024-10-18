// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Static routing enrichment value type. For e.g. this property value can be 'String'. </summary>
    internal readonly partial struct StaticRoutingEnrichmentType : IEquatable<StaticRoutingEnrichmentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StaticRoutingEnrichmentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StaticRoutingEnrichmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "String";

        /// <summary> String. </summary>
        public static StaticRoutingEnrichmentType String { get; } = new StaticRoutingEnrichmentType(StringValue);
        /// <summary> Determines if two <see cref="StaticRoutingEnrichmentType"/> values are the same. </summary>
        public static bool operator ==(StaticRoutingEnrichmentType left, StaticRoutingEnrichmentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StaticRoutingEnrichmentType"/> values are not the same. </summary>
        public static bool operator !=(StaticRoutingEnrichmentType left, StaticRoutingEnrichmentType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StaticRoutingEnrichmentType"/>. </summary>
        public static implicit operator StaticRoutingEnrichmentType(string value) => new StaticRoutingEnrichmentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StaticRoutingEnrichmentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StaticRoutingEnrichmentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
