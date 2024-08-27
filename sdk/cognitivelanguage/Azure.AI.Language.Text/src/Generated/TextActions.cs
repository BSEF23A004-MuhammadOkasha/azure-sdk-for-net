// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Container for the tasks status for the LRO job. </summary>
    public partial class TextActions
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TextActions"/>. </summary>
        /// <param name="completed"> Count of completed tasks. </param>
        /// <param name="failed"> Count of failed tasks. </param>
        /// <param name="inProgress"> Count of inprogress tasks. </param>
        /// <param name="total"> Count of total tasks. </param>
        internal TextActions(int completed, int failed, int inProgress, int total)
        {
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            Items = new ChangeTrackingList<AnalyzeTextOperationResult>();
        }

        /// <summary> Initializes a new instance of <see cref="TextActions"/>. </summary>
        /// <param name="completed"> Count of completed tasks. </param>
        /// <param name="failed"> Count of failed tasks. </param>
        /// <param name="inProgress"> Count of inprogress tasks. </param>
        /// <param name="total"> Count of total tasks. </param>
        /// <param name="items">
        /// Enumerable of Analyze text job results.
        /// Please note <see cref="AnalyzeTextOperationResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AbstractiveSummarizationOperationResult"/>, <see cref="CustomAbstractiveSummarizationOperationResult"/>, <see cref="CustomEntityRecognitionOperationResult"/>, <see cref="CustomHealthcareOperationResult"/>, <see cref="CustomMultiLabelClassificationOperationResult"/>, <see cref="CustomSentimentAnalysisOperationResult"/>, <see cref="CustomSingleLabelClassificationOperationResult"/>, <see cref="EntityLinkingOperationResult"/>, <see cref="EntityRecognitionOperationResult"/>, <see cref="ExtractiveSummarizationOperationResult"/>, <see cref="HealthcareOperationResult"/>, <see cref="KeyPhraseExtractionOperationResult"/>, <see cref="PiiEntityRecognitionOperationResult"/> and <see cref="SentimentOperationResult"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TextActions(int completed, int failed, int inProgress, int total, IReadOnlyList<AnalyzeTextOperationResult> items, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            Items = items;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextActions"/> for deserialization. </summary>
        internal TextActions()
        {
        }

        /// <summary> Count of completed tasks. </summary>
        public int Completed { get; }
        /// <summary> Count of failed tasks. </summary>
        public int Failed { get; }
        /// <summary> Count of inprogress tasks. </summary>
        public int InProgress { get; }
        /// <summary> Count of total tasks. </summary>
        public int Total { get; }
        /// <summary>
        /// Enumerable of Analyze text job results.
        /// Please note <see cref="AnalyzeTextOperationResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AbstractiveSummarizationOperationResult"/>, <see cref="CustomAbstractiveSummarizationOperationResult"/>, <see cref="CustomEntityRecognitionOperationResult"/>, <see cref="CustomHealthcareOperationResult"/>, <see cref="CustomMultiLabelClassificationOperationResult"/>, <see cref="CustomSentimentAnalysisOperationResult"/>, <see cref="CustomSingleLabelClassificationOperationResult"/>, <see cref="EntityLinkingOperationResult"/>, <see cref="EntityRecognitionOperationResult"/>, <see cref="ExtractiveSummarizationOperationResult"/>, <see cref="HealthcareOperationResult"/>, <see cref="KeyPhraseExtractionOperationResult"/>, <see cref="PiiEntityRecognitionOperationResult"/> and <see cref="SentimentOperationResult"/>.
        /// </summary>
        public IReadOnlyList<AnalyzeTextOperationResult> Items { get; }
    }
}
