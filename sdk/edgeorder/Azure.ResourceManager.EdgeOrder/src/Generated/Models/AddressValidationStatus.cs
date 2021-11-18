// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Status of address validation. </summary>
    public readonly partial struct AddressValidationStatus : IEquatable<AddressValidationStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AddressValidationStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AddressValidationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValidValue = "Valid";
        private const string InvalidValue = "Invalid";
        private const string AmbiguousValue = "Ambiguous";

        /// <summary> Address provided is valid. </summary>
        public static AddressValidationStatus Valid { get; } = new AddressValidationStatus(ValidValue);
        /// <summary> Address provided is invalid or not supported. </summary>
        public static AddressValidationStatus Invalid { get; } = new AddressValidationStatus(InvalidValue);
        /// <summary> Address provided is ambiguous, please choose one of the alternate addresses returned. </summary>
        public static AddressValidationStatus Ambiguous { get; } = new AddressValidationStatus(AmbiguousValue);
        /// <summary> Determines if two <see cref="AddressValidationStatus"/> values are the same. </summary>
        public static bool operator ==(AddressValidationStatus left, AddressValidationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AddressValidationStatus"/> values are not the same. </summary>
        public static bool operator !=(AddressValidationStatus left, AddressValidationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AddressValidationStatus"/>. </summary>
        public static implicit operator AddressValidationStatus(string value) => new AddressValidationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AddressValidationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AddressValidationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
