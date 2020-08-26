// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Execution, display, or stream outputs. </summary>
    public readonly partial struct CellOutputType : IEquatable<CellOutputType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CellOutputType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CellOutputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExecuteResultValue = "execute_result";
        private const string DisplayDataValue = "display_data";
        private const string StreamValue = "stream";
        private const string ErrorValue = "error";

        /// <summary> execute_result. </summary>
        public static CellOutputType ExecuteResult { get; } = new CellOutputType(ExecuteResultValue);
        /// <summary> display_data. </summary>
        public static CellOutputType DisplayData { get; } = new CellOutputType(DisplayDataValue);
        /// <summary> stream. </summary>
        public static CellOutputType Stream { get; } = new CellOutputType(StreamValue);
        /// <summary> error. </summary>
        public static CellOutputType Error { get; } = new CellOutputType(ErrorValue);
        /// <summary> Determines if two <see cref="CellOutputType"/> values are the same. </summary>
        public static bool operator ==(CellOutputType left, CellOutputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CellOutputType"/> values are not the same. </summary>
        public static bool operator !=(CellOutputType left, CellOutputType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CellOutputType"/>. </summary>
        public static implicit operator CellOutputType(string value) => new CellOutputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CellOutputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CellOutputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
