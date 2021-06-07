// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OperationalInsightsManagementClient.Models
{
    /// <summary> The status of data ingestion for this workspace. </summary>
    public readonly partial struct DataIngestionStatus : IEquatable<DataIngestionStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DataIngestionStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataIngestionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RespectQuotaValue = "RespectQuota";
        private const string ForceOnValue = "ForceOn";
        private const string ForceOffValue = "ForceOff";
        private const string OverQuotaValue = "OverQuota";
        private const string SubscriptionSuspendedValue = "SubscriptionSuspended";
        private const string ApproachingQuotaValue = "ApproachingQuota";

        /// <summary> Ingestion enabled following daily cap quota reset, or subscription enablement. </summary>
        public static DataIngestionStatus RespectQuota { get; } = new DataIngestionStatus(RespectQuotaValue);
        /// <summary> Ingestion started following service setting change. </summary>
        public static DataIngestionStatus ForceOn { get; } = new DataIngestionStatus(ForceOnValue);
        /// <summary> Ingestion stopped following service setting change. </summary>
        public static DataIngestionStatus ForceOff { get; } = new DataIngestionStatus(ForceOffValue);
        /// <summary> Reached daily cap quota, ingestion stopped. </summary>
        public static DataIngestionStatus OverQuota { get; } = new DataIngestionStatus(OverQuotaValue);
        /// <summary> Ingestion stopped following suspended subscription. </summary>
        public static DataIngestionStatus SubscriptionSuspended { get; } = new DataIngestionStatus(SubscriptionSuspendedValue);
        /// <summary> 80% of daily cap quota reached. </summary>
        public static DataIngestionStatus ApproachingQuota { get; } = new DataIngestionStatus(ApproachingQuotaValue);
        /// <summary> Determines if two <see cref="DataIngestionStatus"/> values are the same. </summary>
        public static bool operator ==(DataIngestionStatus left, DataIngestionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataIngestionStatus"/> values are not the same. </summary>
        public static bool operator !=(DataIngestionStatus left, DataIngestionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataIngestionStatus"/>. </summary>
        public static implicit operator DataIngestionStatus(string value) => new DataIngestionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataIngestionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataIngestionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
