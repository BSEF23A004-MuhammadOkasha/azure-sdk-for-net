// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of NetworkInterfaceTapConfiguration and their operations over its parent. </summary>
    public partial class NetworkInterfaceTapConfigurationCollection : ArmCollection, IEnumerable<NetworkInterfaceTapConfigurationResource>, IAsyncEnumerable<NetworkInterfaceTapConfigurationResource>
    {
        private readonly ClientDiagnostics _networkInterfaceTapConfigurationClientDiagnostics;
        private readonly NetworkInterfaceTapConfigurationsRestOperations _networkInterfaceTapConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceTapConfigurationCollection"/> class for mocking. </summary>
        protected NetworkInterfaceTapConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceTapConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkInterfaceTapConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkInterfaceTapConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkInterfaceTapConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkInterfaceTapConfigurationResource.ResourceType, out string networkInterfaceTapConfigurationApiVersion);
            _networkInterfaceTapConfigurationRestClient = new NetworkInterfaceTapConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkInterfaceTapConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkInterfaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkInterfaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Tap configuration in the specified NetworkInterface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}
        /// Operation Id: NetworkInterfaceTapConfigurations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="tapConfigurationParameters"> Parameters supplied to the create or update tap configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> or <paramref name="tapConfigurationParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkInterfaceTapConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tapConfigurationName, NetworkInterfaceTapConfigurationData tapConfigurationParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));
            Argument.AssertNotNull(tapConfigurationParameters, nameof(tapConfigurationParameters));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkInterfaceTapConfigurationResource>(new NetworkInterfaceTapConfigurationOperationSource(Client), _networkInterfaceTapConfigurationClientDiagnostics, Pipeline, _networkInterfaceTapConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a Tap configuration in the specified NetworkInterface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}
        /// Operation Id: NetworkInterfaceTapConfigurations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="tapConfigurationParameters"> Parameters supplied to the create or update tap configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> or <paramref name="tapConfigurationParameters"/> is null. </exception>
        public virtual ArmOperation<NetworkInterfaceTapConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string tapConfigurationName, NetworkInterfaceTapConfigurationData tapConfigurationParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));
            Argument.AssertNotNull(tapConfigurationParameters, nameof(tapConfigurationParameters));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters, cancellationToken);
                var operation = new NetworkArmOperation<NetworkInterfaceTapConfigurationResource>(new NetworkInterfaceTapConfigurationOperationSource(Client), _networkInterfaceTapConfigurationClientDiagnostics, Pipeline, _networkInterfaceTapConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the specified tap configuration on a network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}
        /// Operation Id: NetworkInterfaceTapConfigurations_Get
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual async Task<Response<NetworkInterfaceTapConfigurationResource>> GetAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified tap configuration on a network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}
        /// Operation Id: NetworkInterfaceTapConfigurations_Get
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<NetworkInterfaceTapConfigurationResource> Get(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all Tap configurations in a network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations
        /// Operation Id: NetworkInterfaceTapConfigurations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterfaceTapConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterfaceTapConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkInterfaceTapConfigurationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceTapConfigurationRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkInterfaceTapConfigurationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceTapConfigurationRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Get all Tap configurations in a network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations
        /// Operation Id: NetworkInterfaceTapConfigurations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterfaceTapConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterfaceTapConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkInterfaceTapConfigurationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkInterfaceTapConfigurationRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkInterfaceTapConfigurationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkInterfaceTapConfigurationRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}
        /// Operation Id: NetworkInterfaceTapConfigurations_Get
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tapConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}
        /// Operation Id: NetworkInterfaceTapConfigurations_Get
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tapConfigurationName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}
        /// Operation Id: NetworkInterfaceTapConfigurations_Get
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual async Task<Response<NetworkInterfaceTapConfigurationResource>> GetIfExistsAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NetworkInterfaceTapConfigurationResource>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/tapConfigurations/{tapConfigurationName}
        /// Operation Id: NetworkInterfaceTapConfigurations_Get
        /// </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<NetworkInterfaceTapConfigurationResource> GetIfExists(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NetworkInterfaceTapConfigurationResource>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkInterfaceTapConfigurationResource> IEnumerable<NetworkInterfaceTapConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkInterfaceTapConfigurationResource> IAsyncEnumerable<NetworkInterfaceTapConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
