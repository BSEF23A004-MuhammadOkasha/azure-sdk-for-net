// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.ContentSafety
{
    /// <summary> Text analysis result. </summary>
    public partial class TextAnalyzeSeverityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of TextAnalyzeSeverityResult. </summary>
        /// <param name="category"> The text category. </param>
        /// <param name="severity"> The higher the severity of input content, the larger this value is. The values could be: 0,2,4,6. </param>
        internal TextAnalyzeSeverityResult(TextCategory category, int severity)
        {
            Category = category;
            Severity = severity;
        }

        /// <summary> Initializes a new instance of TextAnalyzeSeverityResult. </summary>
        /// <param name="category"> The text category. </param>
        /// <param name="severity"> The higher the severity of input content, the larger this value is. The values could be: 0,2,4,6. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TextAnalyzeSeverityResult(TextCategory category, int severity, Dictionary<string, BinaryData> rawData)
        {
            Category = category;
            Severity = severity;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextAnalyzeSeverityResult"/> for deserialization. </summary>
        internal TextAnalyzeSeverityResult()
        {
        }

        /// <summary> The text category. </summary>
        public TextCategory Category { get; }
        /// <summary> The higher the severity of input content, the larger this value is. The values could be: 0,2,4,6. </summary>
        public int Severity { get; }
    }
}
