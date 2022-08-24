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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteDeploymentResource" /> and their operations.
    /// Each <see cref="SiteDeploymentResource" /> in the collection will belong to the same instance of <see cref="AppServiceResource" />.
    /// To get a <see cref="SiteDeploymentCollection" /> instance call the GetSiteDeployments method from an instance of <see cref="AppServiceResource" />.
    /// </summary>
    public partial class SiteDeploymentCollection : ArmCollection, IEnumerable<SiteDeploymentResource>, IAsyncEnumerable<SiteDeploymentResource>
    {
        private readonly ClientDiagnostics _siteDeploymentWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteDeploymentWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteDeploymentCollection"/> class for mocking. </summary>
        protected SiteDeploymentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDeploymentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteDeploymentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteDeploymentWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteDeploymentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteDeploymentResource.ResourceType, out string siteDeploymentWebAppsApiVersion);
            _siteDeploymentWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteDeploymentWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Create a deployment for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/deployments/{id}
        /// Operation Id: WebApps_CreateDeployment
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> ID of an existing deployment. </param>
        /// <param name="data"> Deployment details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteDeploymentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string id, DeploymentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteDeploymentWebAppsClientDiagnostics.CreateScope("SiteDeploymentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteDeploymentWebAppsRestClient.CreateDeploymentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteDeploymentResource>(Response.FromValue(new SiteDeploymentResource(Client, response), response.GetRawResponse()));
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
        /// Description for Create a deployment for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/deployments/{id}
        /// Operation Id: WebApps_CreateDeployment
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> ID of an existing deployment. </param>
        /// <param name="data"> Deployment details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteDeploymentResource> CreateOrUpdate(WaitUntil waitUntil, string id, DeploymentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteDeploymentWebAppsClientDiagnostics.CreateScope("SiteDeploymentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteDeploymentWebAppsRestClient.CreateDeployment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteDeploymentResource>(Response.FromValue(new SiteDeploymentResource(Client, response), response.GetRawResponse()));
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
        /// Description for Get a deployment by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/deployments/{id}
        /// Operation Id: WebApps_GetDeployment
        /// </summary>
        /// <param name="id"> Deployment ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<SiteDeploymentResource>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteDeploymentWebAppsClientDiagnostics.CreateScope("SiteDeploymentCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteDeploymentWebAppsRestClient.GetDeploymentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDeploymentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a deployment by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/deployments/{id}
        /// Operation Id: WebApps_GetDeployment
        /// </summary>
        /// <param name="id"> Deployment ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<SiteDeploymentResource> Get(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteDeploymentWebAppsClientDiagnostics.CreateScope("SiteDeploymentCollection.Get");
            scope.Start();
            try
            {
                var response = _siteDeploymentWebAppsRestClient.GetDeployment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDeploymentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List deployments for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/deployments
        /// Operation Id: WebApps_ListDeployments
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDeploymentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDeploymentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteDeploymentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteDeploymentWebAppsClientDiagnostics.CreateScope("SiteDeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteDeploymentWebAppsRestClient.ListDeploymentsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDeploymentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteDeploymentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteDeploymentWebAppsClientDiagnostics.CreateScope("SiteDeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteDeploymentWebAppsRestClient.ListDeploymentsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDeploymentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for List deployments for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/deployments
        /// Operation Id: WebApps_ListDeployments
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDeploymentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDeploymentResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteDeploymentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteDeploymentWebAppsClientDiagnostics.CreateScope("SiteDeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteDeploymentWebAppsRestClient.ListDeployments(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDeploymentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteDeploymentResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteDeploymentWebAppsClientDiagnostics.CreateScope("SiteDeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteDeploymentWebAppsRestClient.ListDeploymentsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDeploymentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/deployments/{id}
        /// Operation Id: WebApps_GetDeployment
        /// </summary>
        /// <param name="id"> Deployment ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteDeploymentWebAppsClientDiagnostics.CreateScope("SiteDeploymentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteDeploymentWebAppsRestClient.GetDeploymentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/deployments/{id}
        /// Operation Id: WebApps_GetDeployment
        /// </summary>
        /// <param name="id"> Deployment ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteDeploymentWebAppsClientDiagnostics.CreateScope("SiteDeploymentCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteDeploymentWebAppsRestClient.GetDeployment(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteDeploymentResource> IEnumerable<SiteDeploymentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDeploymentResource> IAsyncEnumerable<SiteDeploymentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
