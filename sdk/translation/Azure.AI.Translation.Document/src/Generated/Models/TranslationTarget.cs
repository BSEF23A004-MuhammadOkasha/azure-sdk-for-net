// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    /// <summary> Destination for the finished translated documents. </summary>
    public partial class TranslationTarget
    {
        /// <summary> Initializes a new instance of <see cref="TranslationTarget"/>. </summary>
        /// <param name="targetUri"> Location of the folder / container with your documents. </param>
        /// <param name="languageCode"> Target Language. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetUri"/> or <paramref name="languageCode"/> is null. </exception>
        public TranslationTarget(Uri targetUri, string languageCode)
        {
            Argument.AssertNotNull(targetUri, nameof(targetUri));
            Argument.AssertNotNull(languageCode, nameof(languageCode));

            TargetUri = targetUri;
            LanguageCode = languageCode;
            Glossaries = new ChangeTrackingList<TranslationGlossary>();
        }

        /// <summary> Initializes a new instance of <see cref="TranslationTarget"/>. </summary>
        /// <param name="targetUri"> Location of the folder / container with your documents. </param>
        /// <param name="categoryId"> Category / custom system for translation request. </param>
        /// <param name="languageCode"> Target Language. </param>
        /// <param name="glossaries"> List of Glossary. </param>
        /// <param name="storageSource"> Storage Source. </param>
        internal TranslationTarget(Uri targetUri, string categoryId, string languageCode, IList<TranslationGlossary> glossaries, string storageSource)
        {
            TargetUri = targetUri;
            CategoryId = categoryId;
            LanguageCode = languageCode;
            Glossaries = glossaries;
            StorageSource = storageSource;
        }
        /// <summary> List of Glossary. </summary>
        public IList<TranslationGlossary> Glossaries { get; }
    }
}
