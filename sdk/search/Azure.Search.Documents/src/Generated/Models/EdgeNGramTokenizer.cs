// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> Tokenizes the input from an edge into n-grams of the given size(s). This tokenizer is implemented using Apache Lucene. </summary>
    public partial class EdgeNGramTokenizer : Tokenizer
    {
        /// <summary> Initializes a new instance of EdgeNGramTokenizer. </summary>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        public EdgeNGramTokenizer(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            ODataType = "#Microsoft.Azure.Search.EdgeNGramTokenizer";
        }

        /// <summary> Initializes a new instance of EdgeNGramTokenizer. </summary>
        /// <param name="minGram"> The minimum n-gram length. Default is 1. Maximum is 300. Must be less than the value of maxGram. </param>
        /// <param name="maxGram"> The maximum n-gram length. Default is 2. Maximum is 300. </param>
        /// <param name="tokenChars"> Character classes to keep in the tokens. </param>
        /// <param name="oDataType"> The model type. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal EdgeNGramTokenizer(int? minGram, int? maxGram, IList<TokenCharacterKind> tokenChars, string oDataType, string name) : base(oDataType, name)
        {
            MinGram = minGram;
            MaxGram = maxGram;
            TokenChars = tokenChars;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.EdgeNGramTokenizer";
        }

        /// <summary> The minimum n-gram length. Default is 1. Maximum is 300. Must be less than the value of maxGram. </summary>
        public int? MinGram { get; set; }
        /// <summary> The maximum n-gram length. Default is 2. Maximum is 300. </summary>
        public int? MaxGram { get; set; }
        /// <summary> Character classes to keep in the tokens. </summary>
        public IList<TokenCharacterKind> TokenChars { get; set; }
    }
}
