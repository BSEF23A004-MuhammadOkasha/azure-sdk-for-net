// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Breaks text following the Unicode Text Segmentation rules. This tokenizer is implemented using Apache Lucene. </summary>
    public partial class LuceneStandardTokenizer : LexicalTokenizer
    {

        /// <summary> Initializes a new instance of LuceneStandardTokenizer. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the tokenizer. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="maxTokenLength"> The maximum token length. Default is 255. Tokens longer than the maximum length are split. The maximum token length that can be used is 300 characters. </param>
        internal LuceneStandardTokenizer(string oDataType, string name, int? maxTokenLength) : base(oDataType, name)
        {
            MaxTokenLength = maxTokenLength;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.StandardTokenizerV2";
        }
    }
}
