// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> The ExtractedSummarySentence. </summary>
    public partial class ExtractedSummarySentence
    {
        /// <summary> Initializes a new instance of <see cref="ExtractedSummarySentence"/>. </summary>
        /// <param name="text"> The extracted sentence text. </param>
        /// <param name="rankScore"> A double value representing the relevance of the sentence within the summary. Higher values indicate higher importance. </param>
        /// <param name="offset"> The sentence offset from the start of the document, based on the value of the parameter StringIndexType. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal ExtractedSummarySentence(string text, double rankScore, int offset, int length)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
            RankScore = rankScore;
            Offset = offset;
            Length = length;
        }

        /// <summary> The extracted sentence text. </summary>
        public string Text { get; }
        /// <summary> A double value representing the relevance of the sentence within the summary. Higher values indicate higher importance. </summary>
        public double RankScore { get; }
        /// <summary> The sentence offset from the start of the document, based on the value of the parameter StringIndexType. </summary>
        public int Offset { get; }
        /// <summary> The length of the sentence. </summary>
        public int Length { get; }
    }
}
