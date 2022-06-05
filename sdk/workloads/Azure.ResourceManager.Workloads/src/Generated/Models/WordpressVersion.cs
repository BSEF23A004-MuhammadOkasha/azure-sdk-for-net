// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Application version. </summary>
    public readonly partial struct WordpressVersion : IEquatable<WordpressVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WordpressVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WordpressVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string V5_4_3Value = "5.4.3";
        private const string V5_4_2Value = "5.4.2";
        private const string V5_4_1Value = "5.4.1";
        private const string V5_4_0Value = "5.4";
        /// <summary> Determines if two <see cref="WordpressVersion"/> values are the same. </summary>
        public static bool operator ==(WordpressVersion left, WordpressVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WordpressVersion"/> values are not the same. </summary>
        public static bool operator !=(WordpressVersion left, WordpressVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WordpressVersion"/>. </summary>
        public static implicit operator WordpressVersion(string value) => new WordpressVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WordpressVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WordpressVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
