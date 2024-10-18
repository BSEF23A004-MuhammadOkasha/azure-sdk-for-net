// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> Represents a supported Fabric/Infra. (AKSEdge etc...). </summary>
    public readonly partial struct ResourceConnectorDistro : IEquatable<ResourceConnectorDistro>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceConnectorDistro"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceConnectorDistro(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AksEdgeValue = "AKSEdge";

        /// <summary> AKSEdge. </summary>
        public static ResourceConnectorDistro AksEdge { get; } = new ResourceConnectorDistro(AksEdgeValue);
        /// <summary> Determines if two <see cref="ResourceConnectorDistro"/> values are the same. </summary>
        public static bool operator ==(ResourceConnectorDistro left, ResourceConnectorDistro right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceConnectorDistro"/> values are not the same. </summary>
        public static bool operator !=(ResourceConnectorDistro left, ResourceConnectorDistro right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ResourceConnectorDistro"/>. </summary>
        public static implicit operator ResourceConnectorDistro(string value) => new ResourceConnectorDistro(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceConnectorDistro other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceConnectorDistro other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
