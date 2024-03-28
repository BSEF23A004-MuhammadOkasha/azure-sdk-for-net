// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> The CustomSentimentAnalysisResultDocument. </summary>
    public partial class CustomSentimentAnalysisResultDocument
    {
        /// <summary> Initializes a new instance of <see cref="CustomSentimentAnalysisResultDocument"/>. </summary>
        /// <param name="sentiment"> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="sentences"></param>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="confidenceScores"/>, <paramref name="sentences"/>, <paramref name="id"/> or <paramref name="warnings"/> is null. </exception>
        internal CustomSentimentAnalysisResultDocument(DocumentSentimentValue sentiment, SentimentConfidenceScores confidenceScores, IEnumerable<CustomSentenceSentiment> sentences, string id, IEnumerable<DocumentWarning> warnings)
        {
            Argument.AssertNotNull(confidenceScores, nameof(confidenceScores));
            Argument.AssertNotNull(sentences, nameof(sentences));
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));

            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Sentences = sentences.ToList();
            Id = id;
            Warnings = warnings.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CustomSentimentAnalysisResultDocument"/>. </summary>
        /// <param name="sentiment"> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="sentences"></param>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="detectedLanguage"> If 'language' is set to 'auto' for the document in the request this field will contain a 2 letter ISO 639-1 representation of the language detected for this document. </param>
        internal CustomSentimentAnalysisResultDocument(DocumentSentimentValue sentiment, SentimentConfidenceScores confidenceScores, IReadOnlyList<CustomSentenceSentiment> sentences, string id, IReadOnlyList<DocumentWarning> warnings, DocumentStatistics statistics, DetectedLanguage detectedLanguage)
        {
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Sentences = sentences;
            Id = id;
            Warnings = warnings;
            Statistics = statistics;
            DetectedLanguage = detectedLanguage;
        }

        /// <summary> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </summary>
        public DocumentSentimentValue Sentiment { get; }
        /// <summary> The sentiment confidence score between 0 and 1 for the sentence for all classes. </summary>
        public SentimentConfidenceScores ConfidenceScores { get; }
        /// <summary> Gets the sentences. </summary>
        public IReadOnlyList<CustomSentenceSentiment> Sentences { get; }
        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        /// <summary> Warnings encountered while processing document. </summary>
        public IReadOnlyList<DocumentWarning> Warnings { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; }
        /// <summary> If 'language' is set to 'auto' for the document in the request this field will contain a 2 letter ISO 639-1 representation of the language detected for this document. </summary>
        public DetectedLanguage DetectedLanguage { get; }
    }
}
