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

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing a collection of <see cref="NotificationRegistrationResource"/> and their operations.
    /// Each <see cref="NotificationRegistrationResource"/> in the collection will belong to the same instance of <see cref="ProviderRegistrationResource"/>.
    /// To get a <see cref="NotificationRegistrationCollection"/> instance call the GetNotificationRegistrations method from an instance of <see cref="ProviderRegistrationResource"/>.
    /// </summary>
    public partial class NotificationRegistrationCollection : ArmCollection, IEnumerable<NotificationRegistrationResource>, IAsyncEnumerable<NotificationRegistrationResource>
    {
        private readonly ClientDiagnostics _notificationRegistrationClientDiagnostics;
        private readonly NotificationRegistrationsRestOperations _notificationRegistrationRestClient;

        /// <summary> Initializes a new instance of the <see cref="NotificationRegistrationCollection"/> class for mocking. </summary>
        protected NotificationRegistrationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NotificationRegistrationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NotificationRegistrationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _notificationRegistrationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", NotificationRegistrationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NotificationRegistrationResource.ResourceType, out string notificationRegistrationApiVersion);
            _notificationRegistrationRestClient = new NotificationRegistrationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, notificationRegistrationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProviderRegistrationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProviderRegistrationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a notification registration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="notificationRegistrationName"> The notification registration. </param>
        /// <param name="data"> The required body parameters supplied to the notification registration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationRegistrationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NotificationRegistrationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string notificationRegistrationName, NotificationRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationRegistrationName, nameof(notificationRegistrationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _notificationRegistrationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, notificationRegistrationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<NotificationRegistrationResource>(Response.FromValue(new NotificationRegistrationResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a notification registration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="notificationRegistrationName"> The notification registration. </param>
        /// <param name="data"> The required body parameters supplied to the notification registration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationRegistrationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NotificationRegistrationResource> CreateOrUpdate(WaitUntil waitUntil, string notificationRegistrationName, NotificationRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationRegistrationName, nameof(notificationRegistrationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _notificationRegistrationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, notificationRegistrationName, data, cancellationToken);
                var operation = new ProviderHubArmOperation<NotificationRegistrationResource>(Response.FromValue(new NotificationRegistrationResource(Client, response), response.GetRawResponse()));
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
        /// Gets the notification registration details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="notificationRegistrationName"> The notification registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationRegistrationName"/> is null. </exception>
        public virtual async Task<Response<NotificationRegistrationResource>> GetAsync(string notificationRegistrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationRegistrationName, nameof(notificationRegistrationName));

            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationCollection.Get");
            scope.Start();
            try
            {
                var response = await _notificationRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.Name, notificationRegistrationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NotificationRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the notification registration details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="notificationRegistrationName"> The notification registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationRegistrationName"/> is null. </exception>
        public virtual Response<NotificationRegistrationResource> Get(string notificationRegistrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationRegistrationName, nameof(notificationRegistrationName));

            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationCollection.Get");
            scope.Start();
            try
            {
                var response = _notificationRegistrationRestClient.Get(Id.SubscriptionId, Id.Name, notificationRegistrationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NotificationRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of the notification registrations for the given provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_ListByProviderRegistration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NotificationRegistrationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NotificationRegistrationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _notificationRegistrationRestClient.CreateListByProviderRegistrationRequest(Id.SubscriptionId, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _notificationRegistrationRestClient.CreateListByProviderRegistrationNextPageRequest(nextLink, Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new NotificationRegistrationResource(Client, NotificationRegistrationData.DeserializeNotificationRegistrationData(e)), _notificationRegistrationClientDiagnostics, Pipeline, "NotificationRegistrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of the notification registrations for the given provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_ListByProviderRegistration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NotificationRegistrationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NotificationRegistrationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _notificationRegistrationRestClient.CreateListByProviderRegistrationRequest(Id.SubscriptionId, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _notificationRegistrationRestClient.CreateListByProviderRegistrationNextPageRequest(nextLink, Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new NotificationRegistrationResource(Client, NotificationRegistrationData.DeserializeNotificationRegistrationData(e)), _notificationRegistrationClientDiagnostics, Pipeline, "NotificationRegistrationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="notificationRegistrationName"> The notification registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationRegistrationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string notificationRegistrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationRegistrationName, nameof(notificationRegistrationName));

            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _notificationRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.Name, notificationRegistrationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="notificationRegistrationName"> The notification registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationRegistrationName"/> is null. </exception>
        public virtual Response<bool> Exists(string notificationRegistrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationRegistrationName, nameof(notificationRegistrationName));

            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationCollection.Exists");
            scope.Start();
            try
            {
                var response = _notificationRegistrationRestClient.Get(Id.SubscriptionId, Id.Name, notificationRegistrationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="notificationRegistrationName"> The notification registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationRegistrationName"/> is null. </exception>
        public virtual async Task<NullableResponse<NotificationRegistrationResource>> GetIfExistsAsync(string notificationRegistrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationRegistrationName, nameof(notificationRegistrationName));

            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _notificationRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.Name, notificationRegistrationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NotificationRegistrationResource>(response.GetRawResponse());
                return Response.FromValue(new NotificationRegistrationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="notificationRegistrationName"> The notification registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationRegistrationName"/> is null. </exception>
        public virtual NullableResponse<NotificationRegistrationResource> GetIfExists(string notificationRegistrationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationRegistrationName, nameof(notificationRegistrationName));

            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _notificationRegistrationRestClient.Get(Id.SubscriptionId, Id.Name, notificationRegistrationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NotificationRegistrationResource>(response.GetRawResponse());
                return Response.FromValue(new NotificationRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NotificationRegistrationResource> IEnumerable<NotificationRegistrationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NotificationRegistrationResource> IAsyncEnumerable<NotificationRegistrationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
