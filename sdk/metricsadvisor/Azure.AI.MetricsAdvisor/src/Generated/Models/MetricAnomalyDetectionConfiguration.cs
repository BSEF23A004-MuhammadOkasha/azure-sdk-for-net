// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AnomalyDetectionConfiguration. </summary>
    public partial class MetricAnomalyDetectionConfiguration
    {

        /// <summary> Initializes a new instance of MetricAnomalyDetectionConfiguration. </summary>
        /// <param name="id"> anomaly detection configuration unique id. </param>
        /// <param name="name"> anomaly detection configuration name. </param>
        /// <param name="description"> anomaly detection configuration description. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="wholeSeriesDetectionConditions"> . </param>
        /// <param name="seriesGroupDetectionConditions"> detection configuration for series group. </param>
        /// <param name="seriesDetectionConditions"> detection configuration for specific series. </param>
        internal MetricAnomalyDetectionConfiguration(string id, string name, string description, string metricId, MetricAnomalyDetectionConditions wholeSeriesDetectionConditions, IList<MetricSeriesGroupAnomalyDetectionConditions> seriesGroupDetectionConditions, IList<MetricSingleSeriesAnomalyDetectionConditions> seriesDetectionConditions)
        {
            Id = id;
            Name = name;
            Description = description;
            MetricId = metricId;
            WholeSeriesDetectionConditions = wholeSeriesDetectionConditions;
            SeriesGroupDetectionConditions = seriesGroupDetectionConditions;
            SeriesDetectionConditions = seriesDetectionConditions;
        }
    }
}
