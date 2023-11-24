// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Grammar-based tokenizer that is suitable for processing most European-language documents. This tokenizer is implemented using Apache Lucene. </summary>
    public partial class ClassicTokenizer : LexicalTokenizer
    {
        /// <summary> Initializes a new instance of <see cref="ClassicTokenizer"/>. </summary>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ClassicTokenizer(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ODataType = "#Microsoft.Azure.Search.ClassicTokenizer";
        }

        /// <summary> Initializes a new instance of <see cref="ClassicTokenizer"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of tokenizer. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="maxTokenLength"> The maximum token length. Default is 255. Tokens longer than the maximum length are split. The maximum token length that can be used is 300 characters. </param>
        internal ClassicTokenizer(string oDataType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData, int? maxTokenLength) : base(oDataType, name, serializedAdditionalRawData)
        {
            MaxTokenLength = maxTokenLength;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.ClassicTokenizer";
        }

        /// <summary> Initializes a new instance of <see cref="ClassicTokenizer"/> for deserialization. </summary>
        internal ClassicTokenizer()
        {
        }

        /// <summary> The maximum token length. Default is 255. Tokens longer than the maximum length are split. The maximum token length that can be used is 300 characters. </summary>
        public int? MaxTokenLength { get; set; }
    }
}
