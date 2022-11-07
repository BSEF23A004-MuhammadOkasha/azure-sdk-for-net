// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Data.SchemaRegistry
{
    /// <summary> The ContentType. </summary>
    internal readonly partial struct ContentTypeInternal : IEquatable<ContentTypeInternal>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContentTypeInternal"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContentTypeInternal(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvroValue = "application/json; serialization=Avro";
        private const string JsonValue = "application/json; serialization=json";
        private const string CustomValue = "text/plain; charset=utf-8";
        /// <summary> Determines if two <see cref="ContentTypeInternal"/> values are the same. </summary>
        public static bool operator ==(ContentTypeInternal left, ContentTypeInternal right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContentTypeInternal"/> values are not the same. </summary>
        public static bool operator !=(ContentTypeInternal left, ContentTypeInternal right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContentTypeInternal"/>. </summary>
        public static implicit operator ContentTypeInternal(string value) => new ContentTypeInternal(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContentTypeInternal other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContentTypeInternal other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
