// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the topic type. </summary>
    public readonly partial struct TopicTypeProvisioningState : IEquatable<TopicTypeProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TopicTypeProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TopicTypeProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> Creating. </summary>
        public static TopicTypeProvisioningState Creating { get; } = new TopicTypeProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static TopicTypeProvisioningState Updating { get; } = new TopicTypeProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static TopicTypeProvisioningState Deleting { get; } = new TopicTypeProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static TopicTypeProvisioningState Succeeded { get; } = new TopicTypeProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static TopicTypeProvisioningState Canceled { get; } = new TopicTypeProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static TopicTypeProvisioningState Failed { get; } = new TopicTypeProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="TopicTypeProvisioningState"/> values are the same. </summary>
        public static bool operator ==(TopicTypeProvisioningState left, TopicTypeProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TopicTypeProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(TopicTypeProvisioningState left, TopicTypeProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TopicTypeProvisioningState"/>. </summary>
        public static implicit operator TopicTypeProvisioningState(string value) => new TopicTypeProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TopicTypeProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TopicTypeProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
