// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Definition of the link mapping of prediction. </summary>
    public partial class PredictionMappings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PredictionMappings"/>. </summary>
        /// <param name="score"> The score of the link mapping. </param>
        /// <param name="grade"> The grade of the link mapping. </param>
        /// <param name="reason"> The reason of the link mapping. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="score"/>, <paramref name="grade"/> or <paramref name="reason"/> is null. </exception>
        public PredictionMappings(string score, string grade, string reason)
        {
            Argument.AssertNotNull(score, nameof(score));
            Argument.AssertNotNull(grade, nameof(grade));
            Argument.AssertNotNull(reason, nameof(reason));

            Score = score;
            Grade = grade;
            Reason = reason;
        }

        /// <summary> Initializes a new instance of <see cref="PredictionMappings"/>. </summary>
        /// <param name="score"> The score of the link mapping. </param>
        /// <param name="grade"> The grade of the link mapping. </param>
        /// <param name="reason"> The reason of the link mapping. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PredictionMappings(string score, string grade, string reason, Dictionary<string, BinaryData> rawData)
        {
            Score = score;
            Grade = grade;
            Reason = reason;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PredictionMappings"/> for deserialization. </summary>
        internal PredictionMappings()
        {
        }

        /// <summary> The score of the link mapping. </summary>
        public string Score { get; set; }
        /// <summary> The grade of the link mapping. </summary>
        public string Grade { get; set; }
        /// <summary> The reason of the link mapping. </summary>
        public string Reason { get; set; }
    }
}
