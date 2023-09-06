// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> LogAnalytics operation status response. </summary>
    public partial class LogAnalytics
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogAnalytics"/>. </summary>
        internal LogAnalytics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalytics"/>. </summary>
        /// <param name="properties"> LogAnalyticsOutput. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogAnalytics(LogAnalyticsOutput properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> LogAnalyticsOutput. </summary>
        internal LogAnalyticsOutput Properties { get; }
        /// <summary> Output file Uri path to blob container. </summary>
        public string LogAnalyticsOutput
        {
            get => Properties?.Output;
        }
    }
}
