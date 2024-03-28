// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> Human-readable error code. </summary>
    public readonly partial struct ErrorCode : IEquatable<ErrorCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ErrorCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidRequestValue = "InvalidRequest";
        private const string InvalidArgumentValue = "InvalidArgument";
        private const string UnauthorizedValue = "Unauthorized";
        private const string ForbiddenValue = "Forbidden";
        private const string NotFoundValue = "NotFound";
        private const string ProjectNotFoundValue = "ProjectNotFound";
        private const string OperationNotFoundValue = "OperationNotFound";
        private const string AzureCognitiveSearchNotFoundValue = "AzureCognitiveSearchNotFound";
        private const string AzureCognitiveSearchIndexNotFoundValue = "AzureCognitiveSearchIndexNotFound";
        private const string TooManyRequestsValue = "TooManyRequests";
        private const string AzureCognitiveSearchThrottlingValue = "AzureCognitiveSearchThrottling";
        private const string AzureCognitiveSearchIndexLimitReachedValue = "AzureCognitiveSearchIndexLimitReached";
        private const string InternalServerErrorValue = "InternalServerError";
        private const string ServiceUnavailableValue = "ServiceUnavailable";
        private const string TimeoutValue = "Timeout";
        private const string QuotaExceededValue = "QuotaExceeded";
        private const string ConflictValue = "Conflict";
        private const string WarningValue = "Warning";

        /// <summary> InvalidRequest. </summary>
        public static ErrorCode InvalidRequest { get; } = new ErrorCode(InvalidRequestValue);
        /// <summary> InvalidArgument. </summary>
        public static ErrorCode InvalidArgument { get; } = new ErrorCode(InvalidArgumentValue);
        /// <summary> Unauthorized. </summary>
        public static ErrorCode Unauthorized { get; } = new ErrorCode(UnauthorizedValue);
        /// <summary> Forbidden. </summary>
        public static ErrorCode Forbidden { get; } = new ErrorCode(ForbiddenValue);
        /// <summary> NotFound. </summary>
        public static ErrorCode NotFound { get; } = new ErrorCode(NotFoundValue);
        /// <summary> ProjectNotFound. </summary>
        public static ErrorCode ProjectNotFound { get; } = new ErrorCode(ProjectNotFoundValue);
        /// <summary> OperationNotFound. </summary>
        public static ErrorCode OperationNotFound { get; } = new ErrorCode(OperationNotFoundValue);
        /// <summary> AzureCognitiveSearchNotFound. </summary>
        public static ErrorCode AzureCognitiveSearchNotFound { get; } = new ErrorCode(AzureCognitiveSearchNotFoundValue);
        /// <summary> AzureCognitiveSearchIndexNotFound. </summary>
        public static ErrorCode AzureCognitiveSearchIndexNotFound { get; } = new ErrorCode(AzureCognitiveSearchIndexNotFoundValue);
        /// <summary> TooManyRequests. </summary>
        public static ErrorCode TooManyRequests { get; } = new ErrorCode(TooManyRequestsValue);
        /// <summary> AzureCognitiveSearchThrottling. </summary>
        public static ErrorCode AzureCognitiveSearchThrottling { get; } = new ErrorCode(AzureCognitiveSearchThrottlingValue);
        /// <summary> AzureCognitiveSearchIndexLimitReached. </summary>
        public static ErrorCode AzureCognitiveSearchIndexLimitReached { get; } = new ErrorCode(AzureCognitiveSearchIndexLimitReachedValue);
        /// <summary> InternalServerError. </summary>
        public static ErrorCode InternalServerError { get; } = new ErrorCode(InternalServerErrorValue);
        /// <summary> ServiceUnavailable. </summary>
        public static ErrorCode ServiceUnavailable { get; } = new ErrorCode(ServiceUnavailableValue);
        /// <summary> Timeout. </summary>
        public static ErrorCode Timeout { get; } = new ErrorCode(TimeoutValue);
        /// <summary> QuotaExceeded. </summary>
        public static ErrorCode QuotaExceeded { get; } = new ErrorCode(QuotaExceededValue);
        /// <summary> Conflict. </summary>
        public static ErrorCode Conflict { get; } = new ErrorCode(ConflictValue);
        /// <summary> Warning. </summary>
        public static ErrorCode Warning { get; } = new ErrorCode(WarningValue);
        /// <summary> Determines if two <see cref="ErrorCode"/> values are the same. </summary>
        public static bool operator ==(ErrorCode left, ErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ErrorCode"/> values are not the same. </summary>
        public static bool operator !=(ErrorCode left, ErrorCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ErrorCode"/>. </summary>
        public static implicit operator ErrorCode(string value) => new ErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
