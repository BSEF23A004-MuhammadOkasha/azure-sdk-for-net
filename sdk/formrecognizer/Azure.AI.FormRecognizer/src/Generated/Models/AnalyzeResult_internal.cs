// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Analyze operation result. </summary>
    internal partial class AnalyzeResult_internal
    {
        /// <summary> Initializes a new instance of AnalyzeResult_internal. </summary>
        internal AnalyzeResult_internal()
        {
        }

        /// <summary> Initializes a new instance of AnalyzeResult_internal. </summary>
        /// <param name="version"> Version of schema used for this result. </param>
        /// <param name="readResults"> Text extracted from the input. </param>
        /// <param name="pageResults"> Page-level information extracted from the input. </param>
        /// <param name="documentResults"> Document-level information extracted from the input. </param>
        /// <param name="errors"> List of errors reported during the analyze operation. </param>
        internal AnalyzeResult_internal(string version, IList<ReadResult_internal> readResults, IList<PageResult_internal> pageResults, IList<DocumentResult_internal> documentResults, IList<FormRecognizerError> errors)
        {
            Version = version;
            ReadResults = readResults;
            PageResults = pageResults;
            DocumentResults = documentResults;
            Errors = errors;
        }

        /// <summary> Version of schema used for this result. </summary>
        public string Version { get; internal set; }
        /// <summary> Text extracted from the input. </summary>
        public IList<ReadResult_internal> ReadResults { get; internal set; } = new List<ReadResult_internal>();
        /// <summary> Page-level information extracted from the input. </summary>
        public IList<PageResult_internal> PageResults { get; internal set; }
        /// <summary> Document-level information extracted from the input. </summary>
        public IList<DocumentResult_internal> DocumentResults { get; internal set; }
        /// <summary> List of errors reported during the analyze operation. </summary>
        public IList<FormRecognizerError> Errors { get; internal set; }
    }
}
