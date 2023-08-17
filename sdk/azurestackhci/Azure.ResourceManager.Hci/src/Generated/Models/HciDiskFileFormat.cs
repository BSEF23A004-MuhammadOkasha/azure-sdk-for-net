// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The format of the actual VHD file [vhd, vhdx]. </summary>
    public readonly partial struct HciDiskFileFormat : IEquatable<HciDiskFileFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HciDiskFileFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HciDiskFileFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VhdxValue = "vhdx";
        private const string VhdValue = "vhd";

        /// <summary> vhdx. </summary>
        public static HciDiskFileFormat Vhdx { get; } = new HciDiskFileFormat(VhdxValue);
        /// <summary> vhd. </summary>
        public static HciDiskFileFormat Vhd { get; } = new HciDiskFileFormat(VhdValue);
        /// <summary> Determines if two <see cref="HciDiskFileFormat"/> values are the same. </summary>
        public static bool operator ==(HciDiskFileFormat left, HciDiskFileFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HciDiskFileFormat"/> values are not the same. </summary>
        public static bool operator !=(HciDiskFileFormat left, HciDiskFileFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HciDiskFileFormat"/>. </summary>
        public static implicit operator HciDiskFileFormat(string value) => new HciDiskFileFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HciDiskFileFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HciDiskFileFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
