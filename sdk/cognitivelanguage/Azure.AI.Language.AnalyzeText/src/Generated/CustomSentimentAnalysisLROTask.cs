// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> Use custom models to ease the process of sentiment analysis from documents like product reviews. </summary>
    public partial class CustomSentimentAnalysisLROTask : AnalyzeTextLROTask
    {
        /// <summary> Initializes a new instance of <see cref="CustomSentimentAnalysisLROTask"/>. </summary>
        public CustomSentimentAnalysisLROTask()
        {
            Kind = AnalyzeTextLROTaskKind.CustomSentimentAnalysis;
        }

        /// <summary> Initializes a new instance of <see cref="CustomSentimentAnalysisLROTask"/>. </summary>
        /// <param name="taskName"> task name. </param>
        /// <param name="kind"> The kind of task to perform. </param>
        /// <param name="parameters"></param>
        internal CustomSentimentAnalysisLROTask(string taskName, AnalyzeTextLROTaskKind kind, CustomSentimentAnalysisTaskParameters parameters) : base(taskName, kind)
        {
            Parameters = parameters;
        }

        /// <summary> Gets or sets the parameters. </summary>
        public CustomSentimentAnalysisTaskParameters Parameters { get; set; }
    }
}
