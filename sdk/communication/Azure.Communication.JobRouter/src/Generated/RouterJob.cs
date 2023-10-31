// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> A unit of work to be routed. </summary>
    public partial class RouterJob
    {
        /// <summary> Initializes a new instance of RouterJob. </summary>
        internal RouterJob()
        {
            RequestedWorkerSelectors = new ChangeTrackingList<RouterWorkerSelector>();
            AttachedWorkerSelectors = new ChangeTrackingList<RouterWorkerSelector>();
            _labels = new ChangeTrackingDictionary<string, BinaryData>();
            Assignments = new ChangeTrackingDictionary<string, RouterJobAssignment>();
            _tags = new ChangeTrackingDictionary<string, BinaryData>();
            Notes = new ChangeTrackingList<RouterJobNote>();
        }

        /// <summary> Initializes a new instance of RouterJob. </summary>
        /// <param name="etag"> Concurrency Token. </param>
        /// <param name="id"> The id of the job. </param>
        /// <param name="channelReference"> Reference to an external parent context, eg. call ID. </param>
        /// <param name="status"> The status of the Job. </param>
        /// <param name="enqueuedAt"> The time a job was queued in UTC. </param>
        /// <param name="channelId"> The channel identifier. eg. voice, chat, etc. </param>
        /// <param name="classificationPolicyId"> The Id of the Classification policy used for classifying a job. </param>
        /// <param name="queueId"> The Id of the Queue that this job is queued to. </param>
        /// <param name="priority"> The priority of this job. </param>
        /// <param name="dispositionCode"> Reason code for cancelled or closed jobs. </param>
        /// <param name="requestedWorkerSelectors">
        /// A collection of manually specified label selectors, which a worker must satisfy
        /// in order to process this job.
        /// </param>
        /// <param name="attachedWorkerSelectors">
        /// A collection of label selectors attached by a classification policy, which a
        /// worker must satisfy in order to process this job.
        /// </param>
        /// <param name="labels">
        /// A set of key/value pairs that are identifying attributes used by the rules
        /// engines to make decisions.
        /// </param>
        /// <param name="assignments">
        /// A collection of the assignments of the job.
        /// Key is AssignmentId.
        /// </param>
        /// <param name="tags"> A set of non-identifying attributes attached to this job. </param>
        /// <param name="notes"> Notes attached to a job, sorted by timestamp. </param>
        /// <param name="scheduledAt"> If set, job will be scheduled to be enqueued at a given time. </param>
        /// <param name="matchingMode">
        /// The matching mode to be applied to this job.
        ///
        /// Supported types:
        ///
        ///
        /// QueueAndMatchMode: Used when matching worker to a job is required to be
        /// done right after job is queued.
        /// ScheduleAndSuspendMode: Used for scheduling
        /// jobs to be queued at a future time. At specified time, matching of a worker to
        /// the job will not start automatically.
        /// SuspendMode: Used when matching workers
        /// to a job needs to be suspended.
        /// Please note <see cref="JobMatchingMode"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ScheduleAndSuspendMode"/>, <see cref="QueueAndMatchMode"/> and <see cref="SuspendMode"/>.
        /// </param>
        internal RouterJob(string etag, string id, string channelReference, RouterJobStatus? status, DateTimeOffset? enqueuedAt, string channelId, string classificationPolicyId, string queueId, int? priority, string dispositionCode, IList<RouterWorkerSelector> requestedWorkerSelectors, IReadOnlyList<RouterWorkerSelector> attachedWorkerSelectors, IDictionary<string, BinaryData> labels, IReadOnlyDictionary<string, RouterJobAssignment> assignments, IDictionary<string, BinaryData> tags, IList<RouterJobNote> notes, DateTimeOffset? scheduledAt, JobMatchingMode matchingMode)
        {
            Etag = etag;
            Id = id;
            ChannelReference = channelReference;
            Status = status;
            EnqueuedAt = enqueuedAt;
            ChannelId = channelId;
            ClassificationPolicyId = classificationPolicyId;
            QueueId = queueId;
            Priority = priority;
            DispositionCode = dispositionCode;
            RequestedWorkerSelectors = requestedWorkerSelectors;
            AttachedWorkerSelectors = attachedWorkerSelectors;
            _labels = labels;
            Assignments = assignments;
            _tags = tags;
            Notes = notes;
            ScheduledAt = scheduledAt;
            MatchingMode = matchingMode;
        }

        /// <summary> Concurrency Token. </summary>
        public string Etag { get; }
        /// <summary> The id of the job. </summary>
        public string Id { get; }
        /// <summary> The status of the Job. </summary>
        public RouterJobStatus? Status { get; }
        /// <summary> The time a job was queued in UTC. </summary>
        public DateTimeOffset? EnqueuedAt { get; }
        /// <summary>
        /// A collection of label selectors attached by a classification policy, which a
        /// worker must satisfy in order to process this job.
        /// </summary>
        public IReadOnlyList<RouterWorkerSelector> AttachedWorkerSelectors { get; }
        /// <summary>
        /// A collection of the assignments of the job.
        /// Key is AssignmentId.
        /// </summary>
        public IReadOnlyDictionary<string, RouterJobAssignment> Assignments { get; }
        /// <summary> If set, job will be scheduled to be enqueued at a given time. </summary>
        public DateTimeOffset? ScheduledAt { get; }
    }
}
