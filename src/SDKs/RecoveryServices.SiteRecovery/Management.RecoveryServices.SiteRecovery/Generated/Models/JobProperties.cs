// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Job custom data details.
    /// </summary>
    public partial class JobProperties
    {
        /// <summary>
        /// Initializes a new instance of the JobProperties class.
        /// </summary>
        public JobProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobProperties class.
        /// </summary>
        /// <param name="activityId">The activity id.</param>
        /// <param name="scenarioName">The ScenarioName.</param>
        /// <param name="friendlyName">The DisplayName.</param>
        /// <param name="state">The status of the Job. It is one of these
        /// values - NotStarted, InProgress,
        /// Succeeded, Failed, Cancelled, Suspended or Other.</param>
        /// <param name="stateDescription">The description of the state of the
        /// Job. For e.g. - For Succeeded state,
        /// description can be Completed, PartiallySucceeded,
        /// CompletedWithInformation or Skipped.</param>
        /// <param name="tasks">The tasks.</param>
        /// <param name="errors">The errors.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="allowedActions">The Allowed action the job.</param>
        /// <param name="targetObjectId">The affected Object Id.</param>
        /// <param name="targetObjectName">The name of the affected
        /// object.</param>
        /// <param name="targetInstanceType">The type of the affected object
        /// which is
        /// of {Microsoft.Azure.SiteRecovery.V2015_11_10.AffectedObjectType}
        /// class.</param>
        /// <param name="customDetails">The custom job details like test
        /// failover job details.</param>
        public JobProperties(string activityId = default(string), string scenarioName = default(string), string friendlyName = default(string), string state = default(string), string stateDescription = default(string), IList<ASRTask> tasks = default(IList<ASRTask>), IList<JobErrorDetails> errors = default(IList<JobErrorDetails>), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), IList<string> allowedActions = default(IList<string>), string targetObjectId = default(string), string targetObjectName = default(string), string targetInstanceType = default(string), JobDetails customDetails = default(JobDetails))
        {
            ActivityId = activityId;
            ScenarioName = scenarioName;
            FriendlyName = friendlyName;
            State = state;
            StateDescription = stateDescription;
            Tasks = tasks;
            Errors = errors;
            StartTime = startTime;
            EndTime = endTime;
            AllowedActions = allowedActions;
            TargetObjectId = targetObjectId;
            TargetObjectName = targetObjectName;
            TargetInstanceType = targetInstanceType;
            CustomDetails = customDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the activity id.
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId { get; set; }

        /// <summary>
        /// Gets or sets the ScenarioName.
        /// </summary>
        [JsonProperty(PropertyName = "scenarioName")]
        public string ScenarioName { get; set; }

        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the status of the Job. It is one of these values -
        /// NotStarted, InProgress,
        /// Succeeded, Failed, Cancelled, Suspended or Other.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the description of the state of the Job. For e.g. -
        /// For Succeeded state,
        /// description can be Completed, PartiallySucceeded,
        /// CompletedWithInformation or Skipped.
        /// </summary>
        [JsonProperty(PropertyName = "stateDescription")]
        public string StateDescription { get; set; }

        /// <summary>
        /// Gets or sets the tasks.
        /// </summary>
        [JsonProperty(PropertyName = "tasks")]
        public IList<ASRTask> Tasks { get; set; }

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<JobErrorDetails> Errors { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the Allowed action the job.
        /// </summary>
        [JsonProperty(PropertyName = "allowedActions")]
        public IList<string> AllowedActions { get; set; }

        /// <summary>
        /// Gets or sets the affected Object Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetObjectId")]
        public string TargetObjectId { get; set; }

        /// <summary>
        /// Gets or sets the name of the affected object.
        /// </summary>
        [JsonProperty(PropertyName = "targetObjectName")]
        public string TargetObjectName { get; set; }

        /// <summary>
        /// Gets or sets the type of the affected object which is
        /// of {Microsoft.Azure.SiteRecovery.V2015_11_10.AffectedObjectType}
        /// class.
        /// </summary>
        [JsonProperty(PropertyName = "targetInstanceType")]
        public string TargetInstanceType { get; set; }

        /// <summary>
        /// Gets or sets the custom job details like test failover job details.
        /// </summary>
        [JsonProperty(PropertyName = "customDetails")]
        public JobDetails CustomDetails { get; set; }

    }
}
