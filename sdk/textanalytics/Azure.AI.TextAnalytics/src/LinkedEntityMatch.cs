﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Details regarding the specific substring in the document matching
    /// the linked entity, or well-known item, that the Text Analytics model
    /// identified.
    /// </summary>
    [CodeGenModel("Match")]
    public readonly partial struct LinkedEntityMatch
    {
        internal LinkedEntityMatch(double confidenceScore, string text, int offset, int length)
        {
            ConfidenceScore = confidenceScore;
            Text = text ?? string.Empty;
            Offset = offset;
            Length = length;
        }

        /// <summary>
        /// Gets the entity text as it appears in the document.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Gets a score between 0 and 1, indicating the confidence that this
        /// substring matches the corresponding linked entity.
        /// </summary>
        public double ConfidenceScore { get; }

        /// <summary> Start position for the entity match text. </summary>
        private int Offset { get; }
        /// <summary> Length for the entity match text. </summary>
        private int Length { get; }
}
}
