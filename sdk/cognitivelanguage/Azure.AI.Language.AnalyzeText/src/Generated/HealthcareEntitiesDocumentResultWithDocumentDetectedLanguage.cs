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
    /// <summary> The HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage. </summary>
    public partial class HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage : DocumentResult
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="entities"> Healthcare entities. </param>
        /// <param name="relations"> Healthcare entity relations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/>, <paramref name="entities"/> or <paramref name="relations"/> is null. </exception>
        internal HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<HealthcareEntity> entities, IEnumerable<HealthcareRelation> relations) : base(id, warnings)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(entities, nameof(entities));
            Argument.AssertNotNull(relations, nameof(relations));

            Entities = entities.ToList();
            Relations = relations.ToList();
            FhirBundle = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="entities"> Healthcare entities. </param>
        /// <param name="relations"> Healthcare entity relations. </param>
        /// <param name="fhirBundle"> JSON bundle containing a FHIR compatible object for consumption in other Healthcare tools. For additional information see https://www.hl7.org/fhir/overview.html. </param>
        /// <param name="detectedLanguage"> If 'language' is set to 'auto' for the document in the request this field will contain a 2 letter ISO 639-1 representation of the language detected for this document. </param>
        internal HealthcareEntitiesDocumentResultWithDocumentDetectedLanguage(string id, IReadOnlyList<DocumentWarning> warnings, DocumentStatistics statistics, IReadOnlyList<HealthcareEntity> entities, IReadOnlyList<HealthcareRelation> relations, IReadOnlyDictionary<string, BinaryData> fhirBundle, DetectedLanguage detectedLanguage) : base(id, warnings, statistics)
        {
            Entities = entities;
            Relations = relations;
            FhirBundle = fhirBundle;
            DetectedLanguage = detectedLanguage;
        }

        /// <summary> Healthcare entities. </summary>
        public IReadOnlyList<HealthcareEntity> Entities { get; }
        /// <summary> Healthcare entity relations. </summary>
        public IReadOnlyList<HealthcareRelation> Relations { get; }
        /// <summary>
        /// JSON bundle containing a FHIR compatible object for consumption in other Healthcare tools. For additional information see https://www.hl7.org/fhir/overview.html.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> FhirBundle { get; }
        /// <summary> If 'language' is set to 'auto' for the document in the request this field will contain a 2 letter ISO 639-1 representation of the language detected for this document. </summary>
        public DetectedLanguage DetectedLanguage { get; }
    }
}
