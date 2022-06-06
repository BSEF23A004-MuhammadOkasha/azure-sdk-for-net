// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Base definition for a job.
    /// Please note <see cref="MachineLearningJobProperties"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
    /// The available derived classes include <see cref="AutoMLJob"/>, <see cref="CommandJob"/>, <see cref="PipelineJob"/>, <see cref="SweepJob"/>.
    /// </summary>
    public partial class MachineLearningJobProperties : ResourceBase
    {
        /// <summary> Initializes a new instance of MachineLearningJobProperties. </summary>
        public MachineLearningJobProperties()
        {
            Services = new ChangeTrackingDictionary<string, JobService>();
        }

        /// <summary> Initializes a new instance of MachineLearningJobProperties. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the &quot;Default&quot; experiment. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="IdentityConfiguration"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="ManagedIdentity"/>, <see cref="UserIdentity"/>.
        /// </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="schedule">
        /// Schedule definition of job.
        /// If no schedule is provided, the job is run once and immediately after submission.
        /// Please note <see cref="ScheduleBase"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
        /// The available derived classes include <see cref="CronSchedule"/>, <see cref="RecurrenceSchedule"/>.
        /// </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="status"> Status of the job. </param>
        internal MachineLearningJobProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, string computeId, string displayName, string experimentName, IdentityConfiguration identity, bool? isArchived, JobType jobType, ScheduleBase schedule, IDictionary<string, JobService> services, JobStatus? status) : base(description, properties, tags)
        {
            ComputeId = computeId;
            DisplayName = displayName;
            ExperimentName = experimentName;
            Identity = identity;
            IsArchived = isArchived;
            JobType = jobType;
            Schedule = schedule;
            Services = services;
            Status = status;
        }

        /// <summary> ARM resource ID of the compute resource. </summary>
        public string ComputeId { get; set; }
        /// <summary> Display name of job. </summary>
        public string DisplayName { get; set; }
        /// <summary> The name of the experiment the job belongs to. If not set, the job is placed in the &quot;Default&quot; experiment. </summary>
        public string ExperimentName { get; set; }
        /// <summary>
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="IdentityConfiguration"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="ManagedIdentity"/>, <see cref="UserIdentity"/>.
        /// </summary>
        public IdentityConfiguration Identity { get; set; }
        /// <summary> Is the asset archived?. </summary>
        public bool? IsArchived { get; set; }
        /// <summary> [Required] Specifies the type of job. </summary>
        internal JobType JobType { get; set; }
        /// <summary>
        /// Schedule definition of job.
        /// If no schedule is provided, the job is run once and immediately after submission.
        /// Please note <see cref="ScheduleBase"/> is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
        /// The available derived classes include <see cref="CronSchedule"/>, <see cref="RecurrenceSchedule"/>.
        /// </summary>
        public ScheduleBase Schedule { get; set; }
        /// <summary>
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </summary>
        public IDictionary<string, JobService> Services { get; set; }
        /// <summary> Status of the job. </summary>
        public JobStatus? Status { get; }
    }
}
