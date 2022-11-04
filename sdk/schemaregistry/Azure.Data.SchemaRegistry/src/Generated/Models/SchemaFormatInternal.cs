// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Data.SchemaRegistry
{
    /// <summary> The SchemaFormat. </summary>
    internal readonly partial struct SchemaFormatInternal : IEquatable<SchemaFormatInternal>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SchemaFormatInternal"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SchemaFormatInternal(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApplicationJsonSerializationAvroValue = "application/json; serialization=Avro";
        private const string ApplicationJsonSerializationJsonValue = "application/json; serialization=json";
        private const string TextPlainCharsetUtf8Value = "text/plain; charset=utf-8";

        /// <summary> application/json; serialization=Avro. </summary>
        public static SchemaFormatInternal ApplicationJsonSerializationAvro { get; } = new SchemaFormatInternal(ApplicationJsonSerializationAvroValue);
        /// <summary> application/json; serialization=json. </summary>
        public static SchemaFormatInternal ApplicationJsonSerializationJson { get; } = new SchemaFormatInternal(ApplicationJsonSerializationJsonValue);
        /// <summary> text/plain; charset=utf-8. </summary>
        public static SchemaFormatInternal TextPlainCharsetUtf8 { get; } = new SchemaFormatInternal(TextPlainCharsetUtf8Value);
        /// <summary> Determines if two <see cref="SchemaFormatInternal"/> values are the same. </summary>
        public static bool operator ==(SchemaFormatInternal left, SchemaFormatInternal right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SchemaFormatInternal"/> values are not the same. </summary>
        public static bool operator !=(SchemaFormatInternal left, SchemaFormatInternal right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SchemaFormatInternal"/>. </summary>
        public static implicit operator SchemaFormatInternal(string value) => new SchemaFormatInternal(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SchemaFormatInternal other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SchemaFormatInternal other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
