// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct ServerPortOperator : IEquatable<ServerPortOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServerPortOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServerPortOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string EqualValue = "Equal";
        private const string ContainsValue = "Contains";
        private const string BeginsWithValue = "BeginsWith";
        private const string EndsWithValue = "EndsWith";
        private const string LessThanValue = "LessThan";
        private const string LessThanOrEqualValue = "LessThanOrEqual";
        private const string GreaterThanValue = "GreaterThan";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string RegExValue = "RegEx";

        /// <summary> Any. </summary>
        public static ServerPortOperator Any { get; } = new ServerPortOperator(AnyValue);
        /// <summary> Equal. </summary>
        public static ServerPortOperator Equal { get; } = new ServerPortOperator(EqualValue);
        /// <summary> Contains. </summary>
        public static ServerPortOperator Contains { get; } = new ServerPortOperator(ContainsValue);
        /// <summary> BeginsWith. </summary>
        public static ServerPortOperator BeginsWith { get; } = new ServerPortOperator(BeginsWithValue);
        /// <summary> EndsWith. </summary>
        public static ServerPortOperator EndsWith { get; } = new ServerPortOperator(EndsWithValue);
        /// <summary> LessThan. </summary>
        public static ServerPortOperator LessThan { get; } = new ServerPortOperator(LessThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static ServerPortOperator LessThanOrEqual { get; } = new ServerPortOperator(LessThanOrEqualValue);
        /// <summary> GreaterThan. </summary>
        public static ServerPortOperator GreaterThan { get; } = new ServerPortOperator(GreaterThanValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static ServerPortOperator GreaterThanOrEqual { get; } = new ServerPortOperator(GreaterThanOrEqualValue);
        /// <summary> RegEx. </summary>
        public static ServerPortOperator RegEx { get; } = new ServerPortOperator(RegExValue);
        /// <summary> Determines if two <see cref="ServerPortOperator"/> values are the same. </summary>
        public static bool operator ==(ServerPortOperator left, ServerPortOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerPortOperator"/> values are not the same. </summary>
        public static bool operator !=(ServerPortOperator left, ServerPortOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServerPortOperator"/>. </summary>
        public static implicit operator ServerPortOperator(string value) => new ServerPortOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerPortOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerPortOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
