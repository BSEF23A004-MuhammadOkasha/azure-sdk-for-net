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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedInstanceServerConfigurationOptionResource"/> and their operations.
    /// Each <see cref="ManagedInstanceServerConfigurationOptionResource"/> in the collection will belong to the same instance of <see cref="ManagedInstanceResource"/>.
    /// To get a <see cref="ManagedInstanceServerConfigurationOptionCollection"/> instance call the GetManagedInstanceServerConfigurationOptions method from an instance of <see cref="ManagedInstanceResource"/>.
    /// </summary>
    public partial class ManagedInstanceServerConfigurationOptionCollection : ArmCollection, IEnumerable<ManagedInstanceServerConfigurationOptionResource>, IAsyncEnumerable<ManagedInstanceServerConfigurationOptionResource>
    {
        private readonly ClientDiagnostics _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics;
        private readonly ServerConfigurationOptionsRestOperations _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceServerConfigurationOptionCollection"/> class for mocking. </summary>
        protected ManagedInstanceServerConfigurationOptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceServerConfigurationOptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceServerConfigurationOptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceServerConfigurationOptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedInstanceServerConfigurationOptionResource.ResourceType, out string managedInstanceServerConfigurationOptionServerConfigurationOptionsApiVersion);
            _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient = new ServerConfigurationOptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceServerConfigurationOptionServerConfigurationOptionsApiVersion);
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
        /// Updates managed instance server configuration option.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverConfigurationOptionName"> The name of the server configuration option. </param>
        /// <param name="data"> Server configuration option parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstanceServerConfigurationOptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ManagedInstanceServerConfigurationOptionName serverConfigurationOptionName, ManagedInstanceServerConfigurationOptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverConfigurationOptionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceServerConfigurationOptionResource>(new ManagedInstanceServerConfigurationOptionOperationSource(Client), _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics, Pipeline, _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverConfigurationOptionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates managed instance server configuration option.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverConfigurationOptionName"> The name of the server configuration option. </param>
        /// <param name="data"> Server configuration option parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceServerConfigurationOptionResource> CreateOrUpdate(WaitUntil waitUntil, ManagedInstanceServerConfigurationOptionName serverConfigurationOptionName, ManagedInstanceServerConfigurationOptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverConfigurationOptionName, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceServerConfigurationOptionResource>(new ManagedInstanceServerConfigurationOptionOperationSource(Client), _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics, Pipeline, _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverConfigurationOptionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets managed instance server configuration option.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverConfigurationOptionName"> The name of the server configuration option. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceServerConfigurationOptionResource>> GetAsync(ManagedInstanceServerConfigurationOptionName serverConfigurationOptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverConfigurationOptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceServerConfigurationOptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets managed instance server configuration option.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverConfigurationOptionName"> The name of the server configuration option. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceServerConfigurationOptionResource> Get(ManagedInstanceServerConfigurationOptionName serverConfigurationOptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverConfigurationOptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceServerConfigurationOptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of managed instance server configuration options.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_ListByManagedInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceServerConfigurationOptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceServerConfigurationOptionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateListByManagedInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateListByManagedInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedInstanceServerConfigurationOptionResource(Client, ManagedInstanceServerConfigurationOptionData.DeserializeManagedInstanceServerConfigurationOptionData(e)), _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics, Pipeline, "ManagedInstanceServerConfigurationOptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of managed instance server configuration options.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_ListByManagedInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceServerConfigurationOptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceServerConfigurationOptionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateListByManagedInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.CreateListByManagedInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedInstanceServerConfigurationOptionResource(Client, ManagedInstanceServerConfigurationOptionData.DeserializeManagedInstanceServerConfigurationOptionData(e)), _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics, Pipeline, "ManagedInstanceServerConfigurationOptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverConfigurationOptionName"> The name of the server configuration option. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(ManagedInstanceServerConfigurationOptionName serverConfigurationOptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverConfigurationOptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverConfigurationOptionName"> The name of the server configuration option. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(ManagedInstanceServerConfigurationOptionName serverConfigurationOptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverConfigurationOptionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverConfigurationOptionName"> The name of the server configuration option. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ManagedInstanceServerConfigurationOptionResource>> GetIfExistsAsync(ManagedInstanceServerConfigurationOptionName serverConfigurationOptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverConfigurationOptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagedInstanceServerConfigurationOptionResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceServerConfigurationOptionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverConfigurationOptions/{serverConfigurationOptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerConfigurationOptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverConfigurationOptionName"> The name of the server configuration option. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ManagedInstanceServerConfigurationOptionResource> GetIfExists(ManagedInstanceServerConfigurationOptionName serverConfigurationOptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceServerConfigurationOptionServerConfigurationOptionsClientDiagnostics.CreateScope("ManagedInstanceServerConfigurationOptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceServerConfigurationOptionServerConfigurationOptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverConfigurationOptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagedInstanceServerConfigurationOptionResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceServerConfigurationOptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceServerConfigurationOptionResource> IEnumerable<ManagedInstanceServerConfigurationOptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceServerConfigurationOptionResource> IAsyncEnumerable<ManagedInstanceServerConfigurationOptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
