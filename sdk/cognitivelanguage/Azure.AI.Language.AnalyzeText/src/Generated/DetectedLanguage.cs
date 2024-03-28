// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> The DetectedLanguage. </summary>
    public partial class DetectedLanguage
    {
        /// <summary> Initializes a new instance of <see cref="DetectedLanguage"/>. </summary>
        /// <param name="name"> Long name of a detected language (e.g. English, French). </param>
        /// <param name="iso6391Name"> A two letter representation of the detected language according to the ISO 639-1 standard (e.g. en, fr). </param>
        /// <param name="confidenceScore"> A confidence score between 0 and 1. Scores close to 1 indicate 100% certainty that the identified language is true. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="iso6391Name"/> is null. </exception>
        internal DetectedLanguage(string name, string iso6391Name, double confidenceScore)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(iso6391Name, nameof(iso6391Name));

            Name = name;
            Iso6391Name = iso6391Name;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Initializes a new instance of <see cref="DetectedLanguage"/>. </summary>
        /// <param name="name"> Long name of a detected language (e.g. English, French). </param>
        /// <param name="iso6391Name"> A two letter representation of the detected language according to the ISO 639-1 standard (e.g. en, fr). </param>
        /// <param name="confidenceScore"> A confidence score between 0 and 1. Scores close to 1 indicate 100% certainty that the identified language is true. </param>
        /// <param name="script"> Identifies the script of the input document. </param>
        /// <param name="scriptCode"> Identifies the script of the input document. </param>
        internal DetectedLanguage(string name, string iso6391Name, double confidenceScore, ScriptKind? script, ScriptCode? scriptCode)
        {
            Name = name;
            Iso6391Name = iso6391Name;
            ConfidenceScore = confidenceScore;
            Script = script;
            ScriptCode = scriptCode;
        }

        /// <summary> Long name of a detected language (e.g. English, French). </summary>
        public string Name { get; }
        /// <summary> A two letter representation of the detected language according to the ISO 639-1 standard (e.g. en, fr). </summary>
        public string Iso6391Name { get; }
        /// <summary> A confidence score between 0 and 1. Scores close to 1 indicate 100% certainty that the identified language is true. </summary>
        public double ConfidenceScore { get; }
        /// <summary> Identifies the script of the input document. </summary>
        public ScriptKind? Script { get; }
        /// <summary> Identifies the script of the input document. </summary>
        public ScriptCode? ScriptCode { get; }
    }
}
