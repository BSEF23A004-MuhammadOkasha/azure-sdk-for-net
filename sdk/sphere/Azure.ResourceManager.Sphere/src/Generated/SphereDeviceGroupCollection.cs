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

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing a collection of <see cref="SphereDeviceGroupResource" /> and their operations.
    /// Each <see cref="SphereDeviceGroupResource" /> in the collection will belong to the same instance of <see cref="SphereProductResource" />.
    /// To get a <see cref="SphereDeviceGroupCollection" /> instance call the GetSphereDeviceGroups method from an instance of <see cref="SphereProductResource" />.
    /// </summary>
    public partial class SphereDeviceGroupCollection : ArmCollection, IEnumerable<SphereDeviceGroupResource>, IAsyncEnumerable<SphereDeviceGroupResource>
    {
        private readonly ClientDiagnostics _sphereDeviceGroupDeviceGroupsClientDiagnostics;
        private readonly DeviceGroupsRestOperations _sphereDeviceGroupDeviceGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SphereDeviceGroupCollection"/> class for mocking. </summary>
        protected SphereDeviceGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SphereDeviceGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SphereDeviceGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sphereDeviceGroupDeviceGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sphere", SphereDeviceGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SphereDeviceGroupResource.ResourceType, out string sphereDeviceGroupDeviceGroupsApiVersion);
            _sphereDeviceGroupDeviceGroupsRestClient = new DeviceGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sphereDeviceGroupDeviceGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SphereProductResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SphereProductResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deviceGroupName"> Name of device group. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SphereDeviceGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string deviceGroupName, SphereDeviceGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceGroupName, nameof(deviceGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sphereDeviceGroupDeviceGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deviceGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SphereArmOperation<SphereDeviceGroupResource>(new SphereDeviceGroupOperationSource(Client), _sphereDeviceGroupDeviceGroupsClientDiagnostics, Pipeline, _sphereDeviceGroupDeviceGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deviceGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deviceGroupName"> Name of device group. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SphereDeviceGroupResource> CreateOrUpdate(WaitUntil waitUntil, string deviceGroupName, SphereDeviceGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceGroupName, nameof(deviceGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sphereDeviceGroupDeviceGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deviceGroupName, data, cancellationToken);
                var operation = new SphereArmOperation<SphereDeviceGroupResource>(new SphereDeviceGroupOperationSource(Client), _sphereDeviceGroupDeviceGroupsClientDiagnostics, Pipeline, _sphereDeviceGroupDeviceGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deviceGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceGroupName"> Name of device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupName"/> is null. </exception>
        public virtual async Task<Response<SphereDeviceGroupResource>> GetAsync(string deviceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceGroupName, nameof(deviceGroupName));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _sphereDeviceGroupDeviceGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deviceGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereDeviceGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DeviceGroup. '.default' and '.unassigned' are system defined values and cannot be used for product or device group name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceGroupName"> Name of device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupName"/> is null. </exception>
        public virtual Response<SphereDeviceGroupResource> Get(string deviceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceGroupName, nameof(deviceGroupName));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _sphereDeviceGroupDeviceGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deviceGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereDeviceGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List DeviceGroup resources by Product. '.default' and '.unassigned' are system defined values and cannot be used for product name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_ListByProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SphereDeviceGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SphereDeviceGroupResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sphereDeviceGroupDeviceGroupsRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, pageSizeHint);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sphereDeviceGroupDeviceGroupsRestClient.CreateListByProductNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, pageSizeHint);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SphereDeviceGroupResource(Client, SphereDeviceGroupData.DeserializeSphereDeviceGroupData(e)), _sphereDeviceGroupDeviceGroupsClientDiagnostics, Pipeline, "SphereDeviceGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DeviceGroup resources by Product. '.default' and '.unassigned' are system defined values and cannot be used for product name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_ListByProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SphereDeviceGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SphereDeviceGroupResource> GetAll(string filter = null, int? top = null, int? skip = null, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sphereDeviceGroupDeviceGroupsRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, pageSizeHint);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sphereDeviceGroupDeviceGroupsRestClient.CreateListByProductNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, pageSizeHint);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SphereDeviceGroupResource(Client, SphereDeviceGroupData.DeserializeSphereDeviceGroupData(e)), _sphereDeviceGroupDeviceGroupsClientDiagnostics, Pipeline, "SphereDeviceGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceGroupName"> Name of device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string deviceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceGroupName, nameof(deviceGroupName));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sphereDeviceGroupDeviceGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deviceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceGroupName"> Name of device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string deviceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceGroupName, nameof(deviceGroupName));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _sphereDeviceGroupDeviceGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deviceGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceGroupName"> Name of device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<SphereDeviceGroupResource>> GetIfExistsAsync(string deviceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceGroupName, nameof(deviceGroupName));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sphereDeviceGroupDeviceGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deviceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SphereDeviceGroupResource>(response.GetRawResponse());
                return Response.FromValue(new SphereDeviceGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/products/{productName}/deviceGroups/{deviceGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeviceGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceGroupName"> Name of device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupName"/> is null. </exception>
        public virtual NullableResponse<SphereDeviceGroupResource> GetIfExists(string deviceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceGroupName, nameof(deviceGroupName));

            using var scope = _sphereDeviceGroupDeviceGroupsClientDiagnostics.CreateScope("SphereDeviceGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sphereDeviceGroupDeviceGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deviceGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SphereDeviceGroupResource>(response.GetRawResponse());
                return Response.FromValue(new SphereDeviceGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SphereDeviceGroupResource> IEnumerable<SphereDeviceGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SphereDeviceGroupResource> IAsyncEnumerable<SphereDeviceGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
