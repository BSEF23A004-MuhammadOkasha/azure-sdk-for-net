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

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="MobileAttachedDataNetworkResource"/> and their operations.
    /// Each <see cref="MobileAttachedDataNetworkResource"/> in the collection will belong to the same instance of <see cref="PacketCoreDataPlaneResource"/>.
    /// To get a <see cref="MobileAttachedDataNetworkCollection"/> instance call the GetMobileAttachedDataNetworks method from an instance of <see cref="PacketCoreDataPlaneResource"/>.
    /// </summary>
    public partial class MobileAttachedDataNetworkCollection : ArmCollection, IEnumerable<MobileAttachedDataNetworkResource>, IAsyncEnumerable<MobileAttachedDataNetworkResource>
    {
        private readonly ClientDiagnostics _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics;
        private readonly AttachedDataNetworksRestOperations _mobileAttachedDataNetworkAttachedDataNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="MobileAttachedDataNetworkCollection"/> class for mocking. </summary>
        protected MobileAttachedDataNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MobileAttachedDataNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MobileAttachedDataNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", MobileAttachedDataNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MobileAttachedDataNetworkResource.ResourceType, out string mobileAttachedDataNetworkAttachedDataNetworksApiVersion);
            _mobileAttachedDataNetworkAttachedDataNetworksRestClient = new AttachedDataNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mobileAttachedDataNetworkAttachedDataNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PacketCoreDataPlaneResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PacketCoreDataPlaneResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an attached data network. Must be created in the same location as its parent packet core data plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}/attachedDataNetworks/{attachedDataNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDataNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attachedDataNetworkName"> The name of the attached data network. </param>
        /// <param name="data"> Parameters supplied to the create or update attached data network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDataNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDataNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MobileAttachedDataNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string attachedDataNetworkName, MobileAttachedDataNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDataNetworkName, nameof(attachedDataNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics.CreateScope("MobileAttachedDataNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mobileAttachedDataNetworkAttachedDataNetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDataNetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<MobileAttachedDataNetworkResource>(new MobileAttachedDataNetworkOperationSource(Client), _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics, Pipeline, _mobileAttachedDataNetworkAttachedDataNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDataNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an attached data network. Must be created in the same location as its parent packet core data plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}/attachedDataNetworks/{attachedDataNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDataNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attachedDataNetworkName"> The name of the attached data network. </param>
        /// <param name="data"> Parameters supplied to the create or update attached data network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDataNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDataNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MobileAttachedDataNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string attachedDataNetworkName, MobileAttachedDataNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDataNetworkName, nameof(attachedDataNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics.CreateScope("MobileAttachedDataNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mobileAttachedDataNetworkAttachedDataNetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDataNetworkName, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<MobileAttachedDataNetworkResource>(new MobileAttachedDataNetworkOperationSource(Client), _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics, Pipeline, _mobileAttachedDataNetworkAttachedDataNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDataNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified attached data network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}/attachedDataNetworks/{attachedDataNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDataNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDataNetworkName"> The name of the attached data network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDataNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDataNetworkName"/> is null. </exception>
        public virtual async Task<Response<MobileAttachedDataNetworkResource>> GetAsync(string attachedDataNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDataNetworkName, nameof(attachedDataNetworkName));

            using var scope = _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics.CreateScope("MobileAttachedDataNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _mobileAttachedDataNetworkAttachedDataNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDataNetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileAttachedDataNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified attached data network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}/attachedDataNetworks/{attachedDataNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDataNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDataNetworkName"> The name of the attached data network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDataNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDataNetworkName"/> is null. </exception>
        public virtual Response<MobileAttachedDataNetworkResource> Get(string attachedDataNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDataNetworkName, nameof(attachedDataNetworkName));

            using var scope = _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics.CreateScope("MobileAttachedDataNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _mobileAttachedDataNetworkAttachedDataNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDataNetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileAttachedDataNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the attached data networks associated with a packet core data plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}/attachedDataNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDataNetworks_ListByPacketCoreDataPlane</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MobileAttachedDataNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MobileAttachedDataNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileAttachedDataNetworkAttachedDataNetworksRestClient.CreateListByPacketCoreDataPlaneRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileAttachedDataNetworkAttachedDataNetworksRestClient.CreateListByPacketCoreDataPlaneNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MobileAttachedDataNetworkResource(Client, MobileAttachedDataNetworkData.DeserializeMobileAttachedDataNetworkData(e)), _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics, Pipeline, "MobileAttachedDataNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the attached data networks associated with a packet core data plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}/attachedDataNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDataNetworks_ListByPacketCoreDataPlane</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MobileAttachedDataNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MobileAttachedDataNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileAttachedDataNetworkAttachedDataNetworksRestClient.CreateListByPacketCoreDataPlaneRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileAttachedDataNetworkAttachedDataNetworksRestClient.CreateListByPacketCoreDataPlaneNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MobileAttachedDataNetworkResource(Client, MobileAttachedDataNetworkData.DeserializeMobileAttachedDataNetworkData(e)), _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics, Pipeline, "MobileAttachedDataNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}/attachedDataNetworks/{attachedDataNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDataNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDataNetworkName"> The name of the attached data network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDataNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDataNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string attachedDataNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDataNetworkName, nameof(attachedDataNetworkName));

            using var scope = _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics.CreateScope("MobileAttachedDataNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mobileAttachedDataNetworkAttachedDataNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDataNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}/attachedDataNetworks/{attachedDataNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDataNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDataNetworkName"> The name of the attached data network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDataNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDataNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string attachedDataNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDataNetworkName, nameof(attachedDataNetworkName));

            using var scope = _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics.CreateScope("MobileAttachedDataNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _mobileAttachedDataNetworkAttachedDataNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDataNetworkName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}/attachedDataNetworks/{attachedDataNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDataNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDataNetworkName"> The name of the attached data network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDataNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDataNetworkName"/> is null. </exception>
        public virtual async Task<NullableResponse<MobileAttachedDataNetworkResource>> GetIfExistsAsync(string attachedDataNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDataNetworkName, nameof(attachedDataNetworkName));

            using var scope = _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics.CreateScope("MobileAttachedDataNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mobileAttachedDataNetworkAttachedDataNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDataNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MobileAttachedDataNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new MobileAttachedDataNetworkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}/packetCoreDataPlanes/{packetCoreDataPlaneName}/attachedDataNetworks/{attachedDataNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttachedDataNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachedDataNetworkName"> The name of the attached data network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachedDataNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedDataNetworkName"/> is null. </exception>
        public virtual NullableResponse<MobileAttachedDataNetworkResource> GetIfExists(string attachedDataNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachedDataNetworkName, nameof(attachedDataNetworkName));

            using var scope = _mobileAttachedDataNetworkAttachedDataNetworksClientDiagnostics.CreateScope("MobileAttachedDataNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mobileAttachedDataNetworkAttachedDataNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, attachedDataNetworkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MobileAttachedDataNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new MobileAttachedDataNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MobileAttachedDataNetworkResource> IEnumerable<MobileAttachedDataNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MobileAttachedDataNetworkResource> IAsyncEnumerable<MobileAttachedDataNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
