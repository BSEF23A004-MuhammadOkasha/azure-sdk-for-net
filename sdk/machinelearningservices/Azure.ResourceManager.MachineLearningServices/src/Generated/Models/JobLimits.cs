// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The JobLimits. </summary>
    public partial class JobLimits
    {
        /// <summary> Initializes a new instance of JobLimits. </summary>
        public JobLimits()
        {
        }

        /// <summary> Initializes a new instance of JobLimits. </summary>
        /// <param name="jobLimitsType"> JobLimit type. </param>
        /// <param name="timeout"> The max run duration in ISO 8601 format, after which the job will be cancelled. Only supports duration with precision as low as Seconds. </param>
        internal JobLimits(JobLimitsType jobLimitsType, TimeSpan? timeout)
        {
            JobLimitsType = jobLimitsType;
            Timeout = timeout;
        }

        /// <summary> JobLimit type. </summary>
        internal JobLimitsType JobLimitsType { get; set; }
        /// <summary> The max run duration in ISO 8601 format, after which the job will be cancelled. Only supports duration with precision as low as Seconds. </summary>
        public TimeSpan? Timeout { get; set; }
    }
}
