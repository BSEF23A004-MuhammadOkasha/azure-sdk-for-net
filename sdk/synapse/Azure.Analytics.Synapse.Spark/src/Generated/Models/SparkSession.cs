// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkSession. </summary>
    public partial class SparkSession
    {
        /// <summary> Initializes a new instance of SparkSession. </summary>
        /// <param name="id"> . </param>
        internal SparkSession(int id)
        {
            Errors = new ChangeTrackingList<SparkServiceError>();
            Tags = new ChangeTrackingDictionary<string, string>();
            Id = id;
            AppInfo = new ChangeTrackingDictionary<string, string>();
            LogLines = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SparkSession. </summary>
        /// <param name="livyInfo"> . </param>
        /// <param name="name"> . </param>
        /// <param name="workspaceName"> . </param>
        /// <param name="sparkPoolName"> . </param>
        /// <param name="submitterName"> . </param>
        /// <param name="submitterId"> . </param>
        /// <param name="artifactId"> . </param>
        /// <param name="jobType"> The job type. </param>
        /// <param name="result"> . </param>
        /// <param name="scheduler"> . </param>
        /// <param name="plugin"> . </param>
        /// <param name="errors"> . </param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="id"> . </param>
        /// <param name="appId"> . </param>
        /// <param name="appInfo"> Dictionary of &lt;string&gt;. </param>
        /// <param name="state"> . </param>
        /// <param name="logLines"> . </param>
        internal SparkSession(SparkSessionState livyInfo, string name, string workspaceName, string sparkPoolName, string submitterName, string submitterId, string artifactId, SparkJobType? jobType, SparkSessionResultType? result, SparkScheduler scheduler, SparkServicePlugin plugin, IReadOnlyList<SparkServiceError> errors, IReadOnlyDictionary<string, string> tags, int id, string appId, IReadOnlyDictionary<string, string> appInfo, string state, IReadOnlyList<string> logLines)
        {
            LivyInfo = livyInfo;
            Name = name;
            WorkspaceName = workspaceName;
            SparkPoolName = sparkPoolName;
            SubmitterName = submitterName;
            SubmitterId = submitterId;
            ArtifactId = artifactId;
            JobType = jobType;
            Result = result;
            Scheduler = scheduler;
            Plugin = plugin;
            Errors = errors;
            Tags = tags;
            Id = id;
            AppId = appId;
            AppInfo = appInfo;
            State = state;
            LogLines = logLines;
        }

        public SparkSessionState LivyInfo { get; }
        public string Name { get; }
        public string WorkspaceName { get; }
        public string SparkPoolName { get; }
        public string SubmitterName { get; }
        public string SubmitterId { get; }
        public string ArtifactId { get; }
        /// <summary> The job type. </summary>
        public SparkJobType? JobType { get; }
        public SparkSessionResultType? Result { get; }
        public SparkScheduler Scheduler { get; }
        public SparkServicePlugin Plugin { get; }
        public IReadOnlyList<SparkServiceError> Errors { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        public int Id { get; }
        public string AppId { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> AppInfo { get; }
        public string State { get; }
        public IReadOnlyList<string> LogLines { get; }
    }
}
