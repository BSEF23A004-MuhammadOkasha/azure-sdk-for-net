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
    /// <summary> A class representing collection of SiteSlotInstanceProcess and their operations over its parent. </summary>
    public partial class SiteSlotInstanceProcessCollection : ArmCollection, IEnumerable<SiteSlotInstanceProcess>, IAsyncEnumerable<SiteSlotInstanceProcess>
    {
        private readonly ClientDiagnostics _siteSlotInstanceProcessWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotInstanceProcessWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceProcessCollection"/> class for mocking. </summary>
        protected SiteSlotInstanceProcessCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceProcessCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotInstanceProcessCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotInstanceProcessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotInstanceProcess.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SiteSlotInstanceProcess.ResourceType, out string siteSlotInstanceProcessWebAppsApiVersion);
            _siteSlotInstanceProcessWebAppsRestClient = new WebAppsRestOperations(_siteSlotInstanceProcessWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotInstanceProcessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotInstance.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotInstance.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public async virtual Task<Response<SiteSlotInstanceProcess>> GetAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceProcessWebAppsRestClient.GetInstanceProcessSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, processId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotInstanceProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<SiteSlotInstanceProcess> Get(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceProcessWebAppsRestClient.GetInstanceProcessSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, processId, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes
        /// Operation Id: WebApps_ListInstanceProcessesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotInstanceProcess" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotInstanceProcess> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotInstanceProcess>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotInstanceProcessWebAppsRestClient.ListInstanceProcessesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotInstanceProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotInstanceProcess>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotInstanceProcessWebAppsRestClient.ListInstanceProcessesSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotInstanceProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes
        /// Operation Id: WebApps_ListInstanceProcessesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotInstanceProcess" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotInstanceProcess> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotInstanceProcess> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotInstanceProcessWebAppsRestClient.ListInstanceProcessesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotInstanceProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotInstanceProcess> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotInstanceProcessWebAppsRestClient.ListInstanceProcessesSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotInstanceProcess(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(processId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<bool> Exists(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(processId, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public async virtual Task<Response<SiteSlotInstanceProcess>> GetIfExistsAsync(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceProcessWebAppsRestClient.GetInstanceProcessSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, processId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotInstanceProcess>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<SiteSlotInstanceProcess> GetIfExists(string processId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(processId, nameof(processId));

            using var scope = _siteSlotInstanceProcessWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceProcessWebAppsRestClient.GetInstanceProcessSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, processId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotInstanceProcess>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceProcess(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotInstanceProcess> IEnumerable<SiteSlotInstanceProcess>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotInstanceProcess> IAsyncEnumerable<SiteSlotInstanceProcess>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
