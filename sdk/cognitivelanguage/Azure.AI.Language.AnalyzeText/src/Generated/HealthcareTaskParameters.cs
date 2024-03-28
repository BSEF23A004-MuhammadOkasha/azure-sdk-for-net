// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> Supported parameters for a Healthcare task. </summary>
    public partial class HealthcareTaskParameters : PreBuiltTaskParameters
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareTaskParameters"/>. </summary>
        public HealthcareTaskParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareTaskParameters"/>. </summary>
        /// <param name="loggingOptOut"> logging opt out. </param>
        /// <param name="modelVersion"> model version. </param>
        /// <param name="stringIndexType"></param>
        /// <param name="fhirVersion"> The FHIR Spec version that the result will use to format the fhirBundle. For additional information see https://www.hl7.org/fhir/overview.html. </param>
        /// <param name="documentType"> Document type that can be provided as input for Fhir Documents. Expect to have fhirVersion provided when used. Behavior of using None enum is the same as not using the documentType parameter. </param>
        internal HealthcareTaskParameters(bool? loggingOptOut, string modelVersion, StringIndexType? stringIndexType, FhirVersion? fhirVersion, HealthcareDocumentType? documentType) : base(loggingOptOut, modelVersion)
        {
            StringIndexType = stringIndexType;
            FhirVersion = fhirVersion;
            DocumentType = documentType;
        }

        /// <summary> Gets or sets the string index type. </summary>
        public StringIndexType? StringIndexType { get; set; }
        /// <summary> The FHIR Spec version that the result will use to format the fhirBundle. For additional information see https://www.hl7.org/fhir/overview.html. </summary>
        public FhirVersion? FhirVersion { get; set; }
        /// <summary> Document type that can be provided as input for Fhir Documents. Expect to have fhirVersion provided when used. Behavior of using None enum is the same as not using the documentType parameter. </summary>
        public HealthcareDocumentType? DocumentType { get; set; }
    }
}
