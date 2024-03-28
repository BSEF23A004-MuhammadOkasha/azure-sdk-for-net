// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> Supported parameters for the pre-build Abstractive Summarization task. </summary>
    public partial class AbstractiveSummarizationTaskParameters : PreBuiltTaskParameters
    {
        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationTaskParameters"/>. </summary>
        public AbstractiveSummarizationTaskParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationTaskParameters"/>. </summary>
        /// <param name="loggingOptOut"> logging opt out. </param>
        /// <param name="modelVersion"> model version. </param>
        /// <param name="sentenceCount"> Controls the approximate number of sentences in the output summaries. </param>
        /// <param name="stringIndexType"> String index type. </param>
        /// <param name="summaryLength"> (NOTE: Recommended to use summaryLength over sentenceCount) Controls the approximate length of the output summaries. </param>
        /// <param name="query"> (Optional) If provided, the query will be used to generate the summary. </param>
        internal AbstractiveSummarizationTaskParameters(bool? loggingOptOut, string modelVersion, int? sentenceCount, StringIndexType? stringIndexType, SummaryLengthBucket? summaryLength, string query) : base(loggingOptOut, modelVersion)
        {
            SentenceCount = sentenceCount;
            StringIndexType = stringIndexType;
            SummaryLength = summaryLength;
            Query = query;
        }

        /// <summary> Controls the approximate number of sentences in the output summaries. </summary>
        public int? SentenceCount { get; set; }
        /// <summary> String index type. </summary>
        public StringIndexType? StringIndexType { get; set; }
        /// <summary> (NOTE: Recommended to use summaryLength over sentenceCount) Controls the approximate length of the output summaries. </summary>
        public SummaryLengthBucket? SummaryLength { get; set; }
        /// <summary> (Optional) If provided, the query will be used to generate the summary. </summary>
        public string Query { get; set; }
    }
}
