// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather.Models
{
    /// <summary> Phrase summaries for the entire forecast period. </summary>
    public partial class MinuteForecastSummary
    {
        /// <summary> Initializes a new instance of MinuteForecastSummary. </summary>
        internal MinuteForecastSummary()
        {
        }

        /// <summary> Initializes a new instance of MinuteForecastSummary. </summary>
        /// <param name="briefPhrase60"> Summary phrase for the next 60 minutes. Phrase length is approximately 60 characters. </param>
        /// <param name="shortPhrase"> Short summary phrase for the next 120 minutes. Phrase length is approximately 25 characters. </param>
        /// <param name="briefPhrase"> Summary phrase for the next 120 minutes. Phrase length is approximately 60 characters. </param>
        /// <param name="longPhrase"> Long summary phrase for the next 120 minutes. Phrase length is 60+ characters. </param>
        /// <param name="iconCode"> Numeric value representing an image that displays the `iconPhrase`. Please refer to [Weather Service Concepts](https://aka.ms/AzureMapsWeatherConcepts) for details. </param>
        internal MinuteForecastSummary(string briefPhrase60, string shortPhrase, string briefPhrase, string longPhrase, int? iconCode)
        {
            BriefPhrase60 = briefPhrase60;
            ShortPhrase = shortPhrase;
            BriefPhrase = briefPhrase;
            LongPhrase = longPhrase;
            IconCode = iconCode;
        }

        /// <summary> Summary phrase for the next 60 minutes. Phrase length is approximately 60 characters. </summary>
        public string BriefPhrase60 { get; }
        /// <summary> Short summary phrase for the next 120 minutes. Phrase length is approximately 25 characters. </summary>
        public string ShortPhrase { get; }
        /// <summary> Summary phrase for the next 120 minutes. Phrase length is approximately 60 characters. </summary>
        public string BriefPhrase { get; }
        /// <summary> Long summary phrase for the next 120 minutes. Phrase length is 60+ characters. </summary>
        public string LongPhrase { get; }
        /// <summary> Numeric value representing an image that displays the `iconPhrase`. Please refer to [Weather Service Concepts](https://aka.ms/AzureMapsWeatherConcepts) for details. </summary>
        public int? IconCode { get; }
    }
}
