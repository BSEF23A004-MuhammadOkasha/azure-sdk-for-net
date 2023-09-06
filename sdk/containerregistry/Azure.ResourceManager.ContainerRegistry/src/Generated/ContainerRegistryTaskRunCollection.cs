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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerRegistryTaskRunResource" /> and their operations.
    /// Each <see cref="ContainerRegistryTaskRunResource" /> in the collection will belong to the same instance of <see cref="ContainerRegistryResource" />.
    /// To get a <see cref="ContainerRegistryTaskRunCollection" /> instance call the GetContainerRegistryTaskRuns method from an instance of <see cref="ContainerRegistryResource" />.
    /// </summary>
    public partial class ContainerRegistryTaskRunCollection : ArmCollection, IEnumerable<ContainerRegistryTaskRunResource>, IAsyncEnumerable<ContainerRegistryTaskRunResource>
    {
        private readonly ClientDiagnostics _containerRegistryTaskRunTaskRunsClientDiagnostics;
        private readonly TaskRunsRestOperations _containerRegistryTaskRunTaskRunsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryTaskRunCollection"/> class for mocking. </summary>
        protected ContainerRegistryTaskRunCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryTaskRunCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerRegistryTaskRunCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerRegistryTaskRunTaskRunsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ContainerRegistryTaskRunResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerRegistryTaskRunResource.ResourceType, out string containerRegistryTaskRunTaskRunsApiVersion);
            _containerRegistryTaskRunTaskRunsRestClient = new TaskRunsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryTaskRunTaskRunsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a task run for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/taskRuns/{taskRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TaskRuns_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="taskRunName"> The name of the task run. </param>
        /// <param name="data"> The parameters of a run that needs to scheduled. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskRunName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerRegistryTaskRunResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string taskRunName, ContainerRegistryTaskRunData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskRunName, nameof(taskRunName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryTaskRunTaskRunsClientDiagnostics.CreateScope("ContainerRegistryTaskRunCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerRegistryTaskRunTaskRunsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskRunName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryTaskRunResource>(new ContainerRegistryTaskRunOperationSource(Client), _containerRegistryTaskRunTaskRunsClientDiagnostics, Pipeline, _containerRegistryTaskRunTaskRunsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskRunName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a task run for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/taskRuns/{taskRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TaskRuns_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="taskRunName"> The name of the task run. </param>
        /// <param name="data"> The parameters of a run that needs to scheduled. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskRunName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerRegistryTaskRunResource> CreateOrUpdate(WaitUntil waitUntil, string taskRunName, ContainerRegistryTaskRunData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskRunName, nameof(taskRunName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryTaskRunTaskRunsClientDiagnostics.CreateScope("ContainerRegistryTaskRunCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerRegistryTaskRunTaskRunsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskRunName, data, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryTaskRunResource>(new ContainerRegistryTaskRunOperationSource(Client), _containerRegistryTaskRunTaskRunsClientDiagnostics, Pipeline, _containerRegistryTaskRunTaskRunsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskRunName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the detailed information for a given task run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/taskRuns/{taskRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TaskRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskRunName"> The name of the task run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskRunName"/> is null. </exception>
        public virtual async Task<Response<ContainerRegistryTaskRunResource>> GetAsync(string taskRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskRunName, nameof(taskRunName));

            using var scope = _containerRegistryTaskRunTaskRunsClientDiagnostics.CreateScope("ContainerRegistryTaskRunCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryTaskRunTaskRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskRunName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryTaskRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the detailed information for a given task run.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/taskRuns/{taskRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TaskRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskRunName"> The name of the task run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskRunName"/> is null. </exception>
        public virtual Response<ContainerRegistryTaskRunResource> Get(string taskRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskRunName, nameof(taskRunName));

            using var scope = _containerRegistryTaskRunTaskRunsClientDiagnostics.CreateScope("ContainerRegistryTaskRunCollection.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryTaskRunTaskRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskRunName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryTaskRunResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the task runs for a specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/taskRuns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TaskRuns_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryTaskRunResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerRegistryTaskRunResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryTaskRunTaskRunsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryTaskRunTaskRunsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ContainerRegistryTaskRunResource(Client, ContainerRegistryTaskRunData.DeserializeContainerRegistryTaskRunData(e)), _containerRegistryTaskRunTaskRunsClientDiagnostics, Pipeline, "ContainerRegistryTaskRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the task runs for a specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/taskRuns</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TaskRuns_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryTaskRunResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerRegistryTaskRunResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryTaskRunTaskRunsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryTaskRunTaskRunsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ContainerRegistryTaskRunResource(Client, ContainerRegistryTaskRunData.DeserializeContainerRegistryTaskRunData(e)), _containerRegistryTaskRunTaskRunsClientDiagnostics, Pipeline, "ContainerRegistryTaskRunCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/taskRuns/{taskRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TaskRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskRunName"> The name of the task run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskRunName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string taskRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskRunName, nameof(taskRunName));

            using var scope = _containerRegistryTaskRunTaskRunsClientDiagnostics.CreateScope("ContainerRegistryTaskRunCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerRegistryTaskRunTaskRunsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskRunName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/taskRuns/{taskRunName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TaskRuns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskRunName"> The name of the task run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskRunName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskRunName"/> is null. </exception>
        public virtual Response<bool> Exists(string taskRunName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskRunName, nameof(taskRunName));

            using var scope = _containerRegistryTaskRunTaskRunsClientDiagnostics.CreateScope("ContainerRegistryTaskRunCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerRegistryTaskRunTaskRunsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskRunName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerRegistryTaskRunResource> IEnumerable<ContainerRegistryTaskRunResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerRegistryTaskRunResource> IAsyncEnumerable<ContainerRegistryTaskRunResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
