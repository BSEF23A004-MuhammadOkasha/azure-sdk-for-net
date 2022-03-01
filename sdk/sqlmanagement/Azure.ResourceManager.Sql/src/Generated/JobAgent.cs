// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a JobAgent along with the instance operations that can be performed on it. </summary>
    public partial class JobAgent : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="JobAgent"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _jobAgentClientDiagnostics;
        private readonly JobAgentsRestOperations _jobAgentRestClient;
        private readonly ClientDiagnostics _serverJobAgentJobExecutionJobExecutionsClientDiagnostics;
        private readonly JobExecutionsRestOperations _serverJobAgentJobExecutionJobExecutionsRestClient;
        private readonly JobAgentData _data;

        /// <summary> Initializes a new instance of the <see cref="JobAgent"/> class for mocking. </summary>
        protected JobAgent()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "JobAgent"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal JobAgent(ArmClient client, JobAgentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="JobAgent"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal JobAgent(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jobAgentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string jobAgentApiVersion);
            _jobAgentRestClient = new JobAgentsRestOperations(_jobAgentClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, jobAgentApiVersion);
            _serverJobAgentJobExecutionJobExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerJobAgentJobExecution.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ServerJobAgentJobExecution.ResourceType, out string serverJobAgentJobExecutionJobExecutionsApiVersion);
            _serverJobAgentJobExecutionJobExecutionsRestClient = new JobExecutionsRestOperations(_serverJobAgentJobExecutionJobExecutionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverJobAgentJobExecutionJobExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/jobAgents";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual JobAgentData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of JobCredentials in the JobCredential. </summary>
        /// <returns> An object representing collection of JobCredentials and their operations over a JobCredential. </returns>
        public virtual JobCredentialCollection GetJobCredentials()
        {
            return new JobCredentialCollection(Client, Id);
        }

        /// <summary> Gets a collection of SqlJobs in the SqlJob. </summary>
        /// <returns> An object representing collection of SqlJobs and their operations over a SqlJob. </returns>
        public virtual SqlJobCollection GetSqlJobs()
        {
            return new SqlJobCollection(Client, Id);
        }

        /// <summary> Gets a collection of JobTargetGroups in the JobTargetGroup. </summary>
        /// <returns> An object representing collection of JobTargetGroups and their operations over a JobTargetGroup. </returns>
        public virtual JobTargetGroupCollection GetJobTargetGroups()
        {
            return new JobTargetGroupCollection(Client, Id);
        }

        /// <summary>
        /// Gets a job agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<JobAgent>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgent.Get");
            scope.Start();
            try
            {
                var response = await _jobAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _jobAgentClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new JobAgent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a job agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobAgent> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgent.Get");
            scope.Start();
            try
            {
                var response = _jobAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _jobAgentClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobAgent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a job agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgent.Delete");
            scope.Start();
            try
            {
                var response = await _jobAgentRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_jobAgentClientDiagnostics, Pipeline, _jobAgentRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a job agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgent.Delete");
            scope.Start();
            try
            {
                var response = _jobAgentRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_jobAgentClientDiagnostics, Pipeline, _jobAgentRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all executions in a job agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/executions
        /// Operation Id: JobExecutions_ListByAgent
        /// </summary>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerJobAgentJobExecution" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerJobAgentJobExecution> GetJobExecutionsByAgentAsync(DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerJobAgentJobExecution>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("JobAgent.GetJobExecutionsByAgent");
                scope.Start();
                try
                {
                    var response = await _serverJobAgentJobExecutionJobExecutionsRestClient.ListByAgentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecution(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerJobAgentJobExecution>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("JobAgent.GetJobExecutionsByAgent");
                scope.Start();
                try
                {
                    var response = await _serverJobAgentJobExecutionJobExecutionsRestClient.ListByAgentNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecution(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all executions in a job agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/executions
        /// Operation Id: JobExecutions_ListByAgent
        /// </summary>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerJobAgentJobExecution" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerJobAgentJobExecution> GetJobExecutionsByAgent(DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ServerJobAgentJobExecution> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("JobAgent.GetJobExecutionsByAgent");
                scope.Start();
                try
                {
                    var response = _serverJobAgentJobExecutionJobExecutionsRestClient.ListByAgent(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecution(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerJobAgentJobExecution> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("JobAgent.GetJobExecutionsByAgent");
                scope.Start();
                try
                {
                    var response = _serverJobAgentJobExecutionJobExecutionsRestClient.ListByAgentNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecution(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<JobAgent>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgent.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _jobAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new JobAgent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<JobAgent> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgent.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _jobAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new JobAgent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<JobAgent>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgent.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _jobAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new JobAgent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<JobAgent> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgent.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _jobAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new JobAgent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<JobAgent>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgent.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _jobAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new JobAgent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// Operation Id: JobAgents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<JobAgent> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgent.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _jobAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new JobAgent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
