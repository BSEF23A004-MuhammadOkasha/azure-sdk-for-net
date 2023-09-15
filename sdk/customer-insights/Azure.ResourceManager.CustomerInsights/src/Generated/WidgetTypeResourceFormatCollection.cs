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

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="WidgetTypeResourceFormatResource" /> and their operations.
    /// Each <see cref="WidgetTypeResourceFormatResource" /> in the collection will belong to the same instance of <see cref="HubResource" />.
    /// To get a <see cref="WidgetTypeResourceFormatCollection" /> instance call the GetWidgetTypeResourceFormats method from an instance of <see cref="HubResource" />.
    /// </summary>
    public partial class WidgetTypeResourceFormatCollection : ArmCollection, IEnumerable<WidgetTypeResourceFormatResource>, IAsyncEnumerable<WidgetTypeResourceFormatResource>
    {
        private readonly ClientDiagnostics _widgetTypeResourceFormatWidgetTypesClientDiagnostics;
        private readonly WidgetTypesRestOperations _widgetTypeResourceFormatWidgetTypesRestClient;

        /// <summary> Initializes a new instance of the <see cref="WidgetTypeResourceFormatCollection"/> class for mocking. </summary>
        protected WidgetTypeResourceFormatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WidgetTypeResourceFormatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WidgetTypeResourceFormatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _widgetTypeResourceFormatWidgetTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", WidgetTypeResourceFormatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WidgetTypeResourceFormatResource.ResourceType, out string widgetTypeResourceFormatWidgetTypesApiVersion);
            _widgetTypeResourceFormatWidgetTypesRestClient = new WidgetTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, widgetTypeResourceFormatWidgetTypesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a widget type in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/widgetTypes/{widgetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WidgetTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="widgetTypeName"> The name of the widget type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="widgetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="widgetTypeName"/> is null. </exception>
        public virtual async Task<Response<WidgetTypeResourceFormatResource>> GetAsync(string widgetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(widgetTypeName, nameof(widgetTypeName));

            using var scope = _widgetTypeResourceFormatWidgetTypesClientDiagnostics.CreateScope("WidgetTypeResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = await _widgetTypeResourceFormatWidgetTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, widgetTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WidgetTypeResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a widget type in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/widgetTypes/{widgetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WidgetTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="widgetTypeName"> The name of the widget type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="widgetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="widgetTypeName"/> is null. </exception>
        public virtual Response<WidgetTypeResourceFormatResource> Get(string widgetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(widgetTypeName, nameof(widgetTypeName));

            using var scope = _widgetTypeResourceFormatWidgetTypesClientDiagnostics.CreateScope("WidgetTypeResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = _widgetTypeResourceFormatWidgetTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, widgetTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WidgetTypeResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all available widget types in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/widgetTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WidgetTypes_ListByHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WidgetTypeResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WidgetTypeResourceFormatResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _widgetTypeResourceFormatWidgetTypesRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _widgetTypeResourceFormatWidgetTypesRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WidgetTypeResourceFormatResource(Client, WidgetTypeResourceFormatData.DeserializeWidgetTypeResourceFormatData(e)), _widgetTypeResourceFormatWidgetTypesClientDiagnostics, Pipeline, "WidgetTypeResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all available widget types in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/widgetTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WidgetTypes_ListByHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WidgetTypeResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WidgetTypeResourceFormatResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _widgetTypeResourceFormatWidgetTypesRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _widgetTypeResourceFormatWidgetTypesRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WidgetTypeResourceFormatResource(Client, WidgetTypeResourceFormatData.DeserializeWidgetTypeResourceFormatData(e)), _widgetTypeResourceFormatWidgetTypesClientDiagnostics, Pipeline, "WidgetTypeResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/widgetTypes/{widgetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WidgetTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="widgetTypeName"> The name of the widget type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="widgetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="widgetTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string widgetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(widgetTypeName, nameof(widgetTypeName));

            using var scope = _widgetTypeResourceFormatWidgetTypesClientDiagnostics.CreateScope("WidgetTypeResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _widgetTypeResourceFormatWidgetTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, widgetTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/widgetTypes/{widgetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WidgetTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="widgetTypeName"> The name of the widget type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="widgetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="widgetTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string widgetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(widgetTypeName, nameof(widgetTypeName));

            using var scope = _widgetTypeResourceFormatWidgetTypesClientDiagnostics.CreateScope("WidgetTypeResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = _widgetTypeResourceFormatWidgetTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, widgetTypeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WidgetTypeResourceFormatResource> IEnumerable<WidgetTypeResourceFormatResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WidgetTypeResourceFormatResource> IAsyncEnumerable<WidgetTypeResourceFormatResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
