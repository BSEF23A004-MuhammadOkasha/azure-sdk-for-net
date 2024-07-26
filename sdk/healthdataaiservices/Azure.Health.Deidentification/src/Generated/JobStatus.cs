// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Deidentification
{
    /// <summary> List of statuses a job can have. </summary>
    public readonly partial struct JobStatus : IEquatable<JobStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string PartialFailedValue = "PartialFailed";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Job has been submitted and is waiting to be processed. </summary>
        public static JobStatus NotStarted { get; } = new JobStatus(NotStartedValue);
        /// <summary> Job has been started. </summary>
        public static JobStatus Running { get; } = new JobStatus(RunningValue);
        /// <summary> Job has completed successfully. All documents have succeeded. </summary>
        public static JobStatus Succeeded { get; } = new JobStatus(SucceededValue);
        /// <summary> Job has completed with at least a single document failing. </summary>
        public static JobStatus PartialFailed { get; } = new JobStatus(PartialFailedValue);
        /// <summary> Job has completed with all documents failing, or a validation failure. </summary>
        public static JobStatus Failed { get; } = new JobStatus(FailedValue);
        /// <summary> Job has been canceled after user request. </summary>
        public static JobStatus Canceled { get; } = new JobStatus(CanceledValue);
        /// <summary> Determines if two <see cref="JobStatus"/> values are the same. </summary>
        public static bool operator ==(JobStatus left, JobStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobStatus"/> values are not the same. </summary>
        public static bool operator !=(JobStatus left, JobStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobStatus"/>. </summary>
        public static implicit operator JobStatus(string value) => new JobStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
