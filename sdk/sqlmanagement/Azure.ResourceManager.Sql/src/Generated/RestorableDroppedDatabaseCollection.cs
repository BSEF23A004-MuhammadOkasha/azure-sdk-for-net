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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="RestorableDroppedDatabaseResource"/> and their operations.
    /// Each <see cref="RestorableDroppedDatabaseResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="RestorableDroppedDatabaseCollection"/> instance call the GetRestorableDroppedDatabases method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class RestorableDroppedDatabaseCollection : ArmCollection, IEnumerable<RestorableDroppedDatabaseResource>, IAsyncEnumerable<RestorableDroppedDatabaseResource>
    {
        private readonly ClientDiagnostics _restorableDroppedDatabaseClientDiagnostics;
        private readonly RestorableDroppedDatabasesRestOperations _restorableDroppedDatabaseRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedDatabaseCollection"/> class for mocking. </summary>
        protected RestorableDroppedDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RestorableDroppedDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorableDroppedDatabaseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", RestorableDroppedDatabaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RestorableDroppedDatabaseResource.ResourceType, out string restorableDroppedDatabaseApiVersion);
            _restorableDroppedDatabaseRestClient = new RestorableDroppedDatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, restorableDroppedDatabaseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a restorable dropped database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The <see cref="string"/> to use. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual async Task<Response<RestorableDroppedDatabaseResource>> GetAsync(string restorableDroppedDatabaseId, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedDatabaseClientDiagnostics.CreateScope("RestorableDroppedDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorableDroppedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, expand, filter, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a restorable dropped database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The <see cref="string"/> to use. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual Response<RestorableDroppedDatabaseResource> Get(string restorableDroppedDatabaseId, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedDatabaseClientDiagnostics.CreateScope("RestorableDroppedDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _restorableDroppedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, expand, filter, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of restorable dropped databases.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedDatabases_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableDroppedDatabaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableDroppedDatabaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _restorableDroppedDatabaseRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _restorableDroppedDatabaseRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RestorableDroppedDatabaseResource(Client, RestorableDroppedDatabaseData.DeserializeRestorableDroppedDatabaseData(e)), _restorableDroppedDatabaseClientDiagnostics, Pipeline, "RestorableDroppedDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of restorable dropped databases.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedDatabases_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableDroppedDatabaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableDroppedDatabaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _restorableDroppedDatabaseRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _restorableDroppedDatabaseRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RestorableDroppedDatabaseResource(Client, RestorableDroppedDatabaseData.DeserializeRestorableDroppedDatabaseData(e)), _restorableDroppedDatabaseClientDiagnostics, Pipeline, "RestorableDroppedDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The <see cref="string"/> to use. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string restorableDroppedDatabaseId, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedDatabaseClientDiagnostics.CreateScope("RestorableDroppedDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _restorableDroppedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, expand, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The <see cref="string"/> to use. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual Response<bool> Exists(string restorableDroppedDatabaseId, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedDatabaseClientDiagnostics.CreateScope("RestorableDroppedDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = _restorableDroppedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, expand, filter, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The <see cref="string"/> to use. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual async Task<NullableResponse<RestorableDroppedDatabaseResource>> GetIfExistsAsync(string restorableDroppedDatabaseId, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedDatabaseClientDiagnostics.CreateScope("RestorableDroppedDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restorableDroppedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, expand, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RestorableDroppedDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedDatabaseResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedDatabaseId"> The <see cref="string"/> to use. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedDatabaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedDatabaseId"/> is null. </exception>
        public virtual NullableResponse<RestorableDroppedDatabaseResource> GetIfExists(string restorableDroppedDatabaseId, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedDatabaseId, nameof(restorableDroppedDatabaseId));

            using var scope = _restorableDroppedDatabaseClientDiagnostics.CreateScope("RestorableDroppedDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorableDroppedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedDatabaseId, expand, filter, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RestorableDroppedDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RestorableDroppedDatabaseResource> IEnumerable<RestorableDroppedDatabaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorableDroppedDatabaseResource> IAsyncEnumerable<RestorableDroppedDatabaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
