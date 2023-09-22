// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The operation status code. </summary>
    public readonly partial struct ExtensionOperationStatusCode : IEquatable<ExtensionOperationStatusCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExtensionOperationStatusCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExtensionOperationStatusCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Extension was created/updated successfully. </summary>
        public static ExtensionOperationStatusCode Succeeded { get; } = new ExtensionOperationStatusCode(SucceededValue);
        /// <summary> Extension was not created/updated successfully. See operation status message for more details. </summary>
        public static ExtensionOperationStatusCode Failed { get; } = new ExtensionOperationStatusCode(FailedValue);
        /// <summary> Determines if two <see cref="ExtensionOperationStatusCode"/> values are the same. </summary>
        public static bool operator ==(ExtensionOperationStatusCode left, ExtensionOperationStatusCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExtensionOperationStatusCode"/> values are not the same. </summary>
        public static bool operator !=(ExtensionOperationStatusCode left, ExtensionOperationStatusCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExtensionOperationStatusCode"/>. </summary>
        public static implicit operator ExtensionOperationStatusCode(string value) => new ExtensionOperationStatusCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExtensionOperationStatusCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExtensionOperationStatusCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
