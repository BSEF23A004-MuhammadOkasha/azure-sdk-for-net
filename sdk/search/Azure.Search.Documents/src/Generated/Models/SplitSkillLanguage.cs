// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The language codes supported for input text by SplitSkill. </summary>
    public readonly partial struct SplitSkillLanguage : IEquatable<SplitSkillLanguage>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SplitSkillLanguage"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SplitSkillLanguage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AmValue = "am";
        private const string BsValue = "bs";
        private const string CsValue = "cs";
        private const string DaValue = "da";
        private const string DeValue = "de";
        private const string EnValue = "en";
        private const string EsValue = "es";
        private const string EtValue = "et";
        private const string FiValue = "fi";
        private const string FrValue = "fr";
        private const string HeValue = "he";
        private const string HiValue = "hi";
        private const string HrValue = "hr";
        private const string HuValue = "hu";
        private const string IdValue = "id";
        private const string IsValue = "is";
        private const string ItValue = "it";
        private const string JaValue = "ja";
        private const string KoValue = "ko";
        private const string LvValue = "lv";
        private const string NbValue = "nb";
        private const string NlValue = "nl";
        private const string PlValue = "pl";
        private const string PtValue = "pt";
        private const string PtBrValue = "pt-br";
        private const string RuValue = "ru";
        private const string SkValue = "sk";
        private const string SlValue = "sl";
        private const string SrValue = "sr";
        private const string SvValue = "sv";
        private const string TrValue = "tr";
        private const string UrValue = "ur";
        private const string ZhValue = "zh";

        /// <summary> Amharic. </summary>
        public static SplitSkillLanguage Am { get; } = new SplitSkillLanguage(AmValue);
        /// <summary> Bosnian. </summary>
        public static SplitSkillLanguage Bs { get; } = new SplitSkillLanguage(BsValue);
        /// <summary> Czech. </summary>
        public static SplitSkillLanguage Cs { get; } = new SplitSkillLanguage(CsValue);
        /// <summary> Danish. </summary>
        public static SplitSkillLanguage Da { get; } = new SplitSkillLanguage(DaValue);
        /// <summary> German. </summary>
        public static SplitSkillLanguage De { get; } = new SplitSkillLanguage(DeValue);
        /// <summary> English. </summary>
        public static SplitSkillLanguage En { get; } = new SplitSkillLanguage(EnValue);
        /// <summary> Spanish. </summary>
        public static SplitSkillLanguage Es { get; } = new SplitSkillLanguage(EsValue);
        /// <summary> Estonian. </summary>
        public static SplitSkillLanguage Et { get; } = new SplitSkillLanguage(EtValue);
        /// <summary> Finnish. </summary>
        public static SplitSkillLanguage Fi { get; } = new SplitSkillLanguage(FiValue);
        /// <summary> French. </summary>
        public static SplitSkillLanguage Fr { get; } = new SplitSkillLanguage(FrValue);
        /// <summary> Hebrew. </summary>
        public static SplitSkillLanguage He { get; } = new SplitSkillLanguage(HeValue);
        /// <summary> Hindi. </summary>
        public static SplitSkillLanguage Hi { get; } = new SplitSkillLanguage(HiValue);
        /// <summary> Croatian. </summary>
        public static SplitSkillLanguage Hr { get; } = new SplitSkillLanguage(HrValue);
        /// <summary> Hungarian. </summary>
        public static SplitSkillLanguage Hu { get; } = new SplitSkillLanguage(HuValue);
        /// <summary> Indonesian. </summary>
        public static SplitSkillLanguage Id { get; } = new SplitSkillLanguage(IdValue);
        /// <summary> Icelandic. </summary>
        public static SplitSkillLanguage Is { get; } = new SplitSkillLanguage(IsValue);
        /// <summary> Italian. </summary>
        public static SplitSkillLanguage It { get; } = new SplitSkillLanguage(ItValue);
        /// <summary> Japanese. </summary>
        public static SplitSkillLanguage Ja { get; } = new SplitSkillLanguage(JaValue);
        /// <summary> Korean. </summary>
        public static SplitSkillLanguage Ko { get; } = new SplitSkillLanguage(KoValue);
        /// <summary> Latvian. </summary>
        public static SplitSkillLanguage Lv { get; } = new SplitSkillLanguage(LvValue);
        /// <summary> Norwegian. </summary>
        public static SplitSkillLanguage Nb { get; } = new SplitSkillLanguage(NbValue);
        /// <summary> Dutch. </summary>
        public static SplitSkillLanguage Nl { get; } = new SplitSkillLanguage(NlValue);
        /// <summary> Polish. </summary>
        public static SplitSkillLanguage Pl { get; } = new SplitSkillLanguage(PlValue);
        /// <summary> Portuguese (Portugal). </summary>
        public static SplitSkillLanguage Pt { get; } = new SplitSkillLanguage(PtValue);
        /// <summary> Portuguese (Brazil). </summary>
        public static SplitSkillLanguage PtBr { get; } = new SplitSkillLanguage(PtBrValue);
        /// <summary> Russian. </summary>
        public static SplitSkillLanguage Ru { get; } = new SplitSkillLanguage(RuValue);
        /// <summary> Slovak. </summary>
        public static SplitSkillLanguage Sk { get; } = new SplitSkillLanguage(SkValue);
        /// <summary> Slovenian. </summary>
        public static SplitSkillLanguage Sl { get; } = new SplitSkillLanguage(SlValue);
        /// <summary> Serbian. </summary>
        public static SplitSkillLanguage Sr { get; } = new SplitSkillLanguage(SrValue);
        /// <summary> Swedish. </summary>
        public static SplitSkillLanguage Sv { get; } = new SplitSkillLanguage(SvValue);
        /// <summary> Turkish. </summary>
        public static SplitSkillLanguage Tr { get; } = new SplitSkillLanguage(TrValue);
        /// <summary> Urdu. </summary>
        public static SplitSkillLanguage Ur { get; } = new SplitSkillLanguage(UrValue);
        /// <summary> Chinese (Simplified). </summary>
        public static SplitSkillLanguage Zh { get; } = new SplitSkillLanguage(ZhValue);
        /// <summary> Determines if two <see cref="SplitSkillLanguage"/> values are the same. </summary>
        public static bool operator ==(SplitSkillLanguage left, SplitSkillLanguage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SplitSkillLanguage"/> values are not the same. </summary>
        public static bool operator !=(SplitSkillLanguage left, SplitSkillLanguage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SplitSkillLanguage"/>. </summary>
        public static implicit operator SplitSkillLanguage(string value) => new SplitSkillLanguage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SplitSkillLanguage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SplitSkillLanguage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
