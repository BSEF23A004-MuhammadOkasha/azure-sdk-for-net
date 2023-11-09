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
    /// A class representing a collection of <see cref="RecoverableManagedDatabaseResource" /> and their operations.
    /// Each <see cref="RecoverableManagedDatabaseResource" /> in the collection will belong to the same instance of <see cref="ManagedInstanceResource" />.
    /// To get a <see cref="RecoverableManagedDatabaseCollection" /> instance call the GetRecoverableManagedDatabases method from an instance of <see cref="ManagedInstanceResource" />.
    /// </summary>
    public partial class RecoverableManagedDatabaseCollection : ArmCollection, IEnumerable<RecoverableManagedDatabaseResource>, IAsyncEnumerable<RecoverableManagedDatabaseResource>
    {
        private readonly ClientDiagnostics _recoverableManagedDatabaseClientDiagnostics;
        private readonly RecoverableManagedDatabasesRestOperations _recoverableManagedDatabaseRestClient;

        /// <summary> Initializes a new instance of the <see cref="RecoverableManagedDatabaseCollection"/> class for mocking. </summary>
        protected RecoverableManagedDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RecoverableManagedDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RecoverableManagedDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _recoverableManagedDatabaseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", RecoverableManagedDatabaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RecoverableManagedDatabaseResource.ResourceType, out string recoverableManagedDatabaseApiVersion);
            _recoverableManagedDatabaseRestClient = new RecoverableManagedDatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, recoverableManagedDatabaseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a recoverable managed database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases/{recoverableDatabaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoverableDatabaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public virtual async Task<Response<RecoverableManagedDatabaseResource>> GetAsync(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoverableDatabaseName, nameof(recoverableDatabaseName));

            using var scope = _recoverableManagedDatabaseClientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _recoverableManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, recoverableDatabaseName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoverableManagedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a recoverable managed database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases/{recoverableDatabaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoverableDatabaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public virtual Response<RecoverableManagedDatabaseResource> Get(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoverableDatabaseName, nameof(recoverableDatabaseName));

            using var scope = _recoverableManagedDatabaseClientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _recoverableManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, recoverableDatabaseName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoverableManagedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of recoverable managed databases.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableManagedDatabases_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecoverableManagedDatabaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecoverableManagedDatabaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _recoverableManagedDatabaseRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _recoverableManagedDatabaseRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RecoverableManagedDatabaseResource(Client, RecoverableManagedDatabaseData.DeserializeRecoverableManagedDatabaseData(e)), _recoverableManagedDatabaseClientDiagnostics, Pipeline, "RecoverableManagedDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of recoverable managed databases.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableManagedDatabases_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecoverableManagedDatabaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecoverableManagedDatabaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _recoverableManagedDatabaseRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _recoverableManagedDatabaseRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RecoverableManagedDatabaseResource(Client, RecoverableManagedDatabaseData.DeserializeRecoverableManagedDatabaseData(e)), _recoverableManagedDatabaseClientDiagnostics, Pipeline, "RecoverableManagedDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases/{recoverableDatabaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoverableDatabaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoverableDatabaseName, nameof(recoverableDatabaseName));

            using var scope = _recoverableManagedDatabaseClientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _recoverableManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, recoverableDatabaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases/{recoverableDatabaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoverableDatabaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public virtual Response<bool> Exists(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoverableDatabaseName, nameof(recoverableDatabaseName));

            using var scope = _recoverableManagedDatabaseClientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = _recoverableManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, recoverableDatabaseName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases/{recoverableDatabaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoverableDatabaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public virtual async Task<NullableResponse<RecoverableManagedDatabaseResource>> GetIfExistsAsync(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoverableDatabaseName, nameof(recoverableDatabaseName));

            using var scope = _recoverableManagedDatabaseClientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _recoverableManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, recoverableDatabaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RecoverableManagedDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new RecoverableManagedDatabaseResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/recoverableDatabases/{recoverableDatabaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableManagedDatabases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recoverableDatabaseName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoverableDatabaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoverableDatabaseName"/> is null. </exception>
        public virtual NullableResponse<RecoverableManagedDatabaseResource> GetIfExists(string recoverableDatabaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoverableDatabaseName, nameof(recoverableDatabaseName));

            using var scope = _recoverableManagedDatabaseClientDiagnostics.CreateScope("RecoverableManagedDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _recoverableManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, recoverableDatabaseName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RecoverableManagedDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new RecoverableManagedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RecoverableManagedDatabaseResource> IEnumerable<RecoverableManagedDatabaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RecoverableManagedDatabaseResource> IAsyncEnumerable<RecoverableManagedDatabaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
