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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseClusterPrincipalAssignmentResource" /> and their operations.
    /// Each <see cref="SynapseClusterPrincipalAssignmentResource" /> in the collection will belong to the same instance of <see cref="SynapseKustoPoolResource" />.
    /// To get a <see cref="SynapseClusterPrincipalAssignmentCollection" /> instance call the GetSynapseClusterPrincipalAssignments method from an instance of <see cref="SynapseKustoPoolResource" />.
    /// </summary>
    public partial class SynapseClusterPrincipalAssignmentCollection : ArmCollection, IEnumerable<SynapseClusterPrincipalAssignmentResource>, IAsyncEnumerable<SynapseClusterPrincipalAssignmentResource>
    {
        private readonly ClientDiagnostics _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics;
        private readonly KustoPoolPrincipalAssignmentsRestOperations _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseClusterPrincipalAssignmentCollection"/> class for mocking. </summary>
        protected SynapseClusterPrincipalAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseClusterPrincipalAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseClusterPrincipalAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseClusterPrincipalAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseClusterPrincipalAssignmentResource.ResourceType, out string synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsApiVersion);
            _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient = new KustoPoolPrincipalAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseKustoPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseKustoPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Kusto pool principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="data"> The Kusto pool principalAssignment's parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseClusterPrincipalAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string principalAssignmentName, SynapseClusterPrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, principalAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseClusterPrincipalAssignmentResource>(new SynapseClusterPrincipalAssignmentOperationSource(Client), _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics, Pipeline, _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, principalAssignmentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a Kusto pool principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="data"> The Kusto pool principalAssignment's parameters supplied for the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseClusterPrincipalAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string principalAssignmentName, SynapseClusterPrincipalAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, principalAssignmentName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseClusterPrincipalAssignmentResource>(new SynapseClusterPrincipalAssignmentOperationSource(Client), _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics, Pipeline, _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, principalAssignmentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a Kusto pool principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual async Task<Response<SynapseClusterPrincipalAssignmentResource>> GetAsync(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, principalAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseClusterPrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Kusto pool principalAssignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual Response<SynapseClusterPrincipalAssignmentResource> Get(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, principalAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseClusterPrincipalAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Kusto pool principalAssignments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseClusterPrincipalAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseClusterPrincipalAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new SynapseClusterPrincipalAssignmentResource(Client, SynapseClusterPrincipalAssignmentData.DeserializeSynapseClusterPrincipalAssignmentData(e)), _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics, Pipeline, "SynapseClusterPrincipalAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all Kusto pool principalAssignments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseClusterPrincipalAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseClusterPrincipalAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new SynapseClusterPrincipalAssignmentResource(Client, SynapseClusterPrincipalAssignmentData.DeserializeSynapseClusterPrincipalAssignmentData(e)), _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics, Pipeline, "SynapseClusterPrincipalAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, principalAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/kustoPools/{kustoPoolName}/principalAssignments/{principalAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>KustoPoolPrincipalAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="principalAssignmentName"> The name of the Kusto principalAssignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="principalAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="principalAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string principalAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(principalAssignmentName, nameof(principalAssignmentName));

            using var scope = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsClientDiagnostics.CreateScope("SynapseClusterPrincipalAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseClusterPrincipalAssignmentKustoPoolPrincipalAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, principalAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseClusterPrincipalAssignmentResource> IEnumerable<SynapseClusterPrincipalAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseClusterPrincipalAssignmentResource> IAsyncEnumerable<SynapseClusterPrincipalAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
