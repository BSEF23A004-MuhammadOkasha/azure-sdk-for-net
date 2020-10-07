// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MetricFeedback. </summary>
    public partial class MetricFeedback
    {

        /// <summary> Initializes a new instance of MetricFeedback. </summary>
        /// <param name="type"> feedback type. </param>
        /// <param name="id"> feedback unique id. </param>
        /// <param name="createdTime"> feedback created time. </param>
        /// <param name="userPrincipal"> user who gives this feedback. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"> . </param>
        internal MetricFeedback(FeedbackType type, string id, DateTimeOffset? createdTime, string userPrincipal, string metricId, FeedbackDimensionFilter dimensionFilter)
        {
            Type = type;
            Id = id;
            CreatedTime = createdTime;
            UserPrincipal = userPrincipal;
            MetricId = metricId;
            DimensionFilter = dimensionFilter;
        }
    }
}
