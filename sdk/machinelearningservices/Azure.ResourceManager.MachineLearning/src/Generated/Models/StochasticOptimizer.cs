// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Stochastic optimizer for image models. </summary>
    public readonly partial struct StochasticOptimizer : IEquatable<StochasticOptimizer>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StochasticOptimizer"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StochasticOptimizer(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SgdValue = "Sgd";
        private const string AdamValue = "Adam";
        private const string AdamwValue = "Adamw";

        /// <summary> No optimizer selected. </summary>
        public static StochasticOptimizer None { get; } = new StochasticOptimizer(NoneValue);
        /// <summary> Stochastic Gradient Descent optimizer. </summary>
        public static StochasticOptimizer Sgd { get; } = new StochasticOptimizer(SgdValue);
        /// <summary> Adam is algorithm the optimizes stochastic objective functions based on adaptive estimates of moments. </summary>
        public static StochasticOptimizer Adam { get; } = new StochasticOptimizer(AdamValue);
        /// <summary> AdamW is a variant of the optimizer Adam that has an improved implementation of weight decay. </summary>
        public static StochasticOptimizer Adamw { get; } = new StochasticOptimizer(AdamwValue);
        /// <summary> Determines if two <see cref="StochasticOptimizer"/> values are the same. </summary>
        public static bool operator ==(StochasticOptimizer left, StochasticOptimizer right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StochasticOptimizer"/> values are not the same. </summary>
        public static bool operator !=(StochasticOptimizer left, StochasticOptimizer right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StochasticOptimizer"/>. </summary>
        public static implicit operator StochasticOptimizer(string value) => new StochasticOptimizer(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StochasticOptimizer other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StochasticOptimizer other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
