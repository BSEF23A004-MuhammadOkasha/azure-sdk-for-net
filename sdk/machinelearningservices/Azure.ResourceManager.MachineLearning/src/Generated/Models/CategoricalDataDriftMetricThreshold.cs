// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The CategoricalDataDriftMetricThreshold. </summary>
    public partial class CategoricalDataDriftMetricThreshold : DataDriftMetricThresholdBase
    {
        /// <summary> Initializes a new instance of CategoricalDataDriftMetricThreshold. </summary>
        /// <param name="metric"> [Required] The categorical data drift metric to calculate. </param>
        public CategoricalDataDriftMetricThreshold(CategoricalDataDriftMetric metric)
        {
            Metric = metric;
            DataType = MonitoringFeatureDataType.Categorical;
        }

        /// <summary> Initializes a new instance of CategoricalDataDriftMetricThreshold. </summary>
        /// <param name="dataType"> [Required] Specifies the data type of the metric threshold. </param>
        /// <param name="threshold"> The threshold value. If null, a default value will be set depending on the selected metric. </param>
        /// <param name="metric"> [Required] The categorical data drift metric to calculate. </param>
        internal CategoricalDataDriftMetricThreshold(MonitoringFeatureDataType dataType, MonitoringThreshold threshold, CategoricalDataDriftMetric metric) : base(dataType, threshold)
        {
            Metric = metric;
            DataType = dataType;
        }

        /// <summary> [Required] The categorical data drift metric to calculate. </summary>
        public CategoricalDataDriftMetric Metric { get; set; }
    }
}
