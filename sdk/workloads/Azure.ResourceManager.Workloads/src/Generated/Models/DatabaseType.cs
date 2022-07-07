// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Database type. </summary>
    public readonly partial struct DatabaseType : IEquatable<DatabaseType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatabaseType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatabaseType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MySqlValue = "MySql";

        /// <summary> MySql. </summary>
        public static DatabaseType MySql { get; } = new DatabaseType(MySqlValue);
        /// <summary> Determines if two <see cref="DatabaseType"/> values are the same. </summary>
        public static bool operator ==(DatabaseType left, DatabaseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatabaseType"/> values are not the same. </summary>
        public static bool operator !=(DatabaseType left, DatabaseType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DatabaseType"/>. </summary>
        public static implicit operator DatabaseType(string value) => new DatabaseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatabaseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatabaseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
