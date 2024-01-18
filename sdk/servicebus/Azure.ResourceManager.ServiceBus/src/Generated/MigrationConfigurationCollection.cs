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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing a collection of <see cref="MigrationConfigurationResource"/> and their operations.
    /// Each <see cref="MigrationConfigurationResource"/> in the collection will belong to the same instance of <see cref="ServiceBusNamespaceResource"/>.
    /// To get a <see cref="MigrationConfigurationCollection"/> instance call the GetMigrationConfigurations method from an instance of <see cref="ServiceBusNamespaceResource"/>.
    /// </summary>
    public partial class MigrationConfigurationCollection : ArmCollection, IEnumerable<MigrationConfigurationResource>, IAsyncEnumerable<MigrationConfigurationResource>
    {
        private readonly ClientDiagnostics _migrationConfigurationMigrationConfigsClientDiagnostics;
        private readonly MigrationConfigsRestOperations _migrationConfigurationMigrationConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MigrationConfigurationCollection"/> class for mocking. </summary>
        protected MigrationConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MigrationConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrationConfigurationMigrationConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", MigrationConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MigrationConfigurationResource.ResourceType, out string migrationConfigurationMigrationConfigsApiVersion);
            _migrationConfigurationMigrationConfigsRestClient = new MigrationConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrationConfigurationMigrationConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates Migration configuration and starts migration of entities from Standard to Premium namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationConfigs_CreateAndStartMigration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configName"> The configuration name. Should always be "$default". </param>
        /// <param name="data"> Parameters required to create Migration Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MigrationConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, MigrationConfigurationName configName, MigrationConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrationConfigurationMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _migrationConfigurationMigrationConfigsRestClient.CreateAndStartMigrationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<MigrationConfigurationResource>(new MigrationConfigurationOperationSource(Client), _migrationConfigurationMigrationConfigsClientDiagnostics, Pipeline, _migrationConfigurationMigrationConfigsRestClient.CreateCreateAndStartMigrationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates Migration configuration and starts migration of entities from Standard to Premium namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationConfigs_CreateAndStartMigration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configName"> The configuration name. Should always be "$default". </param>
        /// <param name="data"> Parameters required to create Migration Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MigrationConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, MigrationConfigurationName configName, MigrationConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrationConfigurationMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _migrationConfigurationMigrationConfigsRestClient.CreateAndStartMigration(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, data, cancellationToken);
                var operation = new ServiceBusArmOperation<MigrationConfigurationResource>(new MigrationConfigurationOperationSource(Client), _migrationConfigurationMigrationConfigsClientDiagnostics, Pipeline, _migrationConfigurationMigrationConfigsRestClient.CreateCreateAndStartMigrationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves Migration Config
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configName"> The configuration name. Should always be "$default". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MigrationConfigurationResource>> GetAsync(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigurationMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _migrationConfigurationMigrationConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves Migration Config
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configName"> The configuration name. Should always be "$default". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MigrationConfigurationResource> Get(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigurationMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _migrationConfigurationMigrationConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all migrationConfigurations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationConfigs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MigrationConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MigrationConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationConfigurationMigrationConfigsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationConfigurationMigrationConfigsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MigrationConfigurationResource(Client, MigrationConfigurationData.DeserializeMigrationConfigurationData(e)), _migrationConfigurationMigrationConfigsClientDiagnostics, Pipeline, "MigrationConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all migrationConfigurations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationConfigs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MigrationConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MigrationConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationConfigurationMigrationConfigsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationConfigurationMigrationConfigsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MigrationConfigurationResource(Client, MigrationConfigurationData.DeserializeMigrationConfigurationData(e)), _migrationConfigurationMigrationConfigsClientDiagnostics, Pipeline, "MigrationConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configName"> The configuration name. Should always be "$default". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigurationMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _migrationConfigurationMigrationConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configName"> The configuration name. Should always be "$default". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigurationMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _migrationConfigurationMigrationConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configName"> The configuration name. Should always be "$default". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<MigrationConfigurationResource>> GetIfExistsAsync(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigurationMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _migrationConfigurationMigrationConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MigrationConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configName"> The configuration name. Should always be "$default". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<MigrationConfigurationResource> GetIfExists(MigrationConfigurationName configName, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigurationMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _migrationConfigurationMigrationConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MigrationConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MigrationConfigurationResource> IEnumerable<MigrationConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MigrationConfigurationResource> IAsyncEnumerable<MigrationConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
