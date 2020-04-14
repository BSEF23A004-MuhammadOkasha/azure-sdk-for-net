// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Models
{
    /// <summary> Defines the data type of a field in a search index. </summary>
    public readonly partial struct DataType : IEquatable<DataType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DataType"/> values are the same. </summary>
        public DataType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "Edm.String";
        private const string Int32Value = "Edm.Int32";
        private const string Int64Value = "Edm.Int64";
        private const string DoubleValue = "Edm.Double";
        private const string BooleanValue = "Edm.Boolean";
        private const string DateTimeOffsetValue = "Edm.DateTimeOffset";
        private const string GeographyPointValue = "Edm.GeographyPoint";
        private const string ComplexValue = "Edm.ComplexType";
        /// <summary> Determines if two <see cref="DataType"/> values are the same. </summary>
        public static bool operator ==(DataType left, DataType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataType"/> values are not the same. </summary>
        public static bool operator !=(DataType left, DataType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataType"/>. </summary>
        public static implicit operator DataType(string value) => new DataType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
