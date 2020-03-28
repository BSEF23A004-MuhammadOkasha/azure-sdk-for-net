// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Models
{
    /// <summary> Marks terms as keywords. This token filter is implemented using Apache Lucene. </summary>
    public partial class KeywordMarkerTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of KeywordMarkerTokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="keywords"> A list of words to mark as keywords. </param>
        public KeywordMarkerTokenFilter(string name, IEnumerable<string> keywords) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (keywords == null)
            {
                throw new ArgumentNullException(nameof(keywords));
            }

            Keywords = keywords.ToArray();
            ODataType = "#Microsoft.Azure.Search.KeywordMarkerTokenFilter";
        }

        /// <summary> Initializes a new instance of KeywordMarkerTokenFilter. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="keywords"> A list of words to mark as keywords. </param>
        /// <param name="ignoreCase"> A value indicating whether to ignore case. If true, all words are converted to lower case first. Default is false. </param>
        internal KeywordMarkerTokenFilter(string oDataType, string name, IList<string> keywords, bool? ignoreCase) : base(oDataType, name)
        {
            Keywords = keywords;
            IgnoreCase = ignoreCase;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.KeywordMarkerTokenFilter";
        }

        /// <summary> A list of words to mark as keywords. </summary>
        public IList<string> Keywords { get; }
        /// <summary> A value indicating whether to ignore case. If true, all words are converted to lower case first. Default is false. </summary>
        public bool? IgnoreCase { get; set; }
    }
}
