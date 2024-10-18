// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> To trigger cancel for entire migration we need to send this flag as True. </summary>
    public readonly partial struct PostgreSqlMigrationCancel : IEquatable<PostgreSqlMigrationCancel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationCancel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlMigrationCancel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static PostgreSqlMigrationCancel True { get; } = new PostgreSqlMigrationCancel(TrueValue);
        /// <summary> False. </summary>
        public static PostgreSqlMigrationCancel False { get; } = new PostgreSqlMigrationCancel(FalseValue);
        /// <summary> Determines if two <see cref="PostgreSqlMigrationCancel"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlMigrationCancel left, PostgreSqlMigrationCancel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlMigrationCancel"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlMigrationCancel left, PostgreSqlMigrationCancel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlMigrationCancel"/>. </summary>
        public static implicit operator PostgreSqlMigrationCancel(string value) => new PostgreSqlMigrationCancel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlMigrationCancel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlMigrationCancel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
