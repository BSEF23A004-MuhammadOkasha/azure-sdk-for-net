// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> This is a required field. This field is used to schedule an inventory formation. </summary>
    public readonly partial struct BlobInventoryPolicySchedule : IEquatable<BlobInventoryPolicySchedule>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicySchedule"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BlobInventoryPolicySchedule(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DailyValue = "Daily";
        private const string WeeklyValue = "Weekly";

        /// <summary> Daily. </summary>
        public static BlobInventoryPolicySchedule Daily { get; } = new BlobInventoryPolicySchedule(DailyValue);
        /// <summary> Weekly. </summary>
        public static BlobInventoryPolicySchedule Weekly { get; } = new BlobInventoryPolicySchedule(WeeklyValue);
        /// <summary> Determines if two <see cref="BlobInventoryPolicySchedule"/> values are the same. </summary>
        public static bool operator ==(BlobInventoryPolicySchedule left, BlobInventoryPolicySchedule right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BlobInventoryPolicySchedule"/> values are not the same. </summary>
        public static bool operator !=(BlobInventoryPolicySchedule left, BlobInventoryPolicySchedule right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BlobInventoryPolicySchedule"/>. </summary>
        public static implicit operator BlobInventoryPolicySchedule(string value) => new BlobInventoryPolicySchedule(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BlobInventoryPolicySchedule other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BlobInventoryPolicySchedule other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
