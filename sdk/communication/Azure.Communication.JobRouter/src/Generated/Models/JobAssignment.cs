// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.JobRouter
{
    /// <summary> Assigns a job to a worker. </summary>
    public partial class JobAssignment
    {
        /// <summary> Initializes a new instance of JobAssignment. </summary>
        /// <param name="id"> The Id of the job assignment. </param>
        /// <param name="assignTime"> The assignment time of the job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal JobAssignment(string id, DateTimeOffset assignTime)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
            AssignTime = assignTime;
        }

        /// <summary> Initializes a new instance of JobAssignment. </summary>
        /// <param name="id"> The Id of the job assignment. </param>
        /// <param name="workerId"> The Id of the Worker assigned to the job. </param>
        /// <param name="assignTime"> The assignment time of the job. </param>
        /// <param name="completeTime"> The time the job was marked as completed after being assigned. </param>
        /// <param name="closeTime"> The time the job was marked as closed after being completed. </param>
        internal JobAssignment(string id, string workerId, DateTimeOffset assignTime, DateTimeOffset? completeTime, DateTimeOffset? closeTime)
        {
            Id = id;
            WorkerId = workerId;
            AssignTime = assignTime;
            CompleteTime = completeTime;
            CloseTime = closeTime;
        }

        /// <summary> The Id of the job assignment. </summary>
        public string Id { get; }
        /// <summary> The Id of the Worker assigned to the job. </summary>
        public string WorkerId { get; }
        /// <summary> The assignment time of the job. </summary>
        public DateTimeOffset AssignTime { get; }
        /// <summary> The time the job was marked as completed after being assigned. </summary>
        public DateTimeOffset? CompleteTime { get; }
        /// <summary> The time the job was marked as closed after being completed. </summary>
        public DateTimeOffset? CloseTime { get; }
    }
}
