// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of the job.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Job : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="runbook">Gets or sets the runbook.</param>
        /// <param name="startedBy">Gets or sets the job started by.</param>
        /// <param name="runOn">Gets or sets the runOn which specifies the
        /// group name where the job is to be executed.</param>
        /// <param name="jobId">Gets or sets the id of the job.</param>
        /// <param name="creationTime">Gets or sets the creation time of the
        /// job.</param>
        /// <param name="status">Gets or sets the status of the job. Possible
        /// values include: 'New', 'Activating', 'Running', 'Completed',
        /// 'Failed', 'Stopped', 'Blocked', 'Suspended', 'Disconnected',
        /// 'Suspending', 'Stopping', 'Resuming', 'Removing'</param>
        /// <param name="statusDetails">Gets or sets the status details of the
        /// job.</param>
        /// <param name="startTime">Gets or sets the start time of the
        /// job.</param>
        /// <param name="endTime">Gets or sets the end time of the job.</param>
        /// <param name="exception">Gets or sets the exception of the
        /// job.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified time
        /// of the job.</param>
        /// <param name="lastStatusModifiedTime">Gets or sets the last status
        /// modified time of the job.</param>
        /// <param name="parameters">Gets or sets the parameters of the
        /// job.</param>
        /// <param name="provisioningState">The provisioning state of a
        /// resource.</param>
        public Job(string id = default(string), string name = default(string), string type = default(string), RunbookAssociationProperty runbook = default(RunbookAssociationProperty), string startedBy = default(string), string runOn = default(string), System.Guid? jobId = default(System.Guid?), System.DateTimeOffset creationTime = default(System.DateTimeOffset), string status = default(string), string statusDetails = default(string), System.DateTimeOffset startTime = default(System.DateTimeOffset), System.DateTimeOffset endTime = default(System.DateTimeOffset), string exception = default(string), System.DateTimeOffset lastModifiedTime = default(System.DateTimeOffset), System.DateTimeOffset lastStatusModifiedTime = default(System.DateTimeOffset), IDictionary<string, string> parameters = default(IDictionary<string, string>), JobProvisioningStateProperty provisioningState = default(JobProvisioningStateProperty))
            : base(id, name, type)
        {
            Runbook = runbook;
            StartedBy = startedBy;
            RunOn = runOn;
            JobId = jobId;
            CreationTime = creationTime;
            Status = status;
            StatusDetails = statusDetails;
            StartTime = startTime;
            EndTime = endTime;
            Exception = exception;
            LastModifiedTime = lastModifiedTime;
            LastStatusModifiedTime = lastStatusModifiedTime;
            Parameters = parameters;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the runbook.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runbook")]
        public RunbookAssociationProperty Runbook { get; set; }

        /// <summary>
        /// Gets or sets the job started by.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startedBy")]
        public string StartedBy { get; set; }

        /// <summary>
        /// Gets or sets the runOn which specifies the group name where the job
        /// is to be executed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runOn")]
        public string RunOn { get; set; }

        /// <summary>
        /// Gets or sets the id of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobId")]
        public System.Guid? JobId { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTimeOffset CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the status of the job. Possible values include: 'New',
        /// 'Activating', 'Running', 'Completed', 'Failed', 'Stopped',
        /// 'Blocked', 'Suspended', 'Disconnected', 'Suspending', 'Stopping',
        /// 'Resuming', 'Removing'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the status details of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusDetails")]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Gets or sets the start time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Gets or sets the exception of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.exception")]
        public string Exception { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTimeOffset LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the last status modified time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastStatusModifiedTime")]
        public System.DateTimeOffset LastStatusModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of a resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public JobProvisioningStateProperty ProvisioningState { get; set; }

    }
}
