// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Mount Action. </summary>
    public readonly partial struct MountAction : IEquatable<MountAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MountAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MountAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MountValue = "Mount";
        private const string UnmountValue = "Unmount";

        /// <summary> Mount. </summary>
        public static MountAction Mount { get; } = new MountAction(MountValue);
        /// <summary> Unmount. </summary>
        public static MountAction Unmount { get; } = new MountAction(UnmountValue);
        /// <summary> Determines if two <see cref="MountAction"/> values are the same. </summary>
        public static bool operator ==(MountAction left, MountAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MountAction"/> values are not the same. </summary>
        public static bool operator !=(MountAction left, MountAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MountAction"/>. </summary>
        public static implicit operator MountAction(string value) => new MountAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MountAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MountAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
