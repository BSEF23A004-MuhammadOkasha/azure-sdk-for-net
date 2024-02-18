// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="TenantsCostManagementViewsResource"/> and their operations.
    /// Each <see cref="TenantsCostManagementViewsResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="TenantsCostManagementViewsCollection"/> instance call the GetTenantsCostManagementViews method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class TenantsCostManagementViewsCollection : ArmCollection
    {
        private readonly ClientDiagnostics _tenantsCostManagementViewsViewsClientDiagnostics;
        private readonly ViewsRestOperations _tenantsCostManagementViewsViewsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantsCostManagementViewsCollection"/> class for mocking. </summary>
        protected TenantsCostManagementViewsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantsCostManagementViewsCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TenantsCostManagementViewsCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantsCostManagementViewsViewsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CostManagement", TenantsCostManagementViewsResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TenantsCostManagementViewsResource.ResourceType, out string tenantsCostManagementViewsViewsApiVersion);
            _tenantsCostManagementViewsViewsRestClient = new ViewsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantsCostManagementViewsViewsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update a view. Update operation requires latest eTag to be set in the request. You may obtain the latest eTag by performing a get operation. Create operation does not require eTag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantsCostManagementViewsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="viewName"> View name. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate View operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TenantsCostManagementViewsResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string viewName, CostManagementViewData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tenantsCostManagementViewsViewsClientDiagnostics.CreateScope("TenantsCostManagementViewsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tenantsCostManagementViewsViewsRestClient.CreateOrUpdateAsync(viewName, data, cancellationToken).ConfigureAwait(false);
                var uri = _tenantsCostManagementViewsViewsRestClient.CreateCreateOrUpdateRequestUri(viewName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new CostManagementArmOperation<TenantsCostManagementViewsResource>(Response.FromValue(new TenantsCostManagementViewsResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// The operation to create or update a view. Update operation requires latest eTag to be set in the request. You may obtain the latest eTag by performing a get operation. Create operation does not require eTag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantsCostManagementViewsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="viewName"> View name. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate View operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TenantsCostManagementViewsResource> CreateOrUpdate(WaitUntil waitUntil, string viewName, CostManagementViewData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tenantsCostManagementViewsViewsClientDiagnostics.CreateScope("TenantsCostManagementViewsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tenantsCostManagementViewsViewsRestClient.CreateOrUpdate(viewName, data, cancellationToken);
                var uri = _tenantsCostManagementViewsViewsRestClient.CreateCreateOrUpdateRequestUri(viewName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new CostManagementArmOperation<TenantsCostManagementViewsResource>(Response.FromValue(new TenantsCostManagementViewsResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets the view by view name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantsCostManagementViewsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> View name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual async Task<Response<TenantsCostManagementViewsResource>> GetAsync(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _tenantsCostManagementViewsViewsClientDiagnostics.CreateScope("TenantsCostManagementViewsCollection.Get");
            scope.Start();
            try
            {
                var response = await _tenantsCostManagementViewsViewsRestClient.GetAsync(viewName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantsCostManagementViewsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the view by view name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantsCostManagementViewsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> View name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual Response<TenantsCostManagementViewsResource> Get(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _tenantsCostManagementViewsViewsClientDiagnostics.CreateScope("TenantsCostManagementViewsCollection.Get");
            scope.Start();
            try
            {
                var response = _tenantsCostManagementViewsViewsRestClient.Get(viewName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantsCostManagementViewsResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantsCostManagementViewsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> View name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _tenantsCostManagementViewsViewsClientDiagnostics.CreateScope("TenantsCostManagementViewsCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tenantsCostManagementViewsViewsRestClient.GetAsync(viewName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantsCostManagementViewsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> View name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual Response<bool> Exists(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _tenantsCostManagementViewsViewsClientDiagnostics.CreateScope("TenantsCostManagementViewsCollection.Exists");
            scope.Start();
            try
            {
                var response = _tenantsCostManagementViewsViewsRestClient.Get(viewName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantsCostManagementViewsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> View name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual async Task<NullableResponse<TenantsCostManagementViewsResource>> GetIfExistsAsync(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _tenantsCostManagementViewsViewsClientDiagnostics.CreateScope("TenantsCostManagementViewsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _tenantsCostManagementViewsViewsRestClient.GetAsync(viewName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TenantsCostManagementViewsResource>(response.GetRawResponse());
                return Response.FromValue(new TenantsCostManagementViewsResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantsCostManagementViewsResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> View name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual NullableResponse<TenantsCostManagementViewsResource> GetIfExists(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _tenantsCostManagementViewsViewsClientDiagnostics.CreateScope("TenantsCostManagementViewsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _tenantsCostManagementViewsViewsRestClient.Get(viewName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TenantsCostManagementViewsResource>(response.GetRawResponse());
                return Response.FromValue(new TenantsCostManagementViewsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
