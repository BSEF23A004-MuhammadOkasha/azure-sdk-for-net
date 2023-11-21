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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppResource"/> and their operations.
    /// Each <see cref="ContainerAppResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ContainerAppCollection"/> instance call the GetContainerApps method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ContainerAppCollection : ArmCollection, IEnumerable<ContainerAppResource>, IAsyncEnumerable<ContainerAppResource>
    {
        private readonly ClientDiagnostics _containerAppClientDiagnostics;
        private readonly ContainerAppsRestOperations _containerAppRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppCollection"/> class for mocking. </summary>
        protected ContainerAppCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppResource.ResourceType, out string containerAppApiVersion);
            _containerAppRestClient = new ContainerAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppApiVersion);
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
        /// Create or update a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="data"> Properties used to create a container app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string containerAppName, ContainerAppData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppClientDiagnostics.CreateScope("ContainerAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerAppRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, containerAppName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppResource>(new ContainerAppOperationSource(Client), _containerAppClientDiagnostics, Pipeline, _containerAppRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, containerAppName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="data"> Properties used to create a container app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppResource> CreateOrUpdate(WaitUntil waitUntil, string containerAppName, ContainerAppData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppClientDiagnostics.CreateScope("ContainerAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerAppRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, containerAppName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppResource>(new ContainerAppOperationSource(Client), _containerAppClientDiagnostics, Pipeline, _containerAppRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, containerAppName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the properties of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppResource>> GetAsync(string containerAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));

            using var scope = _containerAppClientDiagnostics.CreateScope("ContainerAppCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, containerAppName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> is null. </exception>
        public virtual Response<ContainerAppResource> Get(string containerAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));

            using var scope = _containerAppClientDiagnostics.CreateScope("ContainerAppCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, containerAppName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Container Apps in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ContainerAppResource(Client, ContainerAppData.DeserializeContainerAppData(e)), _containerAppClientDiagnostics, Pipeline, "ContainerAppCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Container Apps in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ContainerAppResource(Client, ContainerAppData.DeserializeContainerAppData(e)), _containerAppClientDiagnostics, Pipeline, "ContainerAppCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string containerAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));

            using var scope = _containerAppClientDiagnostics.CreateScope("ContainerAppCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, containerAppName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> is null. </exception>
        public virtual Response<bool> Exists(string containerAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));

            using var scope = _containerAppClientDiagnostics.CreateScope("ContainerAppCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, containerAppName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppResource>> GetIfExistsAsync(string containerAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));

            using var scope = _containerAppClientDiagnostics.CreateScope("ContainerAppCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, containerAppName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppResource> GetIfExists(string containerAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerAppName, nameof(containerAppName));

            using var scope = _containerAppClientDiagnostics.CreateScope("ContainerAppCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, containerAppName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppResource> IEnumerable<ContainerAppResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppResource> IAsyncEnumerable<ContainerAppResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
