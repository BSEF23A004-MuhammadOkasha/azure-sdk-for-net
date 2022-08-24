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
    /// A class representing a collection of <see cref="SitePublicCertificateResource" /> and their operations.
    /// Each <see cref="SitePublicCertificateResource" /> in the collection will belong to the same instance of <see cref="AppServiceResource" />.
    /// To get a <see cref="SitePublicCertificateCollection" /> instance call the GetSitePublicCertificates method from an instance of <see cref="AppServiceResource" />.
    /// </summary>
    public partial class SitePublicCertificateCollection : ArmCollection, IEnumerable<SitePublicCertificateResource>, IAsyncEnumerable<SitePublicCertificateResource>
    {
        private readonly ClientDiagnostics _sitePublicCertificateWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _sitePublicCertificateWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SitePublicCertificateCollection"/> class for mocking. </summary>
        protected SitePublicCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SitePublicCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SitePublicCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sitePublicCertificateWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SitePublicCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SitePublicCertificateResource.ResourceType, out string sitePublicCertificateWebAppsApiVersion);
            _sitePublicCertificateWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sitePublicCertificateWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a hostname binding for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_CreateOrUpdatePublicCertificate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="data"> Public certificate details. This is the JSON representation of a PublicCertificate object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SitePublicCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string publicCertificateName, PublicCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sitePublicCertificateWebAppsClientDiagnostics.CreateScope("SitePublicCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sitePublicCertificateWebAppsRestClient.CreateOrUpdatePublicCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SitePublicCertificateResource>(Response.FromValue(new SitePublicCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Description for Creates a hostname binding for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_CreateOrUpdatePublicCertificate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="data"> Public certificate details. This is the JSON representation of a PublicCertificate object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SitePublicCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string publicCertificateName, PublicCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sitePublicCertificateWebAppsClientDiagnostics.CreateScope("SitePublicCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sitePublicCertificateWebAppsRestClient.CreateOrUpdatePublicCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SitePublicCertificateResource>(Response.FromValue(new SitePublicCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Description for Get the named public certificate for an app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_GetPublicCertificate
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual async Task<Response<SitePublicCertificateResource>> GetAsync(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _sitePublicCertificateWebAppsClientDiagnostics.CreateScope("SitePublicCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _sitePublicCertificateWebAppsRestClient.GetPublicCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SitePublicCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the named public certificate for an app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_GetPublicCertificate
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual Response<SitePublicCertificateResource> Get(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _sitePublicCertificateWebAppsClientDiagnostics.CreateScope("SitePublicCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _sitePublicCertificateWebAppsRestClient.GetPublicCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SitePublicCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get public certificates for an app or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates
        /// Operation Id: WebApps_ListPublicCertificates
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SitePublicCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SitePublicCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SitePublicCertificateResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sitePublicCertificateWebAppsClientDiagnostics.CreateScope("SitePublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sitePublicCertificateWebAppsRestClient.ListPublicCertificatesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePublicCertificateResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SitePublicCertificateResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sitePublicCertificateWebAppsClientDiagnostics.CreateScope("SitePublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sitePublicCertificateWebAppsRestClient.ListPublicCertificatesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePublicCertificateResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get public certificates for an app or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates
        /// Operation Id: WebApps_ListPublicCertificates
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SitePublicCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SitePublicCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SitePublicCertificateResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sitePublicCertificateWebAppsClientDiagnostics.CreateScope("SitePublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sitePublicCertificateWebAppsRestClient.ListPublicCertificates(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePublicCertificateResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SitePublicCertificateResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sitePublicCertificateWebAppsClientDiagnostics.CreateScope("SitePublicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sitePublicCertificateWebAppsRestClient.ListPublicCertificatesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePublicCertificateResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_GetPublicCertificate
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _sitePublicCertificateWebAppsClientDiagnostics.CreateScope("SitePublicCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sitePublicCertificateWebAppsRestClient.GetPublicCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/publicCertificates/{publicCertificateName}
        /// Operation Id: WebApps_GetPublicCertificate
        /// </summary>
        /// <param name="publicCertificateName"> Public certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string publicCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicCertificateName, nameof(publicCertificateName));

            using var scope = _sitePublicCertificateWebAppsClientDiagnostics.CreateScope("SitePublicCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _sitePublicCertificateWebAppsRestClient.GetPublicCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicCertificateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SitePublicCertificateResource> IEnumerable<SitePublicCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SitePublicCertificateResource> IAsyncEnumerable<SitePublicCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
