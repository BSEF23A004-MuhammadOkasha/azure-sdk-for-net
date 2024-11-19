// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> The ThreadDeletionStatus_object. </summary>
    internal readonly partial struct ThreadDeletionStatusObject : IEquatable<ThreadDeletionStatusObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ThreadDeletionStatusObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ThreadDeletionStatusObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadDeletedValue = "thread.deleted";

        /// <summary> thread.deleted. </summary>
        public static ThreadDeletionStatusObject ThreadDeleted { get; } = new ThreadDeletionStatusObject(ThreadDeletedValue);
        /// <summary> Determines if two <see cref="ThreadDeletionStatusObject"/> values are the same. </summary>
        public static bool operator ==(ThreadDeletionStatusObject left, ThreadDeletionStatusObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ThreadDeletionStatusObject"/> values are not the same. </summary>
        public static bool operator !=(ThreadDeletionStatusObject left, ThreadDeletionStatusObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ThreadDeletionStatusObject"/>. </summary>
        public static implicit operator ThreadDeletionStatusObject(string value) => new ThreadDeletionStatusObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ThreadDeletionStatusObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ThreadDeletionStatusObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
