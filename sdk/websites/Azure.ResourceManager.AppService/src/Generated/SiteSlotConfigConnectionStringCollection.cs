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
    /// <summary> A class representing collection of SiteSlotConfigConnectionString and their operations over its parent. </summary>
    public partial class SiteSlotConfigConnectionStringCollection : ArmCollection, IEnumerable<SiteSlotConfigConnectionStringResource>, IAsyncEnumerable<SiteSlotConfigConnectionStringResource>
    {
        private readonly ClientDiagnostics _siteSlotConfigConnectionStringWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotConfigConnectionStringWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigConnectionStringCollection"/> class for mocking. </summary>
        protected SiteSlotConfigConnectionStringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigConnectionStringCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotConfigConnectionStringCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotConfigConnectionStringWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotConfigConnectionStringResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotConfigConnectionStringResource.ResourceType, out string siteSlotConfigConnectionStringWebAppsApiVersion);
            _siteSlotConfigConnectionStringWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotConfigConnectionStringWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReferenceSlot
        /// </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual async Task<Response<SiteSlotConfigConnectionStringResource>> GetAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _siteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigConnectionStringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReferenceSlot
        /// </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual Response<SiteSlotConfigConnectionStringResource> Get(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _siteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigConnectionStringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the config reference app settings and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReferencesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotConfigConnectionStringResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotConfigConnectionStringResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotConfigConnectionStringResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferencesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigConnectionStringResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotConfigConnectionStringResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferencesSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigConnectionStringResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Gets the config reference app settings and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReferencesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotConfigConnectionStringResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotConfigConnectionStringResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotConfigConnectionStringResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferencesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigConnectionStringResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotConfigConnectionStringResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferencesSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigConnectionStringResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReferenceSlot
        /// </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _siteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionStringKey, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReferenceSlot
        /// </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _siteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionStringKey, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReferenceSlot
        /// </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual async Task<Response<SiteSlotConfigConnectionStringResource>> GetIfExistsAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _siteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotConfigConnectionStringResource>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigConnectionStringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}
        /// Operation Id: WebApps_GetSiteConnectionStringKeyVaultReferenceSlot
        /// </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual Response<SiteSlotConfigConnectionStringResource> GetIfExists(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _siteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotConfigConnectionStringResource>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigConnectionStringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotConfigConnectionStringResource> IEnumerable<SiteSlotConfigConnectionStringResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotConfigConnectionStringResource> IAsyncEnumerable<SiteSlotConfigConnectionStringResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
