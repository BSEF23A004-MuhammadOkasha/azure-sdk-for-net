// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The ServerTrustGroupPropertiesTrustScopesItem. </summary>
    public readonly partial struct ServerTrustGroupPropertiesTrustScopesItem : IEquatable<ServerTrustGroupPropertiesTrustScopesItem>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServerTrustGroupPropertiesTrustScopesItem"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServerTrustGroupPropertiesTrustScopesItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GlobalTransactionsValue = "GlobalTransactions";
        private const string ServiceBrokerValue = "ServiceBroker";

        /// <summary> GlobalTransactions. </summary>
        public static ServerTrustGroupPropertiesTrustScopesItem GlobalTransactions { get; } = new ServerTrustGroupPropertiesTrustScopesItem(GlobalTransactionsValue);
        /// <summary> ServiceBroker. </summary>
        public static ServerTrustGroupPropertiesTrustScopesItem ServiceBroker { get; } = new ServerTrustGroupPropertiesTrustScopesItem(ServiceBrokerValue);
        /// <summary> Determines if two <see cref="ServerTrustGroupPropertiesTrustScopesItem"/> values are the same. </summary>
        public static bool operator ==(ServerTrustGroupPropertiesTrustScopesItem left, ServerTrustGroupPropertiesTrustScopesItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerTrustGroupPropertiesTrustScopesItem"/> values are not the same. </summary>
        public static bool operator !=(ServerTrustGroupPropertiesTrustScopesItem left, ServerTrustGroupPropertiesTrustScopesItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServerTrustGroupPropertiesTrustScopesItem"/>. </summary>
        public static implicit operator ServerTrustGroupPropertiesTrustScopesItem(string value) => new ServerTrustGroupPropertiesTrustScopesItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerTrustGroupPropertiesTrustScopesItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerTrustGroupPropertiesTrustScopesItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
