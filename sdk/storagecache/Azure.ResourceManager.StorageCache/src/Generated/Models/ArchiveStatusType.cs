// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> The state of the archive operation. </summary>
    public readonly partial struct ArchiveStatusType : IEquatable<ArchiveStatusType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArchiveStatusType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArchiveStatusType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotConfiguredValue = "NotConfigured";
        private const string IdleValue = "Idle";
        private const string InProgressValue = "InProgress";
        private const string CanceledValue = "Canceled";
        private const string CompletedValue = "Completed";
        private const string FailedValue = "Failed";
        private const string CancellingValue = "Cancelling";
        private const string FSScanInProgressValue = "FSScanInProgress";

        /// <summary> NotConfigured. </summary>
        public static ArchiveStatusType NotConfigured { get; } = new ArchiveStatusType(NotConfiguredValue);
        /// <summary> Idle. </summary>
        public static ArchiveStatusType Idle { get; } = new ArchiveStatusType(IdleValue);
        /// <summary> InProgress. </summary>
        public static ArchiveStatusType InProgress { get; } = new ArchiveStatusType(InProgressValue);
        /// <summary> Canceled. </summary>
        public static ArchiveStatusType Canceled { get; } = new ArchiveStatusType(CanceledValue);
        /// <summary> Completed. </summary>
        public static ArchiveStatusType Completed { get; } = new ArchiveStatusType(CompletedValue);
        /// <summary> Failed. </summary>
        public static ArchiveStatusType Failed { get; } = new ArchiveStatusType(FailedValue);
        /// <summary> Cancelling. </summary>
        public static ArchiveStatusType Cancelling { get; } = new ArchiveStatusType(CancellingValue);
        /// <summary> FSScanInProgress. </summary>
        public static ArchiveStatusType FSScanInProgress { get; } = new ArchiveStatusType(FSScanInProgressValue);
        /// <summary> Determines if two <see cref="ArchiveStatusType"/> values are the same. </summary>
        public static bool operator ==(ArchiveStatusType left, ArchiveStatusType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArchiveStatusType"/> values are not the same. </summary>
        public static bool operator !=(ArchiveStatusType left, ArchiveStatusType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArchiveStatusType"/>. </summary>
        public static implicit operator ArchiveStatusType(string value) => new ArchiveStatusType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArchiveStatusType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArchiveStatusType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
