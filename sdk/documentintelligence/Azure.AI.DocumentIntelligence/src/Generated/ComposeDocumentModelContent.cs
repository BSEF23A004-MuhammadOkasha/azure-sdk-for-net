// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Request body to create a composed document model from component document models. </summary>
    public partial class ComposeDocumentModelContent
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

        /// <summary> Initializes a new instance of <see cref="ComposeDocumentModelContent"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="classifierId"> Custom classifier to split and classify the input file. </param>
        /// <param name="docTypes"> Dictionary mapping supported docTypes to the corresponding document models. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/>, <paramref name="classifierId"/> or <paramref name="docTypes"/> is null. </exception>
        public ComposeDocumentModelContent(string modelId, string classifierId, IDictionary<string, DocumentTypeDetails> docTypes)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));
            Argument.AssertNotNull(classifierId, nameof(classifierId));
            Argument.AssertNotNull(docTypes, nameof(docTypes));

            ModelId = modelId;
            ClassifierId = classifierId;
            DocTypes = docTypes;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ComposeDocumentModelContent"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="description"> Document model description. </param>
        /// <param name="classifierId"> Custom classifier to split and classify the input file. </param>
        /// <param name="split"> File splitting behavior. </param>
        /// <param name="docTypes"> Dictionary mapping supported docTypes to the corresponding document models. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComposeDocumentModelContent(string modelId, string description, string classifierId, SplitMode? split, IDictionary<string, DocumentTypeDetails> docTypes, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ModelId = modelId;
            Description = description;
            ClassifierId = classifierId;
            Split = split;
            DocTypes = docTypes;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComposeDocumentModelContent"/> for deserialization. </summary>
        internal ComposeDocumentModelContent()
        {
        }

        /// <summary> Unique document model name. </summary>
        public string ModelId { get; }
        /// <summary> Document model description. </summary>
        public string Description { get; set; }
        /// <summary> Custom classifier to split and classify the input file. </summary>
        public string ClassifierId { get; }
        /// <summary> File splitting behavior. </summary>
        public SplitMode? Split { get; set; }
        /// <summary> Dictionary mapping supported docTypes to the corresponding document models. </summary>
        public IDictionary<string, DocumentTypeDetails> DocTypes { get; }
        /// <summary> List of key-value tag attributes associated with the document model. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
