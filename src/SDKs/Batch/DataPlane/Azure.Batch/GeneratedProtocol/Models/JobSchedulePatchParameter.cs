// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The set of changes to be made to a job schedule.
    /// </summary>
    public partial class JobSchedulePatchParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobSchedulePatchParameter class.
        /// </summary>
        public JobSchedulePatchParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobSchedulePatchParameter class.
        /// </summary>
        /// <param name="schedule">The schedule according to which jobs will be
        /// created.</param>
        /// <param name="jobSpecification">The details of the jobs to be
        /// created on this schedule.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the job schedule as metadata.</param>
        public JobSchedulePatchParameter(Schedule schedule = default(Schedule), JobSpecification jobSpecification = default(JobSpecification), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            Schedule = schedule;
            JobSpecification = jobSpecification;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the schedule according to which jobs will be created.
        /// </summary>
        /// <remarks>
        /// If you do not specify this element, the existing schedule is left
        /// unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or sets the details of the jobs to be created on this
        /// schedule.
        /// </summary>
        /// <remarks>
        /// Updates affect only jobs that are started after the update has
        /// taken place. Any currently active job continues with the older
        /// specification.
        /// </remarks>
        [JsonProperty(PropertyName = "jobSpecification")]
        public JobSpecification JobSpecification { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job
        /// schedule as metadata.
        /// </summary>
        /// <remarks>
        /// If you do not specify this element, existing metadata is left
        /// unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

    }
}
