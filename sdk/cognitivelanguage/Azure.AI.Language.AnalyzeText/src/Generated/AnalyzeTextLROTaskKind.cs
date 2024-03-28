// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.AnalyzeText
{
    internal readonly partial struct AnalyzeTextLROTaskKind : IEquatable<AnalyzeTextLROTaskKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextLROTaskKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnalyzeTextLROTaskKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SentimentAnalysisValue = "SentimentAnalysis";
        private const string EntityRecognitionValue = "EntityRecognition";
        private const string PiiEntityRecognitionValue = "PiiEntityRecognition";
        private const string KeyPhraseExtractionValue = "KeyPhraseExtraction";
        private const string EntityLinkingValue = "EntityLinking";
        private const string HealthcareValue = "Healthcare";
        private const string CustomEntityRecognitionValue = "CustomEntityRecognition";
        private const string CustomSingleLabelClassificationValue = "CustomSingleLabelClassification";
        private const string CustomMultiLabelClassificationValue = "CustomMultiLabelClassification";
        private const string ExtractiveSummarizationValue = "ExtractiveSummarization";
        private const string AbstractiveSummarizationValue = "AbstractiveSummarization";
        private const string CustomHealthcareValue = "CustomHealthcare";
        private const string CustomSentimentAnalysisValue = "CustomSentimentAnalysis";
        private const string CustomAbstractiveSummarizationValue = "CustomAbstractiveSummarization";

        /// <summary> SentimentAnalysis. </summary>
        public static AnalyzeTextLROTaskKind SentimentAnalysis { get; } = new AnalyzeTextLROTaskKind(SentimentAnalysisValue);
        /// <summary> EntityRecognition. </summary>
        public static AnalyzeTextLROTaskKind EntityRecognition { get; } = new AnalyzeTextLROTaskKind(EntityRecognitionValue);
        /// <summary> PiiEntityRecognition. </summary>
        public static AnalyzeTextLROTaskKind PiiEntityRecognition { get; } = new AnalyzeTextLROTaskKind(PiiEntityRecognitionValue);
        /// <summary> KeyPhraseExtraction. </summary>
        public static AnalyzeTextLROTaskKind KeyPhraseExtraction { get; } = new AnalyzeTextLROTaskKind(KeyPhraseExtractionValue);
        /// <summary> EntityLinking. </summary>
        public static AnalyzeTextLROTaskKind EntityLinking { get; } = new AnalyzeTextLROTaskKind(EntityLinkingValue);
        /// <summary> Healthcare. </summary>
        public static AnalyzeTextLROTaskKind Healthcare { get; } = new AnalyzeTextLROTaskKind(HealthcareValue);
        /// <summary> CustomEntityRecognition. </summary>
        public static AnalyzeTextLROTaskKind CustomEntityRecognition { get; } = new AnalyzeTextLROTaskKind(CustomEntityRecognitionValue);
        /// <summary> CustomSingleLabelClassification. </summary>
        public static AnalyzeTextLROTaskKind CustomSingleLabelClassification { get; } = new AnalyzeTextLROTaskKind(CustomSingleLabelClassificationValue);
        /// <summary> CustomMultiLabelClassification. </summary>
        public static AnalyzeTextLROTaskKind CustomMultiLabelClassification { get; } = new AnalyzeTextLROTaskKind(CustomMultiLabelClassificationValue);
        /// <summary> ExtractiveSummarization. </summary>
        public static AnalyzeTextLROTaskKind ExtractiveSummarization { get; } = new AnalyzeTextLROTaskKind(ExtractiveSummarizationValue);
        /// <summary> AbstractiveSummarization. </summary>
        public static AnalyzeTextLROTaskKind AbstractiveSummarization { get; } = new AnalyzeTextLROTaskKind(AbstractiveSummarizationValue);
        /// <summary> CustomHealthcare. </summary>
        public static AnalyzeTextLROTaskKind CustomHealthcare { get; } = new AnalyzeTextLROTaskKind(CustomHealthcareValue);
        /// <summary> CustomSentimentAnalysis. </summary>
        public static AnalyzeTextLROTaskKind CustomSentimentAnalysis { get; } = new AnalyzeTextLROTaskKind(CustomSentimentAnalysisValue);
        /// <summary> CustomAbstractiveSummarization. </summary>
        public static AnalyzeTextLROTaskKind CustomAbstractiveSummarization { get; } = new AnalyzeTextLROTaskKind(CustomAbstractiveSummarizationValue);
        /// <summary> Determines if two <see cref="AnalyzeTextLROTaskKind"/> values are the same. </summary>
        public static bool operator ==(AnalyzeTextLROTaskKind left, AnalyzeTextLROTaskKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnalyzeTextLROTaskKind"/> values are not the same. </summary>
        public static bool operator !=(AnalyzeTextLROTaskKind left, AnalyzeTextLROTaskKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AnalyzeTextLROTaskKind"/>. </summary>
        public static implicit operator AnalyzeTextLROTaskKind(string value) => new AnalyzeTextLROTaskKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnalyzeTextLROTaskKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnalyzeTextLROTaskKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
