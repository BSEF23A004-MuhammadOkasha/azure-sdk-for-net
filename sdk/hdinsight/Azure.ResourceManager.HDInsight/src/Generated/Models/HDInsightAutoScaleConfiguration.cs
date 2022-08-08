// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The autoscale request parameters. </summary>
    public partial class HDInsightAutoScaleConfiguration
    {
        /// <summary> Initializes a new instance of HDInsightAutoScaleConfiguration. </summary>
        public HDInsightAutoScaleConfiguration()
        {
        }

        /// <summary> Initializes a new instance of HDInsightAutoScaleConfiguration. </summary>
        /// <param name="capacity"> Parameters for load-based autoscale. </param>
        /// <param name="recurrence"> Parameters for schedule-based autoscale. </param>
        internal HDInsightAutoScaleConfiguration(HDInsightAutoScaleCapacity capacity, HDInsightAutoScaleRecurrence recurrence)
        {
            Capacity = capacity;
            Recurrence = recurrence;
        }

        /// <summary> Parameters for load-based autoscale. </summary>
        public HDInsightAutoScaleCapacity Capacity { get; set; }
        /// <summary> Parameters for schedule-based autoscale. </summary>
        public HDInsightAutoScaleRecurrence Recurrence { get; set; }
    }
}
