// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
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
    /// <summary> A class representing collection of DetectorDefinitionAutoGenerated and their operations over its parent. </summary>
    public partial class SiteSlotDiagnosticDetectorCollection : ArmCollection, IEnumerable<SiteSlotDiagnosticDetector>, IAsyncEnumerable<SiteSlotDiagnosticDetector>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DiagnosticsRestOperations _diagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticDetectorCollection"/> class for mocking. </summary>
        protected SiteSlotDiagnosticDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteSlotDiagnosticDetectorCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotDiagnosticDetectorCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _diagnosticsRestClient = new DiagnosticsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SiteSlotDiagnostic.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_GetSiteDetectorSlot
        /// <summary> Description for Get Detector. </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<SiteSlotDiagnosticDetector> Get(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticsRestClient.GetSiteDetectorSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticDetector(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_GetSiteDetectorSlot
        /// <summary> Description for Get Detector. </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotDiagnosticDetector>> GetAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticsRestClient.GetSiteDetectorSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotDiagnosticDetector(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<SiteSlotDiagnosticDetector> GetIfExists(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diagnosticsRestClient.GetSiteDetectorSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteSlotDiagnosticDetector>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotDiagnosticDetector(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotDiagnosticDetector>> GetIfExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _diagnosticsRestClient.GetSiteDetectorSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteSlotDiagnosticDetector>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotDiagnosticDetector(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(detectorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_ListSiteDetectorsSlot
        /// <summary> Description for Get Detectors. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDiagnosticDetector" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDiagnosticDetector> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotDiagnosticDetector> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticsRestClient.ListSiteDetectorsSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticDetector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotDiagnosticDetector> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticsRestClient.ListSiteDetectorsSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticDetector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_ListSiteDetectorsSlot
        /// <summary> Description for Get Detectors. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDiagnosticDetector" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDiagnosticDetector> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotDiagnosticDetector>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticsRestClient.ListSiteDetectorsSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticDetector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotDiagnosticDetector>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticsRestClient.ListSiteDetectorsSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticDetector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteSlotDiagnosticDetector> IEnumerable<SiteSlotDiagnosticDetector>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDiagnosticDetector> IAsyncEnumerable<SiteSlotDiagnosticDetector>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteSlotDiagnosticDetector, DetectorDefinitionAutoGeneratedData> Construct() { }
    }
}
