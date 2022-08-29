// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The type of resource, Microsoft.Kusto/clusters/databases/dataConnections. </summary>
    public readonly partial struct DataConnectionType : IEquatable<DataConnectionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataConnectionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataConnectionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftKustoClustersDatabasesDataConnectionsValue = "Microsoft.Kusto/clusters/databases/dataConnections";

        /// <summary> Microsoft.Kusto/clusters/databases/dataConnections. </summary>
        public static DataConnectionType MicrosoftKustoClustersDatabasesDataConnections { get; } = new DataConnectionType(MicrosoftKustoClustersDatabasesDataConnectionsValue);
        /// <summary> Determines if two <see cref="DataConnectionType"/> values are the same. </summary>
        public static bool operator ==(DataConnectionType left, DataConnectionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataConnectionType"/> values are not the same. </summary>
        public static bool operator !=(DataConnectionType left, DataConnectionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataConnectionType"/>. </summary>
        public static implicit operator DataConnectionType(string value) => new DataConnectionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataConnectionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataConnectionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
