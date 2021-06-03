// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The KeyPhraseTaskResult. </summary>
    internal partial class KeyPhraseTaskResult
    {
        /// <summary> Initializes a new instance of KeyPhraseTaskResult. </summary>
        internal KeyPhraseTaskResult()
        {
        }

        /// <summary> Initializes a new instance of KeyPhraseTaskResult. </summary>
        /// <param name="results"> . </param>
        internal KeyPhraseTaskResult(KeyPhraseResult results)
        {
            Results = results;
        }

        public KeyPhraseResult Results { get; }
    }
}
