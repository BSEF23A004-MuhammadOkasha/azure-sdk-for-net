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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebSiteSlotContinuousWebJobResource"/> and their operations.
    /// Each <see cref="WebSiteSlotContinuousWebJobResource"/> in the collection will belong to the same instance of <see cref="WebSiteSlotResource"/>.
    /// To get a <see cref="WebSiteSlotContinuousWebJobCollection"/> instance call the GetWebSiteSlotContinuousWebJobs method from an instance of <see cref="WebSiteSlotResource"/>.
    /// </summary>
    public partial class WebSiteSlotContinuousWebJobCollection : ArmCollection, IEnumerable<WebSiteSlotContinuousWebJobResource>, IAsyncEnumerable<WebSiteSlotContinuousWebJobResource>
    {
        private readonly ClientDiagnostics _webSiteSlotContinuousWebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotContinuousWebJobWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotContinuousWebJobCollection"/> class for mocking. </summary>
        protected WebSiteSlotContinuousWebJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotContinuousWebJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteSlotContinuousWebJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotContinuousWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteSlotContinuousWebJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteSlotContinuousWebJobResource.ResourceType, out string webSiteSlotContinuousWebJobWebAppsApiVersion);
            _webSiteSlotContinuousWebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotContinuousWebJobWebAppsApiVersion);
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
        /// Description for Gets a continuous web job by its ID for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetContinuousWebJobSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotContinuousWebJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<Response<WebSiteSlotContinuousWebJobResource>> GetAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotContinuousWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotContinuousWebJobWebAppsRestClient.GetContinuousWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotContinuousWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a continuous web job by its ID for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetContinuousWebJobSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotContinuousWebJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<WebSiteSlotContinuousWebJobResource> Get(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotContinuousWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotContinuousWebJobWebAppsRestClient.GetContinuousWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotContinuousWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List continuous web jobs for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListContinuousWebJobsSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotContinuousWebJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteSlotContinuousWebJobResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteSlotContinuousWebJobResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotContinuousWebJobWebAppsRestClient.CreateListContinuousWebJobsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotContinuousWebJobWebAppsRestClient.CreateListContinuousWebJobsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotContinuousWebJobResource(Client, ContinuousWebJobData.DeserializeContinuousWebJobData(e)), _webSiteSlotContinuousWebJobWebAppsClientDiagnostics, Pipeline, "WebSiteSlotContinuousWebJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List continuous web jobs for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListContinuousWebJobsSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotContinuousWebJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteSlotContinuousWebJobResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteSlotContinuousWebJobResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotContinuousWebJobWebAppsRestClient.CreateListContinuousWebJobsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotContinuousWebJobWebAppsRestClient.CreateListContinuousWebJobsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotContinuousWebJobResource(Client, ContinuousWebJobData.DeserializeContinuousWebJobData(e)), _webSiteSlotContinuousWebJobWebAppsClientDiagnostics, Pipeline, "WebSiteSlotContinuousWebJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetContinuousWebJobSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotContinuousWebJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotContinuousWebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotContinuousWebJobWebAppsRestClient.GetContinuousWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetContinuousWebJobSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotContinuousWebJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<bool> Exists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotContinuousWebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteSlotContinuousWebJobWebAppsRestClient.GetContinuousWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetContinuousWebJobSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotContinuousWebJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<NullableResponse<WebSiteSlotContinuousWebJobResource>> GetIfExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotContinuousWebJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotContinuousWebJobWebAppsRestClient.GetContinuousWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteSlotContinuousWebJobResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotContinuousWebJobResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetContinuousWebJobSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotContinuousWebJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual NullableResponse<WebSiteSlotContinuousWebJobResource> GetIfExists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _webSiteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotContinuousWebJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webSiteSlotContinuousWebJobWebAppsRestClient.GetContinuousWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteSlotContinuousWebJobResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotContinuousWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteSlotContinuousWebJobResource> IEnumerable<WebSiteSlotContinuousWebJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteSlotContinuousWebJobResource> IAsyncEnumerable<WebSiteSlotContinuousWebJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
