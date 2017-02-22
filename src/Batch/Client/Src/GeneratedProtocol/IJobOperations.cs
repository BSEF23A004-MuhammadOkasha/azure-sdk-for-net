// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// JobOperations operations.
    /// </summary>
    public partial interface IJobOperations
    {
        /// <summary>
        /// Gets lifetime summary statistics for all of the jobs in the
        /// specified account.
        /// </summary>
        /// <remarks>
        /// Statistics are aggregated across all jobs that have ever existed in
        /// the account, from account creation to the last update time of the
        /// statistics.
        /// </remarks>
        /// <param name='jobGetAllLifetimeStatisticsOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<JobStatistics,JobGetAllLifetimeStatisticsHeaders>> GetAllLifetimeStatisticsWithHttpMessagesAsync(JobGetAllLifetimeStatisticsOptions jobGetAllLifetimeStatisticsOptions = default(JobGetAllLifetimeStatisticsOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <remarks>
        /// Deleting a job also deletes all tasks that are part of that job,
        /// and all job statistics. This also overrides the retention period
        /// for task data; that is, if the job contains tasks which are still
        /// retained on compute nodes, the Batch services deletes those tasks'
        /// working directories and all their contents.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job to delete.
        /// </param>
        /// <param name='jobDeleteOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<JobDeleteHeaders>> DeleteWithHttpMessagesAsync(string jobId, JobDeleteOptions jobDeleteOptions = default(JobDeleteOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets information about the specified job.
        /// </summary>
        /// <param name='jobId'>
        /// The ID of the job.
        /// </param>
        /// <param name='jobGetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<CloudJob,JobGetHeaders>> GetWithHttpMessagesAsync(string jobId, JobGetOptions jobGetOptions = default(JobGetOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates the properties of the specified job.
        /// </summary>
        /// <remarks>
        /// This replaces only the job properties specified in the request. For
        /// example, if the job has constraints, and a request does not specify
        /// the constraints element, then the job keeps the existing
        /// constraints.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job whose properties you want to update.
        /// </param>
        /// <param name='jobPatchParameter'>
        /// The parameters for the request.
        /// </param>
        /// <param name='jobPatchOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<JobPatchHeaders>> PatchWithHttpMessagesAsync(string jobId, JobPatchParameter jobPatchParameter, JobPatchOptions jobPatchOptions = default(JobPatchOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates the properties of the specified job.
        /// </summary>
        /// <remarks>
        /// This fully replaces all the updateable properties of the job. For
        /// example, if the job has constraints associated with it and if
        /// constraints is not specified with this request, then the Batch
        /// service will remove the existing constraints.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job whose properties you want to update.
        /// </param>
        /// <param name='jobUpdateParameter'>
        /// The parameters for the request.
        /// </param>
        /// <param name='jobUpdateOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<JobUpdateHeaders>> UpdateWithHttpMessagesAsync(string jobId, JobUpdateParameter jobUpdateParameter, JobUpdateOptions jobUpdateOptions = default(JobUpdateOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Disables the specified job, preventing new tasks from running.
        /// </summary>
        /// <remarks>
        /// The Batch Service immediately moves the job to the disabling state.
        /// Batch then uses the disableTasks parameter to determine what to do
        /// with the currently running tasks of the job. The job remains in the
        /// disabling state until the disable operation is completed and all
        /// tasks have been dealt with according to the disableTasks option;
        /// the job then moves to the disabled state. No new tasks are started
        /// under the job until it moves back to active state. If you try to
        /// disable a job that is in any state other than active, disabling, or
        /// disabled, the request fails with status code 409.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job to disable.
        /// </param>
        /// <param name='disableTasks'>
        /// What to do with active tasks associated with the job. requeue -
        /// Terminate running tasks and requeue them. The tasks will run again
        /// when the job is enabled. terminate - Terminate running tasks. The
        /// tasks will not run again. wait - Allow currently running tasks to
        /// complete. Possible values include: 'requeue', 'terminate', 'wait'
        /// </param>
        /// <param name='jobDisableOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<JobDisableHeaders>> DisableWithHttpMessagesAsync(string jobId, DisableJobOption disableTasks, JobDisableOptions jobDisableOptions = default(JobDisableOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Enables the specified job, allowing new tasks to run.
        /// </summary>
        /// <remarks>
        /// When you call this API, the Batch service sets a disabled job to
        /// the enabling state. After the this operation is completed, the job
        /// moves to the active state, and scheduling of new tasks under the
        /// job resumes. The Batch service does not allow a task to remain in
        /// the active state for more than 7 days. Therefore, if you enable a
        /// job containing active tasks which were added more than 7 days ago,
        /// those tasks will not run.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job to enable.
        /// </param>
        /// <param name='jobEnableOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<JobEnableHeaders>> EnableWithHttpMessagesAsync(string jobId, JobEnableOptions jobEnableOptions = default(JobEnableOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Terminates the specified job, marking it as completed.
        /// </summary>
        /// <remarks>
        /// When a Terminate Job request is received, the Batch service sets
        /// the job to the terminating state. The Batch service then terminates
        /// any active or running tasks associated with the job, and runs any
        /// required Job Release tasks. The job then moves into the completed
        /// state.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job to terminate.
        /// </param>
        /// <param name='terminateReason'>
        /// The text you want to appear as the job's TerminateReason. The
        /// default is 'UserTerminate'.
        /// </param>
        /// <param name='jobTerminateOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<JobTerminateHeaders>> TerminateWithHttpMessagesAsync(string jobId, string terminateReason = default(string), JobTerminateOptions jobTerminateOptions = default(JobTerminateOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Adds a job to the specified account.
        /// </summary>
        /// <remarks>
        /// The Batch service supports two ways to control the work done as
        /// part of a job. In the first approach, the user specifies a Job
        /// Manager task. The Batch service launches this task when it is ready
        /// to start the job. The Job Manager task controls all other tasks
        /// that run under this job, by using the Task APIs. In the second
        /// approach, the user directly controls the execution of tasks under
        /// an active job, by using the Task APIs. Also note: when naming jobs,
        /// avoid including sensitive information such as user names or secret
        /// project names. This information may appear in telemetry logs
        /// accessible to Microsoft Support engineers.
        /// </remarks>
        /// <param name='job'>
        /// The job to be added.
        /// </param>
        /// <param name='jobAddOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<JobAddHeaders>> AddWithHttpMessagesAsync(JobAddParameter job, JobAddOptions jobAddOptions = default(JobAddOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists all of the jobs in the specified account.
        /// </summary>
        /// <param name='jobListOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<CloudJob>,JobListHeaders>> ListWithHttpMessagesAsync(JobListOptions jobListOptions = default(JobListOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists the jobs that have been created under the specified job
        /// schedule.
        /// </summary>
        /// <param name='jobScheduleId'>
        /// The ID of the job schedule from which you want to get a list of
        /// jobs.
        /// </param>
        /// <param name='jobListFromJobScheduleOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<CloudJob>,JobListFromJobScheduleHeaders>> ListFromJobScheduleWithHttpMessagesAsync(string jobScheduleId, JobListFromJobScheduleOptions jobListFromJobScheduleOptions = default(JobListFromJobScheduleOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists the execution status of the Job Preparation and Job Release
        /// task for the specified job across the compute nodes where the job
        /// has run.
        /// </summary>
        /// <remarks>
        /// This API returns the Job Preparation and Job Release task status on
        /// all compute nodes that have run the Job Preparation or Job Release
        /// task. This includes nodes which have since been removed from the
        /// pool.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job.
        /// </param>
        /// <param name='jobListPreparationAndReleaseTaskStatusOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<JobPreparationAndReleaseTaskExecutionInformation>,JobListPreparationAndReleaseTaskStatusHeaders>> ListPreparationAndReleaseTaskStatusWithHttpMessagesAsync(string jobId, JobListPreparationAndReleaseTaskStatusOptions jobListPreparationAndReleaseTaskStatusOptions = default(JobListPreparationAndReleaseTaskStatusOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists all of the jobs in the specified account.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='jobListNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<CloudJob>,JobListHeaders>> ListNextWithHttpMessagesAsync(string nextPageLink, JobListNextOptions jobListNextOptions = default(JobListNextOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists the jobs that have been created under the specified job
        /// schedule.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='jobListFromJobScheduleNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<CloudJob>,JobListFromJobScheduleHeaders>> ListFromJobScheduleNextWithHttpMessagesAsync(string nextPageLink, JobListFromJobScheduleNextOptions jobListFromJobScheduleNextOptions = default(JobListFromJobScheduleNextOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists the execution status of the Job Preparation and Job Release
        /// task for the specified job across the compute nodes where the job
        /// has run.
        /// </summary>
        /// <remarks>
        /// This API returns the Job Preparation and Job Release task status on
        /// all compute nodes that have run the Job Preparation or Job Release
        /// task. This includes nodes which have since been removed from the
        /// pool.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='jobListPreparationAndReleaseTaskStatusNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<JobPreparationAndReleaseTaskExecutionInformation>,JobListPreparationAndReleaseTaskStatusHeaders>> ListPreparationAndReleaseTaskStatusNextWithHttpMessagesAsync(string nextPageLink, JobListPreparationAndReleaseTaskStatusNextOptions jobListPreparationAndReleaseTaskStatusNextOptions = default(JobListPreparationAndReleaseTaskStatusNextOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
