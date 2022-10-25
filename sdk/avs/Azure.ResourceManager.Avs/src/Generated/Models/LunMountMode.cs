// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN. </summary>
    public readonly partial struct LunMountMode : IEquatable<LunMountMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LunMountMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LunMountMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MountValue = "MOUNT";
        private const string AttachValue = "ATTACH";

        /// <summary> MOUNT. </summary>
        public static LunMountMode Mount { get; } = new LunMountMode(MountValue);
        /// <summary> ATTACH. </summary>
        public static LunMountMode Attach { get; } = new LunMountMode(AttachValue);
        /// <summary> Determines if two <see cref="LunMountMode"/> values are the same. </summary>
        public static bool operator ==(LunMountMode left, LunMountMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LunMountMode"/> values are not the same. </summary>
        public static bool operator !=(LunMountMode left, LunMountMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LunMountMode"/>. </summary>
        public static implicit operator LunMountMode(string value) => new LunMountMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LunMountMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LunMountMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
