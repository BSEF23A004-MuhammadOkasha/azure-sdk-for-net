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
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorResource"/> and their operations.
    /// Each <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorResource"/> in the collection will belong to the same instance of <see cref="PostgreSqlFlexibleServerResource"/>.
    /// To get a <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection"/> instance call the GetPostgreSqlFlexibleServerActiveDirectoryAdministrators method from an instance of <see cref="PostgreSqlFlexibleServerResource"/>.
    /// </summary>
    public partial class PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection : ArmCollection, IEnumerable<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>, IAsyncEnumerable<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>
    {
        private readonly ClientDiagnostics _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics;
        private readonly AdministratorsRestOperations _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection"/> class for mocking. </summary>
        protected PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", PostgreSqlFlexibleServerActiveDirectoryAdministratorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlFlexibleServerActiveDirectoryAdministratorResource.ResourceType, out string postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsApiVersion);
            _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient = new AdministratorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PostgreSqlFlexibleServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PostgreSqlFlexibleServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/administrators/{objectId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Administrators_Create</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.DBforPostgreSQL/flexibleServers/administrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="objectId"> Guid of the objectId for the administrator. </param>
        /// <param name="content"> The required parameters for adding an active directory administrator for a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string objectId, PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectId, nameof(objectId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectId, content, cancellationToken).ConfigureAwait(false);
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>(new PostgreSqlFlexibleServerActiveDirectoryAdministratorOperationSource(Client), _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics, Pipeline, _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectId, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/administrators/{objectId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Administrators_Create</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.DBforPostgreSQL/flexibleServers/administrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="objectId"> Guid of the objectId for the administrator. </param>
        /// <param name="content"> The required parameters for adding an active directory administrator for a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource> CreateOrUpdate(WaitUntil waitUntil, string objectId, PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectId, nameof(objectId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectId, content, cancellationToken);
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>(new PostgreSqlFlexibleServerActiveDirectoryAdministratorOperationSource(Client), _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics, Pipeline, _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectId, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/administrators/{objectId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Administrators_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.DBforPostgreSQL/flexibleServers/administrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="objectId"> Guid of the objectId for the administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>> GetAsync(string objectId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectId, nameof(objectId));

            using var scope = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerActiveDirectoryAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/administrators/{objectId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Administrators_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.DBforPostgreSQL/flexibleServers/administrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="objectId"> Guid of the objectId for the administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public virtual Response<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource> Get(string objectId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectId, nameof(objectId));

            using var scope = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerActiveDirectoryAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the AAD administrators for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/administrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Administrators_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.DBforPostgreSQL/flexibleServers/administrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerActiveDirectoryAdministratorResource(Client, PostgreSqlFlexibleServerActiveDirectoryAdministratorData.DeserializePostgreSqlFlexibleServerActiveDirectoryAdministratorData(e)), _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the AAD administrators for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/administrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Administrators_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.DBforPostgreSQL/flexibleServers/administrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerActiveDirectoryAdministratorResource(Client, PostgreSqlFlexibleServerActiveDirectoryAdministratorData.DeserializePostgreSqlFlexibleServerActiveDirectoryAdministratorData(e)), _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/administrators/{objectId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Administrators_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.DBforPostgreSQL/flexibleServers/administrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="objectId"> Guid of the objectId for the administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string objectId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectId, nameof(objectId));

            using var scope = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/administrators/{objectId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Administrators_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.DBforPostgreSQL/flexibleServers/administrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="objectId"> Guid of the objectId for the administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public virtual Response<bool> Exists(string objectId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectId, nameof(objectId));

            using var scope = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/administrators/{objectId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Administrators_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.DBforPostgreSQL/flexibleServers/administrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="objectId"> Guid of the objectId for the administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public virtual async Task<NullableResponse<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>> GetIfExistsAsync(string objectId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectId, nameof(objectId));

            using var scope = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerActiveDirectoryAdministratorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/administrators/{objectId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Administrators_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.DBforPostgreSQL/flexibleServers/administrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="objectId"> Guid of the objectId for the administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public virtual NullableResponse<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource> GetIfExists(string objectId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectId, nameof(objectId));

            using var scope = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsClientDiagnostics.CreateScope("PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerActiveDirectoryAdministratorAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerActiveDirectoryAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource> IEnumerable<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource> IAsyncEnumerable<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
