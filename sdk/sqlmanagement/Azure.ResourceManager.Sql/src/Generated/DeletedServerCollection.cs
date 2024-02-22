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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="DeletedServerResource"/> and their operations.
    /// Each <see cref="DeletedServerResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="DeletedServerCollection"/> instance call the GetDeletedServers method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class DeletedServerCollection : ArmCollection, IEnumerable<DeletedServerResource>, IAsyncEnumerable<DeletedServerResource>
    {
        private readonly ClientDiagnostics _deletedServerClientDiagnostics;
        private readonly DeletedServersRestOperations _deletedServerRestClient;
        private readonly AzureLocation _locationName;

        /// <summary> Initializes a new instance of the <see cref="DeletedServerCollection"/> class for mocking. </summary>
        protected DeletedServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        internal DeletedServerCollection(ArmClient client, ResourceIdentifier id, AzureLocation locationName) : base(client, id)
        {
            _locationName = locationName;
            _deletedServerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", DeletedServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeletedServerResource.ResourceType, out string deletedServerApiVersion);
            _deletedServerRestClient = new DeletedServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deletedServerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a deleted server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual async Task<Response<DeletedServerResource>> GetAsync(string deletedServerName, CancellationToken cancellationToken = default)
        {
            if (deletedServerName == null)
            {
                throw new ArgumentNullException(nameof(deletedServerName));
            }
            if (deletedServerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deletedServerName));
            }

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedServerRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), deletedServerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deleted server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual Response<DeletedServerResource> Get(string deletedServerName, CancellationToken cancellationToken = default)
        {
            if (deletedServerName == null)
            {
                throw new ArgumentNullException(nameof(deletedServerName));
            }
            if (deletedServerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deletedServerName));
            }

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedServerRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), deletedServerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of deleted servers for a location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServers_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deletedServerRestClient.CreateListByLocationRequest(Id.SubscriptionId, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deletedServerRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeletedServerResource(Client, DeletedServerData.DeserializeDeletedServerData(e)), _deletedServerClientDiagnostics, Pipeline, "DeletedServerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of deleted servers for a location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServers_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deletedServerRestClient.CreateListByLocationRequest(Id.SubscriptionId, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deletedServerRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeletedServerResource(Client, DeletedServerData.DeserializeDeletedServerData(e)), _deletedServerClientDiagnostics, Pipeline, "DeletedServerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string deletedServerName, CancellationToken cancellationToken = default)
        {
            if (deletedServerName == null)
            {
                throw new ArgumentNullException(nameof(deletedServerName));
            }
            if (deletedServerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deletedServerName));
            }

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deletedServerRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), deletedServerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual Response<bool> Exists(string deletedServerName, CancellationToken cancellationToken = default)
        {
            if (deletedServerName == null)
            {
                throw new ArgumentNullException(nameof(deletedServerName));
            }
            if (deletedServerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deletedServerName));
            }

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _deletedServerRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), deletedServerName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual async Task<NullableResponse<DeletedServerResource>> GetIfExistsAsync(string deletedServerName, CancellationToken cancellationToken = default)
        {
            if (deletedServerName == null)
            {
                throw new ArgumentNullException(nameof(deletedServerName));
            }
            if (deletedServerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deletedServerName));
            }

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deletedServerRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), deletedServerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DeletedServerResource>(response.GetRawResponse());
                return Response.FromValue(new DeletedServerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedServers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeletedServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual NullableResponse<DeletedServerResource> GetIfExists(string deletedServerName, CancellationToken cancellationToken = default)
        {
            if (deletedServerName == null)
            {
                throw new ArgumentNullException(nameof(deletedServerName));
            }
            if (deletedServerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deletedServerName));
            }

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deletedServerRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), deletedServerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DeletedServerResource>(response.GetRawResponse());
                return Response.FromValue(new DeletedServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeletedServerResource> IEnumerable<DeletedServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeletedServerResource> IAsyncEnumerable<DeletedServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
