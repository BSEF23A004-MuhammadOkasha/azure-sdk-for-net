// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    /// <summary> The analysis request of the text. </summary>
    public partial class AnalyzeTextOptions
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of AnalyzeTextOptions. </summary>
        /// <param name="text"> The text needs to be scanned. We support at most 1000 characters (unicode code points) in text of one request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        public AnalyzeTextOptions(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
            Categories = new ChangeTrackingList<TextCategory>();
            BlocklistNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AnalyzeTextOptions. </summary>
        /// <param name="text"> The text needs to be scanned. We support at most 1000 characters (unicode code points) in text of one request. </param>
        /// <param name="categories"> The categories will be analyzed. If not assigned, a default set of the categories' analysis results will be returned. </param>
        /// <param name="blocklistNames"> The names of blocklists. </param>
        /// <param name="breakByBlocklists"> When set to true, further analyses of harmful content will not be performed in cases where blocklists are hit. When set to false, all analyses of harmful content will be performed, whether or not blocklists are hit. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeTextOptions(string text, IList<TextCategory> categories, IList<string> blocklistNames, bool? breakByBlocklists, Dictionary<string, BinaryData> rawData)
        {
            Text = text;
            Categories = categories;
            BlocklistNames = blocklistNames;
            BreakByBlocklists = breakByBlocklists;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextOptions"/> for deserialization. </summary>
        internal AnalyzeTextOptions()
        {
        }

        /// <summary> The text needs to be scanned. We support at most 1000 characters (unicode code points) in text of one request. </summary>
        public string Text { get; }
        /// <summary> The categories will be analyzed. If not assigned, a default set of the categories' analysis results will be returned. </summary>
        public IList<TextCategory> Categories { get; }
        /// <summary> The names of blocklists. </summary>
        public IList<string> BlocklistNames { get; }
        /// <summary> When set to true, further analyses of harmful content will not be performed in cases where blocklists are hit. When set to false, all analyses of harmful content will be performed, whether or not blocklists are hit. </summary>
        public bool? BreakByBlocklists { get; set; }
    }
}
