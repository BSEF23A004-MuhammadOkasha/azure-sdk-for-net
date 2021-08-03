// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> Enums containing high level error codes. </summary>
    public readonly partial struct TranslationErrorCode : IEquatable<TranslationErrorCode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TranslationErrorCode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TranslationErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidRequestValue = "InvalidRequest";
        private const string InvalidArgumentValue = "InvalidArgument";
        private const string InternalServerErrorValue = "InternalServerError";
        private const string ServiceUnavailableValue = "ServiceUnavailable";
        private const string ResourceNotFoundValue = "ResourceNotFound";
        private const string UnauthorizedValue = "Unauthorized";
        private const string RequestRateTooHighValue = "RequestRateTooHigh";

        /// <summary> InvalidRequest. </summary>
        public static TranslationErrorCode InvalidRequest { get; } = new TranslationErrorCode(InvalidRequestValue);
        /// <summary> InvalidArgument. </summary>
        public static TranslationErrorCode InvalidArgument { get; } = new TranslationErrorCode(InvalidArgumentValue);
        /// <summary> InternalServerError. </summary>
        public static TranslationErrorCode InternalServerError { get; } = new TranslationErrorCode(InternalServerErrorValue);
        /// <summary> ServiceUnavailable. </summary>
        public static TranslationErrorCode ServiceUnavailable { get; } = new TranslationErrorCode(ServiceUnavailableValue);
        /// <summary> ResourceNotFound. </summary>
        public static TranslationErrorCode ResourceNotFound { get; } = new TranslationErrorCode(ResourceNotFoundValue);
        /// <summary> Unauthorized. </summary>
        public static TranslationErrorCode Unauthorized { get; } = new TranslationErrorCode(UnauthorizedValue);
        /// <summary> RequestRateTooHigh. </summary>
        public static TranslationErrorCode RequestRateTooHigh { get; } = new TranslationErrorCode(RequestRateTooHighValue);
        /// <summary> Determines if two <see cref="TranslationErrorCode"/> values are the same. </summary>
        public static bool operator ==(TranslationErrorCode left, TranslationErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TranslationErrorCode"/> values are not the same. </summary>
        public static bool operator !=(TranslationErrorCode left, TranslationErrorCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TranslationErrorCode"/>. </summary>
        public static implicit operator TranslationErrorCode(string value) => new TranslationErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TranslationErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TranslationErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
