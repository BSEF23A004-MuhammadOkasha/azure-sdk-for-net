// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.AnalyzeText
{
    public readonly partial struct WarningCodeValue : IEquatable<WarningCodeValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WarningCodeValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WarningCodeValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LongWordsInDocumentValue = "LongWordsInDocument";
        private const string DocumentTruncatedValue = "DocumentTruncated";

        /// <summary> LongWordsInDocument. </summary>
        public static WarningCodeValue LongWordsInDocument { get; } = new WarningCodeValue(LongWordsInDocumentValue);
        /// <summary> DocumentTruncated. </summary>
        public static WarningCodeValue DocumentTruncated { get; } = new WarningCodeValue(DocumentTruncatedValue);
        /// <summary> Determines if two <see cref="WarningCodeValue"/> values are the same. </summary>
        public static bool operator ==(WarningCodeValue left, WarningCodeValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WarningCodeValue"/> values are not the same. </summary>
        public static bool operator !=(WarningCodeValue left, WarningCodeValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WarningCodeValue"/>. </summary>
        public static implicit operator WarningCodeValue(string value) => new WarningCodeValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WarningCodeValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WarningCodeValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
