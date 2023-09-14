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
    /// A class representing a collection of <see cref="WebSiteSlotConfigConnectionStringResource" /> and their operations.
    /// Each <see cref="WebSiteSlotConfigConnectionStringResource" /> in the collection will belong to the same instance of <see cref="WebSiteSlotResource" />.
    /// To get a <see cref="WebSiteSlotConfigConnectionStringCollection" /> instance call the GetWebSiteSlotConfigConnectionStrings method from an instance of <see cref="WebSiteSlotResource" />.
    /// </summary>
    public partial class WebSiteSlotConfigConnectionStringCollection : ArmCollection, IEnumerable<WebSiteSlotConfigConnectionStringResource>, IAsyncEnumerable<WebSiteSlotConfigConnectionStringResource>
    {
        private readonly ClientDiagnostics _webSiteSlotConfigConnectionStringWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotConfigConnectionStringWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotConfigConnectionStringCollection"/> class for mocking. </summary>
        protected WebSiteSlotConfigConnectionStringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotConfigConnectionStringCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteSlotConfigConnectionStringCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotConfigConnectionStringWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteSlotConfigConnectionStringResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteSlotConfigConnectionStringResource.ResourceType, out string webSiteSlotConfigConnectionStringWebAppsApiVersion);
            _webSiteSlotConfigConnectionStringWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotConfigConnectionStringWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReferenceSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual async Task<Response<WebSiteSlotConfigConnectionStringResource>> GetAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _webSiteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigConnectionStringCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotConfigConnectionStringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReferenceSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual Response<WebSiteSlotConfigConnectionStringResource> Get(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _webSiteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigConnectionStringCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotConfigConnectionStringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the config reference app settings and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReferencesSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteSlotConfigConnectionStringResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteSlotConfigConnectionStringResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotConfigConnectionStringWebAppsRestClient.CreateGetSiteConnectionStringKeyVaultReferencesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotConfigConnectionStringWebAppsRestClient.CreateGetSiteConnectionStringKeyVaultReferencesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotConfigConnectionStringResource(Client, ApiKeyVaultReferenceData.DeserializeApiKeyVaultReferenceData(e)), _webSiteSlotConfigConnectionStringWebAppsClientDiagnostics, Pipeline, "WebSiteSlotConfigConnectionStringCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets the config reference app settings and status of an app
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReferencesSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteSlotConfigConnectionStringResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteSlotConfigConnectionStringResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotConfigConnectionStringWebAppsRestClient.CreateGetSiteConnectionStringKeyVaultReferencesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotConfigConnectionStringWebAppsRestClient.CreateGetSiteConnectionStringKeyVaultReferencesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotConfigConnectionStringResource(Client, ApiKeyVaultReferenceData.DeserializeApiKeyVaultReferenceData(e)), _webSiteSlotConfigConnectionStringWebAppsClientDiagnostics, Pipeline, "WebSiteSlotConfigConnectionStringCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReferenceSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _webSiteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigConnectionStringCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteConnectionStringKeyVaultReferenceSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionStringKey, nameof(connectionStringKey));

            using var scope = _webSiteSlotConfigConnectionStringWebAppsClientDiagnostics.CreateScope("WebSiteSlotConfigConnectionStringCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteSlotConfigConnectionStringWebAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteSlotConfigConnectionStringResource> IEnumerable<WebSiteSlotConfigConnectionStringResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteSlotConfigConnectionStringResource> IAsyncEnumerable<WebSiteSlotConfigConnectionStringResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
