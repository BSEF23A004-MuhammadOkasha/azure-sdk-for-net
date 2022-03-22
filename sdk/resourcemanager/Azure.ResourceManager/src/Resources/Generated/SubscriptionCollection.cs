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

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of Subscription and their operations over its parent. </summary>
    public partial class SubscriptionCollection : ArmCollection, IEnumerable<SubscriptionResource>, IAsyncEnumerable<SubscriptionResource>
    {
        private readonly ClientDiagnostics _subscriptionClientDiagnostics;
        private readonly SubscriptionsRestOperations _subscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionCollection"/> class for mocking. </summary>
        protected SubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", SubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionResource.ResourceType, out string subscriptionApiVersion);
            _subscriptionRestClient = new SubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets details about a specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public virtual async Task<Response<SubscriptionResource>> GetAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var scope = _subscriptionClientDiagnostics.CreateScope("SubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionRestClient.GetAsync(subscriptionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details about a specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public virtual Response<SubscriptionResource> Get(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var scope = _subscriptionClientDiagnostics.CreateScope("SubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionRestClient.Get(subscriptionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all subscriptions for a tenant.
        /// Request Path: /subscriptions
        /// Operation Id: Subscriptions_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubscriptionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionClientDiagnostics.CreateScope("SubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionRestClient.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionClientDiagnostics.CreateScope("SubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionRestClient.ListNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all subscriptions for a tenant.
        /// Request Path: /subscriptions
        /// Operation Id: Subscriptions_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubscriptionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionClientDiagnostics.CreateScope("SubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionRestClient.List(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionClientDiagnostics.CreateScope("SubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionRestClient.ListNextPage(nextLink, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var scope = _subscriptionClientDiagnostics.CreateScope("SubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public virtual Response<bool> Exists(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var scope = _subscriptionClientDiagnostics.CreateScope("SubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subscriptionId, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public virtual async Task<Response<SubscriptionResource>> GetIfExistsAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var scope = _subscriptionClientDiagnostics.CreateScope("SubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subscriptionRestClient.GetAsync(subscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SubscriptionResource>(null, response.GetRawResponse());
                return Response.FromValue(new SubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public virtual Response<SubscriptionResource> GetIfExists(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var scope = _subscriptionClientDiagnostics.CreateScope("SubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subscriptionRestClient.Get(subscriptionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SubscriptionResource>(null, response.GetRawResponse());
                return Response.FromValue(new SubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionResource> IEnumerable<SubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionResource> IAsyncEnumerable<SubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
