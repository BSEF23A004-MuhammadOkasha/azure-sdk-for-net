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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="DevTestLabGlobalScheduleResource" /> and their operations.
    /// Each <see cref="DevTestLabGlobalScheduleResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DevTestLabGlobalScheduleCollection" /> instance call the GetDevTestLabGlobalSchedules method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DevTestLabGlobalScheduleCollection : ArmCollection, IEnumerable<DevTestLabGlobalScheduleResource>, IAsyncEnumerable<DevTestLabGlobalScheduleResource>
    {
        private readonly ClientDiagnostics _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics;
        private readonly GlobalSchedulesRestOperations _devTestLabGlobalScheduleGlobalSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabGlobalScheduleCollection"/> class for mocking. </summary>
        protected DevTestLabGlobalScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabGlobalScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevTestLabGlobalScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabGlobalScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevTestLabGlobalScheduleResource.ResourceType, out string devTestLabGlobalScheduleGlobalSchedulesApiVersion);
            _devTestLabGlobalScheduleGlobalSchedulesRestClient = new GlobalSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabGlobalScheduleGlobalSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="data"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevTestLabGlobalScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DevTestLabScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics.CreateScope("DevTestLabGlobalScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devTestLabGlobalScheduleGlobalSchedulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<DevTestLabGlobalScheduleResource>(Response.FromValue(new DevTestLabGlobalScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Create or replace an existing schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="data"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevTestLabGlobalScheduleResource> CreateOrUpdate(WaitUntil waitUntil, string name, DevTestLabScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics.CreateScope("DevTestLabGlobalScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devTestLabGlobalScheduleGlobalSchedulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<DevTestLabGlobalScheduleResource>(Response.FromValue(new DevTestLabGlobalScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Get schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DevTestLabGlobalScheduleResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics.CreateScope("DevTestLabGlobalScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabGlobalScheduleGlobalSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabGlobalScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DevTestLabGlobalScheduleResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics.CreateScope("DevTestLabGlobalScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _devTestLabGlobalScheduleGlobalSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabGlobalScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List schedules in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabGlobalScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabGlobalScheduleResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabGlobalScheduleGlobalSchedulesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabGlobalScheduleGlobalSchedulesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DevTestLabGlobalScheduleResource(Client, DevTestLabScheduleData.DeserializeDevTestLabScheduleData(e)), _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics, Pipeline, "DevTestLabGlobalScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List schedules in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabGlobalScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabGlobalScheduleResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabGlobalScheduleGlobalSchedulesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabGlobalScheduleGlobalSchedulesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DevTestLabGlobalScheduleResource(Client, DevTestLabScheduleData.DeserializeDevTestLabScheduleData(e)), _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics, Pipeline, "DevTestLabGlobalScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics.CreateScope("DevTestLabGlobalScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devTestLabGlobalScheduleGlobalSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics.CreateScope("DevTestLabGlobalScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _devTestLabGlobalScheduleGlobalSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevTestLabGlobalScheduleResource> IEnumerable<DevTestLabGlobalScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevTestLabGlobalScheduleResource> IAsyncEnumerable<DevTestLabGlobalScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
