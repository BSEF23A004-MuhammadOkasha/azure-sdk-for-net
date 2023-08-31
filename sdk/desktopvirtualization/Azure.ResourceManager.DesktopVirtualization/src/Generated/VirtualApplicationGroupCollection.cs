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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualApplicationGroupResource" /> and their operations.
    /// Each <see cref="VirtualApplicationGroupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="VirtualApplicationGroupCollection" /> instance call the GetVirtualApplicationGroups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class VirtualApplicationGroupCollection : ArmCollection, IEnumerable<VirtualApplicationGroupResource>, IAsyncEnumerable<VirtualApplicationGroupResource>
    {
        private readonly ClientDiagnostics _virtualApplicationGroupApplicationGroupsClientDiagnostics;
        private readonly ApplicationGroupsRestOperations _virtualApplicationGroupApplicationGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualApplicationGroupCollection"/> class for mocking. </summary>
        protected VirtualApplicationGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualApplicationGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualApplicationGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualApplicationGroupApplicationGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", VirtualApplicationGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualApplicationGroupResource.ResourceType, out string virtualApplicationGroupApplicationGroupsApiVersion);
            _virtualApplicationGroupApplicationGroupsRestClient = new ApplicationGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualApplicationGroupApplicationGroupsApiVersion);
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
        /// Create or update an applicationGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="data"> Object containing ApplicationGroup definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualApplicationGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationGroupName, VirtualApplicationGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualApplicationGroupApplicationGroupsClientDiagnostics.CreateScope("VirtualApplicationGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualApplicationGroupApplicationGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation<VirtualApplicationGroupResource>(Response.FromValue(new VirtualApplicationGroupResource(Client, response), response.GetRawResponse()));
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
        /// Create or update an applicationGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="data"> Object containing ApplicationGroup definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualApplicationGroupResource> CreateOrUpdate(WaitUntil waitUntil, string applicationGroupName, VirtualApplicationGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualApplicationGroupApplicationGroupsClientDiagnostics.CreateScope("VirtualApplicationGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualApplicationGroupApplicationGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, applicationGroupName, data, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation<VirtualApplicationGroupResource>(Response.FromValue(new VirtualApplicationGroupResource(Client, response), response.GetRawResponse()));
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
        /// Get an application group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGroupName"/> is null. </exception>
        public virtual async Task<Response<VirtualApplicationGroupResource>> GetAsync(string applicationGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));

            using var scope = _virtualApplicationGroupApplicationGroupsClientDiagnostics.CreateScope("VirtualApplicationGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualApplicationGroupApplicationGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualApplicationGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an application group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGroupName"/> is null. </exception>
        public virtual Response<VirtualApplicationGroupResource> Get(string applicationGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));

            using var scope = _virtualApplicationGroupApplicationGroupsClientDiagnostics.CreateScope("VirtualApplicationGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualApplicationGroupApplicationGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualApplicationGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List applicationGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are applicationGroupType. </param>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualApplicationGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualApplicationGroupResource> GetAllAsync(string filter = null, int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualApplicationGroupApplicationGroupsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualApplicationGroupApplicationGroupsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualApplicationGroupResource(Client, VirtualApplicationGroupData.DeserializeVirtualApplicationGroupData(e)), _virtualApplicationGroupApplicationGroupsClientDiagnostics, Pipeline, "VirtualApplicationGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List applicationGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are applicationGroupType. </param>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualApplicationGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualApplicationGroupResource> GetAll(string filter = null, int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualApplicationGroupApplicationGroupsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualApplicationGroupApplicationGroupsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualApplicationGroupResource(Client, VirtualApplicationGroupData.DeserializeVirtualApplicationGroupData(e)), _virtualApplicationGroupApplicationGroupsClientDiagnostics, Pipeline, "VirtualApplicationGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));

            using var scope = _virtualApplicationGroupApplicationGroupsClientDiagnostics.CreateScope("VirtualApplicationGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualApplicationGroupApplicationGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationGroupName, nameof(applicationGroupName));

            using var scope = _virtualApplicationGroupApplicationGroupsClientDiagnostics.CreateScope("VirtualApplicationGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualApplicationGroupApplicationGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualApplicationGroupResource> IEnumerable<VirtualApplicationGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualApplicationGroupResource> IAsyncEnumerable<VirtualApplicationGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
