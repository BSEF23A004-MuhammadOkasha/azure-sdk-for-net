// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ScheduledActionResource"/> and their operations.
    /// Each <see cref="ScheduledActionResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="ScheduledActionCollection"/> instance call the GetScheduledActions method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class ScheduledActionCollection : ArmCollection, IEnumerable<ScheduledActionResource>, IAsyncEnumerable<ScheduledActionResource>
    {
        private readonly ClientDiagnostics _scheduledActionClientDiagnostics;
        private readonly ScheduledActionsRestOperations _scheduledActionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScheduledActionCollection"/> class for mocking. </summary>
        protected ScheduledActionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScheduledActionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScheduledActionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scheduledActionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CostManagement", ScheduledActionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScheduledActionResource.ResourceType, out string scheduledActionApiVersion);
            _scheduledActionRestClient = new ScheduledActionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scheduledActionApiVersion);
        }

        /// <summary>
        /// Create or update a shared scheduled action within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_CreateOrUpdateByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="data"> Scheduled action to be created or updated. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity. Optional when updating an entity and can be specified to achieve optimistic concurrency. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScheduledActionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, ScheduledActionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scheduledActionRestClient.CreateOrUpdateByScopeAsync(Id, name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new CostManagementArmOperation<ScheduledActionResource>(Response.FromValue(new ScheduledActionResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a shared scheduled action within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_CreateOrUpdateByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="data"> Scheduled action to be created or updated. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity. Optional when updating an entity and can be specified to achieve optimistic concurrency. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScheduledActionResource> CreateOrUpdate(WaitUntil waitUntil, string name, ScheduledActionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scheduledActionRestClient.CreateOrUpdateByScope(Id, name, data, ifMatch, cancellationToken);
                var operation = new CostManagementArmOperation<ScheduledActionResource>(Response.FromValue(new ScheduledActionResource(Client, response), response.GetRawResponse()));
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
        /// Get the shared scheduled action from the given scope by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<ScheduledActionResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionCollection.Get");
            scope.Start();
            try
            {
                var response = await _scheduledActionRestClient.GetByScopeAsync(Id, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScheduledActionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the shared scheduled action from the given scope by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<ScheduledActionResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionCollection.Get");
            scope.Start();
            try
            {
                var response = _scheduledActionRestClient.GetByScope(Id, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScheduledActionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all shared scheduled actions within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_ListByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> May be used to filter scheduled actions by properties/viewId. Supported operator is 'eq'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScheduledActionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScheduledActionResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scheduledActionRestClient.CreateListByScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scheduledActionRestClient.CreateListByScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScheduledActionResource(Client, ScheduledActionData.DeserializeScheduledActionData(e)), _scheduledActionClientDiagnostics, Pipeline, "ScheduledActionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all shared scheduled actions within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_ListByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> May be used to filter scheduled actions by properties/viewId. Supported operator is 'eq'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScheduledActionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScheduledActionResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scheduledActionRestClient.CreateListByScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scheduledActionRestClient.CreateListByScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScheduledActionResource(Client, ScheduledActionData.DeserializeScheduledActionData(e)), _scheduledActionClientDiagnostics, Pipeline, "ScheduledActionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scheduledActionRestClient.GetByScopeAsync(Id, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionCollection.Exists");
            scope.Start();
            try
            {
                var response = _scheduledActionRestClient.GetByScope(Id, name, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<ScheduledActionResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scheduledActionRestClient.GetByScopeAsync(Id, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScheduledActionResource>(response.GetRawResponse());
                return Response.FromValue(new ScheduledActionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Scheduled action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<ScheduledActionResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scheduledActionRestClient.GetByScope(Id, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScheduledActionResource>(response.GetRawResponse());
                return Response.FromValue(new ScheduledActionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScheduledActionResource> IEnumerable<ScheduledActionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScheduledActionResource> IAsyncEnumerable<ScheduledActionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
