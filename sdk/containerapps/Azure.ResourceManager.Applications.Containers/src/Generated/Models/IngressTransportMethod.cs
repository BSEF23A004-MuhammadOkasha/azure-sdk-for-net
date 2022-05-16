// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    /// <summary> Ingress transport protocol. </summary>
    public readonly partial struct IngressTransportMethod : IEquatable<IngressTransportMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IngressTransportMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IngressTransportMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string HttpValue = "http";
        private const string Http2Value = "http2";

        /// <summary> auto. </summary>
        public static IngressTransportMethod Auto { get; } = new IngressTransportMethod(AutoValue);
        /// <summary> http. </summary>
        public static IngressTransportMethod Http { get; } = new IngressTransportMethod(HttpValue);
        /// <summary> http2. </summary>
        public static IngressTransportMethod Http2 { get; } = new IngressTransportMethod(Http2Value);
        /// <summary> Determines if two <see cref="IngressTransportMethod"/> values are the same. </summary>
        public static bool operator ==(IngressTransportMethod left, IngressTransportMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IngressTransportMethod"/> values are not the same. </summary>
        public static bool operator !=(IngressTransportMethod left, IngressTransportMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IngressTransportMethod"/>. </summary>
        public static implicit operator IngressTransportMethod(string value) => new IngressTransportMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IngressTransportMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IngressTransportMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
