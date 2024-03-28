// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> Represents the Currency ) entity Metadata model. </summary>
    public partial class CurrencyMetadata : BaseMetadata
    {
        /// <summary> Initializes a new instance of <see cref="CurrencyMetadata"/>. </summary>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <param name="unit"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="unit"/> is null. </exception>
        internal CurrencyMetadata(double value, string unit)
        {
            Argument.AssertNotNull(unit, nameof(unit));

            MetadataKind = MetadataKind.CurrencyMetadata;
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="CurrencyMetadata"/>. </summary>
        /// <param name="metadataKind"></param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <param name="unit"></param>
        /// <param name="iso4217"> The alphabetic code based on another ISO standard, ISO 3166, which lists the codes for country names. The first two letters of the ISO 4217 three-letter code are the same as the code for the country name, and, where possible, the third letter corresponds to the first letter of the currency name. </param>
        internal CurrencyMetadata(MetadataKind metadataKind, double value, string unit, string iso4217) : base(metadataKind)
        {
            Value = value;
            Unit = unit;
            Iso4217 = iso4217;
        }

        /// <summary> The numeric value that the extracted text denotes. </summary>
        public double Value { get; }
        /// <summary> Gets the unit. </summary>
        public string Unit { get; }
        /// <summary> The alphabetic code based on another ISO standard, ISO 3166, which lists the codes for country names. The first two letters of the ISO 4217 three-letter code are the same as the code for the country name, and, where possible, the third letter corresponds to the first letter of the currency name. </summary>
        public string Iso4217 { get; }
    }
}
