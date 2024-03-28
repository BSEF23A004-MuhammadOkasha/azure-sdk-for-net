// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> Identifies the script of the input document. Maps to the ISO 15924 standard formal name. </summary>
    public readonly partial struct ScriptKind : IEquatable<ScriptKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScriptKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScriptKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ArabicValue = "Arabic";
        private const string ArmenianValue = "Armenian";
        private const string BanglaValue = "Bangla";
        private const string UnifiedCanadianAboriginalSyllabicsValue = "UnifiedCanadianAboriginalSyllabics";
        private const string CyrillicValue = "Cyrillic";
        private const string DevanagariValue = "Devanagari";
        private const string EthiopicValue = "Ethiopic";
        private const string GeorgianValue = "Georgian";
        private const string GreekValue = "Greek";
        private const string GujaratiValue = "Gujarati";
        private const string GurmukhiValue = "Gurmukhi";
        private const string HangulValue = "Hangul";
        private const string HanSimplifiedValue = "HanSimplified";
        private const string HanTraditionalValue = "HanTraditional";
        private const string HebrewValue = "Hebrew";
        private const string JapaneseValue = "Japanese";
        private const string KhmerValue = "Khmer";
        private const string KannadaValue = "Kannada";
        private const string LaoValue = "Lao";
        private const string LatinValue = "Latin";
        private const string MalayalamValue = "Malayalam";
        private const string MyanmarValue = "Myanmar";
        private const string OdiaValue = "Odia";
        private const string SinhalaValue = "Sinhala";
        private const string TamilValue = "Tamil";
        private const string TeluguValue = "Telugu";
        private const string ThaanaValue = "Thaana";
        private const string ThaiValue = "Thai";
        private const string TibetanValue = "Tibetan";

        /// <summary> Script name for the Arabic script. </summary>
        public static ScriptKind Arabic { get; } = new ScriptKind(ArabicValue);
        /// <summary> Script name for the Armenian script. </summary>
        public static ScriptKind Armenian { get; } = new ScriptKind(ArmenianValue);
        /// <summary> Script name for the Bangla script. </summary>
        public static ScriptKind Bangla { get; } = new ScriptKind(BanglaValue);
        /// <summary> Script name for the UnifiedCanadianAboriginalSyllabics script. </summary>
        public static ScriptKind UnifiedCanadianAboriginalSyllabics { get; } = new ScriptKind(UnifiedCanadianAboriginalSyllabicsValue);
        /// <summary> Script name for the Cyrillic script. </summary>
        public static ScriptKind Cyrillic { get; } = new ScriptKind(CyrillicValue);
        /// <summary> Script name for the Devanagari script. </summary>
        public static ScriptKind Devanagari { get; } = new ScriptKind(DevanagariValue);
        /// <summary> Script name for the Ethiopic script. </summary>
        public static ScriptKind Ethiopic { get; } = new ScriptKind(EthiopicValue);
        /// <summary> Script name for the Georgian script. </summary>
        public static ScriptKind Georgian { get; } = new ScriptKind(GeorgianValue);
        /// <summary> Script name for the Greek script. </summary>
        public static ScriptKind Greek { get; } = new ScriptKind(GreekValue);
        /// <summary> Script name for the Gujarati script. </summary>
        public static ScriptKind Gujarati { get; } = new ScriptKind(GujaratiValue);
        /// <summary> Script name for the Gurmukhi script. </summary>
        public static ScriptKind Gurmukhi { get; } = new ScriptKind(GurmukhiValue);
        /// <summary> Script name for the Hangul script. </summary>
        public static ScriptKind Hangul { get; } = new ScriptKind(HangulValue);
        /// <summary> Script name for the HanSimplified script. </summary>
        public static ScriptKind HanSimplified { get; } = new ScriptKind(HanSimplifiedValue);
        /// <summary> Script name for the HanTraditional script. </summary>
        public static ScriptKind HanTraditional { get; } = new ScriptKind(HanTraditionalValue);
        /// <summary> Script name for the Hebrew script. </summary>
        public static ScriptKind Hebrew { get; } = new ScriptKind(HebrewValue);
        /// <summary> Script name for the Japanese script. </summary>
        public static ScriptKind Japanese { get; } = new ScriptKind(JapaneseValue);
        /// <summary> Script name for the Khmer script. </summary>
        public static ScriptKind Khmer { get; } = new ScriptKind(KhmerValue);
        /// <summary> Script name for the Kannada script. </summary>
        public static ScriptKind Kannada { get; } = new ScriptKind(KannadaValue);
        /// <summary> Script name for the Lao script. </summary>
        public static ScriptKind Lao { get; } = new ScriptKind(LaoValue);
        /// <summary> Script name for the Latin script. </summary>
        public static ScriptKind Latin { get; } = new ScriptKind(LatinValue);
        /// <summary> Script name for the Malayalam script. </summary>
        public static ScriptKind Malayalam { get; } = new ScriptKind(MalayalamValue);
        /// <summary> Script name for the Myanmar script. </summary>
        public static ScriptKind Myanmar { get; } = new ScriptKind(MyanmarValue);
        /// <summary> Script name for the Odia script. </summary>
        public static ScriptKind Odia { get; } = new ScriptKind(OdiaValue);
        /// <summary> Script name for the Sinhala script. </summary>
        public static ScriptKind Sinhala { get; } = new ScriptKind(SinhalaValue);
        /// <summary> Script name for the Tamil script. </summary>
        public static ScriptKind Tamil { get; } = new ScriptKind(TamilValue);
        /// <summary> Script name for the Telugu script. </summary>
        public static ScriptKind Telugu { get; } = new ScriptKind(TeluguValue);
        /// <summary> Script name for the Thaana script. </summary>
        public static ScriptKind Thaana { get; } = new ScriptKind(ThaanaValue);
        /// <summary> Script name for the Thai script. </summary>
        public static ScriptKind Thai { get; } = new ScriptKind(ThaiValue);
        /// <summary> Script name for the Tibetan script. </summary>
        public static ScriptKind Tibetan { get; } = new ScriptKind(TibetanValue);
        /// <summary> Determines if two <see cref="ScriptKind"/> values are the same. </summary>
        public static bool operator ==(ScriptKind left, ScriptKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScriptKind"/> values are not the same. </summary>
        public static bool operator !=(ScriptKind left, ScriptKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScriptKind"/>. </summary>
        public static implicit operator ScriptKind(string value) => new ScriptKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScriptKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScriptKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
