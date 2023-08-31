// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Time and capacity request parameters. </summary>
    public partial class HDInsightAutoScaleTimeAndCapacity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightAutoScaleTimeAndCapacity"/>. </summary>
        public HDInsightAutoScaleTimeAndCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightAutoScaleTimeAndCapacity"/>. </summary>
        /// <param name="time"> 24-hour time in the form xx:xx. </param>
        /// <param name="minInstanceCount"> The minimum instance count of the cluster. </param>
        /// <param name="maxInstanceCount"> The maximum instance count of the cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightAutoScaleTimeAndCapacity(string time, int? minInstanceCount, int? maxInstanceCount, Dictionary<string, BinaryData> rawData)
        {
            Time = time;
            MinInstanceCount = minInstanceCount;
            MaxInstanceCount = maxInstanceCount;
            _rawData = rawData;
        }

        /// <summary> 24-hour time in the form xx:xx. </summary>
        public string Time { get; set; }
        /// <summary> The minimum instance count of the cluster. </summary>
        public int? MinInstanceCount { get; set; }
        /// <summary> The maximum instance count of the cluster. </summary>
        public int? MaxInstanceCount { get; set; }
    }
}
