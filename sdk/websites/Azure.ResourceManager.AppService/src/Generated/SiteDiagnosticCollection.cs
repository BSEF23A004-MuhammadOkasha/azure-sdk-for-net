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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteDiagnosticResource" /> and their operations.
    /// Each <see cref="SiteDiagnosticResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="SiteDiagnosticCollection" /> instance call the GetSiteDiagnostics method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class SiteDiagnosticCollection : ArmCollection, IEnumerable<SiteDiagnosticResource>, IAsyncEnumerable<SiteDiagnosticResource>
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
            _siteDiagnosticDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteDiagnosticResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteDiagnosticResource.ResourceType, out string siteDiagnosticDiagnosticsApiVersion);
            _siteDiagnosticDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteDiagnosticDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual async Task<Response<SiteDiagnosticResource>> GetAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<SiteDiagnosticResource> Get(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategory(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Diagnostics Categories
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteDiagnosticCategories</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDiagnosticResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDiagnosticResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteDiagnosticDiagnosticsRestClient.CreateListSiteDiagnosticCategoriesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteDiagnosticDiagnosticsRestClient.CreateListSiteDiagnosticCategoriesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteDiagnosticResource(Client, DiagnosticCategoryData.DeserializeDiagnosticCategoryData(e)), _siteDiagnosticDiagnosticsClientDiagnostics, Pipeline, "SiteDiagnosticCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get Diagnostics Categories
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteDiagnosticCategories</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDiagnosticResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDiagnosticResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteDiagnosticDiagnosticsRestClient.CreateListSiteDiagnosticCategoriesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteDiagnosticDiagnosticsRestClient.CreateListSiteDiagnosticCategoriesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteDiagnosticResource(Client, DiagnosticCategoryData.DeserializeDiagnosticCategoryData(e)), _siteDiagnosticDiagnosticsClientDiagnostics, Pipeline, "SiteDiagnosticCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticCategory"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticCategory, nameof(diagnosticCategory));

            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDiagnosticCategory</description>
        /// </item>
        /// </list>
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
                var response = _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategory(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteDiagnosticResource> IEnumerable<SiteDiagnosticResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDiagnosticResource> IAsyncEnumerable<SiteDiagnosticResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
