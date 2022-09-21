// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> An enumeration of source platform types. </summary>
    public readonly partial struct SqlSourcePlatform : IEquatable<SqlSourcePlatform>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlSourcePlatform"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlSourcePlatform(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SqlOnPremValue = "SqlOnPrem";

        /// <summary> SqlOnPrem. </summary>
        public static SqlSourcePlatform SqlOnPrem { get; } = new SqlSourcePlatform(SqlOnPremValue);
        /// <summary> Determines if two <see cref="SqlSourcePlatform"/> values are the same. </summary>
        public static bool operator ==(SqlSourcePlatform left, SqlSourcePlatform right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlSourcePlatform"/> values are not the same. </summary>
        public static bool operator !=(SqlSourcePlatform left, SqlSourcePlatform right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlSourcePlatform"/>. </summary>
        public static implicit operator SqlSourcePlatform(string value) => new SqlSourcePlatform(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlSourcePlatform other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlSourcePlatform other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
