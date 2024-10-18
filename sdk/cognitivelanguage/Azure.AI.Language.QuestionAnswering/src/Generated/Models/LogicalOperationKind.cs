// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> Set to 'OR' or 'AND' for using corresponding logical operation. </summary>
    public readonly partial struct LogicalOperationKind : IEquatable<LogicalOperationKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogicalOperationKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogicalOperationKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AndValue = "AND";
        private const string OrValue = "OR";
        /// <summary> Determines if two <see cref="LogicalOperationKind"/> values are the same. </summary>
        public static bool operator ==(LogicalOperationKind left, LogicalOperationKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogicalOperationKind"/> values are not the same. </summary>
        public static bool operator !=(LogicalOperationKind left, LogicalOperationKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LogicalOperationKind"/>. </summary>
        public static implicit operator LogicalOperationKind(string value) => new LogicalOperationKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogicalOperationKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogicalOperationKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
