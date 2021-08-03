// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> Destination for the finished translated documents. </summary>
    public partial class TargetInput
    {
        /// <summary> Initializes a new instance of TargetInput. </summary>
        /// <param name="targetUrl"> Location of the folder / container with your documents. </param>
        /// <param name="language"> Target Language. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetUrl"/> or <paramref name="language"/> is null. </exception>
        public TargetInput(string targetUrl, string language)
        {
            if (targetUrl == null)
            {
                throw new ArgumentNullException(nameof(targetUrl));
            }
            if (language == null)
            {
                throw new ArgumentNullException(nameof(language));
            }

            TargetUrl = targetUrl;
            Language = language;
            Glossaries = new ChangeTrackingList<Glossary>();
        }

        /// <summary> Location of the folder / container with your documents. </summary>
        public string TargetUrl { get; }
        /// <summary> Category / custom system for translation request. </summary>
        public string Category { get; set; }
        /// <summary> Target Language. </summary>
        public string Language { get; }
        /// <summary> List of Glossary. </summary>
        public IList<Glossary> Glossaries { get; }
        /// <summary> Storage Source. </summary>
        public StorageSource? StorageSource { get; set; }
    }
}
