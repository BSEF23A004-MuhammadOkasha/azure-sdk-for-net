// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The tone value. </summary>
    public readonly partial struct ToneValue : IEquatable<ToneValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ToneValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ToneValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Tone0Value = "tone0";
        private const string Tone1Value = "tone1";
        private const string Tone2Value = "tone2";
        private const string Tone3Value = "tone3";
        private const string Tone4Value = "tone4";
        private const string Tone5Value = "tone5";
        private const string Tone6Value = "tone6";
        private const string Tone7Value = "tone7";
        private const string Tone8Value = "tone8";
        private const string Tone9Value = "tone9";
        private const string StarValue = "star";
        private const string PoundValue = "pound";
        private const string AValue = "a";
        private const string BValue = "b";
        private const string CValue = "c";
        private const string DValue = "d";
        private const string FlashValue = "flash";

        /// <summary> tone0. </summary>
        public static ToneValue Tone0 { get; } = new ToneValue(Tone0Value);
        /// <summary> tone1. </summary>
        public static ToneValue Tone1 { get; } = new ToneValue(Tone1Value);
        /// <summary> tone2. </summary>
        public static ToneValue Tone2 { get; } = new ToneValue(Tone2Value);
        /// <summary> tone3. </summary>
        public static ToneValue Tone3 { get; } = new ToneValue(Tone3Value);
        /// <summary> tone4. </summary>
        public static ToneValue Tone4 { get; } = new ToneValue(Tone4Value);
        /// <summary> tone5. </summary>
        public static ToneValue Tone5 { get; } = new ToneValue(Tone5Value);
        /// <summary> tone6. </summary>
        public static ToneValue Tone6 { get; } = new ToneValue(Tone6Value);
        /// <summary> tone7. </summary>
        public static ToneValue Tone7 { get; } = new ToneValue(Tone7Value);
        /// <summary> tone8. </summary>
        public static ToneValue Tone8 { get; } = new ToneValue(Tone8Value);
        /// <summary> tone9. </summary>
        public static ToneValue Tone9 { get; } = new ToneValue(Tone9Value);
        /// <summary> star. </summary>
        public static ToneValue Star { get; } = new ToneValue(StarValue);
        /// <summary> pound. </summary>
        public static ToneValue Pound { get; } = new ToneValue(PoundValue);
        /// <summary> a. </summary>
        public static ToneValue A { get; } = new ToneValue(AValue);
        /// <summary> b. </summary>
        public static ToneValue B { get; } = new ToneValue(BValue);
        /// <summary> c. </summary>
        public static ToneValue C { get; } = new ToneValue(CValue);
        /// <summary> d. </summary>
        public static ToneValue D { get; } = new ToneValue(DValue);
        /// <summary> flash. </summary>
        public static ToneValue Flash { get; } = new ToneValue(FlashValue);
        /// <summary> Determines if two <see cref="ToneValue"/> values are the same. </summary>
        public static bool operator ==(ToneValue left, ToneValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ToneValue"/> values are not the same. </summary>
        public static bool operator !=(ToneValue left, ToneValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ToneValue"/>. </summary>
        public static implicit operator ToneValue(string value) => new ToneValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ToneValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ToneValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
