// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The format of the Operation Name for Application Insights telemetries. Default is Name. </summary>
    public readonly partial struct OperationNameFormat : IEquatable<OperationNameFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationNameFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationNameFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NameValue = "Name";
        private const string UriValue = "Url";

        /// <summary> API_NAME;rev=API_REVISION - OPERATION_NAME. </summary>
        public static OperationNameFormat Name { get; } = new OperationNameFormat(NameValue);
        /// <summary> HTTP_VERB URL. </summary>
        public static OperationNameFormat Uri { get; } = new OperationNameFormat(UriValue);
        /// <summary> Determines if two <see cref="OperationNameFormat"/> values are the same. </summary>
        public static bool operator ==(OperationNameFormat left, OperationNameFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationNameFormat"/> values are not the same. </summary>
        public static bool operator !=(OperationNameFormat left, OperationNameFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationNameFormat"/>. </summary>
        public static implicit operator OperationNameFormat(string value) => new OperationNameFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationNameFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationNameFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
