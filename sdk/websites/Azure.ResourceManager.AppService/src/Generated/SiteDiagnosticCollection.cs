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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteDiagnostic and their operations over its parent. </summary>
    public partial class SiteDiagnosticCollection : ArmCollection, IEnumerable<SiteDiagnostic>, IAsyncEnumerable<SiteDiagnostic>
    {
        private readonly ClientDiagnostics _siteDiagnosticDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteDiagnosticDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticCollection"/> class for mocking. </summary>
        protected SiteDiagnosticCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteDiagnosticCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteDiagnosticDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteDiagnostic.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SiteDiagnostic.ResourceType, out string siteDiagnosticDiagnosticsApiVersion);
            _siteDiagnosticDiagnosticsRestClient = new DiagnosticsRestOperations(_siteDiagnosticDiagnosticsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteDiagnosticDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategory
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public async virtual Task<Response<SiteDiagnostic>> GetAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteDiagnosticDiagnosticsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategory
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<SiteDiagnostic> Get(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategory(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken);
                if (response.Value == null)
                    throw _siteDiagnosticDiagnosticsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Diagnostics Categories
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics
        /// Operation Id: Diagnostics_ListSiteDiagnosticCategories
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDiagnostic" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDiagnostic> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteDiagnostic>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteDiagnosticDiagnosticsRestClient.ListSiteDiagnosticCategoriesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnostic(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteDiagnostic>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteDiagnosticDiagnosticsRestClient.ListSiteDiagnosticCategoriesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnostic(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get Diagnostics Categories
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics
        /// Operation Id: Diagnostics_ListSiteDiagnosticCategories
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDiagnostic" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDiagnostic> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteDiagnostic> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteDiagnosticDiagnosticsRestClient.ListSiteDiagnosticCategories(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnostic(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteDiagnostic> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteDiagnosticDiagnosticsRestClient.ListSiteDiagnosticCategoriesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnostic(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategory
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategory
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<bool> Exists(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(diagnosticCategory, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategory
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public async virtual Task<Response<SiteDiagnostic>> GetIfExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteDiagnostic>(null, response.GetRawResponse());
                return Response.FromValue(new SiteDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategory
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<SiteDiagnostic> GetIfExists(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategory(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteDiagnostic>(null, response.GetRawResponse());
                return Response.FromValue(new SiteDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteDiagnostic> IEnumerable<SiteDiagnostic>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDiagnostic> IAsyncEnumerable<SiteDiagnostic>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
