// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Result of the request to calculate template hash. It contains a string of minified template and its hash. </summary>
    public partial class TemplateHashResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TemplateHashResult"/>. </summary>
        internal TemplateHashResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TemplateHashResult"/>. </summary>
        /// <param name="minifiedTemplate"> The minified template string. </param>
        /// <param name="templateHash"> The template hash. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TemplateHashResult(string minifiedTemplate, string templateHash, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MinifiedTemplate = minifiedTemplate;
            TemplateHash = templateHash;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The minified template string. </summary>
        public string MinifiedTemplate { get; }
        /// <summary> The template hash. </summary>
        public string TemplateHash { get; }
    }
}
