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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridRunbookWorkerResource" /> and their operations.
    /// Each <see cref="HybridRunbookWorkerResource" /> in the collection will belong to the same instance of <see cref="HybridRunbookWorkerGroupResource" />.
    /// To get a <see cref="HybridRunbookWorkerCollection" /> instance call the GetHybridRunbookWorkers method from an instance of <see cref="HybridRunbookWorkerGroupResource" />.
    /// </summary>
    public partial class HybridRunbookWorkerCollection : ArmCollection, IEnumerable<HybridRunbookWorkerResource>, IAsyncEnumerable<HybridRunbookWorkerResource>
    {
        private readonly ClientDiagnostics _hybridRunbookWorkerClientDiagnostics;
        private readonly HybridRunbookWorkersRestOperations _hybridRunbookWorkerRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridRunbookWorkerCollection"/> class for mocking. </summary>
        protected HybridRunbookWorkerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridRunbookWorkerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridRunbookWorkerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridRunbookWorkerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", HybridRunbookWorkerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridRunbookWorkerResource.ResourceType, out string hybridRunbookWorkerApiVersion);
            _hybridRunbookWorkerRestClient = new HybridRunbookWorkersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridRunbookWorkerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HybridRunbookWorkerGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HybridRunbookWorkerGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a hybrid runbook worker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hybridRunbookWorkerId"> The hybrid runbook worker id. </param>
        /// <param name="content"> The create or update parameters for hybrid runbook worker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridRunbookWorkerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hybridRunbookWorkerId, HybridRunbookWorkerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerId, nameof(hybridRunbookWorkerId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hybridRunbookWorkerId, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<HybridRunbookWorkerResource>(Response.FromValue(new HybridRunbookWorkerResource(Client, response), response.GetRawResponse()));
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
        /// Create a hybrid runbook worker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hybridRunbookWorkerId"> The hybrid runbook worker id. </param>
        /// <param name="content"> The create or update parameters for hybrid runbook worker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<HybridRunbookWorkerResource> CreateOrUpdate(WaitUntil waitUntil, string hybridRunbookWorkerId, HybridRunbookWorkerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerId, nameof(hybridRunbookWorkerId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hybridRunbookWorkerId, content, cancellationToken);
                var operation = new AutomationArmOperation<HybridRunbookWorkerResource>(Response.FromValue(new HybridRunbookWorkerResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve a hybrid runbook worker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridRunbookWorkerId"> The hybrid runbook worker id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerId"/> is null. </exception>
        public virtual async Task<Response<HybridRunbookWorkerResource>> GetAsync(string hybridRunbookWorkerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerId, nameof(hybridRunbookWorkerId));

            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hybridRunbookWorkerId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridRunbookWorkerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a hybrid runbook worker.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridRunbookWorkerId"> The hybrid runbook worker id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerId"/> is null. </exception>
        public virtual Response<HybridRunbookWorkerResource> Get(string hybridRunbookWorkerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerId, nameof(hybridRunbookWorkerId));

            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hybridRunbookWorkerId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridRunbookWorkerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of hybrid runbook workers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_ListByHybridRunbookWorkerGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridRunbookWorkerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridRunbookWorkerResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridRunbookWorkerRestClient.CreateListByHybridRunbookWorkerGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridRunbookWorkerRestClient.CreateListByHybridRunbookWorkerGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridRunbookWorkerResource(Client, HybridRunbookWorkerData.DeserializeHybridRunbookWorkerData(e)), _hybridRunbookWorkerClientDiagnostics, Pipeline, "HybridRunbookWorkerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of hybrid runbook workers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_ListByHybridRunbookWorkerGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridRunbookWorkerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridRunbookWorkerResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridRunbookWorkerRestClient.CreateListByHybridRunbookWorkerGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridRunbookWorkerRestClient.CreateListByHybridRunbookWorkerGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridRunbookWorkerResource(Client, HybridRunbookWorkerData.DeserializeHybridRunbookWorkerData(e)), _hybridRunbookWorkerClientDiagnostics, Pipeline, "HybridRunbookWorkerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridRunbookWorkerId"> The hybrid runbook worker id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hybridRunbookWorkerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerId, nameof(hybridRunbookWorkerId));

            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridRunbookWorkerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hybridRunbookWorkerId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/hybridRunbookWorkerGroups/{hybridRunbookWorkerGroupName}/hybridRunbookWorkers/{hybridRunbookWorkerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridRunbookWorkers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hybridRunbookWorkerId"> The hybrid runbook worker id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hybridRunbookWorkerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hybridRunbookWorkerId"/> is null. </exception>
        public virtual Response<bool> Exists(string hybridRunbookWorkerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hybridRunbookWorkerId, nameof(hybridRunbookWorkerId));

            using var scope = _hybridRunbookWorkerClientDiagnostics.CreateScope("HybridRunbookWorkerCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridRunbookWorkerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hybridRunbookWorkerId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridRunbookWorkerResource> IEnumerable<HybridRunbookWorkerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridRunbookWorkerResource> IAsyncEnumerable<HybridRunbookWorkerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
