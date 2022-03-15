// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Sweep Job limit class. </summary>
    public partial class SweepJobLimits : JobLimits
    {
        /// <summary> Initializes a new instance of SweepJobLimits. </summary>
        public SweepJobLimits()
        {
            JobLimitsType = JobLimitsType.Sweep;
        }

        /// <summary> Initializes a new instance of SweepJobLimits. </summary>
        /// <param name="jobLimitsType"> JobLimit type. </param>
        /// <param name="timeout"> The max run duration in ISO 8601 format, after which the job will be cancelled. Only supports duration with precision as low as Seconds. </param>
        /// <param name="maxConcurrentTrials"> Sweep Job max concurrent trials. </param>
        /// <param name="maxTotalTrials"> Sweep Job max total trials. </param>
        /// <param name="trialTimeout"> Sweep Job Trial timeout value. </param>
        internal SweepJobLimits(JobLimitsType jobLimitsType, TimeSpan? timeout, int? maxConcurrentTrials, int? maxTotalTrials, TimeSpan? trialTimeout) : base(jobLimitsType, timeout)
        {
            MaxConcurrentTrials = maxConcurrentTrials;
            MaxTotalTrials = maxTotalTrials;
            TrialTimeout = trialTimeout;
            JobLimitsType = jobLimitsType;
        }

        /// <summary> Sweep Job max concurrent trials. </summary>
        public int? MaxConcurrentTrials { get; set; }
        /// <summary> Sweep Job max total trials. </summary>
        public int? MaxTotalTrials { get; set; }
        /// <summary> Sweep Job Trial timeout value. </summary>
        public TimeSpan? TrialTimeout { get; set; }
    }
}
