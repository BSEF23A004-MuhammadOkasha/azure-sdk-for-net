// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Rendering
{
    /// <summary> The MediaType. </summary>
    public readonly partial struct MediaType : IEquatable<MediaType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ImagePngValue = "image/png";
        private const string ImageJpegValue = "image/jpeg";

        /// <summary> Return image in png format. </summary>
        public static MediaType ImagePng { get; } = new MediaType(ImagePngValue);
        /// <summary> Return image in jpeg format. </summary>
        public static MediaType ImageJpeg { get; } = new MediaType(ImageJpegValue);
        /// <summary> Determines if two <see cref="MediaType"/> values are the same. </summary>
        public static bool operator ==(MediaType left, MediaType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaType"/> values are not the same. </summary>
        public static bool operator !=(MediaType left, MediaType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaType"/>. </summary>
        public static implicit operator MediaType(string value) => new MediaType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
