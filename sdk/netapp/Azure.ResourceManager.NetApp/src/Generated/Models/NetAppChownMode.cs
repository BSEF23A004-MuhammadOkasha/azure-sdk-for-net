// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> This parameter specifies who is authorized to change the ownership of a file. restricted - Only root user can change the ownership of the file. unrestricted - Non-root users can change ownership of files that they own. </summary>
    public readonly partial struct NetAppChownMode : IEquatable<NetAppChownMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppChownMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppChownMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RestrictedValue = "Restricted";
        private const string UnrestrictedValue = "Unrestricted";

        /// <summary> Restricted. </summary>
        public static NetAppChownMode Restricted { get; } = new NetAppChownMode(RestrictedValue);
        /// <summary> Unrestricted. </summary>
        public static NetAppChownMode Unrestricted { get; } = new NetAppChownMode(UnrestrictedValue);
        /// <summary> Determines if two <see cref="NetAppChownMode"/> values are the same. </summary>
        public static bool operator ==(NetAppChownMode left, NetAppChownMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppChownMode"/> values are not the same. </summary>
        public static bool operator !=(NetAppChownMode left, NetAppChownMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppChownMode"/>. </summary>
        public static implicit operator NetAppChownMode(string value) => new NetAppChownMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppChownMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppChownMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
