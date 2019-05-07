// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.FormRecognizer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Representation of a key-value pair as a list
    /// of key and value tokens.
    /// </summary>
    public partial class ExtractedKeyValuePair
    {
        /// <summary>
        /// Initializes a new instance of the ExtractedKeyValuePair class.
        /// </summary>
        public ExtractedKeyValuePair()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtractedKeyValuePair class.
        /// </summary>
        /// <param name="key">List of tokens for the extracted key in a
        /// key-value pair.</param>
        /// <param name="value">List of tokens for the extracted value in a
        /// key-value pair.</param>
        public ExtractedKeyValuePair(IList<ExtractedToken> key = default(IList<ExtractedToken>), IList<ExtractedToken> value = default(IList<ExtractedToken>))
        {
            Key = key;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of tokens for the extracted key in a key-value
        /// pair.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public IList<ExtractedToken> Key { get; set; }

        /// <summary>
        /// Gets or sets list of tokens for the extracted value in a key-value
        /// pair.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ExtractedToken> Value { get; set; }

    }
}
