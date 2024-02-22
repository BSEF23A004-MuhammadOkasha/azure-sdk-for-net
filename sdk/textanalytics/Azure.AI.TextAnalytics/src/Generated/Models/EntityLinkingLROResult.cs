// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The EntityLinkingLROResult. </summary>
    internal partial class EntityLinkingLROResult : AnalyzeTextLROResult
    {
        /// <summary> Initializes a new instance of <see cref="EntityLinkingLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="results"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        public EntityLinkingLROResult(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status, EntityLinkingResult results) : base(lastUpdateDateTime, status)
        {
            if (results == null)
            {
                throw new ArgumentNullException(nameof(results));
            }

            Results = results;
            Kind = AnalyzeTextLROResultsKind.EntityLinkingLROResults;
        }

        /// <summary> Initializes a new instance of <see cref="EntityLinkingLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="kind"> Enumeration of supported Text Analysis long-running operation task results. </param>
        /// <param name="taskName"></param>
        /// <param name="results"></param>
        internal EntityLinkingLROResult(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status, AnalyzeTextLROResultsKind kind, string taskName, EntityLinkingResult results) : base(lastUpdateDateTime, status, kind, taskName)
        {
            Results = results;
            Kind = kind;
        }

        /// <summary> Gets or sets the results. </summary>
        public EntityLinkingResult Results { get; set; }
    }
}
