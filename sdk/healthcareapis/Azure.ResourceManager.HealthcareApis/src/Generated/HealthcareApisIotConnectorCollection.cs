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

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A class representing a collection of <see cref="HealthcareApisIotConnectorResource" /> and their operations.
    /// Each <see cref="HealthcareApisIotConnectorResource" /> in the collection will belong to the same instance of <see cref="HealthcareApisWorkspaceResource" />.
    /// To get a <see cref="HealthcareApisIotConnectorCollection" /> instance call the GetHealthcareApisIotConnectors method from an instance of <see cref="HealthcareApisWorkspaceResource" />.
    /// </summary>
    public partial class HealthcareApisIotConnectorCollection : ArmCollection, IEnumerable<HealthcareApisIotConnectorResource>, IAsyncEnumerable<HealthcareApisIotConnectorResource>
    {
        private readonly ClientDiagnostics _healthcareApisIotConnectorIotConnectorsClientDiagnostics;
        private readonly IotConnectorsRestOperations _healthcareApisIotConnectorIotConnectorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisIotConnectorCollection"/> class for mocking. </summary>
        protected HealthcareApisIotConnectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisIotConnectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HealthcareApisIotConnectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _healthcareApisIotConnectorIotConnectorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", HealthcareApisIotConnectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HealthcareApisIotConnectorResource.ResourceType, out string healthcareApisIotConnectorIotConnectorsApiVersion);
            _healthcareApisIotConnectorIotConnectorsRestClient = new IotConnectorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, healthcareApisIotConnectorIotConnectorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HealthcareApisWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HealthcareApisWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an IoT Connector resource with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectors_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="data"> The parameters for creating or updating an IoT Connectors resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iotConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iotConnectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HealthcareApisIotConnectorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string iotConnectorName, HealthcareApisIotConnectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iotConnectorName, nameof(iotConnectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _healthcareApisIotConnectorIotConnectorsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iotConnectorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation<HealthcareApisIotConnectorResource>(new HealthcareApisIotConnectorOperationSource(Client), _healthcareApisIotConnectorIotConnectorsClientDiagnostics, Pipeline, _healthcareApisIotConnectorIotConnectorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iotConnectorName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an IoT Connector resource with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectors_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="data"> The parameters for creating or updating an IoT Connectors resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iotConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iotConnectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HealthcareApisIotConnectorResource> CreateOrUpdate(WaitUntil waitUntil, string iotConnectorName, HealthcareApisIotConnectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iotConnectorName, nameof(iotConnectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _healthcareApisIotConnectorIotConnectorsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iotConnectorName, data, cancellationToken);
                var operation = new HealthcareApisArmOperation<HealthcareApisIotConnectorResource>(new HealthcareApisIotConnectorOperationSource(Client), _healthcareApisIotConnectorIotConnectorsClientDiagnostics, Pipeline, _healthcareApisIotConnectorIotConnectorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iotConnectorName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the properties of the specified IoT Connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iotConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iotConnectorName"/> is null. </exception>
        public virtual async Task<Response<HealthcareApisIotConnectorResource>> GetAsync(string iotConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iotConnectorName, nameof(iotConnectorName));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _healthcareApisIotConnectorIotConnectorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iotConnectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthcareApisIotConnectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified IoT Connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iotConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iotConnectorName"/> is null. </exception>
        public virtual Response<HealthcareApisIotConnectorResource> Get(string iotConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iotConnectorName, nameof(iotConnectorName));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorCollection.Get");
            scope.Start();
            try
            {
                var response = _healthcareApisIotConnectorIotConnectorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iotConnectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthcareApisIotConnectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all IoT Connectors for the given workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectors_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HealthcareApisIotConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HealthcareApisIotConnectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _healthcareApisIotConnectorIotConnectorsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _healthcareApisIotConnectorIotConnectorsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HealthcareApisIotConnectorResource(Client, HealthcareApisIotConnectorData.DeserializeHealthcareApisIotConnectorData(e)), _healthcareApisIotConnectorIotConnectorsClientDiagnostics, Pipeline, "HealthcareApisIotConnectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all IoT Connectors for the given workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectors_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HealthcareApisIotConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HealthcareApisIotConnectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _healthcareApisIotConnectorIotConnectorsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _healthcareApisIotConnectorIotConnectorsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HealthcareApisIotConnectorResource(Client, HealthcareApisIotConnectorData.DeserializeHealthcareApisIotConnectorData(e)), _healthcareApisIotConnectorIotConnectorsClientDiagnostics, Pipeline, "HealthcareApisIotConnectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iotConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iotConnectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string iotConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iotConnectorName, nameof(iotConnectorName));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _healthcareApisIotConnectorIotConnectorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iotConnectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iotConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iotConnectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string iotConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iotConnectorName, nameof(iotConnectorName));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _healthcareApisIotConnectorIotConnectorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iotConnectorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HealthcareApisIotConnectorResource> IEnumerable<HealthcareApisIotConnectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HealthcareApisIotConnectorResource> IAsyncEnumerable<HealthcareApisIotConnectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
