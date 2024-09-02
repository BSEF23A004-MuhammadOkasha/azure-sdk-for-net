// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningJobResource"/> and their operations.
    /// Each <see cref="MachineLearningJobResource"/> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// To get a <see cref="MachineLearningJobCollection"/> instance call the GetMachineLearningJobs method from an instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// </summary>
    public partial class MachineLearningJobCollection : ArmCollection, IEnumerable<MachineLearningJobResource>, IAsyncEnumerable<MachineLearningJobResource>
    {
        private readonly ClientDiagnostics _machineLearningJobJobsClientDiagnostics;
        private readonly JobsRestOperations _machineLearningJobJobsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningJobCollection"/> class for mocking. </summary>
        protected MachineLearningJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningJobJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningJobResource.ResourceType, out string machineLearningJobJobsApiVersion);
            _machineLearningJobJobsRestClient = new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningJobJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates and executes a Job.
        /// For update case, the Tags in the definition passed in will replace Tags in the existing job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="data"> Job definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningJobResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string id, MachineLearningJobData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningJobJobsClientDiagnostics.CreateScope("MachineLearningJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningJobJobsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, cancellationToken).ConfigureAwait(false);
                var uri = _machineLearningJobJobsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation<MachineLearningJobResource>(Response.FromValue(new MachineLearningJobResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates and executes a Job.
        /// For update case, the Tags in the definition passed in will replace Tags in the existing job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="data"> Job definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningJobResource> CreateOrUpdate(WaitUntil waitUntil, string id, MachineLearningJobData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningJobJobsClientDiagnostics.CreateScope("MachineLearningJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningJobJobsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, cancellationToken);
                var uri = _machineLearningJobJobsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation<MachineLearningJobResource>(Response.FromValue(new MachineLearningJobResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Job by name/id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<MachineLearningJobResource>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningJobJobsClientDiagnostics.CreateScope("MachineLearningJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Job by name/id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<MachineLearningJobResource> Get(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningJobJobsClientDiagnostics.CreateScope("MachineLearningJobCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Jobs in the workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="jobType"> Type of job to be returned. </param>
        /// <param name="tag"> Jobs returned will have this tag key. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="properties"> Comma-separated list of user property names (and optionally values). Example: prop1,prop2=value2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningJobResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningJobResource> GetAllAsync(string skip = null, string jobType = null, string tag = null, MachineLearningListViewType? listViewType = null, string properties = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningJobJobsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, jobType, tag, listViewType, properties);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningJobJobsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, jobType, tag, listViewType, properties);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningJobResource(Client, MachineLearningJobData.DeserializeMachineLearningJobData(e)), _machineLearningJobJobsClientDiagnostics, Pipeline, "MachineLearningJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists Jobs in the workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="jobType"> Type of job to be returned. </param>
        /// <param name="tag"> Jobs returned will have this tag key. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="properties"> Comma-separated list of user property names (and optionally values). Example: prop1,prop2=value2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningJobResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningJobResource> GetAll(string skip = null, string jobType = null, string tag = null, MachineLearningListViewType? listViewType = null, string properties = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningJobJobsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, jobType, tag, listViewType, properties);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningJobJobsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, jobType, tag, listViewType, properties);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningJobResource(Client, MachineLearningJobData.DeserializeMachineLearningJobData(e)), _machineLearningJobJobsClientDiagnostics, Pipeline, "MachineLearningJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningJobJobsClientDiagnostics.CreateScope("MachineLearningJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningJobJobsClientDiagnostics.CreateScope("MachineLearningJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningJobResource>> GetIfExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningJobJobsClientDiagnostics.CreateScope("MachineLearningJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningJobResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the Job. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual NullableResponse<MachineLearningJobResource> GetIfExists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningJobJobsClientDiagnostics.CreateScope("MachineLearningJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningJobResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningJobResource> IEnumerable<MachineLearningJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningJobResource> IAsyncEnumerable<MachineLearningJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
