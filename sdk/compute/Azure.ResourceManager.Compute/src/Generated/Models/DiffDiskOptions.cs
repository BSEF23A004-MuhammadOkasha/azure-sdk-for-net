// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the ephemeral disk option for operating system disk. </summary>
    public readonly partial struct DiffDiskOptions : IEquatable<DiffDiskOptions>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DiffDiskOptions"/> values are the same. </summary>
        public DiffDiskOptions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LocalValue = "Local";

        /// <summary> Local. </summary>
        public static DiffDiskOptions Local { get; } = new DiffDiskOptions(LocalValue);
        /// <summary> Determines if two <see cref="DiffDiskOptions"/> values are the same. </summary>
        public static bool operator ==(DiffDiskOptions left, DiffDiskOptions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiffDiskOptions"/> values are not the same. </summary>
        public static bool operator !=(DiffDiskOptions left, DiffDiskOptions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiffDiskOptions"/>. </summary>
        public static implicit operator DiffDiskOptions(string value) => new DiffDiskOptions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiffDiskOptions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiffDiskOptions other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
