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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary>
    /// A class representing a collection of <see cref="DeviceProvisioningServiceResource" /> and their operations.
    /// Each <see cref="DeviceProvisioningServiceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DeviceProvisioningServiceCollection" /> instance call the GetDeviceProvisioningServices method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DeviceProvisioningServiceCollection : ArmCollection, IEnumerable<DeviceProvisioningServiceResource>, IAsyncEnumerable<DeviceProvisioningServiceResource>
    {
        private readonly ClientDiagnostics _deviceProvisioningServiceIotDpsResourceClientDiagnostics;
        private readonly IotDpsResourceRestOperations _deviceProvisioningServiceIotDpsResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServiceCollection"/> class for mocking. </summary>
        protected DeviceProvisioningServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeviceProvisioningServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceProvisioningServiceIotDpsResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceProvisioningServices", DeviceProvisioningServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeviceProvisioningServiceResource.ResourceType, out string deviceProvisioningServiceIotDpsResourceApiVersion);
            _deviceProvisioningServiceIotDpsResourceRestClient = new IotDpsResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceProvisioningServiceIotDpsResourceApiVersion);
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
        /// Create or update the metadata of the provisioning service. The usual pattern to modify a property is to retrieve the provisioning service metadata and security metadata, and then combine them with the modified values in a new body to update the provisioning service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="provisioningServiceName"> Name of provisioning service to create or update. </param>
        /// <param name="data"> Description of the provisioning service to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="provisioningServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="provisioningServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceProvisioningServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string provisioningServiceName, DeviceProvisioningServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(provisioningServiceName, nameof(provisioningServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceProvisioningServiceIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServiceIotDpsResourceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, provisioningServiceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServiceResource>(new DeviceProvisioningServiceOperationSource(Client), _deviceProvisioningServiceIotDpsResourceClientDiagnostics, Pipeline, _deviceProvisioningServiceIotDpsResourceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, provisioningServiceName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Create or update the metadata of the provisioning service. The usual pattern to modify a property is to retrieve the provisioning service metadata and security metadata, and then combine them with the modified values in a new body to update the provisioning service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="provisioningServiceName"> Name of provisioning service to create or update. </param>
        /// <param name="data"> Description of the provisioning service to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="provisioningServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="provisioningServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeviceProvisioningServiceResource> CreateOrUpdate(WaitUntil waitUntil, string provisioningServiceName, DeviceProvisioningServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(provisioningServiceName, nameof(provisioningServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceProvisioningServiceIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServiceIotDpsResourceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, provisioningServiceName, data, cancellationToken);
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServiceResource>(new DeviceProvisioningServiceOperationSource(Client), _deviceProvisioningServiceIotDpsResourceClientDiagnostics, Pipeline, _deviceProvisioningServiceIotDpsResourceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, provisioningServiceName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Get the metadata of the provisioning service without SAS keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="provisioningServiceName"> Name of the provisioning service to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="provisioningServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="provisioningServiceName"/> is null. </exception>
        public virtual async Task<Response<DeviceProvisioningServiceResource>> GetAsync(string provisioningServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(provisioningServiceName, nameof(provisioningServiceName));

            using var scope = _deviceProvisioningServiceIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServiceIotDpsResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, provisioningServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the metadata of the provisioning service without SAS keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="provisioningServiceName"> Name of the provisioning service to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="provisioningServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="provisioningServiceName"/> is null. </exception>
        public virtual Response<DeviceProvisioningServiceResource> Get(string provisioningServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(provisioningServiceName, nameof(provisioningServiceName));

            using var scope = _deviceProvisioningServiceIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServiceIotDpsResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, provisioningServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all provisioning services in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceProvisioningServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceProvisioningServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceProvisioningServiceIotDpsResourceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deviceProvisioningServiceIotDpsResourceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeviceProvisioningServiceResource(Client, DeviceProvisioningServiceData.DeserializeDeviceProvisioningServiceData(e)), _deviceProvisioningServiceIotDpsResourceClientDiagnostics, Pipeline, "DeviceProvisioningServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of all provisioning services in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceProvisioningServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceProvisioningServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceProvisioningServiceIotDpsResourceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deviceProvisioningServiceIotDpsResourceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeviceProvisioningServiceResource(Client, DeviceProvisioningServiceData.DeserializeDeviceProvisioningServiceData(e)), _deviceProvisioningServiceIotDpsResourceClientDiagnostics, Pipeline, "DeviceProvisioningServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="provisioningServiceName"> Name of the provisioning service to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="provisioningServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="provisioningServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string provisioningServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(provisioningServiceName, nameof(provisioningServiceName));

            using var scope = _deviceProvisioningServiceIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServiceIotDpsResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, provisioningServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="provisioningServiceName"> Name of the provisioning service to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="provisioningServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="provisioningServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string provisioningServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(provisioningServiceName, nameof(provisioningServiceName));

            using var scope = _deviceProvisioningServiceIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServiceIotDpsResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, provisioningServiceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeviceProvisioningServiceResource> IEnumerable<DeviceProvisioningServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeviceProvisioningServiceResource> IAsyncEnumerable<DeviceProvisioningServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
