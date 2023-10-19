// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The AlexaInfo. </summary>
    public partial class AlexaInfo
    {
        /// <summary> Initializes a new instance of AlexaInfo. </summary>
        public AlexaInfo()
        {
        }

        /// <summary> Initializes a new instance of AlexaInfo. </summary>
        /// <param name="alexaRank"></param>
        /// <param name="category"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="recent"></param>
        internal AlexaInfo(long? alexaRank, string category, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, bool? recent)
        {
            AlexaRank = alexaRank;
            Category = category;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            Recent = recent;
        }

        /// <summary> Gets or sets the alexa rank. </summary>
        public long? AlexaRank { get; set; }
        /// <summary> Gets or sets the category. </summary>
        public string Category { get; set; }
        /// <summary> Gets or sets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; set; }
        /// <summary> Gets or sets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; set; }
        /// <summary> Gets or sets the count. </summary>
        public long? Count { get; set; }
        /// <summary> Gets or sets the recent. </summary>
        public bool? Recent { get; set; }
    }
}
