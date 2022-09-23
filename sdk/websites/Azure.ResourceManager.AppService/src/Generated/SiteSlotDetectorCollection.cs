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
    /// A class representing a collection of <see cref="SiteSlotDetectorResource" /> and their operations.
    /// Each <see cref="SiteSlotDetectorResource" /> in the collection will belong to the same instance of <see cref="WebSiteSlotResource" />.
    /// To get a <see cref="SiteSlotDetectorCollection" /> instance call the GetSiteSlotDetectors method from an instance of <see cref="WebSiteSlotResource" />.
    /// </summary>
    public partial class SiteSlotDetectorCollection : ArmCollection, IEnumerable<SiteSlotDetectorResource>, IAsyncEnumerable<SiteSlotDetectorResource>
    {
        private readonly ClientDiagnostics _siteSlotDetectorDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteSlotDetectorDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDetectorCollection"/> class for mocking. </summary>
        protected SiteSlotDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDetectorDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotDetectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotDetectorResource.ResourceType, out string siteSlotDetectorDiagnosticsApiVersion);
            _siteSlotDetectorDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotDetectorDiagnosticsApiVersion);
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
        /// Description for Get site detector response
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorResponseSlot
        /// </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotDetectorResource>> GetAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDetectorDiagnosticsRestClient.GetSiteDetectorResponseSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get site detector response
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorResponseSlot
        /// </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<SiteSlotDetectorResource> Get(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDetectorDiagnosticsRestClient.GetSiteDetectorResponseSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List Site Detector Responses
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/detectors
        /// Operation Id: Diagnostics_ListSiteDetectorResponsesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDetectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDetectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotDetectorResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDetectorDiagnosticsRestClient.ListSiteDetectorResponsesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDetectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotDetectorResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDetectorDiagnosticsRestClient.ListSiteDetectorResponsesSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDetectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for List Site Detector Responses
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/detectors
        /// Operation Id: Diagnostics_ListSiteDetectorResponsesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDetectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDetectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotDetectorResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDetectorDiagnosticsRestClient.ListSiteDetectorResponsesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDetectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotDetectorResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDetectorDiagnosticsRestClient.ListSiteDetectorResponsesSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDetectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorResponseSlot
        /// </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotDetectorDiagnosticsRestClient.GetSiteDetectorResponseSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorResponseSlot
        /// </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotDetectorDiagnosticsRestClient.GetSiteDetectorResponseSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotDetectorResource> IEnumerable<SiteSlotDetectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDetectorResource> IAsyncEnumerable<SiteSlotDetectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
