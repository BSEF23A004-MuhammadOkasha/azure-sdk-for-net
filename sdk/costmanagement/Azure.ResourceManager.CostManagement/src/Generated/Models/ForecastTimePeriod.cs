// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Has time period for pulling data for the forecast. </summary>
    public partial class ForecastTimePeriod
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ForecastTimePeriod"/>. </summary>
        /// <param name="from"> The start date to pull data from. </param>
        /// <param name="to"> The end date to pull data to. </param>
        public ForecastTimePeriod(DateTimeOffset @from, DateTimeOffset to)
        {
            From = @from;
            To = to;
        }

        /// <summary> Initializes a new instance of <see cref="ForecastTimePeriod"/>. </summary>
        /// <param name="from"> The start date to pull data from. </param>
        /// <param name="to"> The end date to pull data to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ForecastTimePeriod(DateTimeOffset @from, DateTimeOffset to, Dictionary<string, BinaryData> rawData)
        {
            From = @from;
            To = to;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ForecastTimePeriod"/> for deserialization. </summary>
        internal ForecastTimePeriod()
        {
        }

        /// <summary> The start date to pull data from. </summary>
        public DateTimeOffset From { get; }
        /// <summary> The end date to pull data to. </summary>
        public DateTimeOffset To { get; }
    }
}
