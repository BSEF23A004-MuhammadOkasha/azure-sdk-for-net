// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> All available types of copy behavior. </summary>
    public readonly partial struct CopyBehaviorType : IEquatable<CopyBehaviorType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CopyBehaviorType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CopyBehaviorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PreserveHierarchyValue = "PreserveHierarchy";
        private const string FlattenHierarchyValue = "FlattenHierarchy";
        private const string MergeFilesValue = "MergeFiles";

        /// <summary> PreserveHierarchy. </summary>
        public static CopyBehaviorType PreserveHierarchy { get; } = new CopyBehaviorType(PreserveHierarchyValue);
        /// <summary> FlattenHierarchy. </summary>
        public static CopyBehaviorType FlattenHierarchy { get; } = new CopyBehaviorType(FlattenHierarchyValue);
        /// <summary> MergeFiles. </summary>
        public static CopyBehaviorType MergeFiles { get; } = new CopyBehaviorType(MergeFilesValue);
        /// <summary> Determines if two <see cref="CopyBehaviorType"/> values are the same. </summary>
        public static bool operator ==(CopyBehaviorType left, CopyBehaviorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CopyBehaviorType"/> values are not the same. </summary>
        public static bool operator !=(CopyBehaviorType left, CopyBehaviorType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CopyBehaviorType"/>. </summary>
        public static implicit operator CopyBehaviorType(string value) => new CopyBehaviorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CopyBehaviorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CopyBehaviorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
