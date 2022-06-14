// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The type of the VM. </summary>
    public readonly partial struct VmTier : IEquatable<VmTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string LowPriorityValue = "LowPriority";
        private const string SpotValue = "Spot";

        /// <summary> Standard. </summary>
        public static VmTier Standard { get; } = new VmTier(StandardValue);
        /// <summary> LowPriority. </summary>
        public static VmTier LowPriority { get; } = new VmTier(LowPriorityValue);
        /// <summary> Spot. </summary>
        public static VmTier Spot { get; } = new VmTier(SpotValue);
        /// <summary> Determines if two <see cref="VmTier"/> values are the same. </summary>
        public static bool operator ==(VmTier left, VmTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmTier"/> values are not the same. </summary>
        public static bool operator !=(VmTier left, VmTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VmTier"/>. </summary>
        public static implicit operator VmTier(string value) => new VmTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
