// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The kind of the resource. </summary>
    public readonly partial struct KnownDataCollectionEndpointResourceKind : IEquatable<KnownDataCollectionEndpointResourceKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KnownDataCollectionEndpointResourceKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KnownDataCollectionEndpointResourceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LinuxValue = "Linux";
        private const string WindowsValue = "Windows";

        /// <summary> Linux. </summary>
        public static KnownDataCollectionEndpointResourceKind Linux { get; } = new KnownDataCollectionEndpointResourceKind(LinuxValue);
        /// <summary> Windows. </summary>
        public static KnownDataCollectionEndpointResourceKind Windows { get; } = new KnownDataCollectionEndpointResourceKind(WindowsValue);
        /// <summary> Determines if two <see cref="KnownDataCollectionEndpointResourceKind"/> values are the same. </summary>
        public static bool operator ==(KnownDataCollectionEndpointResourceKind left, KnownDataCollectionEndpointResourceKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KnownDataCollectionEndpointResourceKind"/> values are not the same. </summary>
        public static bool operator !=(KnownDataCollectionEndpointResourceKind left, KnownDataCollectionEndpointResourceKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KnownDataCollectionEndpointResourceKind"/>. </summary>
        public static implicit operator KnownDataCollectionEndpointResourceKind(string value) => new KnownDataCollectionEndpointResourceKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KnownDataCollectionEndpointResourceKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KnownDataCollectionEndpointResourceKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
