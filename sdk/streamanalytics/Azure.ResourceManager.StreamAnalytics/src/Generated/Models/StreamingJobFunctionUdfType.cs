// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The function type. </summary>
    public readonly partial struct StreamingJobFunctionUdfType : IEquatable<StreamingJobFunctionUdfType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StreamingJobFunctionUdfType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StreamingJobFunctionUdfType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ScalarValue = "Scalar";

        /// <summary> Scalar. </summary>
        public static StreamingJobFunctionUdfType Scalar { get; } = new StreamingJobFunctionUdfType(ScalarValue);
        /// <summary> Determines if two <see cref="StreamingJobFunctionUdfType"/> values are the same. </summary>
        public static bool operator ==(StreamingJobFunctionUdfType left, StreamingJobFunctionUdfType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StreamingJobFunctionUdfType"/> values are not the same. </summary>
        public static bool operator !=(StreamingJobFunctionUdfType left, StreamingJobFunctionUdfType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StreamingJobFunctionUdfType"/>. </summary>
        public static implicit operator StreamingJobFunctionUdfType(string value) => new StreamingJobFunctionUdfType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StreamingJobFunctionUdfType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StreamingJobFunctionUdfType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
