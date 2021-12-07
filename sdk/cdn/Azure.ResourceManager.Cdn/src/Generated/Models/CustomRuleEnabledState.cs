// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified. </summary>
    public readonly partial struct CustomRuleEnabledState : IEquatable<CustomRuleEnabledState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CustomRuleEnabledState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CustomRuleEnabledState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static CustomRuleEnabledState Disabled { get; } = new CustomRuleEnabledState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static CustomRuleEnabledState Enabled { get; } = new CustomRuleEnabledState(EnabledValue);
        /// <summary> Determines if two <see cref="CustomRuleEnabledState"/> values are the same. </summary>
        public static bool operator ==(CustomRuleEnabledState left, CustomRuleEnabledState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CustomRuleEnabledState"/> values are not the same. </summary>
        public static bool operator !=(CustomRuleEnabledState left, CustomRuleEnabledState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CustomRuleEnabledState"/>. </summary>
        public static implicit operator CustomRuleEnabledState(string value) => new CustomRuleEnabledState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CustomRuleEnabledState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CustomRuleEnabledState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
