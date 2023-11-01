// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// The configuration information for an embeddings request.
    /// Embeddings measure the relatedness of text strings and are commonly used for search, clustering,
    /// recommendations, and other similar scenarios.
    /// </summary>
    public partial class EmbeddingsOptions
    {
        /// <summary> Initializes a new instance of EmbeddingsOptions. </summary>
        /// <param name="user">
        /// An identifier for the caller or end user of the operation. This may be used for tracking
        /// or rate-limiting purposes.
        /// </param>
        /// <param name="deploymentName">
        /// The model name to provide as part of this embeddings request.
        /// Not applicable to Azure OpenAI, where deployment information should be included in the Azure
        /// resource URI that's connected to.
        /// </param>
        /// <param name="input">
        /// Input texts to get embeddings for, encoded as a an array of strings.
        /// Each input must not exceed 2048 tokens in length.
        ///
        /// Unless you are embedding code, we suggest replacing newlines (\n) in your input with a single space,
        /// as we have observed inferior results when newlines are present.
        /// </param>
        internal EmbeddingsOptions(string user, string deploymentName, IList<string> input)
        {
            User = user;
            DeploymentName = deploymentName;
            Input = input;
        }

        /// <summary>
        /// An identifier for the caller or end user of the operation. This may be used for tracking
        /// or rate-limiting purposes.
        /// </summary>
        public string User { get; set; }
    }
}
