﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class CustomAnalyzer
    {
        /// <summary> Initializes a new instance of CustomAnalyzer. </summary>
        /// <param name="name"> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="tokenizerName"> The name of the tokenizer to use to divide continuous text into a sequence of tokens, such as breaking a sentence into words. </param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is null.</exception>
        public CustomAnalyzer(string name, LexicalTokenizerName tokenizerName) : base(name)
        {
            TokenizerName = tokenizerName;
            TokenFilters = new List<TokenFilterName>();
            CharFilters = new List<string>();
            ODataType = "#Microsoft.Azure.Search.CustomAnalyzer";
        }

        /// <summary> The name of the tokenizer to use to divide continuous text into a sequence of tokens, such as breaking a sentence into words. </summary>
        [CodeGenMember("Tokenizer")]
        public LexicalTokenizerName TokenizerName { get; set; }

        /// <summary> A list of token filters used to filter out or modify the tokens generated by a tokenizer. For example, you can specify a lowercase filter that converts all characters to lowercase. The filters are run in the order in which they are listed. </summary>
        [CodeGenMember(EmptyAsUndefined = true, Initialize = true)]
        public IList<TokenFilterName> TokenFilters { get; }

        /// <summary> A list of character filters used to prepare input text before it is processed by the tokenizer. For instance, they can replace certain characters or symbols. The filters are run in the order in which they are listed. </summary>
        [CodeGenMember(EmptyAsUndefined = true, Initialize = true)]
        public IList<string> CharFilters { get; }
    }
}
