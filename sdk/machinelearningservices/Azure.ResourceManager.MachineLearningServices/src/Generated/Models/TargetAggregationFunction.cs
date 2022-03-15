// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Target aggregate function. </summary>
    public readonly partial struct TargetAggregationFunction : IEquatable<TargetAggregationFunction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TargetAggregationFunction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TargetAggregationFunction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";

        /// <summary> Represent no value set. </summary>
        public static TargetAggregationFunction None { get; } = new TargetAggregationFunction(NoneValue);
        /// <summary> Determines if two <see cref="TargetAggregationFunction"/> values are the same. </summary>
        public static bool operator ==(TargetAggregationFunction left, TargetAggregationFunction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TargetAggregationFunction"/> values are not the same. </summary>
        public static bool operator !=(TargetAggregationFunction left, TargetAggregationFunction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TargetAggregationFunction"/>. </summary>
        public static implicit operator TargetAggregationFunction(string value) => new TargetAggregationFunction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TargetAggregationFunction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TargetAggregationFunction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
