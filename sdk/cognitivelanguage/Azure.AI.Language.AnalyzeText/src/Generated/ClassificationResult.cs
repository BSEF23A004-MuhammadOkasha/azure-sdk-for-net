// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> The ClassificationResult. </summary>
    public partial class ClassificationResult
    {
        /// <summary> Initializes a new instance of <see cref="ClassificationResult"/>. </summary>
        /// <param name="category"> Classification type. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the recognized class. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="category"/> is null. </exception>
        internal ClassificationResult(string category, double confidenceScore)
        {
            Argument.AssertNotNull(category, nameof(category));

            Category = category;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Classification type. </summary>
        public string Category { get; }
        /// <summary> Confidence score between 0 and 1 of the recognized class. </summary>
        public double ConfidenceScore { get; }
    }
}
