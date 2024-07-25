// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter
{
    /// <summary> Model factory for models. </summary>
    public static partial class JobRouterModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="JobRouter.DistributionPolicy"/>. </summary>
        /// <param name="eTag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of a distribution policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="offerExpiresAfter"> Number of seconds after which any offers created under this policy will be expired. </param>
        /// <param name="mode">
        /// Mode governing the specific distribution method.
        /// Please note <see cref="DistributionMode"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BestWorkerMode"/>, <see cref="LongestIdleMode"/> and <see cref="RoundRobinMode"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.DistributionPolicy"/> instance for mocking. </returns>
        public static DistributionPolicy DistributionPolicy(ETag eTag = default, string id = null, string name = null, TimeSpan? offerExpiresAfter = null, DistributionMode mode = null)
        {
            return new DistributionPolicy(
                eTag,
                id,
                name,
                offerExpiresAfter,
                mode,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ClassificationPolicy"/>. </summary>
        /// <param name="eTag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of a classification policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="fallbackQueueId"> Id of a fallback queue to select if queue selector attachments doesn't find a match. </param>
        /// <param name="queueSelectorAttachments">
        /// Queue selector attachments used to resolve a queue for a job.
        /// Please note <see cref="QueueSelectorAttachment"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConditionalQueueSelectorAttachment"/>, <see cref="PassThroughQueueSelectorAttachment"/>, <see cref="RuleEngineQueueSelectorAttachment"/>, <see cref="StaticQueueSelectorAttachment"/> and <see cref="WeightedAllocationQueueSelectorAttachment"/>.
        /// </param>
        /// <param name="prioritizationRule">
        /// A rule to determine a priority score for a job.
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </param>
        /// <param name="workerSelectorAttachments">
        /// Worker selector attachments used to attach worker selectors to a job.
        /// Please note <see cref="WorkerSelectorAttachment"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConditionalWorkerSelectorAttachment"/>, <see cref="JobRouter.PassThroughWorkerSelectorAttachment"/>, <see cref="RuleEngineWorkerSelectorAttachment"/>, <see cref="StaticWorkerSelectorAttachment"/> and <see cref="WeightedAllocationWorkerSelectorAttachment"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.ClassificationPolicy"/> instance for mocking. </returns>
        public static ClassificationPolicy ClassificationPolicy(ETag eTag = default, string id = null, string name = null, string fallbackQueueId = null, IEnumerable<QueueSelectorAttachment> queueSelectorAttachments = null, RouterRule prioritizationRule = null, IEnumerable<WorkerSelectorAttachment> workerSelectorAttachments = null)
        {
            queueSelectorAttachments ??= new List<QueueSelectorAttachment>();
            workerSelectorAttachments ??= new List<WorkerSelectorAttachment>();

            return new ClassificationPolicy(
                eTag,
                id,
                name,
                fallbackQueueId,
                queueSelectorAttachments?.ToList(),
                prioritizationRule,
                workerSelectorAttachments?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.PassThroughWorkerSelectorAttachment"/>. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value pass through. </param>
        /// <param name="expiresAfter"> Describes how long the attached label selector is valid in seconds. </param>
        /// <returns> A new <see cref="JobRouter.PassThroughWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static PassThroughWorkerSelectorAttachment PassThroughWorkerSelectorAttachment(string key = null, LabelOperator labelOperator = default, TimeSpan? expiresAfter = null)
        {
            return new PassThroughWorkerSelectorAttachment(WorkerSelectorAttachmentKind.PassThrough, serializedAdditionalRawData: null, key, labelOperator, expiresAfter);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ExceptionPolicy"/>. </summary>
        /// <param name="eTag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of an exception policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="exceptionRules"> A collection of exception rules on the exception policy. </param>
        /// <returns> A new <see cref="JobRouter.ExceptionPolicy"/> instance for mocking. </returns>
        public static ExceptionPolicy ExceptionPolicy(ETag eTag = default, string id = null, string name = null, IEnumerable<ExceptionRule> exceptionRules = null)
        {
            exceptionRules ??= new List<ExceptionRule>();

            return new ExceptionPolicy(eTag, id, name, exceptionRules?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobAssignment"/>. </summary>
        /// <param name="assignmentId"> Id of a job assignment. </param>
        /// <param name="workerId"> Id of the Worker assigned to the job. </param>
        /// <param name="assignedAt"> Timestamp when the job was assigned to a worker in UTC. </param>
        /// <param name="completedAt"> Timestamp when the job was marked as completed after being assigned in UTC. </param>
        /// <param name="closedAt"> Timestamp when the job was marked as closed after being completed in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobAssignment"/> instance for mocking. </returns>
        public static RouterJobAssignment RouterJobAssignment(string assignmentId = null, string workerId = null, DateTimeOffset assignedAt = default, DateTimeOffset? completedAt = null, DateTimeOffset? closedAt = null)
        {
            return new RouterJobAssignment(
                assignmentId,
                workerId,
                assignedAt,
                completedAt,
                closedAt,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobPositionDetails"/>. </summary>
        /// <param name="jobId"> Id of the job these details are about. </param>
        /// <param name="position"> Position of the job in question within that queue. </param>
        /// <param name="queueId"> Id of the queue this job is enqueued in. </param>
        /// <param name="queueLength"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTime"> Estimated wait time of the job rounded up to the nearest minute. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobPositionDetails"/> instance for mocking. </returns>
        public static RouterJobPositionDetails RouterJobPositionDetails(string jobId = null, int position = default, string queueId = null, int queueLength = default, TimeSpan estimatedWaitTime = default)
        {
            return new RouterJobPositionDetails(
                jobId,
                position,
                queueId,
                queueLength,
                estimatedWaitTime,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.UnassignJobResult"/>. </summary>
        /// <param name="jobId"> Id of an unassigned job. </param>
        /// <param name="unassignmentCount"> The number of times a job is unassigned. At a maximum 3. </param>
        /// <returns> A new <see cref="JobRouter.UnassignJobResult"/> instance for mocking. </returns>
        public static UnassignJobResult UnassignJobResult(string jobId = null, int unassignmentCount = default)
        {
            return new UnassignJobResult(jobId, unassignmentCount, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.AcceptJobOfferResult"/>. </summary>
        /// <param name="assignmentId"> Id of job assignment that assigns a worker that has accepted an offer to a job. </param>
        /// <param name="jobId"> Id of the job assigned. </param>
        /// <param name="workerId"> Id of the worker that has been assigned this job. </param>
        /// <returns> A new <see cref="JobRouter.AcceptJobOfferResult"/> instance for mocking. </returns>
        public static AcceptJobOfferResult AcceptJobOfferResult(string assignmentId = null, string jobId = null, string workerId = null)
        {
            return new AcceptJobOfferResult(assignmentId, jobId, workerId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterQueueStatistics"/>. </summary>
        /// <param name="queueId"> Id of the queue these details are about. </param>
        /// <param name="length"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTimes"> The estimated wait time of this queue rounded up to the nearest minute, grouped by job priority. </param>
        /// <param name="longestJobWaitTimeMinutes"> The wait time of the job that has been enqueued in this queue for the longest. </param>
        /// <returns> A new <see cref="JobRouter.RouterQueueStatistics"/> instance for mocking. </returns>
        public static RouterQueueStatistics RouterQueueStatistics(string queueId = null, int length = default, IDictionary<int, TimeSpan> estimatedWaitTimes = null, double? longestJobWaitTimeMinutes = null)
        {
            estimatedWaitTimes ??= new Dictionary<int, TimeSpan>();

            return new RouterQueueStatistics(queueId, length, estimatedWaitTimes, longestJobWaitTimeMinutes, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobOffer"/>. </summary>
        /// <param name="offerId"> Id of an offer. </param>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="capacityCost"> The capacity cost consumed by the job offer. </param>
        /// <param name="offeredAt"> Timestamp when the offer was created in UTC. </param>
        /// <param name="expiresAt"> Timestamp when the offer will expire in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobOffer"/> instance for mocking. </returns>
        public static RouterJobOffer RouterJobOffer(string offerId = null, string jobId = null, int capacityCost = default, DateTimeOffset? offeredAt = null, DateTimeOffset? expiresAt = null)
        {
            return new RouterJobOffer(
                offerId,
                jobId,
                capacityCost,
                offeredAt,
                expiresAt,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterWorkerAssignment"/>. </summary>
        /// <param name="assignmentId"> Id of the assignment. </param>
        /// <param name="jobId"> Id of the job assigned. </param>
        /// <param name="capacityCost"> The amount of capacity this assignment has consumed on the worker. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterWorkerAssignment"/> instance for mocking. </returns>
        public static RouterWorkerAssignment RouterWorkerAssignment(string assignmentId = null, string jobId = null, int capacityCost = default, DateTimeOffset assignedAt = default)
        {
            return new RouterWorkerAssignment(assignmentId, jobId, capacityCost, assignedAt, serializedAdditionalRawData: null);
        }
    }
}
