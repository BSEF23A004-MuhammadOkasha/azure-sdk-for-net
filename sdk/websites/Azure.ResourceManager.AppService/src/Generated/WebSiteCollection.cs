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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of WebSite and their operations over its parent. </summary>
    public partial class WebSiteCollection : ArmCollection, IEnumerable<WebSiteResource>, IAsyncEnumerable<WebSiteResource>
    {
        private readonly ClientDiagnostics _webSiteWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteCollection"/> class for mocking. </summary>
        protected WebSiteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteResource.ResourceType, out string webSiteWebAppsApiVersion);
            _webSiteWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteWebAppsApiVersion);
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
        /// Description for Creates a new web, mobile, or API app in an existing resource group, or updates an existing app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// Operation Id: WebApps_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Unique name of the app to create or update. To create or update a deployment slot, use the {slot} parameter. </param>
        /// <param name="siteEnvelope"> A JSON representation of the app properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="siteEnvelope"/> is null. </exception>
        public virtual async Task<ArmOperation<WebSiteResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, WebSiteData siteEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(siteEnvelope, nameof(siteEnvelope));

            using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webSiteWebAppsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, siteEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<WebSiteResource>(new WebSiteOperationSource(Client), _webSiteWebAppsClientDiagnostics, Pipeline, _webSiteWebAppsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, siteEnvelope).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Creates a new web, mobile, or API app in an existing resource group, or updates an existing app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// Operation Id: WebApps_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Unique name of the app to create or update. To create or update a deployment slot, use the {slot} parameter. </param>
        /// <param name="siteEnvelope"> A JSON representation of the app properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="siteEnvelope"/> is null. </exception>
        public virtual ArmOperation<WebSiteResource> CreateOrUpdate(WaitUntil waitUntil, string name, WebSiteData siteEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(siteEnvelope, nameof(siteEnvelope));

            using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webSiteWebAppsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, siteEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation<WebSiteResource>(new WebSiteOperationSource(Client), _webSiteWebAppsClientDiagnostics, Pipeline, _webSiteWebAppsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, siteEnvelope).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Gets the details of a web, mobile, or API app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// Operation Id: WebApps_Get
        /// </summary>
        /// <param name="name"> Name of the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<WebSiteResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteWebAppsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of a web, mobile, or API app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// Operation Id: WebApps_Get
        /// </summary>
        /// <param name="name"> Name of the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<WebSiteResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteWebAppsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all web, mobile, and API apps in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites
        /// Operation Id: WebApps_ListByResourceGroup
        /// </summary>
        /// <param name="includeSlots"> Specify &lt;strong&gt;true&lt;/strong&gt; to include deployment slots in results. The default is false, which only gives you the production slot of all apps. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteResource> GetAllAsync(bool? includeSlots = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<WebSiteResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webSiteWebAppsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, includeSlots, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebSiteResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WebSiteResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webSiteWebAppsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, includeSlots, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebSiteResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Gets all web, mobile, and API apps in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites
        /// Operation Id: WebApps_ListByResourceGroup
        /// </summary>
        /// <param name="includeSlots"> Specify &lt;strong&gt;true&lt;/strong&gt; to include deployment slots in results. The default is false, which only gives you the production slot of all apps. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteResource> GetAll(bool? includeSlots = null, CancellationToken cancellationToken = default)
        {
            Page<WebSiteResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webSiteWebAppsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, includeSlots, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebSiteResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WebSiteResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webSiteWebAppsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, includeSlots, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebSiteResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// Operation Id: WebApps_Get
        /// </summary>
        /// <param name="name"> Name of the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// Operation Id: WebApps_Get
        /// </summary>
        /// <param name="name"> Name of the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// Operation Id: WebApps_Get
        /// </summary>
        /// <param name="name"> Name of the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<WebSiteResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webSiteWebAppsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<WebSiteResource>(null, response.GetRawResponse());
                return Response.FromValue(new WebSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// Operation Id: WebApps_Get
        /// </summary>
        /// <param name="name"> Name of the app. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<WebSiteResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _webSiteWebAppsClientDiagnostics.CreateScope("WebSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webSiteWebAppsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<WebSiteResource>(null, response.GetRawResponse());
                return Response.FromValue(new WebSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteResource> IEnumerable<WebSiteResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteResource> IAsyncEnumerable<WebSiteResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
