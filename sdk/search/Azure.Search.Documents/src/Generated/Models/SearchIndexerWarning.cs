// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents an item-level warning. </summary>
    public partial class SearchIndexerWarning
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

        /// <summary> Initializes a new instance of <see cref="SearchIndexerWarning"/>. </summary>
        /// <param name="message"> The message describing the warning that occurred while processing the item. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal SearchIndexerWarning(string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Message = message;
        }

        /// <summary> Initializes a new instance of <see cref="SearchIndexerWarning"/>. </summary>
        /// <param name="key"> The key of the item which generated a warning. </param>
        /// <param name="message"> The message describing the warning that occurred while processing the item. </param>
        /// <param name="name"> The name of the source at which the warning originated. For example, this could refer to a particular skill in the attached skillset. This may not be always available. </param>
        /// <param name="details"> Additional, verbose details about the warning to assist in debugging the indexer. This may not be always available. </param>
        /// <param name="documentationLink"> A link to a troubleshooting guide for these classes of warnings. This may not be always available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchIndexerWarning(string key, string message, string name, string details, string documentationLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key = key;
            Message = message;
            Name = name;
            Details = details;
            DocumentationLink = documentationLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SearchIndexerWarning"/> for deserialization. </summary>
        internal SearchIndexerWarning()
        {
        }

        /// <summary> The key of the item which generated a warning. </summary>
        public string Key { get; }
        /// <summary> The message describing the warning that occurred while processing the item. </summary>
        public string Message { get; }
        /// <summary> The name of the source at which the warning originated. For example, this could refer to a particular skill in the attached skillset. This may not be always available. </summary>
        public string Name { get; }
        /// <summary> Additional, verbose details about the warning to assist in debugging the indexer. This may not be always available. </summary>
        public string Details { get; }
        /// <summary> A link to a troubleshooting guide for these classes of warnings. This may not be always available. </summary>
        public string DocumentationLink { get; }
    }
}
