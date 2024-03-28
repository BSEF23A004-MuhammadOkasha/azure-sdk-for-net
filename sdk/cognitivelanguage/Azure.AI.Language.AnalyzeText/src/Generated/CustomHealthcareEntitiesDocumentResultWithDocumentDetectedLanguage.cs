// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> The CustomHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage. </summary>
    public partial class CustomHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage : DocumentResult
    {
        /// <summary> Initializes a new instance of <see cref="CustomHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="entities"> Healthcare entities. </param>
        /// <param name="relations"> Healthcare entity relations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/>, <paramref name="entities"/> or <paramref name="relations"/> is null. </exception>
        internal CustomHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<CustomHealthcareEntity> entities, IEnumerable<HealthcareRelation> relations) : base(id, warnings)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(entities, nameof(entities));
            Argument.AssertNotNull(relations, nameof(relations));

            Entities = entities.ToList();
            Relations = relations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CustomHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="entities"> Healthcare entities. </param>
        /// <param name="relations"> Healthcare entity relations. </param>
        /// <param name="detectedLanguage"> If 'language' is set to 'auto' for the document in the request this field will contain a 2 letter ISO 639-1 representation of the language detected for this document. </param>
        internal CustomHealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(string id, IReadOnlyList<DocumentWarning> warnings, DocumentStatistics statistics, IReadOnlyList<CustomHealthcareEntity> entities, IReadOnlyList<HealthcareRelation> relations, DetectedLanguage detectedLanguage) : base(id, warnings, statistics)
        {
            Entities = entities;
            Relations = relations;
            DetectedLanguage = detectedLanguage;
        }

        /// <summary> Healthcare entities. </summary>
        public IReadOnlyList<CustomHealthcareEntity> Entities { get; }
        /// <summary> Healthcare entity relations. </summary>
        public IReadOnlyList<HealthcareRelation> Relations { get; }
        /// <summary> If 'language' is set to 'auto' for the document in the request this field will contain a 2 letter ISO 639-1 representation of the language detected for this document. </summary>
        public DetectedLanguage DetectedLanguage { get; }
    }
}
